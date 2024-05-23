#Algorytm na Lidera (liczbę występującą najczęściej)
def Lider():
    import random
    ciag = []
    print("Podaj ile liczb w ciągu")
    n = int(input())
    for i in range(n):
        ciag.append(random.randint(1,10))
    D = dict(element =  "",czestotliwosc = "")
    ilosc = 0
    for element in ciag:
        for czestotliwosc in ciag:
            if(czestotliwosc == element):
                ilosc+=1
        D.update({element,ilosc})
        ilosc = 0

