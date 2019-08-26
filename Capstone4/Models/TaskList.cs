using System;
using System.Collections.Generic;

namespace Capstone4.Models
{
    public partial class TaskList
    {
        public int UserId { get; set; }
        public string Desciption { get; set; }
        public DateTime DueDate { get; set; }
        public string Complete { get; set; }
    }
}
