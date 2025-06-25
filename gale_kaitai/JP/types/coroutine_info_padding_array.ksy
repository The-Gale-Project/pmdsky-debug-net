doc: Represents an array coroutine_info_padding defined within pmdsky.
meta:
  id: coroutine_info_padding_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: coroutine_info_padding_array_dim_0
types:
  coroutine_info_padding_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
