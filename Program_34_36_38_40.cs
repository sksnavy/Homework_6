/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/


Console.WriteLine("Введите номер задачи: 34,36,38 или 40 (задача со звездочкой):");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{

case 34: 
    {
        Console.WriteLine("Введите число элементов массива N:");
        Console.Write("N= "); int N = Convert.ToInt32(Console.ReadLine());
    
        int[] nums = new int[N];
        int chet=0;
        int ch=0; 
        do
        {
            Random rand = new Random();
            nums[ch] = rand.Next (100, 999);
            if (nums[ch]%2 == 0) {chet++;}
            Console.Write($"Элемент массива_{ch} = "); Console.WriteLine($"{nums[ch]}; "); 
          
            ch++;
        } while (ch < N);

        Console.Write($"Количество четных чисел в массиве = {chet}"); 

        break;    
    } //Zadacha 34

case 36:
    {
        Console.WriteLine("Введите натуральное число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное число b:");
        Console.Write("b= "); int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число элементов массива N:");
        Console.Write("N= "); int N = Convert.ToInt32(Console.ReadLine());

        if (a > b) {int old = a; a=b; b=a;}
        int[] nums = new int[N];
        int sum_nechet=0;
        int ch=0; 
        do
        {
            Random rand = new Random();
            nums[ch] = rand.Next (a, b);
            if ((ch+1) % 2 != 0) {sum_nechet=sum_nechet+nums[ch];}
            Console.Write($"Элемент массива_{ch} = "); Console.WriteLine($"{nums[ch]}; "); 
          
            ch++;
        } while (ch < N);

        Console.Write($"Сумма элементов на нечетных местах = {sum_nechet}"); 

        break;
    } //Zadacha 36
  
case 38:
    {
        Console.WriteLine("Введите вещественное число a:");
        Console.Write("a= "); double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вещественное число b:");
        Console.Write("b= "); double b = Convert.ToDouble(Console.ReadLine());        
        Console.WriteLine("Введите целое число элементов массива N:"); int N = Convert.ToInt32(Console.ReadLine());

        double[] nums = new double[N];
        if (a > b) {double old = a; a=b; b=a;}
        int ch=0; 
        double min=b;
        double max=a;
        
        do
        {
          Random rand = new Random();
          nums[ch] = a + rand.NextDouble() * (b-a);
          Console.Write($"Элемент массива_{ch} = "); Console.WriteLine($"{nums[ch]}; ");
          if (nums[ch] <= min) {min = nums[ch];}
          if (nums[ch] >= max) {max = nums[ch];}
          ch++;
        } while (ch < N);

        Console.WriteLine($"Минимальный элемент массива = {min}"); 
        Console.WriteLine($"Максимальный элемент массива = {max}"); 
        Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}"); 

        break;    
    } //Zadacha 38

case 40:
    {
        Console.WriteLine("Введите вещественное число a:");
        Console.Write("a= "); double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вещественное число b:");
        Console.Write("b= "); double b = Convert.ToDouble(Console.ReadLine());        
        Console.WriteLine("Введите целое число элементов массива N:"); int N = Convert.ToInt32(Console.ReadLine());

        double[] nums = new double[N];
        double old1; 
        if (a > b) {double old = a; a=b; b=a;}
        int ch=0; 
        int ch1=0; 
        
        do //Формирум массив
        {
          Random rand = new Random();
          nums[ch] = a + rand.NextDouble() * (b-a);
          Console.Write($"Элемент массива_{ch} = "); Console.WriteLine($"{nums[ch]}; ");
          ch++;
        } while (ch < N);

        ch = 0;
        do //Формируем массив по убыванию значений элементов
        {
            ch1=0;
            do 
            {
                if (nums[ch1]<nums[ch1+1]) { old1=nums[ch1+1]; nums[ch1+1]=nums[ch1]; nums[ch1]=old1;} 
                ch1++;
            } while (ch1 < N-1);
          ch++;
        } while (ch < N-1);
        Console.WriteLine("----");

        ch=0;
        do //Выводим массив
        {
            Console.Write($"Элемент массива_{ch} = "); Console.WriteLine($"{nums[ch]}; ");
            ch++;
        } while (ch < N);

        break;    
    } //Zadacha 40


}