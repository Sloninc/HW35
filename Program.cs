namespace HW35
{
    public class Program
    {
        static void Main()
        {
            OtusDictionary otusDictionary = new OtusDictionary();
            otusDictionary.Add(1, "Anton");
            otusDictionary.Add(30, "Dima");
            Console.WriteLine(otusDictionary.Get(1)+" "+otusDictionary.Get(30));
            Console.ReadLine();
        }
    }
}