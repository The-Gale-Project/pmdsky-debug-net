doc: Represents an array STRING_DEBUG_FORMAT_LINE_FILE defined within pmdsky.
meta:
  id: string_debug_format_line_file_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_debug_format_line_file_array_dim_0
types:
  string_debug_format_line_file_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 28
