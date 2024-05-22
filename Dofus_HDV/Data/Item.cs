using System.ComponentModel.DataAnnotations;

namespace Dofus_HDV.Data
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lot { get; set; }
        public string Price { get; set; }
    }
}
