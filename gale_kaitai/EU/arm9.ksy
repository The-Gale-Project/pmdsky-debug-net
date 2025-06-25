doc: |-
  The main ARM9 binary.

  This is the main binary that gets loaded when the game is launched, and contains the core code that runs the game, low level facilities such as memory allocation, compression, other external dependencies (such as linked libraries), and the functions and tables necessary to load overlays and dispatch execution to them.

  Speaking generally, this is the program run by the Nintendo DS's main ARM946E-S CPU, which handles all gameplay mechanisms and graphics rendering.
meta:
  id: arm9
  tags: EU
  endian: le
  imports:
  - functions/arm9_functions
  - data/arm9_data
  - subregions/itcm
  - subregions/libs
instances:
  functions:
    type: arm9_functions
  data:
    type: arm9_data
  itcm:
    type: itcm
  libs:
    type: libs
