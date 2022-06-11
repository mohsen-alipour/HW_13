using System.ComponentModel.DataAnnotations;
namespace WebApp_HW_13.Models.Entity
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "نام کتاب")]
        public string BookName { get; set; }
        [Display(Name = "نام نویسنده")]
        public string Writer { get; set; }
        [Display(Name = "تعداد صفحات کتاب")]
        public int CountPage { get; set; }

    
    }
}
