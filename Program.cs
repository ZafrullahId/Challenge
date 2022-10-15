namespace CodeChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // var players = new List<int>{17,6,9,9};
            // var trainers = new List<int>{8,28,5,8,10};
            // Console.WriteLine(MatchTrainer(players,trainers));
            // Console.WriteLine(FindingAnumberInAnArray(new List<int>{2,7,9,16,0,4,8},0));
        //    var arr = SumConsequtiveIntigers(315);
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //         Console.Write(arr[i] + ",");
        //    }
        }
        public static int MatchTrainer(List<int> players, List<int> trainers)
        {
            int count = 0;
            for (int i = 0; i < players.Count; i++)
            {
                bool IsLessOrEqual = false;
                for(int j = i; j < trainers.Count; j++)
                {

                    if(players[i] <= trainers[j])
                    {
                        count++;
                        players.Remove(players[i]);
                        trainers.Remove(trainers[j]);
                        i = -1;
                        IsLessOrEqual = true;
                        break;
                    }
                }

                if(IsLessOrEqual == false)
                {
                    players.Remove(players[i]);
                    i = -1;
                }
            }
            return count;
        }

        // public static int FindingAnumberInAnArray(List<int> arr, int original)
        // {
        //     for (int i = 0; i < arr.Count; i++)
        //     {
        //         if(arr.Contains(original))
        //         {
        //             original *= 2;
        //         }
               
        //     }
        //     return original;
        // }

        // public static int[] SumConsequtiveIntigers(int num)
        // {
        //     int [] arr = new int [3];
        //     if(num % 3 != 0)
        //     {
        //         return arr;
        //     }
        //     int middledigit = num / 3;
        //     arr[0] = middledigit - 1;
        //     arr[1] = middledigit;
        //     arr[2] = middledigit + 1;
        //     return arr;
        // }


    }
}
