// // //Zad.1
// //
// // using System.Transactions;
// //
// // int[] T = new int[115];
// // T[0] = 3;
// // for (int i = 1; i < T.Length; i++)
// // {
// //     T[i] = T[i - 1] + 4;
// // }
// //
// //
// // //Zad.2
// // StreamReader sr = new StreamReader("../../../osoby.txt");
// // Osoba[] o = new Osoba[4];
// //
// // string[] s = new string[3];
// // int x = 0;
// // while (!sr.EndOfStream)
// // {
// //     s = sr.ReadLine().Split(";");
// //     Osoba osoba;
// //     osoba.imie = s[0];
// //     osoba.nazwisko = s[1];
// //     osoba.wiek= int.Parse(s[2]);
// //     o[x] = osoba;
// //     x++;
// // }
// //
// // foreach (var item in o)
// // {
// //     Console.WriteLine(item.imie+" "+item.nazwisko+" "+item.wiek);
// // }
// // Console.ReadLine();
// //
// //
// //
// //
// // struct Osoba
// // {
// //     public string imie;
// //     public string nazwisko;
// //     public int wiek;
// // }
// //
// // //3. Stwórz liste 6 losowych slow skladajacych sie z roznych samoglosek
// Random r = new Random();
// char[] SAMO = new char[] { 'a', 'ą', 'e', 'ę', 'i', 'o', 'ó', 'u', 'y' };
// List<string> slowa = new List<string>();
// string SŁOWO;
// int numer;
// for (int i = 0; i < 6; i++)
// {
//     List<char> Samogloski = SAMO.ToList();
//     SŁOWO = "";
//     for (int j = 0; j < 3; j++)
//     {
//         numer = r.Next(0, Samogloski.Count);
//         SŁOWO += Samogloski[numer];
//         Samogloski.RemoveAt(numer);
//     }
//     slowa.Add(SŁOWO);
// }
//
// foreach (var element in slowa)
// {
//     Console.WriteLine(element);
// }

//5.

List<int> AL = new List<int>();
AL[0] = 1;
AL[1] = 2;
int i = 2;
while (AL[i-1]+AL[i-2] < 100)
{
    AL[i] = AL[i - 1] + AL[i - 2];
    i++;
}
