doc: Holds the data for the enum render_type_64.
meta:
  id: render_type_64
  endian: le
  bit-endian: le
seq:
- id: render_type_64_value
  type: b32
  enum: render_type_64_enum
enums:
  render_type_64_enum:
    0: render64_texture
    1: render64_nothing
    2: render64_rectangle
    3: render64_rectangle_multicolor
    4: render64_quadrilateral
    5: render64_tiling
    6: render64_window_frame
    7: render64_texture_0x7
