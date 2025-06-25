doc: Represents an array MOVE_ACCURACY_STARS_TABLE defined within pmdsky.
meta:
  id: move_accuracy_stars_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: move_accuracy_stars_table_array_dim_0
types:
  move_accuracy_stars_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 8
