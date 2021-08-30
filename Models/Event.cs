using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name= "Sự kiện lớn")]
        public Boolean IsBigEvent { get; set; }

        [Display(Name= "Mô tả ngắn gọn")]
        public string Brief { get; set; }

        [Display(Name= "Thông tin chi tiết")]
        public string Body { get; set; }
        [Display(Name="Start Date")]
        public DateTime DateStart { get; set; }
        [Display(Name = "End Date")]
        public DateTime DateEnd { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        [NotMapped] 
        public bool Happening
        {
            get
            {
                DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));

                return (DateStart <= currentTime && currentTime <= DateEnd);
            }
        }
        [NotMapped]
        public bool Ended
        {
            get
            {
                DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));
                return (DateEnd < currentTime);
            }
        }
        [NotMapped]
        public Status Status
        {
            get
            {
                Status stt = new Status();
                if (!Happening && !Ended)
                {
                    stt.Color = "orange";
                    stt.Name = "SOON";
                } else if (!Ended)
                {
                    stt.Color = "green";
                    stt.Name = "Happening";
                } else
                {
                    stt.Color = "gray";
                    stt.Name = "Ended";
                }
                return stt;
            }
        }
    }
}
