doc: Represents an array dialogue_display_state_field_0x99 defined within 
  pmdsky.
meta:
  id: dialogue_display_state_field_0x99_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dialogue_display_state_field_0x99_array_dim_0
types:
  dialogue_display_state_field_0x99_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 4
