doc: Represents an array render_3d_element_64_color defined within pmdsky.
meta:
  id: render_3d_element_64_color_array
  endian: le
  bit-endian: le
  imports:
  - rgba
seq:
- id: entries
  type: render_3d_element_64_color_array_dim_0
types:
  render_3d_element_64_color_array_dim_0:
    seq:
    - id: entries
      type: rgba
      repeat: expr
      repeat-expr: 4
