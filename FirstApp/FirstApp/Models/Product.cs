using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
        //[Key]
        //public int MyProperty { get; set; }

      //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        [Display(Name = "Категория")]
        [MaxLength(20)]
        public string Category { get; set; }
        
        [Display(Name = "Наименование")]
        [MaxLength(30)]
        [Required(ErrorMessage = "Заполните имя")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        [Range(0,100000,ErrorMessage = "Введите число от 0 до 100000")]
        public decimal Price { get; set; }

        [Display(Name = "Изображение")]
        [RegularExpression(@"\w*.jpg", ErrorMessage = "Вводите правильно")]
        public string Image { get; set; }
    }
}
