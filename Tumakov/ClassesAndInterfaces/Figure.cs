using System;
using System.Globalization;
namespace Figure
{
    public interface IFigure
    {
        void MoveHorizontal(int distance);
        void MoveVertical(int distance);
        void ChangeColor(String newColor);
        bool IsVisible();
        void Display();
    }
    public abstract class Figure : IFigure
    {
        protected string color; // Доступно в Figure и всех потомках
        protected bool isVisible; // Доступно в Figure и всех потомках
        protected int x, y; // Доступно в Figure и всех потомках

        public Figure(string color = "black", bool isVisible = true, int x = 0, int y = 0)
        {
            this.color = color;
            this.isVisible = isVisible;
            this.x = x;
            this.y = y;
        }
        // Абстрактный метод для вычисления площади (будет в потомках)
        public abstract double CalculateArea();
        // Реализация методов интерфейса
        public virtual void MoveHorizontal(int distance) //virtual может быть переопределен (override) в классах-потомках
        {
            x += distance;
            Console.WriteLine($"Фигура перемещена по гор. на {distance}. Новые корды: {x},{y}");
        }
        public virtual void MoveVertical(int distance)
        {
            y += distance;
            Console.WriteLine($"Фигура перемещена по вер. на {distance}. Новые корды: {x},{y}");
        }
        public virtual void ChangeColor(string newColor)
        {
            color = newColor;
            Console.WriteLine($"Цвет фигуры изменен на: {color}");
        }
        public bool IsVisible()
        {
            return isVisible;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Цвет: {color}");
            Console.WriteLine($"Видимость: {(isVisible ? "Видимая" : "Невидимая")}"); //тернарный оператор
            Console.WriteLine($"Координаты: {x}, {y}");
        }
    }
    public class Point : Figure
    {
        public Point(string color = "black", bool isVisible = true, int x = 0, int y = 0) : base(color, isVisible, x, y) //вызов конструктора базового класса
        {
        }
        public override double CalculateArea()
        {
            return 0;
        }
        public override void Display()
        {
            Console.WriteLine("==Точка==");
            base.Display();
            Console.WriteLine($"Площадь:{CalculateArea()}");
            Console.WriteLine();
        }
    }
    public class Circle : Point
    {
        private double radius;
        public Circle(double radius, string color = "black", bool isVisible = true, int x = 0, int y = 0) : base(color, isVisible, x, y)
        {
            this.radius = radius;
        }
        // Метод вычисления площади окружности
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Display()
        {
            Console.WriteLine("==Окружность==");
            base.Display();
            Console.WriteLine($"Радиус: {radius}");
            Console.WriteLine($"Площадь: {CalculateArea():F2}");
            Console.WriteLine();
        }
        public double Radius
        {   
            get { return radius; }
            set { radius = value; }
        }
    }
    // Класс Rectangle (прямоугольник)
    public class Rectangle : Point
    {
        private double width;
        private double height;
        public Rectangle(double width, double height, string color = "black", bool isVisible = true, int x = 0, int y = 0) : base(color, isVisible, x, y)
        {
            this.width = width;
            this.height = height;
        }
        // Метод вычисления площади прямоугольника
        public override double CalculateArea()
        {
            return width * height;
        }
        public override void Display()
        {
            Console.WriteLine("==Прямоугольник==");
            base.Display();
            Console.WriteLine($"Ширина: {width}, Высота: {height}");
            Console.WriteLine($"Площадь: {CalculateArea()}");
            Console.WriteLine();
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
  
