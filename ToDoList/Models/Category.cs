using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public Category()
        {
            this.Items = new HashSet<Item>();
        }
        public string Name { get; set; }
        public int CategoryId { get; set;}
        public virtual ICollection<Item> Items { get; set; }

    }
}