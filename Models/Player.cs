namespace RockPaperScissors.Models
{
    using Contracts;
    public abstract class Player : IPlayer
    {
        public Movement Move { get; protected set; }

        public virtual bool SetMovement(string playerMove)
        {
            if (playerMove == "r" || playerMove == "rock")
            {
                Move = Movement.Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                Move = Movement.Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                Move = Movement.Scissors;
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
