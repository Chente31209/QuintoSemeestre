lidts=[]
listaDeR=[]
def prosedimeto(X0, k, g, c):
    a=1+(4*(k))
    m=2**g
    lidts.append(X0)
    Xi=0
    for i in range(0,m):
        Xi=((a*Xi) + c) % (m)
        Ri=Xi/(m-1)
        lidts.append(Xi)
        listaDeR.append(Ri)
    print lidts
    print listaDeR
prosedimeto(6.0, 3.0, 3, 7)