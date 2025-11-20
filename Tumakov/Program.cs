using Figure;
using Shifrovanie;
using System;
using static Figure.Circle;
namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Упражнение 1");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // Тестирование ACipher
            Console.WriteLine("\n===Тест ACipher===");
            ICipher Acipher = new ACipher();
            string Atest = "АБВарвераПкп4354";
            string Aencoded = Acipher.Encode(Atest);
            string Adecoded = Acipher.Decode(Aencoded);
            Console.WriteLine($"\nИсходный: {Atest}");
            Console.WriteLine($"Зашифрованный: {Aencoded}");
            Console.WriteLine($"Расшифрованный: {Adecoded}");
            // Тестирование BCipher
            Console.WriteLine("\n===Тест BCipher===");
            ICipher Bcipher = new BCipher();
            string Btest = "АБВ";
            string Bencoded = Bcipher.Encode(Btest);
            string Bdecoded = Bcipher.Decode(Bencoded);
            Console.WriteLine($"\nИсходный: {Btest}");
            Console.WriteLine($"Зашифрованный: {Bencoded}");
            Console.WriteLine($"Расшифрованный: { Bdecoded}");
            //ДЗ 1
            Console.WriteLine("\nДз 1");
            // Создание объектов разных фигур
            Point point = new Point("red", true, 10, 20);
            Circle circle = new Circle(5.0, "blue", true, 15, 25);
            Rectangle rectangle = new Rectangle(4.0, 6.0, "green", true, 30, 40);
            // Демонстрация работы
            point.Display();
            circle.Display();
            rectangle.Display();

            // Демонстрация перемещения
            Console.WriteLine("--- Перемещение фигур ---");
            point.MoveHorizontal(5);
            circle.MoveVertical(10);
            rectangle.MoveHorizontal(-3);

            // Демонстрация изменения цвета
            Console.WriteLine("--- Изменение цвета ---");
            point.ChangeColor("желтый");
            circle.ChangeColor("фиолетовый");
            // Проверка видимости
            Console.WriteLine("=== Проверка видимости ===");
            IFigure[] figures = { point, circle, rectangle }; //массив фигур
            foreach (var figure in figures)
            {
                Console.WriteLine($"Фигура видима: {figure.IsVisible()}");
            }
        }
    }
}
