using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgorithms
{
    public static class DdaLine
    {
        public static void Calculate(float x1, float y1, float x2, float y2)
        {
            // (1) Целочисленные значения координат начала и конца отрезка,
            // округленные до ближайшего целого
            int iX1 = (int)Math.Round(x1);
            int iY1 = (int)Math.Round(y1);
            int iX2 = (int)Math.Round(x2);
            int iY2 = (int)Math.Round(y2);

            // (2) Длина и высота линии
            int deltaX = Math.Abs(iX1 - iX2);
            int deltaY = Math.Abs(iY1 - iY2);

            // (3) Считаем минимальное количество итераций, необходимое
            // для отрисовки отрезка. Выбирая максимум из длины и высоты
            // линии, обеспечиваем связность линии
            int length = Math.Max(deltaX, deltaY);
            // особый случай, на экране закрашивается ровно один пиксел
            if (length == 0)
            {
                Console.WriteLine($"{iX1} {iY1}");
                return;
            }

            // (4) Вычисляем приращения на каждом шаге по осям абсцисс и ординат
            double dX = (x2 - x1) / length;
            double dY = (y2 - y1) / length;

            // (5) Начальные значения
            double x = x1;
            double y = y1;

            // Основной цикл
            length++;
            while (length > 0)
            {
                length--;
                x += dX;
                y += dY;
                Console.WriteLine($"{(int)Math.Round(x)} {(int)Math.Round(y)}");
            }
        }
    }
}
