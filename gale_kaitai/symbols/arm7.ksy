doc: |-
  The ARM7 binary.
  
  This is the secondary binary that gets loaded when the game is launched.
  
  Speaking generally, this is the program run by the Nintendo DS's secondary ARM7TDMI CPU, which handles the audio I/O, the touch screen, Wi-Fi functions, cryptography, and more.
  
  Memory map: (binary is initially loaded at 0x2380000)
  0x2380000-0x23801E8 => Contains _start_arm7 and two more methods, all related to memory mapping.
  0x23801E8-0x238F7F0 => Mapped to 0x37F8000, contains NitroSpMain and functions crucial to execution.
  0x238F7F0-0x23A7068 => Mapped to 0x27E0000, contains everything else that won't fit in the fast WRAM.
  
  Note that while the length for the main EU/NA/JP block is defined as 0x27080 above, after memory mappings, the block located at that address is only a 0x1E8 long ENTRY block, containing 3 functions solely used for the initial memory mapping. The memory following this block is reused and its purpose is undocumented at the moment.
meta:
  id: arm7
  endian: le
  imports:
    - arm7_functions
instances:
  functions:
    type: arm7_functions
  