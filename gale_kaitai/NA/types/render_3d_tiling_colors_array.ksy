doc: Represents an array render_3d_tiling_colors defined within pmdsky.
meta:
  id: render_3d_tiling_colors_array
  endian: le
  bit-endian: le
  imports:
  - rgb5
seq:
- id: entries
  type: render_3d_tiling_colors_array_dim_0
types:
  render_3d_tiling_colors_array_dim_0:
    seq:
    - id: entries
      type: rgb5
      repeat: expr
      repeat-expr: 4
