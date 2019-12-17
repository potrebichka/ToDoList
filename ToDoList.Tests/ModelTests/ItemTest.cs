using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; // Add this if you want to use Console.WriteLine() in test method.
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable // IDisposable clears all instances before each test method
  {
    public void Dispose()
    {
      // Comment this out in order to use Console.WriteLine()
      Item.ClearAll();
    }


    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("Make Lunch", 7);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }


    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      int num = 1;

      //Act
      Item newItem = new Item(description, num);
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(description, result);
    }


    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      // Arrange
      string description = "Walk the dog.";
      int num = 1;
      Item newItem = new Item(description, num);

      // Act
      string updatedDescription = "Do the dishes";
      int updateNum = 10;
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      // Assert
      Assert.AreEqual(updatedDescription, result);
    }


    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };

      // Act
      List<Item> result = Item.GetAll();

      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
      }

      // Assert
      CollectionAssert.AreEqual(newList, result);

    }


    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      int num1 = 1;
      string description02 = "Wash the dishes";
      int num2 = 2;
      Item newItem1 = new Item(description01, num1);
      Item newItem2 = new Item(description02, num2);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}