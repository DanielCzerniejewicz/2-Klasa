# Metoda 1
def pierwiastek(x,n,eps):
    a = x
    b = 1
    while abs(a-b) > eps:
        a = (a + b) / 2
        b = x / a
    return a

# Metoda 2
def pierwiastek_newtona(x,n,eps):
    a = x
    b = 1
    for i in range(n):
        a = (a + b) / 2
        b = x / a
    return a
