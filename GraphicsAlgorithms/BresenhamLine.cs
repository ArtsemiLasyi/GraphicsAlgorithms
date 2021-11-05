using System;

namespace GraphicsAlgorithms
{
    public static class BresenhamLine
    {
        public static void Calculate(float x1, float y1, float x2, float y2)
        {
            int deltaX, deltaY;
            int signX = 1, signY = 1;

            deltaX = (int)Math.Abs(x2 - x1);
            deltaY = (int)Math.Abs(y2 - y1);

            if (x1 > x2)
            {
                signX = -1;
            }
            if (y1 > y2)
            {
                signY = -1;
            }

            int error = deltaX - deltaY;

            while (x1 != x2 || y1 != y2)
            {
                Console.WriteLine($"{x1} {y1}");

                int error2 = error * 2;

                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x1 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y1 += signY;
                }
            }
            Console.WriteLine($"{x2} {y2}");
        }
    }
}
