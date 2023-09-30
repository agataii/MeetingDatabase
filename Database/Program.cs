using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Database database = new Database();

        while (true)
        {
            database.PrintMainMenu();
        }
    }
}
