// //Zad.1
// int reku1(int n)
// {
//     if (n == 1)
//     {
//         return -5;
//         
//     }
//
//     if (n == 2)
//     {
//         return 2;
//     }
//
//     if (n == 3)
//     {
//         return 4;
//     }
//     else
//     {
//         return (reku1(n - 2) * 2) - (reku1(n - 1) + reku1(n));
//     }
//
//     int suma = 0;
//     for (int i = 1; i <= 8; i++)
//     {
//         suma += reku1(n - i);
//     }
//
//     return suma;
// }
//
// Console.WriteLine(reku1(10));

//Zad.2
int reku2(int a, int b)
{
    while (b != 0)
    {
        //a,b = b, a % b
        int temp = a;
        a = b;
        b = temp % b;
    }

    return b;

}

Console.WriteLine(reku2(10,2));