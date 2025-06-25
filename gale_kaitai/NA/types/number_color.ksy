doc: Holds the data for the enum number_color.
meta:
  id: number_color
  endian: le
  bit-endian: le
seq:
- id: number_color_value
  type: b32
  enum: number_color_enum
enums:
  number_color_enum:
    -1: number_color_auto
    0: number_color_green_0x0
    1: number_color_red_0x1
    2: number_color_dark_green
    3: number_color_yellow
    4: number_color_unk_0x4
    5: number_color_unk_0x5
    6: number_color_red_0x6
    7: number_color_unk_0x7
    8: number_color_unk_0x8
    9: number_color_unk_0x9
    10: number_color_green_0xa
    11: number_color_light_blue
