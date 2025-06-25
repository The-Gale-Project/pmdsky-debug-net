doc: Holds the data for the enum kecleon_shop_version.
meta:
  id: kecleon_shop_version
  endian: le
  bit-endian: le
seq:
- id: kecleon_shop_version_value
  type: b32
  enum: kecleon_shop_version_enum
enums:
  kecleon_shop_version_enum:
    0: kecleon_shop_1
    1: kecleon_shop_2
    2: kecleon_shop_3
    3: kecleon_shop_4
