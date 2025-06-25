doc: Holds the data for the enum mobility_type.
meta:
  id: mobility_type
  endian: le
  bit-endian: le
seq:
- id: mobility_type_value
  type: b32
  enum: mobility_type_enum
enums:
  mobility_type_enum:
    0: mobility_normal
    1: mobility_secondary
    2: mobility_hovering
    3: mobility_intangible
    4: mobility_lava
    5: mobility_water
