using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zkbio.Data.Model.Attendance
{
    public class AccTransaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [StringLength(100, ErrorMessage = "Unique key cannot be longer than 30 characters.")]
        public string unique_key { get; set; }

        public int? log_id { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [StringLength(30, ErrorMessage = "Create operator  cannot be longer than 30 characters.")]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }
        public DateTime? event_time { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [StringLength(30, ErrorMessage = "Pin  cannot be longer than 30 characters.")]
        public string pin { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name  cannot be longer than 50 characters.")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name  cannot be longer than 50 characters.")]
        public string last_name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "Dept name  cannot be longer than 100 characters.")]
        public string dept_name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [StringLength(100, ErrorMessage = "Area name  cannot be longer than 100 characters.")]
        public string area_name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Card no  cannot be longer than 100 characters.")]
        public string card_no { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "Device name cannot be longer than 100 characters.")]
        public string dev_alias { get; set; }
    }
}
