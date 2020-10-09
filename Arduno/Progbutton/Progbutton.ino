int Led = 2, Led13 = 11, tiempo = 100, contador = 0, i;
int alto=12, bajo=13, LedAlto=2,LedBajo=3,valAlto,valBajo;

void setup() {
  Serial.begin(9600);
 pinMode(alto, INPUT);
 pinMode(bajo, INPUT);
 for (i=2; i<=11; i++){
    pinMode(i, OUTPUT);
  }
  
}

void loop() {
  valAlto=digitalRead(alto);
  
  if(valAlto==1){
  for (i=2; i<=11; i++){
    digitalWrite(i,HIGH);
     delay(tiempo);
    }
    for (i=2; i<=11; i++){
    digitalWrite(i,LOW);
     delay(tiempo);
    }
  }
  

  valBajo=digitalRead(bajo);
   if(valBajo==0){
  for (i=11; i>=2; i--){
    digitalWrite(i,HIGH);
     delay(tiempo);
    }
     for (i=11; i>=2; i--){
    digitalWrite(i,LOW);
     delay(tiempo);
    }
}
}

  
 
