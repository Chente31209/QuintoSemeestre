
import math

lir=[0.3,0.2121,0.2424,0.9393,0.2727,0.5050]

inter=[0,0,0,0]

print lir

R=math.sqrt(7)

for i in range (0,7):
    if lir[i]>0.20 and lir[i]<0.30:
        inter[0]=inter[0]+1
    if lir[i]>0.30 and lir[i]<0.40:
        inter[1]=inter[1]+1
    if lir[i]>0.50 and lir[i]<0.60:
        inter[2]=inter[2]+1
    if lir[i]>0.90 and lir[i]<1:
        inter[3]=inter[3]+1



print inter

e=((R-inter[0])**2)/R
f=((R-inter[1])**2)/R
g=((R-inter[2])**2)/R
h=((R-inter[3])**2)/R

total=e+f+g+h

Tz=12.592
if total<=Tz:
    print "Se acepta la H0 en donde los números si son pseudoaleatorios"
else:
    print "No se acepta H0 en donde los números si son pseudoaleatorios "

