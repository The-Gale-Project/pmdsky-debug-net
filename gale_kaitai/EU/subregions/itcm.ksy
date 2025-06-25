doc: |-
  The instruction TCM (tightly-coupled memory) and the corresponding region in the ARM9 binary.

  The ITCM is a special area of low-latency memory meant for performance-critical routines. It's similar to an instruction cache, but more predictable. See the ARMv5 Architecture Reference Manual, Chapter B7 (https://developer.arm.com/documentation/ddi0100/i).

  The Nintendo DS ITCM region is located at 0x0-0x7FFF in memory, but the 32 KiB segment is mirrored throughout the 16 MiB block from 0x0-0x1FFFFFF. The Explorers of Sky code seems to reference only the mirror at 0x1FF8000, the closest one to main memory.

  In Explorers of Sky, a fixed region of the ARM9 binary appears to be loaded in the ITCM at all times, and seems to contain functions related to the dungeon AI, among other things. The ITCM has a max capacity of 0x8000, although not all of it is used.
meta:
  id: itcm
  tags: EU
  endian: le
  imports:
  - functions/itcm_functions
  - data/itcm_data
instances:
  functions:
    type: itcm_functions
  data:
    type: itcm_data
