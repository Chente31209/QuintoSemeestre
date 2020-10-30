#include <SoftwareSerial.h>
SoftwareSerial BTSerial(3,2);
void setup() {
 Serial.begin(9600);
  BTSerial.begin(9600);
}

void loop() {
  if(BTSerial.available()){
    Serial.write(BTSerial.read());
  }
if(Serial.available()){
    BTSerial.write(Serial.read());
  }
}
