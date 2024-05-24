using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dofus_HDV.Data
{
    public class Item
    {
        [Key]
        [Column("ItemID")]
        public int ItemID { get; set; }

        [Column("ItemName")]
        public string ItemName { get; set; }

        [Column("CategoryID")]
        public int CategoryID { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("Level")]
        public int Level { get; set; }
        public Item() { }

        public Item(string itemName, int categoryId, string description, decimal price, int level)
        {
            ItemName = itemName;
            CategoryID = categoryId;
            Description = description;
            Price = price;
            Level = level;
        }
    }

}
