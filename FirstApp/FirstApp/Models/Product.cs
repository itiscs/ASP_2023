namespace FirstApp.Models
{
    //public class Category
    //{
    //    public int Id { get; set; } 
    //    public string Name { get; set; }
    //    public List<Product> Products { get; set; }
    //}

    public class Product
    {
        public int Id { get; set; }

        // public Category Category { get; set; }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
