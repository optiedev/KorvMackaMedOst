using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KorvMackaMedOst.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public DateTime ComlpetedDate { get; set; }
        public bool IsCompleted { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
