int Led = 2, Led13 = 11, tiempo = 250, contador = 0, i;

void setup() {
  Serial.begin(9600);
  for (i=2; i<=11; i++){
    pinMode(i, OUTPUT);
  }
  
}

void loop() {
  while(contador <= 9){
    Serial.print("Contador = ");
    Serial.println(contador);
    digitalWrite(contador+2, HIGH);
    delay(tiempo);
    digitalWrite(contador+2, LOW);
    contador++;
  }
  contador=0;

}
