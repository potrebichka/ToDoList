using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
    public class Program
    {
        static void Main()
        {
            // string description1 = "Make lunch";
            // int num1 = 1;
            // Item item1 = new Item(description1, num1);
            // string description2 = "Make breakfast";
            // int num2= 2;
            // Item item2 = new Item(description2, num2);
            // string description3 = "Make dinner";
            // int num3 = 3;
            // Item item3 = new Item(description3, num3);
            // string description4 = "Make snack";
            // int num4 = 4;
            // Item item4 = new Item(description4, num4);
            
            // Since _instances is static, you cannot use this
            // List<Item> newList = new List<Item>();
            
            // What is 'this' - all the data of constructor of the class
            List<Item> ourList = Item.GetAll();
            foreach (Item item in ourList)
            {
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Num);
                Console.WriteLine(item.String);
            }
        }
    }
}

