def f(x):
    return x + 3

def prostokaty(a,b,n):
    dx = (b - a) / n
    suma = 0
    for i in range(n):
        suma += f(a + dx/2 + i * dx) * dx
    return suma
