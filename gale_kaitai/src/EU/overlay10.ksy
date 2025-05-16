doc: Appears to be used both during ground mode and dungeon mode. With dungeon mode,
  whereas overlay 29 contains the main dungeon engine, this overlay seems to contain
  routines and data for dungeon mechanics.
meta:
  id: overlay10
  tags: EU
  endian: le
  imports:
  - functions/overlay10_functions
  - data/overlay10_data
instances:
  functions:
    type: overlay10_functions
  data:
    type: overlay10_data
