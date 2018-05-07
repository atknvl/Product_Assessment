namespace ProductsPL.Models
{
    public class ProductPO
    {
        //---Instantiate properties for Product presentation objects---//
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}