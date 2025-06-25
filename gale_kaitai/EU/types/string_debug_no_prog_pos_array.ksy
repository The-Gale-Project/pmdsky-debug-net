doc: Represents an array STRING_DEBUG_NO_PROG_POS defined within pmdsky.
meta:
  id: string_debug_no_prog_pos_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_debug_no_prog_pos_array_dim_0
types:
  string_debug_no_prog_pos_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 24
