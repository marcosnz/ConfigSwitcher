using System.Collections.Generic;
using System.Diagnostics;
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
        string result = sut.CreateText(dontDuplicate: list);
        Assert.IsNotNull(result);
        Assert.AreEqual(12, result.Length);
        Debug.WriteLine(result);
        list.Add(result);
        CollectionAssert.AllItemsAreUnique(list, "{0} items in list", list.Count);
      }
    }
    [TestMethod]
    public void TestMethod2()
    {
      TextCreator sut = new TextCreator();
      string result = sut.CreateText(8);
      Assert.IsNotNull(result);
      Assert.AreEqual(8, result.Length);
      Debug.WriteLine(result);

      result = sut.CreateText(15);
      Assert.IsNotNull(result);
      Assert.AreEqual(15, result.Length);
      Debug.WriteLine(result);
    }
  }
}
