/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*
void Number(int number)
{
    if ((number > 9999 && number < 100000) || (number < -9999 && number > -100000))
    {
        int first_digit = number / 10000;
        int second_digit = (number / 1000) % 10;
        int forth_digit = (number % 100) / 10;
        int fifth_digit = number % 10;
        if (first_digit == fifth_digit && second_digit == forth_digit)
            Console.Write("Your number is palindrome!");
        else
            Console.Write("Your number is not palindrome!");
    }
    else
        Console.Write("Your number must be 5-digits!");
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Number(num);
*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double deltaAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return deltaAB;
}

Console.Write("Input X coordinate of A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double a = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);

Console.Write($"Distanse is {a - a % 0.01}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cube(int uN)
{
    int current = 1;
    while (current <= uN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res}, ");
        current++;
    }
    Console.WriteLine("\b\b."); 
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 1)
{
    Console.Write($"{user_number} -> ");
    Cube(user_number);
}
else Console.WriteLine("Impossible number!");