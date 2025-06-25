doc: Represents an array dse_track_loop_padding defined within pmdsky.
meta:
  id: dse_track_loop_padding_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_track_loop_padding_array_dim_0
types:
  dse_track_loop_padding_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 3
