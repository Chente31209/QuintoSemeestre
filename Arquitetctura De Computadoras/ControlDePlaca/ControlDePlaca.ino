#include <SoftwareSerial.h>
SoftwareSerial BTSerial(3, 2);
//Configuración de los motores.
//Motor 1
const int motorAPin1  = 5;  // Pin 14 de L293
const int motorAPin2  = 6;  // Pin 10 de L293
//Motor 2
const int motorBPin3  = 9; // Pin  7 de L293
const int motorBPin4  = 10;  // Pin  2 de L293
int led = 13;
int Vel = 255;

void setup() {
  Serial.begin(9600);
  BTSerial.begin(9600);
  pinMode(motorAPin1, OUTPUT);
  pinMode(motorAPin2, OUTPUT);
  pinMode(motorBPin3, OUTPUT);
  pinMode(motorBPin4, OUTPUT);
  pinMode(led, OUTPUT);
}

void loop() {
  if (BTSerial.available()) {

    char estado = BTSerial.read();
    if (estado == 'S' || estado == 's' ) {
      Alto();
    }

    if (estado == 'D' || estado == 'd' ) {
      Delante();
    }

    if (estado == 'R' || estado == 'r') {
      Reversa();
    }
    if (estado == 'I' || estado == 'i') {
      Isquerda();
    }
    if (estado == 'L' || estado == 'l') {
      Derecha();
    }

    
  }

}

void Delante() {
  analogWrite(motorAPin1, Vel); // Al activar gira el motor A en sentido de las agujas del reloj.
  analogWrite(motorAPin2, 0); // Al activar gira el motor A en sentido contra las agujas del reloj.
  analogWrite(motorBPin3, Vel); // Al activar gira el motor B en sentido de las agujas del reloj.
  analogWrite(motorBPin4, 0); // Al activar gira el motor B en sentido contra las agujas del reloj.
}
void Reversa() {
  analogWrite(motorAPin1, 0); // Al activar gira el motor A en sentido de las agujas del reloj.
  analogWrite(motorAPin2, Vel); // Al activar gira el motor A en sentido contra las agujas del reloj.
  analogWrite(motorBPin3, 0); // Al activar gira el motor B en sentido de las agujas del reloj.
  analogWrite(motorBPin4, Vel); // Al activar gira el motor B en sentido contra las agujas del reloj.
}
void Alto() {
  analogWrite(motorAPin1, 0); // Al activar gira el motor A en sentido de las agujas del reloj.
  analogWrite(motorAPin2, 0); // Al activar gira el motor A en sentido contra las agujas del reloj.
  analogWrite(motorBPin3, 0); // Al activar gira el motor B en sentido de las agujas del reloj.
  analogWrite(motorBPin4, 0); // Al activar gira el motor B en sentido contra las agujas del reloj.
}
void Isquerda() {
  analogWrite(motorAPin1, 0); // Al activar gira el motor A en sentido de las agujas del reloj.
  analogWrite(motorAPin2, 0); // Al activar gira el motor A en sentido contra las agujas del reloj.
  analogWrite(motorBPin3, Vel); // Al activar gira el motor B en sentido de las agujas del reloj.
  analogWrite(motorBPin4, 0); // Al activar gira el motor B en sentido contra las agujas del reloj.
}
void Derecha() {
  analogWrite(motorAPin1, Vel ); // Al activar gira el motor A en sentido de las agujas del reloj.
  analogWrite(motorAPin2, 0); // Al activar gira el motor A en sentido contra las agujas del reloj.
  analogWrite(motorBPin3, 0); // Al activar gira el motor B en sentido de las agujas del reloj.
  analogWrite(motorBPin4, 0); // Al activar gira el motor B en sentido contra las agujas del reloj.
}
