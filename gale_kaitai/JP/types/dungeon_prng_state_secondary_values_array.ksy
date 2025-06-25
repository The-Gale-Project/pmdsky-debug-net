doc: Represents an array DUNGEON_PRNG_STATE_SECONDARY_VALUES defined within 
  pmdsky.
meta:
  id: dungeon_prng_state_secondary_values_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_prng_state_secondary_values_array_dim_0
types:
  dungeon_prng_state_secondary_values_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 5
