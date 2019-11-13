const int focusPin = 13; // Focus
const int snapPin = 12; // Snap

void setup() {
  // put your setup code here, to run once:
digitalWrite(snapPin, HIGH); // close shutter
  digitalWrite(focusPin, HIGH); // close shutter

}

void loop() {
for (int i = 0; i < 15; i++) {
       digitalWrite(focusPin, LOW);
       delay(300);
       }
       digitalWrite(focusPin, HIGH);
        delay(500);
// }
 // put your main code here, to run repeatedly:

}
