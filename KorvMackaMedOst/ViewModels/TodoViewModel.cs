using KorvMackaMedOst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KorvMackaMedOst.ViewModels
{
    public class TodoViewModel
    {
        public string Content { get; set; }
        public List<TodoItem> TodoItems { get; set; }
    }
}
