doc: Represents an array FIXED_ROOM_ENTITY_SPAWN_TABLE defined within pmdsky.
meta:
  id: fixed_room_entity_spawn_table_array
  endian: le
  bit-endian: le
  imports:
  - fixed_room_entity_spawn_entry
seq:
- id: entries
  type: fixed_room_entity_spawn_table_array_dim_0
types:
  fixed_room_entity_spawn_table_array_dim_0:
    seq:
    - id: entries
      type: fixed_room_entity_spawn_entry
      repeat: expr
      repeat-expr: 269
