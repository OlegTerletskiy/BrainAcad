using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson3
    {
    [TestClass]
    public class Operators
        {
        [TestMethod]
        public void DoubleIncrement()
            {

            var i = 0;
            i++;
            ++i;

            Assert.AreEqual(2, i);

            }

        [TestMethod]
        public void ComplexDoubleIncrement()
            {

            var i = 0;
            var j = 0;

            var suffixed=i++;
            var prefixed=++j;

            Assert.AreEqual(0, suffixed);
            Assert.AreEqual(1, prefixed);

            }
        [TestMethod]
        public void PositiveIsOperatortest()
            {

            var value = "Hi, I'm string!";

            var valueIsString = value is String;

            Assert.IsFalse(valueIsString);

            }

        //[TestMethod]
        //public void AsOperatorTest()
        //    {

        //    var value = 123d;

        //    var valueAsString = value as String;

        //    Assert.IsNull(valueAsString);

        //    }

        [TestMethod]
        public void AsOperatorTest2()
            {

            var expected = "Hello!";
            object value = expected;

            var valueAsString = value as String;

            Assert.IsNotNull(valueAsString);
            Assert.AreEqual(expected, valueAsString);

            }

        [TestMethod]
        public void CoalesceOperatorTest()

            //оператор ?? возвращает левое значение если оно не null,
            //иначе возвращает правое
            {

            var defaultValue = "Hi!";
            string valueFromInput = null;

            valueFromInput = valueFromInput ?? defaultValue;

            Assert.AreEqual(defaultValue, valueFromInput);

            }

        [TestMethod]
        public void NeverDoThusIncrement()

            {
            int a = 0;
            a++;
            a += ++a;

            Assert.AreEqual(3, a);
            }
        
        }
    }
