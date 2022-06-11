using System.ComponentModel.DataAnnotations;

namespace WebApp_HW_13.Models.Entity
{
    public class Member
    {
        
            public int ID { get; set; }

            [Display(Name = "نام")]
            public string Name { get; set; }

            [Display(Name = "نام خانوادگی")]
            public string Family { get; set; }

            [Display(Name = "کد ملی")]
            public int Codemeli { get; set; }

            [Display(Name = "شماره تماس")]
            public string Tel { get; set; }

        
    }
}
