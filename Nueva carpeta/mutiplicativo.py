
LIsta=[]
def CongruencialCua(X0, a, b, c, m):
    Xi=X0
    for i in range(0, m+1):
        #Algoritmo de Blum, Blum y Shub#
        if a==1 and b==0 and c==0: 
            Xi=(Xi**2) % m
            LIsta.append(Xi)
            print "X",i+1,"=",Xi
        #Algoritmo congruencial cuadrático#
        else:                       
            Xi=((a*(Xi**2)) + (b*Xi)+c) % m
            LIsta.append(Xi)
            print Xi
CongruencialCua(15.0, 28, 25, 27, 8)
print (35+25)%100