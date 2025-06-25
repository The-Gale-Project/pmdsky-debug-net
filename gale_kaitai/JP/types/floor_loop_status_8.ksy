doc: Holds bitsized data for the parent enum floor_loop_status.
meta:
  id: floor_loop_status_8
  endian: le
  bit-endian: le
seq:
- id: floor_loop_status_8_value
  type: b8
  enum: floor_loop_status_8_enum
enums:
  floor_loop_status_8_enum:
    0: floor_loop_continue
    1: floor_loop_leader_fainted
    2: floor_loop_next_floor
