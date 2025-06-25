doc: Represents an array global_progress_dungeon_max_reached_floor defined 
  within pmdsky.
meta:
  id: global_progress_dungeon_max_reached_floor_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: global_progress_dungeon_max_reached_floor_array_dim_0
types:
  global_progress_dungeon_max_reached_floor_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 180
