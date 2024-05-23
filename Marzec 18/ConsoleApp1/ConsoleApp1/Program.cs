// using System.Collections;
//
// Random r = new Random();
// int[] T = new int[5];
// Console.WriteLine("5 losowych liczb:");
// for (int i = 0; i < T.Length; i++)
// {
//     T[i] = r.Next(10, 100);
//     Console.Write(T[i] + " ");
// }
//
// int min = T.Min();
// int max = T.Max();
//
// Console.WriteLine();
// Console.WriteLine("Przedział liczb parzystych:");
// int[] W = new int[(max - min) / 2 + 1];
// int index = 0;
// for (int i = min; i <= max; i++)
// {
//     if (i % 2 == 0)
//     {
//         W[index] = i;
//         Console.Write(W[index] + " ");
//         index++;
//     }
// }

//2.

using System.Collections;

Random r = new Random();
ArrayList A = new ArrayList();
ArrayList AL = new ArrayList();
for (int i = 0; i < 10; i++)
{
    int kody = 0;
    string slowo = "";
    for (int j = 0; j < 3; j++)
    {
        int liczba = r.Next(65,90);
        kody += liczba;
        slowo = slowo + (char)liczba;
    }

    AL.Add(kody);
    A.Add(slowo);
}

for (int i = 0; i < A.Count; i++)
{
    Console.Write(A[i] + " ");
}

Console.WriteLine();
for (int i = 0; i < A.Count; i++)
{
    Console.Write(AL[i] + " ");
}

int max = 0;
int maxIndex = -1; 
for (int i = 0; i < AL.Count; i++)
{
    int value = (int)AL[i];
    if (value > max)
    {
        max = value;
        maxIndex = i;
    }
}

Console.WriteLine();
Console.WriteLine(A[maxIndex]);