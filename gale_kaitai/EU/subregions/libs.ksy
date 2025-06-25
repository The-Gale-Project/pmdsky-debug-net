doc: |-
  System libraries linked to the main ARM9 binary.

  This includes code from common NDS system libraries like the Nitro SDK (which contains NDS-specific functionality as well as utilities akin to libc and libgcc).

  Where the library region starts and ends is a guess, but there appear to be fairly sharp boundaries. The function directly before it calls functions at lower memory addresses outside of the region, while all functions in the region only call other functions within the region. The bytes after the region seem to be the start of a global data region, used by both the libraries and the rest of ARM9.
meta:
  id: libs
  tags: EU
  endian: le
  imports:
  - functions/libs_functions
instances:
  functions:
    type: libs_functions
