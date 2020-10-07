namespace CslAppEFFilterInclude.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
