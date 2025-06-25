doc: Holds the data for the enum move_target.
meta:
  id: move_target
  endian: le
  bit-endian: le
seq:
- id: move_target_value
  type: b32
  enum: move_target_enum
enums:
  move_target_enum:
    0: target_enemies
    1: target_party
    2: target_all
    3: target_user
    4: target_enemies_after_charging
    5: target_all_except_user
    6: target_teammates
    15: target_special
