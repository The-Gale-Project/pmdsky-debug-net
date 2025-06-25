doc: Holds the data for the enum stairs_type.
meta:
  id: stairs_type
  endian: le
  bit-endian: le
seq:
- id: stairs_type_value
  type: b32
  enum: stairs_type_enum
enums:
  stairs_type_enum:
    0: stairs_type_normal
    1: stairs_type_warp_zone
    2: stairs_type_rescue_point
    3: stairs_type_hidden
