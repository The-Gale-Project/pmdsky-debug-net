doc: Represents an array FIXED_ROOM_PROPERTIES_TABLE defined within pmdsky.
meta:
  id: fixed_room_properties_table_array
  endian: le
  bit-endian: le
  imports:
  - fixed_room_properties_entry
seq:
- id: entries
  type: fixed_room_properties_table_array_dim_0
types:
  fixed_room_properties_table_array_dim_0:
    seq:
    - id: entries
      type: fixed_room_properties_entry
      repeat: expr
      repeat-expr: 256
