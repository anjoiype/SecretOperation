# SecretOperation
This repository contains a solution which serves as an example for publisher-subscriber pattern in C#.
`Program.cs` serves as the entry point of the solution. 
## Overview
Secret operation is a program in which messages which are tagged to different departments like finance, defence, internal security are 
encrypted and send to the listeners. There are listeners who listens to particular topic or all topics. Here the publisher is the 
`MessageEncryptor.cs` class which encrypts and notifies the subscirbers after the message gets encrypted. The encrypted message is read 
by the subscribers and displayed.

### Note
>For keeping the program simple, the subscribers display the encrypted message as it is and there is no decryption method.

>The encryption method used is very simple as the main objective of program is not about the encryption. Encryption method is called 
>as `Ceasor Cipher With Key` where the letters in the message is replaced with letter which comes after N shifts in ASCII table where N
is the `key`

>The input is read from file which is kept under `Resources` folder. Each file type is named accordingly. In the `Message.cs` class 
invocation of correct type takes place. Again this hard coded approach is taken to attain simplicity of program and to concentrate on 
pattern demo.
