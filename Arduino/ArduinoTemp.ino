String inputString="";
boolean stringComplete=false;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("Starting sensor...");

  /*ADMUX= 0x40;*/
  ADMUX = 0xC0; /*select internal 1.1V source and channel0*/
  ADCSRA = 0x07; /*prescaler a 128*/
  ADCSRA |= 1 << ADEN; /*activate ADC*/
  /*enable interrupt*/
  SREG |= 0X80;
  ADCSRA |= 1 << ADIF; /*reset flag*/
  ADCSRA |= 1 << ADIE;  
}

void loop() {
  // put your main code here, to run repeatedly:
  
  if(stringComplete&inputString=="Measure\n"){
    inputString="";
    stringComplete=false;

    /*Serial.println(analogRead(A0));*/
    ADCSRA |= 1 << ADSC; /*start conversion*/
  }
}

void serialEvent(){
  while(Serial.available()){
    char inChar=(char)Serial.read();
    inputString+=inChar;
    if(inChar=='\n'){
      stringComplete=true;
    }
  }
}

ISR(ADC_vect){
  Serial.println(ADC);
} /*Botteon Bertone Berto Prono*/
