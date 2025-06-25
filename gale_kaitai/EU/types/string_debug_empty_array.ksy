doc: Represents an array STRING_DEBUG_EMPTY defined within pmdsky.
meta:
  id: string_debug_empty_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_debug_empty_array_dim_0
types:
  string_debug_empty_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 4
