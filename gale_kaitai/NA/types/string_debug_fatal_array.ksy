doc: Represents an array STRING_DEBUG_FATAL defined within pmdsky.
meta:
  id: string_debug_fatal_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_debug_fatal_array_dim_0
types:
  string_debug_fatal_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 20
