using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contracts
{
    public interface IPrinter<T>
    {
        T[] Options { get; }
        void SetOptions(params T[] options);
        void Print(string outputText);

        void PrintLine(string outputText);
        void ResetOptions();
    }
}
