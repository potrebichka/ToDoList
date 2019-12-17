using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    // We add set; to the line below.
    public string Description { get; set; }
    public string String { get; set; }
    public int Num { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item(string description, int num)
    {
        Description = description;
        Num = num;
        String = "Hello";
        _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }
  }
}