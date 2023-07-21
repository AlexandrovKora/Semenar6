/* Task 1Напишите программу, которая перевернёт одномерный массив (последний элемент 
будет на первом месте, а первый - на последнем и т.д.)*/
/*
void ReverseArray(int[] array)
{
    for(int i=0, j=array.Length-1; i<j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/
/* 1. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/

//int[] CreateArray(int size, int a, int b, int c)

/*
bool Check(int[] myArray)
{
    if (myArray[0]<(myArray[1]+myArray[2]) && 
    myArray[1]<(myArray[0]+myArray[2]) && 
    myArray[2]<(myArray[0]+myArray[1])) return true;
    else return false;
}

Console.Write("Input A side: ");
int a_side = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B side: ");
int b_side = Convert.ToInt32(Console.ReadLine());
Console.Write("Input C side: ");
int c_side = Convert.ToInt32(Console.ReadLine());
int[] myArray={a_side,b_side,c_side};

bool result = Check(myArray);
Console.WriteLine(result);
*/


/* 2.Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.*/
/*
int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    array[0]=0;
    array[1]=1;
    for(int i = 2; i < array.Length; i++) 
        array[i]=array[i-2]+array[i-1];
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateArray(size);
ShowArray(myArray);
*/

/* 3.Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.*/




int[] CopyArray(int[] Array1)
{
    int[] Array2 = new int[Array1.Length];
    for (int i = 0; i<Array1.Length; i++)
        Array2[i] = Array1[i];

    return Array2;

}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int[] Array1 = {1,2,3,4,5,6};

ShowArray(CopyArray(Array1));

