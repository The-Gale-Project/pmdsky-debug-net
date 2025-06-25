doc: Represents an array BAR_RECRUITABLE_MONSTER_TABLE defined within pmdsky.
meta:
  id: bar_recruitable_monster_table_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: bar_recruitable_monster_table_array_dim_0
types:
  bar_recruitable_monster_table_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 108
