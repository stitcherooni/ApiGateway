namespace BLL.FooGenerator
{
    public static class GetDataForBlob
    {
        public static IList<IList<string>> GetListRequest()
        {
            var data1 = new List<string>
            {
                "##",
                "ID",
                "First Name", "Last Name", "Email"
            };
            var data2 = new List<string>
            {
                "1",
                "717817",
                "Lauren", "Harris", "stitcheroonipentest@gmail.com"
            };
            var data3 = new List<string>
            {
                "2",
                "521238",
                "David", "Cooke", "guest@guest.com"
            };
            var data4 = new List<string>
            {
                "3",
                "285525",
                "Geraldine", "O'Keefe", "newuser@yopmail.com"
            };
            return new List<IList<string>> { data1, data2, data3, data4 };
        }
    }
}
