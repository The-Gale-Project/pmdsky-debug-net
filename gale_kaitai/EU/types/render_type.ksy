doc: Holds the data for the enum render_type.
meta:
  id: render_type
  endian: le
  bit-endian: le
seq:
- id: render_type_value
  type: b32
  enum: render_type_enum
enums:
  render_type_enum:
    0: render_rectangle
    1: render_quadrilateral
    2: render_tiling
    3: render_texture
