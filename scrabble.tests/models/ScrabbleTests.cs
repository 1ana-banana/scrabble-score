using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.TestTools{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void Scrabble_AssignWord_WordIsAssigned()
    {
      string newWord = "Epicodus";
      string result = newWord;
      Assert.AreEqual(newWord, result);
    }
    [TestMethod]
    public void Scrabble_WordToCharArray_CharArray()
    {
      string newWord = "Epicodus";
      char[] correctArray = {'E', 'p', 'i', 'c', 'o', 'd', 'u', 's'};
      char[] newArray = newWord.ToCharArray();
      CollectionAssert.AreEqual(correctArray, newArray);
    }
  }
}