using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16ToDoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } // ID added by code first migration
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
