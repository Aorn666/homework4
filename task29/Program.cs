// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//ЗНАЧЕНИЯ ДОЛЖЕН ВВОДИТЬ ПОЛЬЗОВАТЕЛЬ

Console.Clear();
int[] a = new int[8];
for (int i = 0; i < a.Length; i++){
Console.Write("введите "+(i+1)+" элемент массива:");    
a[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"[{string.Join(", ", a)}]");