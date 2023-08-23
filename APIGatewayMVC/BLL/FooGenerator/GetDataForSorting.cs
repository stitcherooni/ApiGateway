using BLL.DTO.Sorting;
using System;
using System.Collections.Generic;

namespace BLL.FooGenerator
{
    public static class GetDataForSorting
    {
        public static IDictionary<int, IEnumerable<Year>> GetLstOfYears()
        {
            int count = 0;
            var lstOfYears = new Dictionary<int, IEnumerable<Year>>();
            int id = 0;
            var counting = SplitIntoParts();
            for (int j = 0; j < 3; j++)
            {
                int year = 2020 + count;
                var yearList = new List<Year>();
                for (int i = 0; i < counting[j]; i++)
                {
                    yearList.Add(GetYear(i + id));
                }
                lstOfYears.Add(year, yearList);
                count++;
                id = id + counting[j];
            }
            return lstOfYears;
        }

        public static string GetRandomFormat()
        {
            string[] groupByOptions = { "horizontal", "vertical" };
            Random random = new Random();
            int randomIndex = random.Next(groupByOptions.Length);
            return groupByOptions[randomIndex];
        }

        public static IEnumerable<GroupBy> GetGroupByForChildBookings()
        {
            List<GroupBy> result = new();
            string[] Id = { "className", "noGroup" };
            string[] Name = { "Class Name", "No Group" };
            result.Add(new GroupBy {Id = Id[0], Name = Name[0]});
            result.Add(new GroupBy { Id = Id[1], Name = Name[1] });

            return result;
        }

        public static IEnumerable<Events> GetEventList()
        {
            Random random = new Random();
            int count = random.Next(15);
            var result = new Events[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = GetEvent();
            }
            return result;
        }

        public static IEnumerable<Products> GetProductsForProductQuestions()
        {
            return new Products[5]
            { new Products() { ProductId = 1, ProductName = "£1 Tickets" },
            new Products() { ProductId = 2, ProductName = "£5 Tickets" },
            new Products() { ProductId = 3, ProductName = "£10 Tickets" },
            new Products() { ProductId = 4, ProductName = "Grotto Boarding Passes" },
            new Products() { ProductId = 5, ProductName = "All" } };
        }

        public static IEnumerable<Products> GetProductsForBooking()
        {
            return new Products[3]
            { new Products() { ProductId = 1, ProductName = "£1 Tickets" },
            new Products() { ProductId = 2, ProductName = "Prize Draws" },
            new Products() { ProductId = 3, ProductName = "All Products" }};
        }

        #region Private methods

        private static Events GetEvent()
        {
            return new Events { Year = GetLstOfYears() };
        }

        public static IEnumerable<GroupBy> GetRandomGroup()
        {
            string[] Id = { "className", "productName", "productOrder", "bookingName" };
            string[] Name = { "Class Name", "Product Name", "Product Order", "BookingName" };

            List <GroupBy> result= new();
            for (int i = 0; i < Id.Length; i++)
            {
                result.Add(new GroupBy { Id = Id[i], Name = Name[i] });
            }

            return result;

        }

        private static Year GetYear(int id)
        {
            Random rnd = new Random();
            return new Year()
            {
                EventId = id,
                EventName = rnd.Next().ToString() + "-name"
            };
        }

        static int[] SplitIntoParts()
        {
            int total = 50;
            int numParts = 3;
            Random random = new Random();
            int[] parts = new int[numParts];
            int remainingTotal = total;

            for (int i = 0; i < numParts - 1; i++)
            {
                int randomValue = random.Next(1, remainingTotal - (numParts - i - 1));
                parts[i] = randomValue;
                remainingTotal -= randomValue;
            }

            parts[numParts - 1] = remainingTotal;

            return parts;
        }

        #endregion
    }
}
