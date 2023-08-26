using Faker;
namespace HW35
{
    public class Program
    {
        static void Main()
        {
            OtusDictionary otusDictionary = new OtusDictionary();
            for(int i = 0; i < 32; i++)
            {
                otusDictionary.Add(RandomNumber.Next(100), Name.First());
            }
            otusDictionary.Add(RandomNumber.Next(100), "Victor");
            for (int i = 0; i < 33; i++)
            {
                var name = otusDictionary.Get(i);
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}