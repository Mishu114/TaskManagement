using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }


        [Column(TypeName ="nvarchar(20)")]
        [DisplayName("Task Title")]
        [Required]
        public string TaskTitle { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Task Description")]
        [Required]
        public string TaskDescription { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Task Status")]
        public string TaskStatus { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
