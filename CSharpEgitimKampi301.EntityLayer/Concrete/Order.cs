namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
/* Sipariş Tablosu
 * 1 nolu Sipariş - 246 nolu Ürün - 1 adet - 100 TL - 1*100=100TL - 3685 nolu Müşteri
 */