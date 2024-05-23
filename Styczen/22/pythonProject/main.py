import numpy as np
from matplotlib import pyplot as plt
def f(x):
    return np.sqrt(x+5) + 1
x = np.linspace(-5,16)

plt.plot(x,f(x),color='red')
plt.show()

def calka(a,b,n):
    krok = (b-a) / n
    suma = 0
    for i in range(n):
        suma += f(a + i * krok + krok/2)
    return suma * krok