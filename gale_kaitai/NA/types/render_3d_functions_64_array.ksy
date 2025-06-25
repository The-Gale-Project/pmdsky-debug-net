doc: Represents an array RENDER_3D_FUNCTIONS_64 defined within pmdsky.
meta:
  id: render_3d_functions_64_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: render_3d_functions_64_array_dim_0
types:
  render_3d_functions_64_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 8
