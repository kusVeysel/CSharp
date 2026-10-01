namespace WebApplicationAPI.Models
{
    public class Product
    {
        public int ID { get; set; } // Core versiyonda, ID yazan property otomatik olarak primary key ve bir bir artan olarak oluşturulur.
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
