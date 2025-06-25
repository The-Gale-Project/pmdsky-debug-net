doc: Represents an array RENDER_3D_FUNCTIONS defined within pmdsky.
meta:
  id: render_3d_functions_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: render_3d_functions_array_dim_0
types:
  render_3d_functions_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 4
