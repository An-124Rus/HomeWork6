internal class Program
{
    private static void Main(string[] args)
    {
        int gold;
        int crystal;
        int crystalPrice = 10;
        int totalCost;        

        Console.Write("Введите количество золота: ");
        gold = Convert.ToInt32(Console.ReadLine());
        Console.Write("Стоимость кристалла - " + crystalPrice + ". Сколько красталлов необходимо: ");
        crystal = Convert.ToInt32(Console.ReadLine());

        totalCost = crystalPrice * crystal;
        gold -= totalCost;

        Console.WriteLine($"Вы купили {crystal} кристаллов и у вас осталось {gold} золота");
    }
}