namespace Dofus_HDV.Data
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }

        public User? User { get; set; }
        public Item? Item { get; set; }


        public Transaction(int userId, int itemId, int quantity, decimal totalPrice)
        {
            UserID = userId;
            ItemID = itemId;
            Quantity = quantity;
            TotalPrice = totalPrice;
            TransactionDate = DateTime.Now;
        }
    }
}
