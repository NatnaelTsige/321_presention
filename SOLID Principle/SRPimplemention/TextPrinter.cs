using System;

namespace ProperImplemention
{
    public class TextPrinter
    {
        TextManipulator textManipulator;

        public TextPrinter(TextManipulator textManipulator)
        {
            this.textManipulator = textManipulator;
        }

        public void printText()
        {
            Console.WriteLine(textManipulator.getText());
        }

      
        public void printRangeOfCharacters(int startingIndex, int endIndex)
        {
            Console.WriteLine(textManipulator.getText().Substring(startingIndex, endIndex));
        }

        public void printToFile() {
            File.WriteAllText("TextOutptu.txt", textManipulator.getText());
        }
    }
}
