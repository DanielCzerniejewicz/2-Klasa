//zad.4

using System.Collections;

int Fibonacci(int n)
{
    if (n == 1)
    {
        return 1;
    }

    if (n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 2) + Fibonacci(n - 1);
    }
}
Console.WriteLine(Fibonacci(6));
List<int> AL = new List<int>();
AL.Add(1);
AL.Add(2);
int i = 2;
while (AL[i - 1] + AL[i - 2] < 100)
{
    AL.Add(AL[i-1] + AL[i-2]);
    i++;
}

Random r = new Random();
Queue q = new Queue();
for (int k = 0; k < 5; k++)
{
    int inde = r.Next(0, AL.Count);
    q.Enqueue(AL.ElementAt(inde));
}