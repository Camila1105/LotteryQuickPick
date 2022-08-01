

namespace lottery
{
    public class QuickPick
    {
        public IDictionary<int, int[]> GenerateTicket()
        {           
            int gameLenght = 7;
            Console.WriteLine("Please enter a number from 4 to 50, to select the number of games you would like to play ");
            int selectedGames = int.Parse(Console.ReadLine());
            int TotalNumbers = selectedGames * 7;
            Random random = new Random();
            IDictionary<int, int[]> ticketGame = new Dictionary<int, int[]>(selectedGames);  
            for (int i = 0; i < selectedGames;)
            {
                HashSet<int> gameNumbers = new HashSet<int>();
                while (gameNumbers.Count < gameLenght)
                {
                    gameNumbers.Add(random.Next(1, 47));
                }
                int[] array = new int[gameLenght];
                for (int j = 0; j < array.Length;)
                {
                    array[j] = gameNumbers.ToList()[j];
                    j++;
                }
                ticketGame[i] = array;
                i++;
                
            }
            Console.WriteLine("Your ticket contains the following games:");
            foreach (KeyValuePair<int, int[]> number in ticketGame)
            {
                Console.WriteLine("Game {0} with the numbers: {1}", number.Key+1, String.Join(",", number.Value));
            }            
            return ticketGame;
        }           

    }
}
