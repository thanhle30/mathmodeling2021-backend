using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Full Name")]
        public string FullName { get; set; }
        [Phone]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        public string Body { get; set; }
        [Display(Name = "Post Date")]
        public DateTime PostDate { get; set; }
        public bool ReviewStatus { get; set; }
        [NotMapped]
        public Status Status
        {
            get
            {
                Status stt = new Status();
                if (ReviewStatus)
                {
                    stt.Color = "green";
                    stt.Name = "Reviewed";
                } else
                { 
                    stt.Color = "orange";
                    stt.Name = "To Review";
                }
                return stt;
            }
        }
    }
}
