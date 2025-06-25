doc: Holds the data for the enum status_reflect_id.
meta:
  id: status_reflect_id
  endian: le
  bit-endian: le
seq:
- id: status_reflect_id_value
  type: b32
  enum: status_reflect_id_enum
enums:
  status_reflect_id_enum:
    0: status_reflect_none
    1: status_reflect_reflect
    2: status_reflect_safeguard
    3: status_reflect_light_screen
    4: status_reflect_counter
    5: status_reflect_magic_coat
    6: status_reflect_wish
    7: status_reflect_protect
    8: status_reflect_mirror_coat
    9: status_reflect_enduring
    10: status_reflect_mini_counter
    11: status_reflect_mirror_move
    12: status_reflect_conversion2
    13: status_reflect_vital_throw
    14: status_reflect_mist
    15: status_reflect_metal_burst
    16: status_reflect_aqua_ring
    17: status_reflect_lucky_chant
