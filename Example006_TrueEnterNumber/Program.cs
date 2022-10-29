//Считать координаты точки и вывести номер четверти, в которой находится точка

//Пример функции, которая реализует защиту от "дурака" при вводе числа

int GetCoordinate (string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        //Добавлена проверка на null в console.resdline
        if (int.TryParse(Console.ReadLine()?? "", out int number) && number != 0) //out означает, 
                                                                            //что передается ссылка на переменную number
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("You enter not digit or your digit equal zero. Please repeat your enter\n");
        }
    }

    return result;
}

int x = GetCoordinate ("Please enter X:");
int y = GetCoordinate ("Please enter Y:");

/*
создание массива

int[] arr  = new int[12];

*/