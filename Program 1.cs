Console.Write("Введите числа через запятую: ");
int[] Numbers = StringToNum(Console.ReadLine());
PrintArray (числа);
целая сумма = 0;
for (int i = 0; я <numbers.Length; i++)
{
    если (числа[i] > 0)
    {
        сумма++;
    }
}
Консоль.WriteLine();
Console.WriteLine($"количество оценок больше 0 = {sum}");


int[] StringToNum(строковый ввод)
{
    число int = 1;
    for (int i = 0; i < input.Length; i++)
    {
        если (вход[i] == ',')
        {
            считать++;
        }
    }

    int[] числа = новый int [count];
    внутренний индекс = 0;

    for (int i = 0; i < input.Length; i++)
    {
        строка темп = "";

        в то время как (ввод [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            я++;
        }
        еще
        {
            temp += input [i].ToString();
            перерыв;
        }
        }
        числа[индекс] = Convert.ToInt32(temp);
        индекс++;
    }
    обратные номера;
}


void PrintArray (массив int [])
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(массив[i] + " ");
    }
    Console.Write("]");
}