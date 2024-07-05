namespace Reverse_Words
{
    public class Program
    {
        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }
            string[] words = sentence.Split(' ');
            string reversedSentence = string.Empty;

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedSentence += words[i];
                if (i > 0)
                {
                    reversedSentence += " ";
                }
            }
            return reversedSentence;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("csharp is programming language"));
            Console.WriteLine(ReverseWords("Reverse the words in this sentence"));
            Console.WriteLine(ReverseWords("challenges and data structures"));
        }
    }
    }
