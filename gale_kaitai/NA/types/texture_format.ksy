doc: Holds the data for the enum texture_format.
meta:
  id: texture_format
  endian: le
  bit-endian: le
seq:
- id: texture_format_value
  type: b32
  enum: texture_format_enum
enums:
  texture_format_enum:
    0: texformat_none
    1: texformat_a3i5
    2: texformat_4color
    3: texformat_16color
    4: texformat_256color
    5: texformat_compressed
    6: texformat_a5i3
    7: texformat_direct
