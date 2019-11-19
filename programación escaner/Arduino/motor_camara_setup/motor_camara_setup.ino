/*LIBRERIAS*/
#include <Wire.h>
#include <AFMotor.h>
#include <Stepper.h>/*Motor paso a paso*/

/*Relación de variables, pines y librerias*/

/*Pamtalla LCD*/

/*Motores paso a paso*/
AF_Stepper motorcamara(300, 1);
AF_Stepper motorpieza(400, 2);

/*finales de carrera*/
const int finalcam = A0;
int estadofinalcam = 0;

void setup() {

  pinMode(A0, OUTPUT);
  digitalWrite(A0, HIGH);//Convertir entrada analoga en digital
  motorcamara.setSpeed(30);
    estadofinalcam= digitalRead(A0);
    if (estadofinalcam==LOW){  /*final de carrera NC*/
    int pasos;
    pasos=0;
    Serial.available();
    pasos=Serial.read();
    
      motorcamara.step(pasos, FORWARD, SINGLE);
      motorcamara.release();
      Serial.println(pasos);
     delay(2000);
    }
    else
    {
      motorcamara.release();
    }
}
void loop() {

}
    estadofinalcam= digitalRead(A0);
    if (estadofinalcam==LOW){  /*final de carrera NC*/

    Serial.available();
    int pasos;
    pasos=Serial.read();
    
      motorcamara.step(pasos, FORWARD, SINGLE);
      motorcamara.release();
      Serial.println("posicionando");
     delay(2000);
    }
    else
    {
      motorcamara.release();
    }
