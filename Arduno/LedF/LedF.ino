int Led=6, tame=250 ;
void setup() {
 Serial.begin(9600);
 pinMode(Led, OUTPUT);

}

void loop() {
  digitalWrite(Led,HIGH);
  delay(tame);
  digitalWrite(Led,LOW);
  delay(tame);
}
