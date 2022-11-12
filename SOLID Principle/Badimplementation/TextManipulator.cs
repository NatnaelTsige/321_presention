using System.Linq;

namespace Badimplementation
{
    public class TextManipulator
    {
        private String text;

        public TextManipulator(String text)
        {
            this.text = text;
        }

        public String getText()
        {
            return text;
        }

        public void appendText(String newText)
        {
            text = (string)text.Concat(newText);
        }

        public String findWordAndReplace(String word, String replacementWord)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, replacementWord);
            }
            return text;
        }

        public String findWordAndDelete(String word)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, "");
            }
            return text;
        }

        public void printText()
        {
            Console.WriteLine(this.text);
        }
    }
}