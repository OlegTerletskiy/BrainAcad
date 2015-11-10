using AsciiArt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsciiArtTests
{
    [TestClass]
    public class SymbolSelectorTests
    {
        [TestMethod]
        public void SymbolLessThan25Test()
        {
            const int code = 24;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("#", symbol);
        }

        [TestMethod]
        public void SymbolLessThan30Test()
            {
            const int code = 28;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("@", symbol);
            }
        [TestMethod]
        public void SymbolLessThan40Test()
            {
            const int code = 37;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("Ø", symbol);
            }
        [TestMethod]
        public void SymbolLessThan45Test()
            {
            const int code = 42;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("$", symbol);
            }
        [TestMethod]
        public void SymbolLessThan50Test()
            {
            const int code = 46;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("&", symbol);
            }
        [TestMethod]
        public void SymbolLessThan55Test()
            {
            const int code = 51;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("¤", symbol);
            }
        [TestMethod]
        public void SymbolLessThan60Test()
            {
            const int code = 58;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("~", symbol);
            }
        [TestMethod]
        public void SymbolLessThan65Test()
            {
            const int code = 62;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("·", symbol);
            }
        [TestMethod]
        public void SymbolLessThan70Test()
            {
            const int code = 68;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("¨", symbol);
            }
        [TestMethod]
        public void SymbolLessThan80Test()
            {
            const int code = 78;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual("´", symbol);
            }
        [TestMethod]
        public void SymbolAbove80Test()
            {
            const int code = 128;
            var symbol = SymbolSelector.ChooseSymbol(code);

            Assert.AreEqual(" ", symbol);
            }
    }
}