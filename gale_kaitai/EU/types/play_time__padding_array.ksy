doc: Represents an array play_time__padding defined within pmdsky.
meta:
  id: play_time__padding_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: play_time__padding_array_dim_0
types:
  play_time__padding_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 3
