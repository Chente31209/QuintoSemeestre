import math

Li=[4.33,1.61,2.16,2.88,0.7,0.44,1.59,2.15,8.59,7.36,
    9.97,7.86,5.49,0.98,4.52,2.12,4.44,0.82,6.96,3.04,
    2.81,14.39,3.44,9.92,4.38,8.04,2.18,6.19,4.48,9.66,
    4.34,1.76,2.3,5.24,11.65,	10.92,12.16,6.6,0.85,	4.82,
    1.36,3.53,6.58,1.45,8.42,3.69,2.44,0.28,1.9,2.89]

linter=[2,4,6,8,10,12,14,16]
LO=[12,13,9,6,6,2,1,1]
po=[]
poa=[]
pea=[]
Total=[]

class Kolmogorov:
    def _init_(self,li,alfa,beta):
        self.li=li
        self.alfa=alfa
        self.beta=beta
    def calcularKolmo(self):
        s=0
        for i in range(0,len(self.li)):
            s=s+self.li[i]
        media=s/len(self.li)
        SV=0
        for i in range(0,len(self.li)):
            SV=SV+((self.li[i]-media)**2)/len(self.li)
        for i in range(0,len(LO)):
            po.append(LO[i]/len(self.li))
            spoa=0
        for i in range(0,len(LO)):
            spoa=spoa+poa[i]
            poa.append(spoa)
        for i in range(0,len(linter)):
            pea.append(1-(math.e(-math.pow(linter[i]/self.beta,self.alfa))))
            ST=0
        for i in range(0,len(pea)):
            Total.append(poa[i]-pea[i])
            ST=ST+(poa[i]-pea[i])
        vc=1.36/50.0
        if vc>ST:
            print "No se rechaza la HIpótesis"
        else:
            print "Otra Distribución

Cm=Kolmogorov(Li,1.38,5.12)
