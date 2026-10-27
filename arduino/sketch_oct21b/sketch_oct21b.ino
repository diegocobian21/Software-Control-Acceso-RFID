#include <SPI.h>
#include <MFRC522.h>

// Definimos los pines configurables (los mismos que conectaste físicamente)
#define RST_PIN  9
#define SS_PIN   10

// Creamos el objeto del lector
MFRC522 mfrc522(SS_PIN, RST_PIN);

void setup() {
  // 1. Iniciamos el puerto serie a 9600 baudios (Misma velocidad que tienes en C# port = new SerialPort("COM5", 9600);)
  Serial.begin(9600); 
  
  // 2. Iniciamos el bus SPI y el lector RC522
  SPI.begin();
  mfrc522.PCD_Init();
}

void loop() {
  // 3. Revisamos si hay una nueva tarjeta presente en el lector
  if (!mfrc522.PICC_IsNewCardPresent()) {
    return; // Si no hay tarjeta, el loop vuelve a empezar en silencio
  }

  // 4. Si hay tarjeta, intentamos leer sus datos
  if (!mfrc522.PICC_ReadCardSerial()) {
    return; // Si hubo un error de lectura, volvemos a empezar
  }

  // 5. Si la lectura fue exitosa, extraemos el ID y lo convertimos a un String limpio
  String tarjetaID = "";
  for (byte i = 0; i < mfrc522.uid.size; i++) {
    // Leemos cada bloque en formato hexadecimal (ej. F3 A1 42 CD)
    tarjetaID += String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "");
    tarjetaID += String(mfrc522.uid.uidByte[i], HEX);
  }

  // Convertimos todo a mayúsculas para mantener un estándar en tu base de datos MySQL
  tarjetaID.toUpperCase();

  // 6. ENVIAMOS EL ID POR EL PUERTO SERIE A WINFORMS
  // Usamos println para que agregue un salto de línea al final. 
  // Esto es vital porque en C# estás usando port.ReadLine().
  Serial.println(tarjetaID);

  // 7. Pausa de seguridad: Detenemos la lectura y "dormimos" la tarjeta
  // Esto evita que el Arduino mande el mismo ID 50 veces por segundo mientras dejas la tarjeta apoyada.
  mfrc522.PICC_HaltA();
}