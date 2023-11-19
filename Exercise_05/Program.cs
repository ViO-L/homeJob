// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Print(double[] point){
    Console.Clear();
    Console.WriteLine($"Точка пересечения двух прямых находится в координатах ({String.Join("; ", point)})");
}

double[] Calculate (double[] values){
    double[] point = new double[2];
    point[0] = Math.Round((values[3] - values[1]) / (values[0]-values[2]), 2);
    point[1] = Math.Round(values[0] * point[0] + values[1], 2);
    return point;
}

void Enter(){
    string[] variables = {"k1", "b1", "k2", "b2"};
    double[] values = new double[4];
    Console.WriteLine($"Программа найдёт точку пересечения прямых заданных уравнениями y=k1*x+b1 и y=k2*x+b2/\nНажмите любую клавишу, чтобы приступить к вводу значений для k1, b1, k2 и b2.");
    Console.ReadKey();
    for(int i = 0; i < 4; i++){
        Console.Clear();
        Console.Write($"Введите значение для {variables[i]}: ");
        values[i]=Convert.ToDouble(Console.ReadLine());
    }
    if (values[0]-values[2]==0){ //k1 - k2
        Console.WriteLine($"Прямые не пересекаются");
    } else {
        Print(Calculate(values));
    }
}

Enter();