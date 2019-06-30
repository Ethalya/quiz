using System;
using System.Timers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz;
namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//Test timera
			Timer t = new Timer(0.1);
			t.Start();
			bool b = false;
			while (true)
			{
				b = t.AutoReset;
				if (b) break;
			}

			Assert.AreEqual(true, b);
		}

		[TestMethod]
		public void TestMethod3()
		{
			//Test funkcji losującej
			int a = Funkcje.losuj(3, 4);
			bool b = a == 3 || a == 4;
			Assert.AreEqual(true, b);
		}

		[TestMethod]
		public void TestMethod4()
		{
			//Test funkcji szukajacej
			int[] x = { 1, 2, 3, 4 };
			int s = 2;
			bool expected = Funkcje.search(x, s);
			Assert.AreEqual(true, expected);
		}
	}
}
