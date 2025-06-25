doc: Represents an array GUMMI_LIKE_STRING_IDS defined within pmdsky.
meta:
  id: gummi_like_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: gummi_like_string_ids_array_dim_0
types:
  gummi_like_string_ids_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 4
