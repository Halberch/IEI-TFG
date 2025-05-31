#define STEP 9 // Pin digital encargado de los pasos
#define DIR 10 // Pin digital encargado de la dirección
#define FC1 5 // Final de carrera derecho, Normalmente Alto
#define FC2 6 // Final de carrera izquierdo, Normalmente Alto

String inputString = "";     // Una String para almacenar los datos entrantes
bool stringComplete = false; //Para ver cuando se completa al string

// Inicialización de los parametros y sus valores iniciales

int vel = 600; // Tiempo en On y en Off (Ciclo de trabajo 50%)
String nesti; // Nº de estiramientos
String mm; // mm por estirar
String vele; // Tiempo en On y en Off (Ciclo de trabajo 50%) en la función de estirar
int v_fc1 = 0; // Valor del final de carrera derecho
int v_fc2 = 0; // Valor del final de carrera izquierdo
int n = 1; // Nº Actual de estiramientos realizados
int pausa = 250; // Tiempo pausado entre estiramiento y vuelta 

// Función encargada de leer el valor de los finales de carrera
void leerfc(){
  v_fc1 = digitalRead(FC1);
  v_fc2 = digitalRead(FC2);
}
// Función encargada de mover la pieza corredera hacia el lado derecho

void movder(int vder){
   digitalWrite(DIR, HIGH); // Establece sentido del motor
    for (int i=0; i < 25*vder; i++) { //Establece la cantidad de pasos que realizar
    leerfc(); //Antes de cada paso comprueba que el final de carrera derecho no esté activado
    if (v_fc1 == HIGH){
    digitalWrite(STEP, HIGH);
    delayMicroseconds (vel);
    digitalWrite(STEP, LOW);
    delayMicroseconds (vel);
    }
   }
  }
// Función encargada de mover la pieza corredera hacia el lado izquierdo

   void movizq(int vizq)
    {
   digitalWrite(DIR, LOW); // Establece sentido del motor
    for (int i=0; i < 25*vizq; i++) { //Establece la cantidad de pasos que realizar
    leerfc(); //Antes de cada paso comprueba que el final de carrera derecho no esté activado
      if (v_fc2 == HIGH){
      digitalWrite(STEP, HIGH);
      delayMicroseconds (vel);
      digitalWrite(STEP, LOW);
      delayMicroseconds (vel);
     }
    }
  }

void idavueltan(int nesti, int mm, int vele){ // Función que realiza la ida y la vuelta con los parametros actualizados
  
  while (n <= nesti) {
   digitalWrite(DIR, LOW);
    for (int i=0; i < 25*mm; i++) { //200 pasos = 1 vuelta = 2 mm (paso de rosca del husillo)
    leerfc();
    if (v_fc1 == HIGH){
    digitalWrite(STEP, HIGH);
    delayMicroseconds (vele);
    digitalWrite(STEP, LOW);
    delayMicroseconds (vele);
     }
     }
    delay(pausa);
   digitalWrite(DIR, HIGH);
    for (int i=0; i < 25*mm; i++) {
    leerfc();
    if (v_fc2 == HIGH){
    digitalWrite(STEP, HIGH);
    delayMicroseconds (vele);
    digitalWrite(STEP, LOW);
    delayMicroseconds (vele);
     }
     }
    delay(pausa);
    n=n+1; 
   }
}

     // En el setup se establecen los pines de salida y se inicializa la comunicación serial
void setup() {
  pinMode(STEP, OUTPUT);
  pinMode(DIR, OUTPUT);
  pinMode(FC1, INPUT);
  pinMode(FC2, INPUT);
  Serial.begin(9600);
}

void loop() {

      if (stringComplete)
    {
        inputString.trim();  // Si hay alguna linea nueva devuelve un espacio en blanco
        // Procesa el comando
        
        if (inputString.indexOf("$I") != -1) // Si el comando empieza por $I lee el valor de mm a estirar y llama a la función izquierda
        {
          String vizq = inputString.substring(2);
          movizq(vizq.toInt());
        }
        else if (inputString.indexOf("$D") != -1)  // Si el comando empieza por $D lee el valor de mm a estirar y llama a la función derecha
        {
          String vder = inputString.substring(2);
          movder(vder.toInt());
        }
        
          else if (inputString.equals("$E")) // Si el comando empieza por $E llama a la función estirar.
        {
          n = 1;
          idavueltan(nesti.toInt(),mm.toInt(),vele.toInt());
        }
        else if (inputString.indexOf("$A") != -1) // Si el comando empieza por $A lee el valor de nesti a estirar y actualiza el parametro
        {
           nesti = inputString.substring(2);
        }
        else if (inputString.indexOf("$B") != -1) // Si el comando empieza por $B lee el valor de mm a estirar y actualiza el parametro
        {
           mm = inputString.substring(2);
        }
        else if (inputString.indexOf("$C") != -1) // Si el comando empieza por $C lee el valor de vel y actualiza el parametro
        {
          vele = inputString.substring(2);
        }  
        inputString = "";
        stringComplete = false; 
        
} 

      while (Serial.available())
    {
        // Coge el nuevo byte
        char inChar = (char)Serial.read();
        // si el carácter entrante es una nueva línea, establezca una bandera para que el ciclo principal pueda hacer algo al respecto:
        if (inChar == '\n')
        {
            stringComplete = true;
        }
        else
        {
            // Lo añade al inputString
            inputString += inChar;
        }
    }
}
