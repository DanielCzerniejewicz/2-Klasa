def MonteCarlo(n):
    import random
    trafione = 0
    for i in range(n):
        x = random.uniform(-1,1)
        y = random.uniform(-1,1)
        if x**2 + y**2 <= 1:
            trafione += 1
    return 4 * (trafione / n)

print(MonteCarlo(10))