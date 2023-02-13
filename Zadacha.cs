string[] GetArray(int size) // метод для заполнения массива string
{
    string[] array = new string[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] ResultArray(string[] array) // метод который заполняет массив элементами размером <=3
{
    int size = 0;

     for(int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3) size++; // определение количества элементов размером <=3
        }      

    string[] mass = new string[size];
    int j = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            mass[j] = array[i]; // заполнение массива элементами размером <=3
            j++; 
        }      
    }
    
    return mass;
}

void PrintArray(string[] array) // метод по выводу массива в терминал
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
