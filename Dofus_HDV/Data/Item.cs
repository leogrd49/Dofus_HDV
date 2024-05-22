namespace Dofus_HDV.Data
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }


        public Item(string itemName, int categoryId, string description, decimal price, int quantity)
        {
            ItemName = itemName;
            CategoryID = categoryId;
            Description = description;
            Price = price;
            Quantity = quantity;
            CreatedAt = DateTime.Now;
        }
    }

}
