int Tiempo=200;
void setup() {
  Serial.begin(9600);
  for(int i=3;i<=8;i++){
    pinMode(i, OUTPUT);
  }

}

void loop() {
  for(int i=3;i<=8;i++){
    digitalWrite(i, HIGH);
    delay(Tiempo);
    digitalWrite(i, LOW);
   
  }
  

}
