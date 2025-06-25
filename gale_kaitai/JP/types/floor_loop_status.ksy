doc: Holds the data for the enum floor_loop_status.
meta:
  id: floor_loop_status
  endian: le
  bit-endian: le
seq:
- id: floor_loop_status_value
  type: b32
  enum: floor_loop_status_enum
enums:
  floor_loop_status_enum:
    0: floor_loop_continue
    1: floor_loop_leader_fainted
    2: floor_loop_next_floor
