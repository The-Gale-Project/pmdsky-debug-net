doc: Represents an array dungeon_spawn_table_entries_chosen defined within 
  pmdsky.
meta:
  id: dungeon_spawn_table_entries_chosen_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_spawn_table_entries_chosen_array_dim_0
types:
  dungeon_spawn_table_entries_chosen_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 16
