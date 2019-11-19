/*Código base del Scaner 3D diseñado por Ramiro Pérez*/
/*Octubre de 2018*/

/*LIBRERIAS*/
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <AFMotor.h>
#include <Stepper.h>/*Motor paso a paso*/

/*Relación de variables, pines y librerias*/

/*Pamtalla LCD*/
 LiquidCrystal_I2C lcd(0x3F,16,2);
 
/*Motores paso a paso*/
AF_Stepper motorcamara(400, 1);
AF_Stepper motorpieza(400, 2);

/*finales de carrera*/
const int finalcam = A0;
int estadofinalcam = 0;
const int finalpieza = A0;
int estadofinalpieza = 0;
const int LED=9;
int i;
void setup() {
  Bienvenida();
  setupMotorCamara();
  setupMotorPieza();
  void setupIluminacion();
}

void loop() {
   //Usuario inicia escaneo
  Serial.begin(9600);

  if (Serial.available()){
      int ok=Serial.read();

      if (ok=='1'){
  //Usuario selecciona intensidad de iluinación

        void iluminacion();
      }
    }
  //Inicia primera ronda de fotos
  void captura(); //programar función
  //Cambio de posición
  void posicion();
}

/*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% FUNCIONES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

void Bienvenida()
{
  Serial.begin(9600);
  //lcd.begin(16, 2);//
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0,0);
  lcd.print("    INICIANDO   ");
  delay(2000);

  lcd.setCursor(0,0);
  lcd.print("   ESCANER 3D     ");
  delay(2000);
  lcd.clear();

  lcd.setCursor(0,0);
  lcd.print("  Creado por  ");
  lcd.setCursor(0,1);
  lcd.print("RAMIRO PEREZ V.");
  delay(2000);
  lcd.clear();

  lcd.setCursor(0,0);
  lcd.clear();
  lcd.print("OK PARA ");
  lcd.setCursor(0,1);
  lcd.print("INICIAR ESCANEO");
  delay(2000);
}
void setupMotorCamara()
{
  pinMode(A0, OUTPUT);
  digitalWrite(A0, HIGH);//Convertir entrada analoga en digital
  estadofinalcam=0;
  motorcamara.setSpeed(40);
    estadofinalcam= digitalRead(A0);
    if (estadofinalcam==LOW){  /*final de carrera NC*/
      
      motorcamara.step(100, FORWARD, SINGLE);
      Serial.println("posicionando");
    }
    else
    {
      motorcamara.release();
    }
}
void setupMotorPieza()
{
//pulsador normalmente abierto, si pulsador HIGH entonces motor detenido, si pulsador LOW entonces motorpieza BACKWARD 

  pinMode (finalpieza,INPUT);
    //pulsador normalmente cerrado, si pulsador LOW entonces motor forward, 
    //si pulsador HIGH entonces motorcamara.release() 

      estadofinalpieza= digitalRead(finalpieza);
      if (estadofinalpieza==LOW){/*final de carrera NC*/
        
        motorpieza.step(100, FORWARD, SINGLE);
        Serial.println("posicionando pieza");
      }
      else
      {
        motorpieza.release();
      }
}

void iluminacion()
{
  Serial.available();{
    int intensidad;
    intensidad=Serial.read();
 switch (intensidad) {
     case 1:
       analogWrite(LED, 225);// Luz alta
       break;
     case 2:
       analogWrite(LED, 100);// Luz media 
       break;
    case 3:
       analogWrite(LED, 50);// Luz baja
        break;
    case 4:
        Serial.available();{
        int inten;
        inten=Serial.read();
        analogWrite(LED, inten);// Manual
        break;
  default:

void setupIluminacion()
//  const int LED=9;
//  int i;
  pinMode(LED,OUTPUT);

  for  (i=255;i>170; i--){
    analogWrite(LED,i);
    delay(5);
  }
  for  (i=1;i<255; i++){
  analogWrite(LED,i);
    }
}
//void captura()
//{
//  Serial.available(){
//    iniciar=Serial.read();
//    if (iniciar==1)
//    {
//      /* inicia motorpieza una revolución, captura de foto cada paso, por lo menos 24 fotos por revolución  */
//    
//    }
//  }
//}
//void posicion(){
//  /*inicia motorcamara hasta la altura seleccioada*/
//}
