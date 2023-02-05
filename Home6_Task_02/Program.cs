//Задача 43:
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//-----------------------------------------------
double[] EnterCoordinate(int newstring)
{
    double[] array = new double[newstring];

    for (int i = 0; i < newstring; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("Введите переменную b1");  //2
            array[i] = Convert.ToInt32(Console.ReadLine());
        }   
        if (i == 1)
        {
            Console.WriteLine("Введите переменную k1");  //5
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        if (i == 2)
        {
            Console.WriteLine("Введите переменную b2");  //4
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        if (i == 3)
        {
            Console.WriteLine("Введите переменную k2");  //9
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

void CrossPoint(double[] array)
{
    double b1 = array[0];
    double k1 = array[1];
    double b2 = array[2];
    double k2 = array[3];

    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x + b1);

    Console.WriteLine($"Координаты точки пересечения линий: {x}, {y}");
}

double[] resultCoordinate = EnterCoordinate(4);
Console.WriteLine("[{0}]", string.Join(", ", resultCoordinate));

CrossPoint(resultCoordinate);
