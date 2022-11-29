using System;
namespace todolist_api_sub.Models
{
    public class TodoItem
    {
            public long Id { get; set; }
            public string? name { get; set; }
            public bool isComplete { get; set; }
            public string? Secret { get; set; }

    }
}

