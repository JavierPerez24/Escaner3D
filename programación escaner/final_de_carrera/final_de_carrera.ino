//funcion finale de carrera finalcam
const int finalcam = 13;
int estadofinalcam = 0;
void setup() {
  Serial.begin(9600);
  pinMode (finalcam,INPUT);
  // put your setup code here, to run once:

}

void loop() {
  estadofinalcam= digitalRead(finalcam);
  if (estadofinalcam==HIGH){
    int detenermotorcam= 1;
    Serial.println(estadofinalcam);
  }
  // put your main code here, to run repeatedly:

}
