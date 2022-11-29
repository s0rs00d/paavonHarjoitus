using System;
namespace todolist_api_sub.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? name { get; set; }
        public bool isComplete { get; set; }
    }
    }

