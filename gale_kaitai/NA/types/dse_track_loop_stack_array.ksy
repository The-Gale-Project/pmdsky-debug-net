doc: Represents an array dse_track_loop_stack defined within pmdsky.
meta:
  id: dse_track_loop_stack_array
  endian: le
  bit-endian: le
  imports:
  - dse_track_loop
seq:
- id: entries
  type: dse_track_loop_stack_array_dim_0
types:
  dse_track_loop_stack_array_dim_0:
    seq:
    - id: entries
      type: dse_track_loop
      repeat: expr
      repeat-expr: 4
