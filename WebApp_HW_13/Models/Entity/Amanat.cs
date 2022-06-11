using System.ComponentModel.DataAnnotations;

namespace WebApp_HW_13.Models.Entity
{
    public class Amanat
    {
        public int ID { get; set; }
        [Display(Name = "شناسه عضو")]
        public int MemberID { get; set; }
        [Display(Name = "عضو")]
        public Member Member { get; set; }
        [Display(Name = "شناسه کتاب ")]
        public int BookID { get; set; }

        [Display(Name = "کتاب")]
        public Book Book { get; set; }
        [Display(Name = "شناسه کتابخانه ")]
        public int LibraryID { get; set; }

        [Display(Name = "کتابخانه")]
        public Library library { get; set; }
    }
}
