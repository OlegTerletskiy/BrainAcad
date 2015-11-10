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

        if (sb < 25) return "#";
        if (sb < 30) return "@";
        if (sb < 40) return "Ø";
        if (sb < 45) return "$";
        if (sb < 50) return "&";
        if (sb < 55) return "¤";
        if (sb < 60) return "~";
        if (sb < 65) return "·";
        if (sb < 70) return "¨";
        if (sb < 80) return "´";
        else return " ";

            
        }
    }
}