doc: Represents an array dialogue_display_state_fields_0x8 defined within 
  pmdsky.
meta:
  id: dialogue_display_state_fields_0x8_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dialogue_display_state_fields_0x8_array_dim_0
types:
  dialogue_display_state_fields_0x8_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 40
