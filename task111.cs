// See https://aka.ms/new-console-template for more information

string[] strarr = new string[] { "kh", "p8j", "dvlj", "jncie", "htyk", "j1", "1tyu" };


PrintArray(strarr);

string[] result = DoTask(strarr);

if(result.Length == 0)
{
  Console.WriteLine("Строк, размером меньше или равно 3 не найдено. ");  
  return;
}


PrintArray(result);

// Функция вывода массива
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[ " + arr[i]+", ");
        }
        else if (i == arr.Length - 1)
        {
            Console.Write(arr[i] + " ]");
        }
        else
        {
            Console.Write(arr[i] +", ");
        }
    }
    Console.WriteLine(" ");
}
// Функция выполняет задачу: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. 

string[] DoTask(string[] strarr)
{
    int n = 0;

    for (int i = 0; i < strarr.Length; i++)
    {
        if (strarr[i].Length <= 3)
        {
            n++;
            Console.WriteLine(strarr[i] + " " + n);

        }
    }

    string[] strarr2 = new string[n];
    n = 0;

    for (int i = 0; i < strarr.Length; i++)
    {
        if (strarr[i].Length <= 3)
        {

            strarr2[n] = strarr[i];
            n++;
        }
    }

    return strarr2;
}
