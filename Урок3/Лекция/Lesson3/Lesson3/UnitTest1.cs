using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson3
    {
    [TestClass]
    public class UnitTest1
        {
        [TestMethod]
        public void TestMethod1()
            {

            var key = ConsoleKey.Spacebar;

            switch (key)
                {
                case ConsoleKey.Spacebar:
                    //ProcessSpacebarCommand();
                    break;

                default:
                    Assert.Fail();
                    break;
                }
            }
        }
    }
