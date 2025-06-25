doc: Represents an array script_var_value_table_dungeon_enter_backup defined 
  within pmdsky.
meta:
  id: script_var_value_table_dungeon_enter_backup_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_var_value_table_dungeon_enter_backup_array_dim_0
types:
  script_var_value_table_dungeon_enter_backup_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 5
