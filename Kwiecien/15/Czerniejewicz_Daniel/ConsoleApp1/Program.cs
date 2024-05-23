// // //0
// // int[] T = new int[11];
// // string wybor = Console.ReadLine();
// // for (int i = 0; i < T.Length; i++)
// // {
// //     T[i] = (int)wybor[i];
// // }
// //
// // float srednia = 0;
// // for (int i = 0; i < T.Length; i++)
// // {
// //     srednia += T[i];
// // }
// //
// // srednia = srednia / 11;
// // int Wielkomiejska = 0;
// // int Małorolna = 0;
// // for (int i = 0; i < T.Length; i++)
// // {
// //     if (T[i] > srednia)
// //     {
// //         Wielkomiejska++;
// //     }
// //
// //     if (T[i] < srednia)
// //     {
// //         Małorolna++;
// //     }
// // }
// //
// // if (Wielkomiejska>Małorolna)
// // {
// //     Console.WriteLine("Tablica jest wielkomiejska");
// // }
// //
// // if (Małorolna > Wielkomiejska)
// // {
// //     Console.WriteLine("Tablica jest małorolna");
// // }
// //
// // // //1.
// // int[] T = new int[30];
// // Random r = new Random();
// // for (int i = 0; i < T.Length ; i++)
// // {
// //     T[i] = r.Next(100, 1000);
// //     for (int j = i; j < i+3; j++)
// //     {
// //         if (T[j+2] - 1 == T[j + 1] && T[j+2] == T[j] - 2)
// //         {
// //             Console.Write($"{T[j]} , {T[j+2]}");
// //         }
// //     }
// // }
// //
// // for (int i = 0; i < T.Length; i++)
// // {
// //     Console.Write(T[i] + " ");
// // }
//
// //2.
//
// using System.Threading.Channels;
//
// List<int> L1 = new List<int>();
// List<int> L2 = new List<int>();
// List<int> Wynikowa = new List<int>();
// Random r = new Random();
// L1.Add(r.Next(1,9));
// while (L1.Count != 6)
// {
//     int znaleziono = 0;
//     int losowa = r.Next(1, 9);
//     for (int i = 0; i < L1.Count; i++)
//     {
//         if (L1[i] == losowa)
//         {
//             znaleziono += 1;
//         }
//     }
//     if (znaleziono == 0)
//     {
//         L1.Add(losowa);
//     }
// }
// L1.Sort();
// int losowa1 = L1[r.Next(0,6)];
// int losowa2 = L1[r.Next(0,6)];
// int losowa3 = L1[r.Next(0, 6)];
// int pomocnicza = 6;
// while (pomocnicza >= 0)
// {
//     int losowosc = r.Next(1, 4);
//     for (int i = 0;i<losowosc;i++)
//     {
//         if (losowosc == losowa1)
//         {
//             L2.Add(losowa1);
//             pomocnicza -= losowosc;
//         }
//
//         if (losowosc == losowa2)
//         {
//             L2.Add(losowa2);
//             pomocnicza -= losowosc;
//         }
//
//         if (losowosc == losowa3)
//         {
//             L2.Add(losowa3);
//             pomocnicza -= losowosc;
//         }
//     }
//
//     if (losowosc == 1)
//     {
//         losowosc = 0;
//     }
// }
//
// for (int i = 0; i < L1.Count; i++)
// {
//     int ilosc = 0;
//     foreach (var element in L2)
//     {
//         if (L1[i] == element)
//         {
//             ilosc++;
//         }
//     }
//
//     if (ilosc > 2)
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             Wynikowa.Add(L1[i]);
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Lista L1");
// foreach (var VARIABLE in L1)
// {
//     Console.Write(VARIABLE + " ");
// }
//
// Console.WriteLine();
// Console.WriteLine("Lista L2");
// foreach (var VARIABLE in L2)
// {
//     Console.Write(VARIABLE + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Wynikowa");
// foreach (var element in Wynikowa)
// {
//     Console.Write(element + " ");
// }

//3.

using System.Collections;

Random r = new Random();
Console.WriteLine((char)65); //A
ArrayList AL = new ArrayList();
for (int i = 0; i < 30; i++)
{
    string slowo = "";
    for (int j = 0; j < 3; j++)
    {
        char literka = (char)r.Next(65, 70);
        slowo = slowo + literka;
    }

    slowo = slowo + " ";
    AL.Add(slowo);
}
AL.Sort();
for (int i = 0; i < AL.Count; i++)
{
    Console.Write(AL[i]);
}