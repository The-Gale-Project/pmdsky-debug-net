doc: Holds bitsized data for the parent enum render_type.
meta:
  id: render_type_3
  endian: le
  bit-endian: le
seq:
- id: render_type_3_value
  type: b3
  enum: render_type_3_enum
enums:
  render_type_3_enum:
    0: render_rectangle
    1: render_quadrilateral
    2: render_tiling
    3: render_texture
