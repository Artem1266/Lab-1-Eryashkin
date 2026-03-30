using ConsoleApp.Modules;

class Program
{
    static void Main(string[] args)
    {
        int n = InputModule.ReadInt("Введите число: ");

        if (ValidationModule.IsValidNumber(n, 1, 20))
        {
            ProcessingModule.PrintSquare(n);
        }
        else
        {
            Console.WriteLine("Ошибка: число вне диапазона");
        }
    }
}