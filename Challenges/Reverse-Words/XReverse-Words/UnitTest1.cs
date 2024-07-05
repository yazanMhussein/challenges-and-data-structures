namespace Reverse_Words
{
    public class ReverseWordsTests
    {
        [Fact]
        public void Test1()
        {
            string input = "csharp is programming language";
            string expected = "language programming is csharp";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string input = "challenges and data structures";
            string expected = "structures data and challenges";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }
    }
