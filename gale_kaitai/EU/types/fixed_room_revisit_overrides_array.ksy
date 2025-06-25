doc: Represents an array FIXED_ROOM_REVISIT_OVERRIDES defined within pmdsky.
meta:
  id: fixed_room_revisit_overrides_array
  endian: le
  bit-endian: le
  imports:
  - fixed_room_id_8
seq:
- id: entries
  type: fixed_room_revisit_overrides_array_dim_0
types:
  fixed_room_revisit_overrides_array_dim_0:
    seq:
    - id: entries
      type: fixed_room_id_8
      repeat: expr
      repeat-expr: 256
