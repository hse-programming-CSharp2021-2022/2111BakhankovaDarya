using System;

namespace HW1_presentation2_01a_task3
{
    class Program
    {
        public class Polygon
        { // Класс многоугольников
            int numb;       // Число сторон
            double radius;  // Радиус вписанной окружности
            public Polygon(int n = 3, double r = 1)
            { // конструктор       
                numb = n;
                radius = r;
            }

            // СВОЙСТВО PERIMETR
            public double Perimeter
            { // Периметр многоугольника - свойство
                get
                {   // аксессор свойства
                    double term = Math.Tan(Math.PI / numb);
                    return 2 * numb * radius * term;
                }
            }

            // СВОЙСТВО AREA
            public double Area
            { // Площадь многоугольника - свойство
                get
                {   // аксессор свойства
                    return Perimeter * radius / 2;
                }
            }
            public string PolygonData()
            {
                string res =
                string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
                numb, radius, Perimeter, Area);
                return res;
            }


        }   // Polygon 

        static void Main(string[] args)
        {
            Polygon polygon = new Polygon();
            Console.WriteLine("По умолчанию создан многоугольник: ");
            Console.WriteLine(polygon.PolygonData());
            double rad;
            int number;
            int n = 0;
            do
            {
                do Console.Write("Количество многоугольников: ");
                while (!int.TryParse(Console.ReadLine(), out n) | n < 0);
                Polygon[] polygons = new Polygon[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Многоугольник {i}:");
                    do Console.Write("Введите число сторон: ");
                    while (!int.TryParse(Console.ReadLine(), out number) | number < 3);
                    do Console.Write("Введите радиус: ");
                    while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
                    polygons[i] = new Polygon(number, rad);
                }
                // Find min amd max.
                var minArea = polygons[0].Area;
                var minN = 0;
                var maxArea = polygons[0].Area;
                var maxN = 0;
                for (int i = 0; i < n; i++)
                {
                    if (polygons[i].Area > maxArea)
                    {
                        maxArea = polygons[i].Area;
                        maxN = i;
                    }
                    if (polygons[i].Area < minArea)
                    {
                        minArea = polygons[i].Area;
                        minN = i;
                    }
                }

                // Вывод информации.
                Console.WriteLine("Сведения о многоугольниках:");
                for (int i = 0; i < n; i++)
                {
                    if (i == minN)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(polygons[i].PolygonData());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i == maxN)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(polygons[i].PolygonData());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(polygons[i].PolygonData());
                    }
                }

                Console.WriteLine("Для выхода нажмите клавишу ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
