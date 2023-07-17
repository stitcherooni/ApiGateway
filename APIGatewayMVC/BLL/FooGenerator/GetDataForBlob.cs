namespace BLL.FooGenerator
{
    public static class GetDataForBlob
    {
        public static List<List<string>> GetListRequest()
        {
            List<string> data1 = new List<string>
            {
                "##",
                "ID",
                "First Name", "Last Name", "Email"
            };
            List<string> data2 = new List<string>
            {
                "1",
                "717817",
                "Lauren", "Harris", "stitcheroonipentest@gmail.com"
            };
            List<string> data3 = new List<string>
            {
                "2",
                "521238",
                "David", "Cooke", "guest@guest.com"
            };
            List<string> data4 = new List<string>
            {
                "3",
                "285525",
                "Geraldine", "O'Keefe", "newuser@yopmail.com"
            };
            return new() { data1, data2, data3, data4 };
        }
    }
}
