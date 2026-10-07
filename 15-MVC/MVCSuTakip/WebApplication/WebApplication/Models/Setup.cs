namespace WebApplication.Models
{
    public class Setup
    {
        public class SizeVM
        {
            public int ID { get; set; }
            public string SizeName { get; set; }
        }

        public class CategoryVM
        {
            public int ID { get; set; }
            public string CategoryName { get; set; }
        }

        public class MaterialVM
        {
            public int ID { get; set; }
            public string MaterialName { get; set; }
        }

    }
}