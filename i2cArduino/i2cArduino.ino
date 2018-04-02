//Copyright 2018 Stefan Schmidt
#include "WireMW.h"

#define MAX_BUFFER 30

void setup() {
  Serial.begin(19200);
   while (!Serial) {}
  Wire2.begin();
}

enum eCmd { Write=1, Read };
enum eState { GetStart, GetCmd, GetAddress, GetLength, GetData };

void handleWrite(byte address, byte *buffer, byte len)
{
//  Serial.print("write");  Serial.print(len);
  Wire2.beginTransmission(address); 
  Wire2.write(buffer, len);
  Wire2.endTransmission(); 
}

void handleRead(byte address, byte len)
{
 // Serial.print("read");  Serial.print(len);
  byte l = Wire2.requestFrom(address, len); 
  Serial.write(Wire2.getRxBuffer(), l);
  Serial.flush();
}

void loop() 
{
    static enum eCmd cmd;
    static enum eState state = GetStart;
    static byte len;
    static byte address;
    static byte i = 0;
    static byte buffer[MAX_BUFFER];
    if (Serial.available()) {

      byte ch = Serial.read();
      switch (state) {
        case GetStart: {
          if (ch == 0xFE) {
            state = GetCmd;
            i = 0;
          }
        } break;
        case GetCmd: {
          cmd = (eCmd) ch;
          switch (cmd) {
            case Write:
            case Read:
              state = GetAddress;
              break;
            default:
              state = GetStart;
              break;
          }
        } break;
        case GetAddress: {
          address = ch;
          state = GetLength;
        } break;
        case GetLength: {
          len = ch;
          if (cmd == Read) {
            handleRead(address, len);
            state = GetStart;
          } else {
            state = GetData;
          }
        } break;
        case GetData: {
          if (len > 0) {
            if (i < MAX_BUFFER)
              buffer[i++] = ch;
            len--;
          }
          if (len == 0) {
            state = GetStart;
            handleWrite(address, buffer, i);
          }
        } break;
      }
   }
}
