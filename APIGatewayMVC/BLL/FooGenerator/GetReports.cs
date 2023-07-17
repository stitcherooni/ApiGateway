using BLL.DTO.Statistic;
using BLL.DTO.Statistic.Reports.Banked;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Customers;
using BLL.DTO.Statistic.Reports.Dashboard;
using BLL.DTO.Statistic.Reports.EmailTracker;
using BLL.DTO.Statistic.Reports.Invoice;
using BLL.DTO.Statistic.Reports.MiWizard;
using BLL.DTO.Statistic.Reports.Order;
using BLL.DTO.Statistic.Reports.ProductQuestion;
using BLL.DTO.Statistic.Reports.Sale;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;
using BLL.DTO.Statistic.Searching.Sales;

namespace BLL.FooGenerator
{
    public static class GetReports
    {
        public static async Task<List<MiWizardDTO>> MiWizardReport(CancellationToken cancellationToken)
        {
            List<MiWizardDTO> result = new List<MiWizardDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetMiWizard(i));
            }
            return result;
        }

        public static async Task<List<CustomerDTO>> CustomerReport(CancellationToken cancellationToken)
        {
            List<CustomerDTO> result = new List<CustomerDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetCustomer(i));
            }
            return result;
        }
        public static async Task<List<OrderDTO>> OrderReport(CancellationToken cancellationToken)
        {
            List<OrderDTO> result = new List<OrderDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetOrder(i));
            }
            return result;
        }

        public static async Task<List<SaleDTO>> SaleReport(CancellationToken cancellationToken)
        {
            List<SaleDTO> result = new List<SaleDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetSalesResponse(cancellationToken));
            }
            return result;
        }

        public static async Task<List<TicketDTO>> TicketReport(CancellationToken cancellationToken)
        {
            List<TicketDTO> result = new List<TicketDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetTicket(i));
            }
            return result;
        }

        public static async Task<List<VolunteerDTO>> VolunteerReport(CancellationToken cancellationToken)
        {
            List<VolunteerDTO> result = new List<VolunteerDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetVolunteer(i));
            }
            return result;
        }

        public static async Task<List<BookingDTO>> BookingReport(CancellationToken cancellationToken)
        {
            List<BookingDTO> result = new List<BookingDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetBooking(i));
            }
            return result;
        }

        public static async Task<List<ProductQuestionHorizontalDTO>> ProductQuestionHorisontalReport(CancellationToken cancellationToken)
        {
            List<ProductQuestionHorizontalDTO> result = new List<ProductQuestionHorizontalDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetProductQuestionHorizontal(i));
            }
            return result;
        }

        public static async Task<List<ProductQuestionVerticalDTO>> ProductQuestionVerticalReport(CancellationToken cancellationToken)
        {
            List<ProductQuestionVerticalDTO> result = new List<ProductQuestionVerticalDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetProductQuestionVertical(i));
            }
            return result;
        }

        public static async Task<List<InvoiceDTO>> InvoiceReport(CancellationToken cancellationToken)
        {
            List<InvoiceDTO> result = new List<InvoiceDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetInvoice(i));
            }
            return result;
        }
        public static async Task<List<TreasurerByEventDTO>> TreasurerByEventReport(CancellationToken cancellationToken)
        {
            List<TreasurerByEventDTO> result = new List<TreasurerByEventDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetTreasurerByEvent(i));
            }
            return result;
        }
        public static async Task<List<TreasurerByDateDTO>> TreasurerByDateReport(CancellationToken cancellationToken)
        {
            List<TreasurerByDateDTO> result = new List<TreasurerByDateDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetTreasurerByDate(i));
            }
            return result;
        }

        public static async Task<List<BankedTransactionDTO>> BankedTransactionReport(CancellationToken cancellationToken)
        {
            List<BankedTransactionDTO> result = new List<BankedTransactionDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetBankedTransaction(i));
            }
            return result;
        }

        public static async Task<List<ChildOnlyBookingDTO>> ChildOnlyBookingReport(CancellationToken cancellationToken)
        {
            List<ChildOnlyBookingDTO> result = new List<ChildOnlyBookingDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetChildOnlyBooking(i));
            }
            return result;
        }

        public static async Task<List<EmailTrackerDTO>> EmailTrackerReport(CancellationToken cancellationToken)
        {
            List<EmailTrackerDTO> result = new List<EmailTrackerDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetEmailTracker(i));
            }
            return result;
        }

        public static async Task<IEnumerable<Order>> GetOrderList(CancellationToken cancellationToken)
        {
            List<Order> result = new();

            result.Add(GetOrder(cancellationToken));

            return result;
        }

        public static SaleDTO GetSalesResponse(CancellationToken cancellationToken)
        {
            return new SaleDTO()
            {
                TotalSales = 10,
                AvgSalesValue = 15,
                TotalSalesValue = 12,
                PlatformBookingFees = 18,
                Data = GetDataDTO(cancellationToken)
            };
        }

        public static DashboardStatistic GetDashboardStatistic(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            return new DashboardStatistic()
            {
                Sales = rnd.Next(0, 100),
                Orders = rnd.Next(0, 100),
                AvgOrderValue = rnd.Next(0, 100),
                Customers = rnd.Next(0, 100),
                Events = rnd.Next(0, 100),
                Products = rnd.Next(0, 100),
                Sponsors = rnd.Next(0, 100),
                BusinessDirectory = rnd.Next(0, 100),
            };
        }

        public static IDictionary<string, SalesData> GetCurrentLiveSalesDictionary(CancellationToken cancellationToken)
        {
            return new Dictionary<string, SalesData>()
            {
                {"School Uniform COPY",  GetSalesData(cancellationToken)},
                { "Second Hand Uniform",  GetSalesData(cancellationToken)},
                { "Advertising",  GetSalesData(cancellationToken)}
            };
        }

        public static async Task<MonthlyReport> GetMonthlyOrders(CancellationToken cancellationToken, int page, int pageSize)
        {
            var monthList = GetMonthYearListUntilToday();
            int skipCount = (page - 1) * pageSize;

            var resultMonthlyOrders = GetListMonthlyOrder(monthList, cancellationToken);

            var totalCount = resultMonthlyOrders.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var paginatedResultMonthlyOrders = resultMonthlyOrders.Skip(skipCount).Take(pageSize);

            var resultMonthlyCustomersRegistrations = GetListMonthlyCustomersRegistrations(monthList, cancellationToken);

            var paginatedResultMonthlyCustomersRegistrations = resultMonthlyCustomersRegistrations.Skip(skipCount).Take(pageSize);

            var responseMonthlyOrders = new MonthlyOrders
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResultMonthlyOrders
            };

            var responseMonthlyCustomersRegistrations = new MonthlyCustomersRegistrations
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResultMonthlyCustomersRegistrations
            };

            return new MonthlyReport { MonthlyOrders = responseMonthlyOrders, MonthlyCustomersRegistrations = responseMonthlyCustomersRegistrations };
        }



        #region Private methods

        private static List<string> GetMonthYearListUntilToday()
        {
            Random random = new Random();
            List<string> months = new List<string>(){
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
        };

            int startYear = 2020;
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            int randomYearIndex = random.Next(startYear, currentYear + 1);
            int randomMonthIndex = random.Next(0, 12);

            List<string> values = new List<string>();

            for (int year = randomYearIndex; year <= currentYear; year++)
            {
                int startMonth = (year == randomYearIndex) ? randomMonthIndex : 0;

                int endMonth = (year == currentYear) ? currentMonth - 1 : 11;

                for (int month = startMonth; month <= endMonth; month++)
                {
                    values.Add(months[month] + " " + year);
                }
            }

            return values;
        }

        private static CurrentSales[] CurrentSalesArray(CancellationToken cancellationToken)
        {
            CurrentSales[] result = new CurrentSales[10];
            for (int i = 0; i < 10; i++)
            {
                result[i] = GeCurrentSales();
            }
            return result;
        }




        private static SalesData GetSalesData(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var salesData = CurrentSalesArray(cancellationToken);
            return new SalesData()
            {
                Data = salesData,
                TotalQuantitySold = salesData.Sum(x => x.QuantitySold),
                TotalQuantityLeft = salesData.Sum(x => x.QuantityLeft),
                TotalSales = salesData.Sum(x => x.Sales),
                Currency = "GBP"
            };
        }

        private static CurrentSales GeCurrentSales()
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 10);
            var randomday = rnd.Next(1, 15);
            return new CurrentSales()
            {
                Name = rnd.Next(0, 50).ToString() + "name",
                Type = rnd.Next(0, 50).ToString() + "type",
                StartDate = new DateTime(2022, month, day),
                EndDate = new DateTime(2022, month, day + randomday),
                Price = rnd.Next(0, 50),
                QuantitySold = rnd.Next(0, 50),
                QuantityLeft = rnd.Next(0, 50),
                Sales = rnd.Next(0, 50),
                Currency = "GBP"
            };
        }

        private static MiWizardDTO GetMiWizard(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            return new MiWizardDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                EventName = rnd.Next(0, 50).ToString() + "name",
                PtaName = rnd.Next(0, 50).ToString() + "name",
                Pupils = rnd.Next(1, 50),
                Date = new DateTime(2022, month, day),
                Orders = rnd.Next(1, 50),
                Value = new TotalDTO { Amount = rnd.Next(1, 40), Currency = "GBP" }
            };
        }

        private static CustomerDTO GetCustomer(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);

            return new CustomerDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                FirstName = rnd.Next(0, 50).ToString() + "name",
                LastName = rnd.Next(0, 50).ToString() + "Lastname",
                Child = rnd.Next(0, 50).ToString() + "child",
                Date = new DateTime(2022, month, day),
                Orders = rnd.Next(1, 28),
                Value = new TotalDTO { Amount = rnd.Next(1, 40), Currency = "GBP" }
            };
        }

        private static OrderDTO GetOrder(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var count = rnd.Next(1, 10);
            History[] history = new History[count];

            for (int i = 0; i < history.Length; i++)
            {
                history[i] = CreateHistory();
            }

            return new OrderDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                CustomerName = rnd.Next(0, 50).ToString() + "name",
                CustomerId = rnd.Next(0, 50),
                Status = rnd.Next(0, 10).ToString() + "status",
                Date = new DateTime(2022, month, day),
                Orders = rnd.Next(0, 70),
                Value = new TotalDTO { Amount = rnd.Next(1, 40), Currency = "GBP" },
                SchoolName = rnd.Next(0, 50).ToString() + "SchoolName",
                Email = rnd.Next(0, 70).ToString() + "@Email.com",
                TransactionId = rnd.Next(0, 70).ToString(),
                PayerEmail = rnd.Next(0, 70).ToString() + "@Email.com",
                Type = rnd.Next(0, 50).ToString() + "type",
                PlatformFee = rnd.Next(0, 50),
                Refunded = rnd.Next(0, 50),
                History = history
            };
        }

        private static History CreateHistory()
        {
            Random rnd = new Random();
            return new History()
            {
                ProductId = rnd.Next(0, 10),
                ProductName = rnd.Next(0, 10).ToString() + "name",
                Quantity = rnd.Next(1, 10),
                Price = new TotalDTO { Amount = rnd.Next(1, 40), Currency = "GBP" },
                LineAmount = new TotalDTO { Amount = rnd.Next(1, 40), Currency = "GBP" },
                Status = rnd.Next(0, 10).ToString() + "Status"
            };
        }

        private static TicketDTO GetTicket(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var count = rnd.Next(1, 10);
            List<string> allergiesAmount = new();

            for (int i = 0; i < count; i++)
            {
                allergiesAmount.Add(rnd.Next(0, 100).ToString());
            }

            return new TicketDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                CustomerName = rnd.Next(0, 50).ToString() + "name",
                Product = rnd.Next(0, 60).ToString() + "product",
                Date = new DateTime(2022, month, day),
                TicketNumber = rnd.Next(0, 100),
                Contact = rnd.Next(0, 50).ToString() + "contact",
                Allergies = allergiesAmount
            };
        }

        private static VolunteerDTO GetVolunteer(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);

            return new VolunteerDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                VolunteerName = rnd.Next(0, 50).ToString() + "name",
                Email = rnd.Next(0, 10).ToString() + "@email.com",
                DbsChecked = rnd.Next(2) == 1,
                FirstAider = rnd.Next(2) == 1,
                Date = new DateTime(2022, month, day),
                Contact = rnd.Next(0, 70).ToString() + "contact"
            };
        }

        private static BookingDTO GetBooking(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var count = rnd.Next(1, 10);
            List<string> allergiesAmount = new();

            for (int i = 0; i < count; i++)
            {
                allergiesAmount.Add(rnd.Next(0, 100).ToString());
            }

            return new BookingDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                Product = rnd.Next(0, 80).ToString() + "product",
                CustomerName = rnd.Next(0, 80).ToString() + "CustomerName",
                BookingName = rnd.Next(0, 80).ToString() + "BookingName",
                Date = new DateTime(2022, month, day),
                Contact = rnd.Next(0, 80).ToString() + "contact",
                Allergies = allergiesAmount
            };
        }

        private static ProductQuestionHorizontalDTO GetProductQuestionHorizontal(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            List<string> allergiesAmount = new();
            int count = rnd.Next(1, 10);
            for (int i = 0; i < count; i++)
            {
                allergiesAmount.Add(rnd.Next(0, 100).ToString());
            }

            List<Answers> answers = new();
            count = rnd.Next(1, 10);
            for (int i = 0; i < count; i++)
            {
                answers.Add(CreateAnswers(i));
            }

            return new ProductQuestionHorizontalDTO()
            {
                OrderId = id,
                BookingName = rnd.Next(0, 50).ToString() + "name",
                ClassName = rnd.Next(0, 50).ToString() + "name",
                Email = rnd.Next(0, 60).ToString() + "@email.com",
                Phone = rnd.Next(0, 60).ToString() + "contact",
                BookedFor = rnd.Next(0, 60).ToString() + "bookedfor",
                Product = rnd.Next(0, 60).ToString() + "product",
                Price = rnd.Next(0, 60),
                Order = rnd.Next(0, 60),
                Date = new DateTime(2022, month, day),
                Terms = rnd.Next(0, 60).ToString() + "terms",
                Allergies = allergiesAmount,
                Answers = answers
            };
        }

        private static ProductQuestionVerticalDTO GetProductQuestionVertical(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var count = rnd.Next(1, 10);
            List<string> allergiesAmount = new();

            for (int i = 0; i < count; i++)
            {
                allergiesAmount.Add(rnd.Next(0, 100).ToString());
            }

            List<Answers> answers = new();
            count = rnd.Next(1, 10);
            for (int i = 0; i < count; i++)
            {
                answers.Add(CreateAnswers(i));
            }

            return new ProductQuestionVerticalDTO()
            {
                Num = id,
                OrderId = rnd.Next(0, 50),
                BookingName = rnd.Next(0, 50).ToString() + "name",
                ClassName = rnd.Next(0, 50).ToString() + "name",
                Email = rnd.Next(0, 60).ToString() + "@email.com",
                Phone = rnd.Next(0, 60).ToString() + "contact",
                BookedFor = rnd.Next(0, 60).ToString() + "bookedfor",
                Product = rnd.Next(0, 60).ToString() + "product",
                Price = rnd.Next(0, 60),
                Order = rnd.Next(0, 60),
                Question = rnd.Next(0, 60),
                Answers = answers,
                Date = new DateTime(2022, month, day),
                Terms = rnd.Next(0, 60).ToString() + "terms",
                Allergies = allergiesAmount
            };
        }

        private static InvoiceDTO GetInvoice(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 10);
            var randomday = rnd.Next(1, 15);

            return new InvoiceDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                IssureDate = new DateTime(2022, month, day),
                DueDate = new DateTime(2022, month, day + randomday),
                Status = rnd.Next(0, 50).ToString() + "Status",
                Net = rnd.Next(0, 60),
                Vat = rnd.Next(0, 60),
                Total = rnd.Next(0, 60),
                Currency = "GBP",
                Invoice = "googl.com"
            };
        }

        private static TreasurerByEventDTO GetTreasurerByEvent(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 10);
            var randomday = rnd.Next(1, 15);

            return new TreasurerByEventDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                CustomerName = rnd.Next(0, 50).ToString() + "CustomerName",
                Product = rnd.Next(0, 50).ToString() + "Product",
                Date = new DateTime(2022, month, day),
                Address = rnd.Next(0, 50).ToString() + "Address",
                Type = rnd.Next(0, 50).ToString() + "Type",
                TransactionId = rnd.Next(0, 50),
                TransactionEmail = rnd.Next(0, 50).ToString() + "@TransactionEmail.com",
                Email = rnd.Next(0, 50).ToString() + "@Email.com",
                ToDate = new DateTime(2022, month, day + randomday),
                Quantity = rnd.Next(0, 50),
                Price = rnd.Next(0, 50),
                Currency = "GBP",
                GitfAid = rnd.Next(0, 50),
                Refunded = rnd.Next(0, 50),
                FeesNotPaid = rnd.Next(0, 50),
                FeePaid = rnd.Next(0, 50),
                PlatformFeesNotPaid = rnd.Next(0, 50),
                PlatformFeePaid = rnd.Next(0, 50),
            };
        }

        private static TreasurerByDateDTO GetTreasurerByDate(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);

            return new TreasurerByDateDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                CustomerName = rnd.Next(0, 50).ToString() + "CustomerName",
                Product = rnd.Next(0, 50).ToString() + "Product",
                Date = new DateTime(2022, month, day),
                Event = rnd.Next(0, 50).ToString() + "Event",
                PaypalId = rnd.Next(0, 50),
                PaypaEmail = rnd.Next(0, 50).ToString() + "@PaypaEmail.com",
                Quantity = rnd.Next(0, 50),
                Price = rnd.Next(0, 50),
                GiftAid = rnd.Next(0, 50),
                Refunded = rnd.Next(0, 50),
                Cost = rnd.Next(0, 50)
            };
        }

        private static BankedTransactionDTO GetBankedTransaction(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);

            return new BankedTransactionDTO()
            {
                Num = id,
                OrderId = rnd.Next(0, 50),
                Status = rnd.Next(0, 50).ToString() + "Status",
                Date = new DateTime(2022, month, day),
                Value = rnd.Next(0, 50),
                BankedFee = rnd.Next(0, 60),
                PlatformFee = rnd.Next(0, 60),
                Order = GetOrder(id)
            };
        }

        private static ChildOnlyBookingDTO GetChildOnlyBooking(int id)
        {
            Random rnd = new Random();
            var count = rnd.Next(1, 10);
            List<string> allergiesAmount = new();

            for (int i = 0; i < count; i++)
            {
                allergiesAmount.Add(rnd.Next(0, 100).ToString());
            }

            return new ChildOnlyBookingDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                FirstName = rnd.Next(0, 50).ToString() + "FirstName",
                LastName = rnd.Next(0, 50).ToString() + "LastName",
                BookedBy = rnd.Next(0, 60).ToString() + "BookedBy",
                Allergies = allergiesAmount,
                Phone = rnd.Next(100000, 9999999),
                SoldQuantity = rnd.Next(0, 60),
            };
        }

        private static EmailTrackerDTO GetEmailTracker(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 10);
            var randomday = rnd.Next(1, 3);
            var delivered = rnd.Next(2) == 1;
            var opened = rnd.Next(2) == 1;

            return new EmailTrackerDTO()
            {
                Num = id,
                Id = rnd.Next(0, 50),
                To = rnd.Next(0, 50).ToString() + "CustomerName",
                Email = rnd.Next(0, 50).ToString() + "@Email.com",
                MessageTitle = rnd.Next(0, 50).ToString() + "MessageTitle",
                Message = rnd.Next(0, 50).ToString() + "Message",
                Subject = rnd.Next(0, 50).ToString() + "Subject",
                MessageId = rnd.Next(0, 50),
                SentBy = rnd.Next(0, 50).ToString() + "CustomerName",
                DateSent = new DateTime(2022, month, day),
                Delivered = delivered,
                DeliveredDate = delivered ? new DateTime(2022, month, day + randomday) : null,
                Opened = delivered == true && opened,
                OpenedDate = opened == true ? new DateTime(2022, month, day + randomday + randomday) : null,
                Location = rnd.Next(0, 50).ToString() + "Location",
                Ip = rnd.Next(0, 50).ToString(),
                Type = rnd.Next(0, 50).ToString() + "Type",
            };
        }

        private static Answers CreateAnswers(int id)
        {
            Random rnd = new Random();
            return new Answers()
            {
                QuestionId = id,
                Answer = rnd.Next().ToString()
            };
        }

        private static DataDTO GetDataDTO(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);

            var result = new DataDTO()
            {
                TotalSales = new TotalSales()
                {
                    ProductPercentage = new Dictionary<string, int>() { { "product1", 20 } },
                    TotalSalesDTO = new TotalSalesDTO()
                    {
                        Product = "product1",
                        Quantity = 20,
                        TargetQuantity = 25,
                        Difference = 5,
                        Attaintment = 15,
                        TotalSales = 30,
                        Currency = "GBP"
                    },
                },
                TotalSoldByDay = new TotalSoldByDayDTO()
                {
                    Date = new DateTime(2022, month, day),
                    Quantity = 30,
                    QuantityToDate = 40,
                    TotalSales = 20,
                    SalesToDate = 17,
                    Currency = "GBP"
                },
                ProductsSoldByDay = new Dictionary<string, ProductSoldByDayDTO>
                {
                    { "soldProduct", new ProductSoldByDayDTO()
                                            {
                                                Date = new DateTime(2022, month, day),
                                                Percentage=rnd.Next(1,30),
                                                Quantity=rnd.Next(1,30),
                                                QuantityToDate=rnd.Next(1,30)-5,
                                                TotalSales=rnd.Next(1,30),
                                                ToDate=rnd.Next(1,30),
                                                Currency = "GBP"
                                            }
                    }
                },
                ProductsSoldBySchool = new Dictionary<string, ProductsSoldBySchoolDTO>
                {
                    {"SoldBySchool", new ProductsSoldBySchoolDTO()
                                            {
                                                SchoolName="someName",
                                                Percentage = rnd.Next(1,30),
                                                Quantity=rnd.Next(1,30),
                                                TotalSales=rnd.Next(1,30),
                                                Currency = "GBP"
                                            }
                    }
                },
                ProductOrderCount = new Dictionary<string, ProductOrderCountDTO>
                {
                    {"OrderCount", new ProductOrderCountDTO()
                                            {
                                                Percentage = rnd.Next(1, 30),
                                                NoOfOrder = rnd.Next(1, 30),
                                                ProductCount = rnd.Next(1, 30)
                                            }
                    }
                }
            };

            return result;
        }

        private static IEnumerable<MonthlyOrder> GetListMonthlyOrder(List<string> monthList, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<MonthlyOrder> result = new();
            for (int i = 0; i < monthList.Count; i++)
            {
                result.Add(new MonthlyOrder
                {
                    Month = monthList[i],
                    Orders = rnd.Next(0, 50),
                    Sales = rnd.Next(0, 50),
                    Currency = "GBP"
                });
            }
            return result;
        }

        private static MonthlyCustomersRegistration[] GetListMonthlyCustomersRegistrations(List<string> monthList, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            MonthlyCustomersRegistration[] result = new MonthlyCustomersRegistration[monthList.Count];
            for (int i = 0; i < monthList.Count; i++)
            {
                result[i] = new MonthlyCustomersRegistration
                {
                    Month = monthList[i],
                    Registations = rnd.Next(0, 50),
                };
            }
            return result;
        }

        private static Order GetOrder(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            return new Order()
            {
                OrderId = rnd.Next(0, 100),
                Date = new DateTime(2022, month, day),
                CustomerName = rnd.Next(0, 100).ToString() + "name",
                CustomerId = rnd.Next(0, 100),
                Value = rnd.Next(0, 100),
                Currency = "GBP"
            };
        }
        #endregion
    }
}