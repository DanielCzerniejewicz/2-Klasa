def maksik(T):
    maks = T[0]
    for item in T:
        if(item > maks):
            maks = item
    return maks
def bloki(binarna):
    ilosc = 0
    for i in range(len(binarna)-1,-1,-1):
        if binarna[i-1] != binarna[i]:
            ilosc = ilosc + 1
    if ilosc == 0:
        ilosc = 1
    return ilosc

def odwroc(T):
    tab = []
    for i in range(len(T)-1, -1, -1):
        tab.append(T[i])
    return tab

def mnozenie_binarnych(a, b):
    len1 = len(a)
    len2 = len(b)
    wynik = [0] * (len1 + len2)
    for i in range(len1 - 1, -1, -1):
        for j in range(len2 - 1, -1, -1):
            temp = int(a[i]) * int(b[j])
            pozycja1 = i + j
            pozycja2 = i + j + 1
            temp += wynik[pozycja2]

            wynik[pozycja1] += temp // 2
            wynik[pozycja2] = temp % 2
    return wynik


# # 1.
# print(bloki("111010"))

# 2.
# ilosc = 0
# tab = []
# with open("bin.txt") as f:
#     tab = f.read().split()
#
# for i in range(0,len(tab)):
#     if bloki(tab[i]) >= 2:
#         ilosc += 1
#
# print(ilosc)

# 3.
# tab = []
# with open("bin.txt") as f:
#     tab = f.read().split()
# print(maksik(tab))

# 4.

# ilosc = 0
# binarka = str(input())
# tab = []
# for item in binarka:
#     tab.append(item)
# odwrocona = odwroc(tab)
# for i in range(len(odwrocona)):
#     if tab[i] == odwrocona[i]:
#         ilosc += 1
#
# if(ilosc == len(binarka)):
#     print("palindromiczna")

# 5.
a = input()
b = input()
print(mnozenie_binarnych(a,b))