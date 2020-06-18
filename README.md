DynamicAES
==========
DYNAMIC S-BOX APPROACH
The AES algorithm uses s-box to implement byte by byte
substitution of the block. Basically s-box is 16 ×16 matrix
and it works as a lookup table, and this matrix is a static
table. In order to make the algorithm more secure against a
timing attack and make its information kept safe and
difficult to be discovered by attackers, we will change this
static table in to dynamic table depending on the key that we
have.

matrix. In order to make the system dynamically updated at
each round, we simply take the mirrored position sub-key of
16 bytes. The sub-key is filled at row 0 of the Dynamic sbox
(Dbox) then it’s circularly left shifted per each row by
BuildLCS function.

        void BuildLCS(byte* [] Data, int Times){
          for (i = 0; i < Times; i++){
          byte temp = Data[0];
            for(int j = 0; j < 15; Data[j] = Data[j+1],j++);
              Data[15] = temp;
          }
        }
        
        
A combination of 16 lines of circularly shifted rows creates
the DBox. This matrix is changed per each row as the basic
ingredient of it as the sub-key is changed per round. Then it
is updated by applying the byte-wise XOR with s-box. The
generated AddByte is dynamically changed per round. It is
applied to the s-box table and as a result it generates a
different box per each round. The inverse box is generated
accordingly for decryption phase.

          void DBoxGen(byte [,] statebox, int round){
            byte [] Temp = new byte[16];
            BuildLCS(ref Temp, round);
            byte AddByte = 0; t = 0;
            for(byte k = 0;k < 16; k+2){
              AddByte << = 1;
              t = (byte)(Temp[k] & 0x01);
              AddByte | = t;
          }
          
          for(byte i = 0; i < 16; i++){
            for(byte r = 0; r < 4; r++)
              for(byte c = 0; c < 4; Temp[r*4+c] = w[((Nrround)*4)+r,c], ++c);
                for(byte j = 0; j < 16; j++){
                  byte row,col,y=0;
                  Dbox[i,j]=(byte)((int)statebox[i,j]^(int)AddByte);
                  row=(byte)(Dbox[i,j]>>4);
                  col=(byte)(Dbox[i,j]&0x0f);
                  iDbox[row,col]=(byte)((int)(i<<4)|(int)j);
              }
            }
          }
          
          
The first transformation is used in the sub bytes encryption
where the SubBytes operation involves 16 independent
byte-to-byte transformations and in order to substitute a
byte, we interpret the byte as two hexadecimal digits.
D-box contains source values for dynamic mode while sbox
includes source values for the conventional AES
routines. A Boolean Mode variable can be taking true or
false values enumerated as Standard and Dynamic terms.
SubBytes function acts as before in case Standard is selected
for Mode. Upon calling SubByte with Dynamic Mode value
it generates D-box and then it applies XOR of 4 by 4
matrices with d-box rather than s-box. This simple trick
avoids attackers analyzing and breaking the payload when it
accesses static s-box.

The following implementationis based on an open source
AES project available at http://x-n2o.com/aes-explained

            void SubBytes(int round)
            { 
              int i;
              if (Mode)
                DBoxGen (Sbox, round) ;
              for(r = 0; r < 4; r++) {
                for(c = 0; c < 4; c++) {
                  State[r,c] = Dbox[( State[r,c])] >> 4),
                  (State[r,c] & 0x0f) ];
              }
            }
            
Similar to SubByte, the InvSubByte works with a Boolean
variable whether to work in conventional mode or in the
proposed dynamic mode.

            void InvSubBytes(int round)
            {
              If (mode)
                BuildDbox(Sbox,round);
              for(int r = 0; r < 4; ++r){
                for(int c = 0; c < 4; ++c){
                  if (mode)
                    State[r,c] = iDbox[(State[r,c] >> 4),(State[r,c] & 0x0f)];
                }
              }
            }
            
The encryption function is updated in order to call the
updated subbytes with an extra parameter either as
(Standard or Dynamic). These two words are predefined
literals to force the algorithm working in the old fashion or
with Dynamic S-Box updates. The other steps including
AddRoundKey, ShiftRows and MixColumns are the same.
Our proposed approach only updates the Subbytes routine.

              void Cipher(byte [] input, byte [] output)
              {
                State = new byte[4, Nb];
                for(int i = 0; i < (4*Nb); ++i)
                  State[i%4, i/4] = input[i];
                AddRoundKey(0);
                int round;
                for(round = 1; round <= (Nr‐1); ++round)
                {
                  SubBytes(round);
                  ShiftRows();
                  MixColoums();
                  AddRoundKey(round);
                }
                SubBytes(Nr);
                ShiftRows();
                AddRoundKey(Nr);
                for (int i = 0; i < (4*Nb); ++i)
                {
                  output[i] = State[i%4, i/4];
                }
              }

Iterations and operations are involved in the encryption and
the decryption process depending on the cipher key size
where each round accomplishes four known stages. The
128-bit cipher key requires 10 rounds to accomplish either
the encryption or decryption phases. In AES 128-bit, 11
sub-keys are deduced from the master key. But the key must
be expanded prior to decryption. Encryption is thus faster
than Decryption. The decryption is updated with just a
similar amendment to the encryption function.
  
              void InvCipher(byte [] input, byte [] output)
              {
                State = new byte[4,Nb];
                for(int i = 0; i < (4*Nb); ++i)
                  State[i%4, i/4] = input[i];
                AddRoundKey(Nr);
                for(int round = Nr‐1; round >= 1; ‐‐round)
                {
                  InvShiftRows();
                  InvSubBytes(round+1);
                  AddRoundKey(round);
                  InvMixColoums();
                }
                
                InvShiftRows();
                InvSubBytes(1);
                AddRoundKey(0);
                for (int i = 0; i < (4*Nb); ++i)
                  output[i] = State[i%4,i/4];
              }
              
You can access full document: https://dl.acm.org/doi/pdf/10.1145/2523514.2523544?download=true
