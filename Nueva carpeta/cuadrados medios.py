import math
class Medios:
    def __init__(self,X0,N):
        self.X0=X0
        self.N=N
    def calculo(self):
        liY=[]
        liY.append(self.X0)
        for i in range (0,self.N):
            Y=math.pow(liY[i],2)
            YE=int(Y)
            YS=str(YE)
            if len(YS)==8:
                YC=YS[2]+YS[3]+YS[4]+YS[5]
            elif len(YS)==7:
                YC=YS[1]+YS[2]+YS[3]+YS[4]
            elif len(YS)==6:
                YC=YS[1]+YS[2]+YS[3]+YS[4]
            else:
                YC=YS[0]+YS[1]+YS[2]+YS[3]
            YE=int(YC)
            liY.append(YE)
        print liY
        
CM=Medios(5735,5)
CM.calculo()
        