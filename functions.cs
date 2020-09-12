namespace CSfunctional
{
    public static class Functions
    {
        public static string ArabicToRoman(this int input) => new string('I', input)
                .Replace("IIIII", "V")
                .Replace("IIII", "IV")
                .Replace("VV", "X")
                .Replace("VIV", "IX")
                .Replace("XXXXX", "L")
                .Replace("XXXX", "XL")
                .Replace("LL", "C")
                .Replace("LXL", "XC")
                .Replace("CCCCC", "D")
                .Replace("CCCC", "CD")
                .Replace("DD", "M")
                .Replace("DCD", "CM")
                ;
    }
}