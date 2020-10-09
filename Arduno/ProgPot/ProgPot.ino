int  tiempo = 250, VarEnt,VE2, entrada =A0,i;

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
  Serial.print(VarEnt);
  VE2=map(VarEnt,0,1024,0,255);
  Serial.print("  Valor2 =");
   Serial.println(VE2);
  delay(tiempo);
}
