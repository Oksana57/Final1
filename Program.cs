// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



void PrintArray(string[] arg)
{
    Console.Write('[');
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"'{arg[i]}'");
        if (i < arg.Length - 1) Console.Write(",");
    }
    Console.WriteLine("]");
}

string[] StringArraySize(string[] arg)
{
    string[] newarg;

    int size = arg.Length;

    newarg = new string[size];
    int count = 0;

    for (int i = 0; i < newarg.Length; i++)
    {

        if (arg[i].Length <= 3)
        {


            newarg[count] = arg[i];
            count++;


        }
    }
    string[] newarg1 = new string[count];
    for (int i = 0; i < newarg.Length && i < newarg1.Length; i++)
    {
        newarg1[i] = newarg[i];
    }
    newarg = newarg1;

    return newarg;
}


string[] arg;
int size = 4;
arg = new string[size];
Console.WriteLine("Введите массив:");

for (int i = 0; i < arg.Length; i++)
{
    Console.Write("arg[{0}] = ", i);
    arg[i] = Console.ReadLine();

}

PrintArray(arg);
string[] stringsize = StringArraySize(arg);
PrintArray(stringsize);
