// адана последовательность натуральных чисел, завершающаяся числом 0.
// Требуется определить значение второго по величине элемента в этой последовательности.

Console.Clear();
Console.Write("введите длину массива:");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int c = 0;
int j = 0;
int[] a = new int[b];
for (int i = 0; i < a.Length; i++){    
Console.Write("введите "+(i+1)+" элемент массива:");    
a[i] = Convert.ToInt32(Console.ReadLine());
if (a[i]==0)
{
    break;
}
}
for (int i = 0; i < a.Length; i++)
{
    if (max<a[i]){
        max=a[i];
        j=i;
    }

}

for (int i = 0; i < a.Length; i++){
    if (i==j)
    {
        i++;
        i--;
    }
    else
    {
        if (c<a[i])
        {
            c=a[i];
        }
    }
}
Console.WriteLine(c);
