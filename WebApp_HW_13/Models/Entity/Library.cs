using System.ComponentModel.DataAnnotations;
namespace WebApp_HW_13.Models.Entity
{
    public class Library
    {
        public int ID { get; set; }
        [Display(Name = "نام کتابخانه")]
        public string LibraryName { get; set; }
        public string LibraryCity { get; set; }
        public string LibraryAddress { get; set; }
    }
}
