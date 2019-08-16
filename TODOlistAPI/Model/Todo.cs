using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TODOlistAPI.Model
{
    [Table("TODO")]
    public partial class Todo
    {
        [Key]
        [Column("TaskID")]
        public int TaskId { get; set; }
        [Required]
        [StringLength(255)]
        public string TaskTitle { get; set; }
        [Required]
        [StringLength(255)]
        public string TaskDescription { get; set; }
    }
}
