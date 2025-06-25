doc: Holds the data for the enum hidden_stairs_type.
meta:
  id: hidden_stairs_type
  endian: le
  bit-endian: le
seq:
- id: hidden_stairs_type_value
  type: b32
  enum: hidden_stairs_type_enum
enums:
  hidden_stairs_type_enum:
    0: hidden_stairs_none
    1: hidden_stairs_secret_bazaar
    2: hidden_stairs_secret_room
    255: hidden_stairs_random_secret_bazaar_or_secret_room
