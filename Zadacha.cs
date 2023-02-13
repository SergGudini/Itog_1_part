// See https://aka.ms/new-console-template for more information

string[] GetArray(int size)
{
    string[] array = new string[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] ResultArray(string[] array)
{
    int size = 0;

     for(int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3) size++;
        }      

    string[] mass = new string[size];
    int j = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            mass[j] = array[i];
            j++; 
        }      
    }
    /*string[] mass = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3) mass[i] = array[i];
        } */
    return mass;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите количесвто элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Заполните массив элементами: ");
string[] massive1 = GetArray(size);

string[] massive2 = ResultArray(massive1);

Console.Write("Ваш массив: ");
PrintArray(massive1);

Console.Write("\nРезультат: ");
PrintArray(massive2);
