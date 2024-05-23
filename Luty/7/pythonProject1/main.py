from random import randint
n = 6
M = [[0 for _ in range(n)] for _ in range(n)]
D = {}
for d in range(1, n+1):
    D[d] = []

ik = 1 + randint(0, 6)/10
for i in range(1, n+1):
    for j in range(1, n+1):
        if i > j:
            w = randint(0, 10) * ik
            if w >= 5:
                D[i].append(j)
                D[j].append(i)


sumwie = 0
for i in range(1, n+1):
    sumwie += len(D[i])

ws = []
print("wierzcholki samodzielne : ")
for i in range(1,n+1):
    if len(d[i]) == 0:
        ws.append(i)
if not ws:
    print("Brak samodzielnych wierzcholkow")

