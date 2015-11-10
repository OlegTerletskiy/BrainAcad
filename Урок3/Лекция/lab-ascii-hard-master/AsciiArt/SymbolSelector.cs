namespace AsciiArt
{
    public static class SymbolSelector
    {
        public static string ChooseSymbol(int sb)
        {
            // # < 25
            // @ < 30
            // Ø < 40
            // $ < 45
            // & < 50
            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80

            // else " "
            return " ";
        }
    }
}