using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public Category()
        {
            this.Items = new HashSet<CategoryItem>();
        }
        public string Name { get; set; }
        public int CategoryId { get; set;}
        public virtual ICollection<CategoryItem> Items { get; set; }

    }
}