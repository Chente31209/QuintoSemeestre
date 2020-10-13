int  tiempo = 250, VarEnt,VE2, entrada =A0,i, Ro=2,Am=3,Ve=4;

void setup() {
  Serial.begin(9600);
  pinMode(entrada,INPUT);
  for (i=2; i<=11; i++){
    pinMode(i, OUTPUT);
  }
  
}

void loop() {
  VarEnt=analogRead(entrada);
  Serial.print("Valor =");
  Serial.println(VarEnt);
  VE2=map(VarEnt,0,1024,0,255);
  Serial.print("  Valor2 =");
   Serial.println(VE2);
  if (VarEnt<= 350){
    digitalWrite(Ro,HIGH);
    digitalWrite(Am,LOW);
    digitalWrite(Ve,LOW);
  }
  if (VarEnt >= 350){
    digitalWrite(Ro,LOW);
    digitalWrite(Am,HIGH);
    digitalWrite(Ve,LOW);
  }
  if (VarEnt >= 700){
    digitalWrite(Ro,LOW);
    digitalWrite(Am,LOW);
    digitalWrite(Ve,HIGH);
  }
  analogWrite(5,VE2);
}
