//Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.
void Number(int number)
{
    int n = 0;               // n - количество знаков в заданном числе
    int number1 = number;    //дополнительная переменная, поскольку number нам еще понадобится
    while (number1 > 0)
    {
        number1 = number1 / 10;     //цикл по нахождению количества знаков в заданном числе
        n++;
    }

    int degree = n - 1; // degree - степень, в которую будем возводиь 10, чтобы искать 1ю, 2ю  тд цифры. Минус один, потому что первая цифра найдена ниже
    
    double dc = Math.Pow(10, degree);  // dc - число, на которое мы поделим исходное, чтобы получить 1ю цифру
    int ic = (int) dc; // перевел тип double в тип int, чтобы можно было совершать арифметические действия
    
    int b = number / ic; // b - первая цифра числа
    int a = number % 10; // а - последняя цифра числа

    int index = n / 2;   // index - переменная для работы цикла по сравнению цифр

    while (index > 0)   // цикл по сравнению первой и последней цифр, второй и предпоследней и тд
    {
        if (a == b)
        {
            a = ((number - a) / 10) % 10;  // формула нажождения предпоследней цифры, предпредпоследней и тд
            b = b / (ic / 10);             // формула нахождения второй цифры, третьей и тд
            index = index - 1;
            Console.Write("Your number is palindrome!");
        }
        else
            Console.WriteLine("Your number is not palindrome!");
            break;
    }
    
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Number(num);
