namespace SuperAltShift.Utilities
{
    static class TextCorrecter
    {
        public static string CorrectText(string text)
        {
            const string notShiftTextEn = "`1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./";
            const string shiftTextEn = "{~}!@#${^}&*{(}{)}_{+}QWERTYUIOP{{}{}}|ASDFGHJKL:\"ZXCVBNM<>?";
            var textEn = (notShiftTextEn + shiftTextEn).ToCharArray();
            const string notShiftTextRu = "ё1234567890-=йцукенгшщзхъ\\фывапролджэячсмитьбю.";
            const string shiftTextRu = "Ё!\"№;%:?*()_+ЙЦУКЕНГШЩЗХЪ/ФЫВАПРОЛДЖЭЯЧСМИТЬБЮ,";
            var textRu = (notShiftTextRu + shiftTextRu).ToCharArray();
            var newText = "";
            foreach (var t in text)
            {
                if (textEn.Contains(t))
                {
                    newText += textRu[Array.IndexOf(textEn, t)];
                }
                else if (textRu.Contains(t))
                {
                    newText += textEn[Array.IndexOf(textRu, t)];
                }
                else
                {
                    newText += t;
                }
            }

            return newText;
        }
    }
}