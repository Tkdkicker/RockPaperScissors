namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            score = 0;
            int computerscore;
            computerscore = 0;
            string userinput;
            var random = new Random();
            var wordlist = new List<string>{ "rock", "paper", "scissors"};
            string computerinput = (wordlist[Index]);

            {
                Console.WriteLine("Welcome to a game of rock, paper, scissors");
                Console.WriteLine("You are playing against the computer, and whoever gets up to 10 is the winner");
                do
                {
                    Console.WriteLine("Choose rock, paper or scissors");
                    userinput = Console.ReadLine();

                    //When you draw
                    if (userinput == computerinput)
                        Console.WriteLine("You draw. Your score is: " + score);
                    Console.ReadLine();

                    //When you lose
                    if (computerinput == "paper" && userinput == "rock")
                        computerinput = computerinput + 1;
                    Console.WriteLine("You lose. Your score is: " + score + " and the PC's score " + computerscore);
                    Console.ReadLine();

                    //When you lose
                    if (computerinput == "rock" && userinput == "scissors")
                        computerinput = computerinput + 1;
                    Console.WriteLine("You lose. Your score is: " + score + " and the PC's score " + computerscore);
                    Console.ReadLine();

                    //When you lose
                    if (computerinput == "scissors" && userinput == "paper")
                        computerinput = computerinput + 1;
                    Console.WriteLine("You lose. Your score is: " + score + " and the PC's score " + computerscore);
                    Console.ReadLine();

                    //When you win
                    if (userinput == "paper" && computerinput == "rock")
                        computerinput = computerinput + 1;
                    Console.WriteLine("You win. Your score is: " + score + " and the PC's score " + computerscore);
                    Console.ReadLine();

                    //When you win
                    if (userinput == "rock" && computerinput == "scissors")
                        computerinput = computerinput + 1;
                    Console.WriteLine("You win. Your score is: " + score + " and the PC's score " + computerscore);
                    Console.ReadLine();

                    //When you win
                    if (userinput == "scissors" && computerinput == "paper")
                        computerinput = computerinput + 1;
                    Console.WriteLine("You win. Your score is: " + score + " and the PC's score " + computerscore);
                    Console.ReadLine();

                } while (score < 10);

                Console.ReadLine();
            }
        }
    }
}