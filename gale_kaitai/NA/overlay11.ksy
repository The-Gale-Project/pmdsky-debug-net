doc: |-
  The script engine.

  This is the "main" overlay of ground mode. The script engine is what runs the ground mode scripts contained in the SCRIPT folder, which are written in a custom scripting language. These scripts encode things like cutscenes, screen transitions, ground mode events, and tons of other things related to ground mode.
meta:
  id: overlay11
  tags: NA
  endian: le
  imports:
  - functions/overlay11_functions
  - data/overlay11_data
instances:
  functions:
    type: overlay11_functions
  data:
    type: overlay11_data
