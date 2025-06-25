doc: Represents an array KEYBOARD_STRING_IDS defined within pmdsky.
meta:
  id: keyboard_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: keyboard_string_ids_array_dim_0
types:
  keyboard_string_ids_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 30
