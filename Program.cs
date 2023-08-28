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
                //Добавление элементов в словарь с генерацией случайных индексов и имен.
                otusDictionary.Add(RandomNumber.Next(100), Name.First());
            }
            //Добавление элемента, расширяющего словарь.
            otusDictionary.Add(-67, "Victor");
            for (int i = 0; i < 33; i++)
            {
                var name = otusDictionary.Get(i);
                Console.WriteLine($"otusDictionary[{i}]: "+name);
            }
            //Добавление элемента по индексу.
            otusDictionary[53] = "Fedor";
            Console.WriteLine(otusDictionary[53]);
            Console.ReadLine();
        }
    }
}