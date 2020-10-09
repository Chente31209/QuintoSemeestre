int Led = 2, Led13 = 11, tiempo = 250, contador = 0;

void setup() {
  Serial.begin(9600);
  pinMode(Led, OUTPUT);
  pinMode(Led13, OUTPUT);
}

// the loop function runs over and over again forever
void loop() {
  Serial.print("Contador = ");
  Serial.println(contador);
  digitalWrite(Led, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(Led13, LOW);
  delay(tiempo);                       // wait for a second
  digitalWrite(Led, LOW);    // turn the LED off by making the voltage LOW
  digitalWrite(Led13, HIGH);
  delay(tiempo);
  contador++;
  if(contador > 10){
    contador = 0;
  }
}
