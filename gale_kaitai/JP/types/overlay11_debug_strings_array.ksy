doc: Represents an array OVERLAY11_DEBUG_STRINGS defined within pmdsky.
meta:
  id: overlay11_debug_strings_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: overlay11_debug_strings_array_dim_0
types:
  overlay11_debug_strings_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 0
