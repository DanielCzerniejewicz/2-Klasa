def f(x):
    return x**3 + 4*x

# Całka dla trapezu


def calka(a, b, n):
    dx = (a+b)/n
    suma = f(a)+f(b)
    for i in range(1, n):
        suma += 2*f(a+i*dx)
    return suma
