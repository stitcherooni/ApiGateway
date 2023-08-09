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
using BLL.DTO.Statistic.Reports.Sales;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;
using BLL.DTO.Statistic.Searching.Sales;

namespace BLL.FooGenerator
{
    public static class GetReports
    {
        public static async Task<IList<MiWizardDTO>> MiWizardReport(CancellationToken cancellationToken)
        {
            var result = new List<MiWizardDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetMiWizard(i));
            }
            return result;
        }

        public static async Task<IList<CustomerDTO>> CustomerReport(CancellationToken cancellationToken)
        {
            var result = new List<CustomerDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetCustomer(i));
            }
            return result;
        }

        public static async Task<IList<OrderDTO>> OrderReport(CancellationToken cancellationToken)
        {
            var result = new List<OrderDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetOrder(i));
            }
            return result;
        }

        public static async Task<IList<TicketDTO>> TicketReport(CancellationToken cancellationToken)
        {
            var result = new List<TicketDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetTicket(i));
            }
            return result;
        }

        public static async Task<IList<VolunteerDTO>> VolunteerReport(CancellationToken cancellationToken)
        {
            var result = new List<VolunteerDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetVolunteer(i));
            }
            return result;
        }

        public static async Task<IList<BookingDTO>> BookingReport(CancellationToken cancellationToken)
        {
            var result = new List<BookingDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetBooking(i));
            }
            return result;
        }

        public static async Task<IList<ProductQuestionHorizontalDTO>> ProductQuestionHorisontalReport(CancellationToken cancellationToken)
        {
            var result = new List<ProductQuestionHorizontalDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetProductQuestionHorizontal(i));
            }
            return result;
        }

        public static async Task<IList<ProductQuestionVerticalDTO>> ProductQuestionVerticalReport(CancellationToken cancellationToken)
        {
            var result = new List<ProductQuestionVerticalDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetProductQuestionVertical(i));
            }
            return result;
        }

        public static async Task<IList<InvoiceDTO>> InvoiceReport(CancellationToken cancellationToken)
        {
            var result = new List<InvoiceDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetInvoice(i));
            }
            return result;
        }

        public static async Task<IList<TreasurerByEventDTO>> TreasurerByEventReport(CancellationToken cancellationToken)
        {
            var result = new List<TreasurerByEventDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetTreasurerByEvent(i));
            }
            return result;
        }

        public static async Task<IList<TreasurerByDateDTO>> TreasurerByDateReport(CancellationToken cancellationToken)
        {
            var result = new List<TreasurerByDateDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetTreasurerByDate(i));
            }
            return result;
        }

        public static async Task<IList<BankedTransactionDTO>> BankedTransactionReport(CancellationToken cancellationToken)
        {
            var result = new List<BankedTransactionDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetBankedTransaction(i));
            }
            return result;
        }

        public static async Task<IList<ChildOnlyBookingDTO>> ChildOnlyBookingReport(CancellationToken cancellationToken)
        {
            var result = new List<ChildOnlyBookingDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetChildOnlyBooking(i));
            }
            return result;
        }

        public static async Task<IList<EmailTrackerDTO>> EmailTrackerReport(CancellationToken cancellationToken)
        {
            var result = new List<EmailTrackerDTO>();
            for (int i = 1; i <= 50; i++)
            {
                result.Add(GetEmailTracker(i));
            }
            return result;
        }

        public static async Task<IDictionary<string, SalesData>> GetCommonLiveSalesDictionary(CancellationToken cancellationToken, int page, int pageSize)
        {
            return new Dictionary<string, SalesData>()
            {
                {"School Uniform COPY",  GetSalesData(cancellationToken, page, pageSize)},
                { "Second Hand Uniform",  GetSalesData(cancellationToken, page, pageSize)},
                { "Advertising",  GetSalesData(cancellationToken, page, pageSize)}
            };
        }

        public static async Task<(string, IEnumerable<CurrentSales>)> GetCurrentLiveSalesDictionary(CancellationToken cancellationToken, int page, int pageSize)
        {
            var tempSalesDats = GetCurrentSalesData(cancellationToken, page, pageSize);
            return (GetProduct(), tempSalesDats.Data);
        }

        public static async Task<IList<string>> GetMonthYearListUntilToday()
        {
            Random random = new Random();
            var months = new List<string>(){
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
        };

            int startYear = 2020;
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            int randomYearIndex = random.Next(startYear, currentYear + 1);
            int randomMonthIndex = random.Next(0, 12);

            var values = new List<string>();

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

        public static async Task<IEnumerable<Order>> GetOrderList(CancellationToken cancellationToken)
        {
            List<Order> result = new();
            Random rnd = new Random();
            int count = rnd.Next(0, 50);
            for (int i = 1; i <= count; i++)
            {
                result.Add(GetOrder(cancellationToken));
            }
            return result;
        }

        public static IEnumerable<MonthlyOrder> GetListMonthlyOrder(IList<string> monthList, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<MonthlyOrder> result = new();
            for (int i = 0; i < monthList.Count; i++)
            {
                result.Add(new MonthlyOrder
                {
                    OrderId = i,
                    Month = monthList[i],
                    Orders = rnd.Next(0, 50),
                    Sales = rnd.Next(0, 50),
                    Currency = "GBP"
                });
            }
            return result;
        }

        public static MonthlyCustomersRegistration[] GetListMonthlyCustomersRegistrations(IList<string> monthList, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            MonthlyCustomersRegistration[] result = new MonthlyCustomersRegistration[monthList.Count];
            for (int i = 0; i < monthList.Count; i++)
            {
                result[i] = new MonthlyCustomersRegistration
                {
                    Month = monthList[i],
                    Registrations = rnd.Next(0, 50),
                };
            }
            return result;
        }

        public static IEnumerable<Questions> GetQuestions(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 10);

            List<Questions> result = new List<Questions>();
            for (int i = 0; i < count; i++)
            {
                result.Add(CreateQuestions(i));
            }
            return result;
        }

        public static SalesDataProps GetSalesDataProps(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = new SalesDataProps()
            {
                TotalSales = GetTotalSale(cancellationToken, page, pageSize),
                TotalSoldByDay = GetTotalSoldByDay(cancellationToken, page, pageSize),
                ProductsSoldByDay = new Dictionary<string, ProductsSoldByDayItem>
                {
                    { "soldProduct", GetProductsSoldByDayItem(cancellationToken, page, pageSize)}
                },
                ProductsSoldBySchool = new Dictionary<string, ProductSoldSchool>
                {
                    {"SoldBySchool", GetProductSoldSchool(cancellationToken, page, pageSize)
                    }
                },
                ProductOrderCount = new Dictionary<string, ProductOrderCount>
                {
                    {"OrderCount", GetProductOrderCount(cancellationToken, page, pageSize) }
                }
            };

            return result;
        }

        public static async Task<GetSalesReportsResponse> GetSalesResponse(CancellationToken cancellationToken, int page, int pageSize)
        {
            return new GetSalesReportsResponse()
            {
                TotalSales = 10,
                AvgSalesValue = 15,
                TotalSalesValue = 12,
                PlatformBookingFees = 18,
                Data = GetSalesDataProps(cancellationToken, page, pageSize)
            };
        }


        #region Private methods

        private static string GetProduct()
        {
            string[] product = { "School Uniform COPY", "Second Hand Uniform", "Advertising" };
            Random random = new Random();
            int randomIndex = random.Next(product.Length);
            return product[randomIndex];
        }

        private static CurrentSales[] CurrentSalesArray(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 50);
            CurrentSales[] result = new CurrentSales[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = GeCurrentSales();
            }
            return result;
        }

        private static SalesData GetSalesData(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var salesData = CurrentSalesArray(cancellationToken);

            var totalCount = salesData.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = salesData.Skip(skipCount).Take(pageSize);

            return new SalesData()
            {
                Data = paginatedResult,
                TotalQuantitySold = salesData.Sum(x => x.QuantitySold),
                TotalQuantityLeft = salesData.Sum(x => x.QuantityLeft),
                TotalSales = salesData.Sum(x => x.Sales),
                Currency = "GBP",
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
        }

        private static CurrentSalesData GetCurrentSalesData(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            var salesData = CurrentSalesArray(cancellationToken);

            return new CurrentSalesData()
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
                EventId = rnd.Next(1, 115),
                ProductId = rnd.Next(1, 200
                ),
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

        private static Questions CreateQuestions(int id)
        {
            Random rnd = new Random();
            return new Questions()
            {
                QuestionId = id,
                Question = rnd.Next().ToString()
            };
        }

        private static TotalSales GetTotalSale(CancellationToken cancellationToken, int page, int pageSize)
        {
            Random rnd = new Random();
            var result = GetTotalSaleDTOList(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            return new TotalSales()
            {
                ProductPercentage = new Dictionary<string, int>() { { "product" + rnd.Next(0, 100).ToString(), rnd.Next(0, 100) } },
                Sales = paginatedResult,
                TotalQuantity = rnd.Next(0, 100),
                TotalSold = rnd.Next(0, 100),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
        }

        private static TotalSoldByDayDTO GetTotalSoldByDay(CancellationToken cancellationToken, int page, int pageSize)
        {
            Random rnd = new Random();
            var result = GetTotalSoldByDayItemList(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            return new TotalSoldByDayDTO()
            {
                Data = paginatedResult,
                TotalQuantity = result.Sum(x => x.Quantity),
                TotalQuantityToDate = result.Sum(x => x.QuantityToDate),
                TotalSales = result.Sum(x => x.TotalSales),
                TotalSalesToDate = result.Sum(x => x.ToDate),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
        }

        public static ProductsSoldByDayItem GetProductsSoldByDayItem(CancellationToken cancellationToken, int page, int pageSize)
        {
            Random rnd = new Random();
            var result = GetSoldByDayProductList(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);
            return new ProductsSoldByDayItem()
            {
                Data = paginatedResult,
                TotalPercentage = result.Sum(x => x.Percentage),
                TotalQuantity = result.Sum(x => x.Quantity),
                TotalQuantityToDate = result.Sum(x => x.QuantityToDate),
                TotalSales = result.Sum(x => x.TotalSales),
                TotalToDate = result.Sum(x => x.ToDate),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
        }

        public static ProductSoldSchool GetProductSoldSchool(CancellationToken cancellationToken, int page, int pageSize)
        {
            Random rnd = new Random();
            var result = GetProductSoldSchoolItemList(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);
            return new ProductSoldSchool()
            {
                Data = paginatedResult,
                TotalPercentage = result.Sum(x => x.Percentage),
                TotalQuantity = result.Sum(x => x.Quantity),
                TotalSales = result.Sum(x => x.TotalSales),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
        }

        public static ProductOrderCount GetProductOrderCount(CancellationToken cancellationToken, int page, int pageSize)
        {
            Random rnd = new Random();
            var result = GetProductOrderCountItemList(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);
            return new ProductOrderCount()
            {
                Data = paginatedResult,
                TotalPercentage = result.Sum(x => x.Percentage),
                TotalOrder = result.Sum(x => x.NoOfOrder),
                TotalProductCount = result.Sum(x => x.ProductCount),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
        }

        private static IEnumerable<TotalSalesItem> GetTotalSaleDTOList(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<TotalSalesItem> result = new();
            int count = rnd.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                result.Add(GetTotalSaleDTO(i));
            }
            return result;
        }

        private static IEnumerable<TotalSoldByDayItem> GetTotalSoldByDayItemList(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<TotalSoldByDayItem> result = new();
            int count = rnd.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                result.Add(GetTotalSoldByDayItem(i));
            }
            return result;
        }

        private static IEnumerable<SoldByDayProduct> GetSoldByDayProductList(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<SoldByDayProduct> result = new();
            int count = rnd.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                result.Add(GetSoldByDayProduct(i));
            }
            return result;
        }

        private static IEnumerable<ProductSoldSchoolItem> GetProductSoldSchoolItemList(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<ProductSoldSchoolItem> result = new();
            int count = rnd.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                result.Add(GetProductSoldSchoolItem(i));
            }
            return result;
        }

        private static IEnumerable<ProductOrderCountItem> GetProductOrderCountItemList(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            List<ProductOrderCountItem> result = new();
            int count = rnd.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                result.Add(GetProductOrderCountItem());
            }
            return result;
        }

        private static TotalSalesItem GetTotalSaleDTO(int id)
        {
            Random rnd = new Random();
            return new TotalSalesItem
            {
                Num = id,
                Product = rnd.Next(0, 100).ToString() + "-productName",
                Quantity = rnd.Next(0, 100),
                TargetQuantity = rnd.Next(0, 100),
                Difference = rnd.Next(0, 100),
                Attainment = rnd.Next(0, 100),
                TotalSales = rnd.Next(0, 100)
            };
        }

        private static TotalSoldByDayItem GetTotalSoldByDayItem(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            return new TotalSoldByDayItem
            {
                Num = id,
                Date = new DateTime(2022, month, day),
                Percentage = rnd.Next(0, 100),
                Quantity = rnd.Next(0, 100),
                QuantityToDate = rnd.Next(0, 100),
                TotalSales = rnd.Next(0, 100),
                ToDate = rnd.Next(0, 100)
            };
        }

        private static SoldByDayProduct GetSoldByDayProduct(int id)
        {
            Random rnd = new Random();
            var month = rnd.Next(1, 12);
            var day = rnd.Next(1, 28);
            return new SoldByDayProduct
            {
                Num = id,
                Date = new DateTime(2022, month, day),
                Percentage = rnd.Next(0, 100),
                Quantity = rnd.Next(0, 100),
                QuantityToDate = rnd.Next(0, 100),
                TotalSales = rnd.Next(0, 100),
                ToDate = rnd.Next(0, 100)
            };
        }

        private static ProductSoldSchoolItem GetProductSoldSchoolItem(int id)
        {
            Random rnd = new Random();
            return new ProductSoldSchoolItem
            {
                Num = id,
                SchoolName = rnd.Next(0, 100).ToString() + "-name",
                Percentage = rnd.Next(0, 100),
                Quantity = rnd.Next(0, 100),
                TotalSales = rnd.Next(0, 100)
            };
        }
        private static ProductOrderCountItem GetProductOrderCountItem()
        {
            Random rnd = new Random();
            return new ProductOrderCountItem
            {
                Percentage = rnd.Next(0, 100),
                NoOfOrder = rnd.Next(0, 100),
                ProductCount = rnd.Next(0, 100)
            };
        }

        #endregion
    }
}