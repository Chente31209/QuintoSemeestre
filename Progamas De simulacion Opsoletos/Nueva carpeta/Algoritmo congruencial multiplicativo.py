
Lista1=[]
Lista2=[]
def Multiplicativo(X0, k, g):
    N=2**(g-2)
    a=3+(8*(k))
    Xi=X0
    Lista1.append(Xi)
    m=2**g
    for i in range(0,N):
        Xi=(a*Xi) % (m)
        Ri=Xi/(m-1)
        Lista1.append(Xi)
        Lista2.append(Ri)
    print Lista1
    print Lista2
        
Multiplicativo(19.0, 2.0, 5)