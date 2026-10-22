using System;
using System.Text;

namespace Lab7Library.TextProcessing
{
    public static class TextTools
    {
        public static string ReverseText(string text)
        {
            StringBuilder reverse = new StringBuilder();
            for(int i = text.Length - 1; i > -1; i--)
                reverse.Append(text[i]);
            return reverse.ToString();
        }
    }
}
