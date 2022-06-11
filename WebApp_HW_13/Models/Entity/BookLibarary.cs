using System.ComponentModel.DataAnnotations;
namespace WebApp_HW_13.Models.Entity
{
    public class BookLibarary
    {
        public int ID { get; set; }
        public int BookID { get; set; }
   
        [Display(Name = "کتاب")]
        public Book Book { get; set; }
        public int LibraryID { get; set; }

        [Display(Name = "کتابخانه")]
        public Library library { get; set; }
        [Display(Name = "تعداد کتاب در کتابخانه")]
        public int CountBook { get; set; }
    }
}
