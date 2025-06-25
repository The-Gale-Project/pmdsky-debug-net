doc: Represents an array DAMAGE_STRING_IDS defined within pmdsky.
meta:
  id: damage_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: damage_string_ids_array_dim_0
types:
  damage_string_ids_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 27
