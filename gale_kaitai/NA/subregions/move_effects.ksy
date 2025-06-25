doc: |-
  Move effect handlers for individual moves, called by ExecuteMoveEffect (and also the Metronome and Nature Power tables).

  This subregion contains only the move effect handlers themselves, and not necessarily all the utility functions used by the move effect handlers (such as the damage calculation functions). These supporting utilities are in the main overlay29 block.
meta:
  id: move_effects
  tags: NA
  endian: le
  imports:
  - functions/move_effects_functions
  - data/move_effects_data
instances:
  functions:
    type: move_effects_functions
  data:
    type: move_effects_data
