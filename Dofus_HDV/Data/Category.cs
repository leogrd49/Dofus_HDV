namespace Dofus_HDV.Data
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {
            
        }
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }

}
