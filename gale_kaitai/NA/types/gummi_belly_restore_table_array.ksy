doc: Represents an array GUMMI_BELLY_RESTORE_TABLE defined within pmdsky.
meta:
  id: gummi_belly_restore_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: gummi_belly_restore_table_array_dim_1
types:
  gummi_belly_restore_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 18
  gummi_belly_restore_table_array_dim_1:
    seq:
    - id: entries
      type: gummi_belly_restore_table_array_dim_0
      repeat: expr
      repeat-expr: 18
