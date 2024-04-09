namespace _0409_S2_Les_boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];
            int repeat, numMoves = 0;

            Console.WriteLine("List dance moves (max 32):");
            Console.WriteLine("(enter \"done\" if you have finish listing)\n");

            while (numMoves < moves.Length)
            {
                string move = moves[numMoves] = Console.ReadLine() ?? "done";
                if (move == "done") break;
                numMoves++;
            }

            Console.Write("\nEnter a number of iterations: ");
            repeat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (repeat > 0)
            {
                for (int i = 0; i < numMoves; i++)
                    Console.WriteLine(moves[i]);
                repeat--;
            }
        }
    }
}
