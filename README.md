# mono-invalidprogram

Do the following on a Windows machine with mono 4.2.3.4 installed. A windows 8.1 x64 was used to reproduce. The bug can also be reproduced by building on a linux machine and then running on windows. This was reproduced by building in a mono:4.2.3.4 docker container and then running the output on windows 8.1 x64.

The same issue has been found when building with mono 4.0.4 and 4.2.2, although that is by no means an exhaustive list.

1. git clone https://github.com/Unarmed/mono-invalidprogram.git
2. cd mono-invalidprogram
3. xbuild invalid-program.sln
4. cd bin/Debug
5. mono invalid-program.exe
  * This produces the expected "If you see this then everything is OK!"
6. invalid-program.exe
  * This produces "Unhandled Exception: System.InvalidProgramException: Common Language Runtime detected an invalid program."