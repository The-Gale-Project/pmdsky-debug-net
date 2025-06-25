doc: Represents an array METRONOME_TABLE defined within pmdsky.
meta:
  id: metronome_table_array
  endian: le
  bit-endian: le
  imports:
  - wildcard_move_desc
seq:
- id: entries
  type: metronome_table_array_dim_0
types:
  metronome_table_array_dim_0:
    seq:
    - id: entries
      type: wildcard_move_desc
      repeat: expr
      repeat-expr: 168
