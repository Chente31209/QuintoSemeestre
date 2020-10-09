int Led = 2, Led13 = 11, tiempo = 250, contador = 0, i;

void setup() {
  Serial.begin(9600);
  for (i=2; i<=11; i++){
    pinMode(i, OUTPUT);
  }
  
}

void loop() {
  Serial.print("Contador = ");
  Serial.println(contador);
  digitalWrite(contador+2, HIGH);
  delay(tiempo);
  digitalWrite(contador+2, LOW);
  //delay(tiempo);
  contador++;
  if(contador > 9){
    contador = 0;
  }
}
