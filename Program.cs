using System;

public class Program
{
    public static void Main()
    {
        Func<string, string, bool> containsWord = (text, word) =>
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        };

        string inputText = "Це приклад тексту для перевірки наявності слова у ньому.";
        string searchWord = "приклад";

        bool contains = containsWord(inputText, searchWord);

        if (contains)
        {
            Console.WriteLine($"Текст містить слово '{searchWord}'.");
        }
        else
        {
            Console.WriteLine($"Текст не містить слово '{searchWord}'.");
        }
    }
}
