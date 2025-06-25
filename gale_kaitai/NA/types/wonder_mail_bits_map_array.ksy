doc: Represents an array WONDER_MAIL_BITS_MAP defined within pmdsky.
meta:
  id: wonder_mail_bits_map_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: wonder_mail_bits_map_array_dim_0
types:
  wonder_mail_bits_map_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 32
