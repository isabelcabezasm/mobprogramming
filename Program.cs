namespace mobprogramming
{
    class Program
    {
        public static void Main()
        { 
        
    
        }
    }
    



    public class Fizzbuzz
    {
        public List<string> Run(int number)
        {
            if((0 > number) || (number > 100))
            {
                throw new ArgumentOutOfRangeException();
            }



            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    var temp = "Fizz";
                }
                if (i % 5 == 0)
                {

                }
            }

            return new List<string>();
        }
    }


}
// See https://aka.ms/new-console-template for more information



