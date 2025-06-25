doc: |-
  The dungeon engine.

  This is the "main" overlay of dungeon mode. It controls most things that happen in a Mystery Dungeon, such as dungeon layout generation, dungeon menus, enemy AI, and generally just running each turn while within a dungeon.
meta:
  id: overlay29
  tags: NA
  endian: le
  imports:
  - functions/overlay29_functions
  - data/overlay29_data
  - subregions/move_effects
instances:
  functions:
    type: overlay29_functions
  data:
    type: overlay29_data
  move_effects:
    type: move_effects
