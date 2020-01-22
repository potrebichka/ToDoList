using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
      this.Completed = false;
    }

    public int ItemId { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; } 
    public ICollection<CategoryItem> Categories { get; }

    public bool Completed { get; set; }
    public DateTime DueDate { get; set; }
  }
}