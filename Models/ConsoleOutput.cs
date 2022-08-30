namespace RockPaperScissors.Models
{
    using Contracts;
    public class ConsoleOutput : IPrinter<ConsoleColor>
    {
        public ConsoleColor[] Options { get; private set; }

        public void Print(string outputText)
        {
            Console.BackgroundColor = this.Options[0];
            Console.ForegroundColor = this.Options[1];
            Console.Write(outputText);
        }

        public void PrintLine(string outputText)
        {
            Console.BackgroundColor = this.Options[0];
            Console.ForegroundColor = this.Options[1];
            Console.WriteLine(outputText);
        }

        public void ResetOptions()
        {
            Console.ResetColor();
        }

        /// <summary>
        /// Add two elements as parameters. 
        /// On index zero you have to add ConsoleColor.BackgroundColor.
        /// On index one you have to add ConsoleColor.ForegroundColor.
        /// All others parameters will be ignored.
        /// </summary>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SetOptions(params ConsoleColor[] options)
        {
            this.Options = options;
        }   
    }
}
