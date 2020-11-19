//Configuración de los motores. 
//Motor 1
const int motorAPin1  = 5;  // Pin 14 de L293
const int motorAPin2  = 6;  // Pin 10 de L293
//Motor 2
const int motorBPin3  = 10; // Pin  7 de L293
const int motorBPin4  = 9;  // Pin  2 de L293

void setup(){
    pinMode(motorAPin1, OUTPUT);
    pinMode(motorAPin2, OUTPUT);
    pinMode(motorBPin3, OUTPUT);
    pinMode(motorBPin4, OUTPUT);
}


void loop(){
    digitalWrite(motorAPin1, 0); // Al activar gira el motor A en sentido de las agujas del reloj. 
    digitalWrite(motorAPin2, 0); // Al activar gira el motor A en sentido contra las agujas del reloj. 
    digitalWrite(motorBPin3, 0); // Al activar gira el motor B en sentido de las agujas del reloj. 
    digitalWrite(motorBPin4, 0); // Al activar gira el motor B en sentido contra las agujas del reloj. 

  
  while(1){} // Esta parte del codigo inicia un bucle inifinito. 

}
