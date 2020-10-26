int Run=100, Walk=200,Idel=700;
int Eentrada;
void setup() {
  Serial.begin(9600);
  //for(int i=3;i<=8;i++){}
    pinMode(3, OUTPUT);
    pinMode(4, OUTPUT);
    pinMode(5, OUTPUT);
    pinMode(6, OUTPUT);
  

}

void loop() {
  Eentrada= Serial.read();
  if(Eentrada == 'r'){
    
       for(int i=3;i<=6;i++){
      digitalWrite(i, HIGH);
    delay(Run);
    digitalWrite(i, LOW);
      
    }
  }
   if(Eentrada == 'w'){
   
       for(int i=3;i<=6;i++){
      digitalWrite(i, HIGH);
     delay(Walk);
    digitalWrite(i, LOW);
        
      }
   }
  else{
  
       for(int i=3;i<=6;i++){
      digitalWrite(i, HIGH);
    delay(Idel);
    digitalWrite(i, LOW);
      
    }
  }
}
