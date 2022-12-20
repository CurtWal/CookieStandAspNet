namespace CookieStandAspNet.Models
{
    public class CookieStand
    {
        public int Id { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public int minimum_customers_per_hour { get; set; }
        public int maximum_customers_per_hour { get; set; }
        public decimal average_cookies_per_sale { get; set; }
        public string owner { get; set; }
       // public int hourly_sales { get; set; }

    }
}
