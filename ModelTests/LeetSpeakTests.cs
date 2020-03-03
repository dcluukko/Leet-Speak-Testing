using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests 
{
    [TestClass]
    public class ToLeetSpeak 
    {
      [TestMethod]
			public void ToLeetSpeak_InputIsString_True()
			{
				ToLeetSpeak testLeetSpeak = new ToLeetSpeak();
				Assert.AreEqual(true, testLeapYear("string"));
			}
    }
}