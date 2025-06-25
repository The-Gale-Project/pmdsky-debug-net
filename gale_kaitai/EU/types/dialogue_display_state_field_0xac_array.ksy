doc: Represents an array dialogue_display_state_field_0xac defined within 
  pmdsky.
meta:
  id: dialogue_display_state_field_0xac_array
  endian: le
  bit-endian: le
  imports:
  - dialogue_display_unk_struct
seq:
- id: entries
  type: dialogue_display_state_field_0xac_array_dim_0
types:
  dialogue_display_state_field_0xac_array_dim_0:
    seq:
    - id: entries
      type: dialogue_display_unk_struct
      repeat: expr
      repeat-expr: 4
