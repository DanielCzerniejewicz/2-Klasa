// //1.
// int n = int.Parse(Console.ReadLine());
// int[] T = new int[n];
// for (int i = 0; i < n; i++)
// {
//     int wprowadzona = int.Parse(Console.ReadLine());
//     T[i] = wprowadzona;
// }
// Array.Sort(T);
// List<int> wyniki = new List<int>();
// foreach (var element in T)
// {
//     wyniki.Add(element);
// }
// for (int i = 0; i < T.Length - 1; i++)
// {
//     int warunek = Math.Abs(T[i] - T[i + 1]);
//     if (T[i + 1] - T[i] == 2 || warunek == 2)
//     {
//         wyniki.Remove(T[i]);
//         wyniki.Remove(T[i + 1]);
//     }
// }
//
// Console.WriteLine("Wynik : ");
// foreach (var element in wyniki)
// {
//     Console.Write(element + " ");
// }
//
// //2.
//
// string input = Console.ReadLine();
// List<string> litery = new List<string>();
// foreach (var element in input)
// {
//     int suma = 0;
//     foreach (var czestotliwosc in input)
//     {
//         if (element == czestotliwosc)
//         {
//             suma++;
//         }
//     }
//
//     if (suma >= 3)
//     {
//         litery.Add(Convert.ToString(element));
//     }
// }
// var unikalne = litery.Distinct().ToList();
// foreach (var element in unikalne)
// {
//     Console.Write(element + " ");
// }
//
// //3.
//
// bool CzyPierwsza(int n)
// {
//     int dzielniki = 0;
//     for (int i = 1; i <= dzielniki; i++)
//     {
//         if (i % 2 == 0)
//         {
//             dzielniki++;
//         }
//     }
//
//     if (dzielniki == 2)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
//
// Console.WriteLine("Wprowadz 2 liczby brytyjskie (roznica miedzy nimi to min. 50");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// List<int> wyniki = new List<int>();
// if (a-b >= 50)
// {
//     for (int i = a; i <= b; i++)
//     {
//         if (CzyPierwsza(i) == true)
//         {
//             wyniki.Add(i);
//         }
//     }
// }

//4.

using System.Collections;

// ArrayList osoby = new ArrayList();
// Random r = new Random();
// for (int i = 0; i < 4; i++)
// {
//     int wiek = r.Next(20, 50);
//     string imie = "A";
//     for (int j = 0; j < 3; j++)
//     {
//         int wylosowana = r.Next(97, 122);
//         char literka = (char)wylosowana;
//         literka = Convert.ToChar(wylosowana);
//         imie += literka;
//     }
//     string nazwisko = (string)imie.Reverse();
//     osoby.Add(imie);
//     osoby.Add(nazwisko);
//     osoby.Add(wiek);
//     osoby.Add("----");
// }
//
// foreach (var element in osoby)
// {
//     Console.WriteLine(element);
// }
//
// //5.
// Queue liczby = new Queue();
// for (int i = 0; i < 1000; i++)
// {
//     int ilosc = 0;
//     int suma = 0;
//     for (int j = 1; j < i; j++)
//     {
//         if (i % j == 0)
//         {
//             suma += j;
//         }
//     }
//
//     if (suma == i)
//     {
//         liczby.Enqueue(i);
//         ilosc++;
//     }
//
//     if (ilosc == 4)
//     {
//         break;
//     }
// }
//
// foreach (var element in liczby)
// {
//     Console.Write(element + " ");
// }
// liczby.Dequeue();
// liczby.Dequeue();

//6.
