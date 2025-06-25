doc: Represents a struct or union render_3d_element defined within pmdsky-debug.
meta:
  id: render_3d_element
  endian: le
  bit-endian: le
  imports:
  - render_3d_rectangle
  - render_3d_quadrilateral
  - render_3d_tiling
  - render_3d_texture
seq:
- id: rectangle
  type: render_3d_rectangle
- id: quadrilateral
  type: render_3d_quadrilateral
- id: tiling
  type: render_3d_tiling
- id: texture
  type: render_3d_texture
