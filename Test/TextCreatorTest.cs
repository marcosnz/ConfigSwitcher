using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigSwitcher.Test
{
  [TestClass]
  public class TextCreatorTest
  {
    [TestMethod]
    public void TestMethod1()
    {
      TextCreator sut = new TextCreator();

      List<string> list = new List<string>();
      for (int i = 0; i < 1000; i++)
      {
        string result = sut.CreateText();
        Assert.IsNotNull(result);
        Assert.AreEqual(12, result.Length);
        System.Diagnostics.Debug.WriteLine(result);
        list.Add(result);
        CollectionAssert.AllItemsAreUnique(list, "{0} items in list", list.Count);
      }
    }
    [TestMethod]
    public void TestMethod2()
    {
      TextCreator sut = new TextCreator();
      string result = sut.CreateText(10);
      Assert.IsNotNull(result);
      Assert.AreEqual(10, result.Length);
      System.Diagnostics.Debug.WriteLine(result);
    }
  }
}
