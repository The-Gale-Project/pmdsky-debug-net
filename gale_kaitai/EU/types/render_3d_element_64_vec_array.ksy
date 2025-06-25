doc: Represents an array render_3d_element_64_vec defined within pmdsky.
meta:
  id: render_3d_element_64_vec_array
  endian: le
  bit-endian: le
  imports:
  - vec2_16
seq:
- id: entries
  type: render_3d_element_64_vec_array_dim_0
types:
  render_3d_element_64_vec_array_dim_0:
    seq:
    - id: entries
      type: vec2_16
      repeat: expr
      repeat-expr: 4
