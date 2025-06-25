doc: Represents an array dungeon_room_data defined within pmdsky.
meta:
  id: dungeon_room_data_array
  endian: le
  bit-endian: le
  imports:
  - room_data
seq:
- id: entries
  type: dungeon_room_data_array_dim_0
types:
  dungeon_room_data_array_dim_0:
    seq:
    - id: entries
      type: room_data
      repeat: expr
      repeat-expr: 32
