using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contracts
{
    public interface IPlayer
    {
        public Movement Move { get; }

        public bool SetMovement(string playerMove);

    }
}
