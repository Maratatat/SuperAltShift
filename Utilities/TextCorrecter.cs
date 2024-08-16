namespace SuperAltShift
{
    static class TextCorrecter
    {

        public static string CorrectText(string text)
        {
            string notShifttextEN = "`1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./";
            string shiftTextEN = "{~}!@#${^}&*{(}{)}_{+}QWERTYUIOP{{}{}}|ASDFGHJKL:\"ZXCVBNM<>?";
            char[] textEN =(notShifttextEN + shiftTextEN).ToCharArray();
            string notShiftTextRU = "ё1234567890-=йцукенгшщзхъ\\фывапролджэячсмитьбю.";
            string shiftTextRU = "Ё!\"№;%:?*()_+ЙЦУКЕНГШЩЗХЪ/ФЫВАПРОЛДЖЭЯЧСМИТЬБЮ,";
            char[] textRU = (notShiftTextRU + shiftTextRU).ToCharArray();
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (textEN.Contains(text[i]))
                {
                    newText+= textRU[Array.IndexOf(textEN, text[i])];
                }
                else if (textRU.Contains(text[i]))
                {
                    newText += textEN[Array.IndexOf(textRU, text[i])];
                }
                else
                {
                    newText += text[i];
                }
            }

            return newText;
        }
    }
}
