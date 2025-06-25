doc: Represents a struct or union render_3d_quadrilateral defined within 
  pmdsky-debug.
meta:
  id: render_3d_quadrilateral
  endian: le
  bit-endian: le
  imports:
  - render_3d_element_hdr
  - render_3d_quadrilateral_vertices_array
  - uvec2_16
  - render_3d_quadrilateral_colors_array
seq:
- id: hdr
  type: render_3d_element_hdr
- id: vertices
  type: render_3d_quadrilateral_vertices_array
- id: unused_scale
  type: uvec2_16
- id: unused_rotation
  type: u2
- id: colors
  type: render_3d_quadrilateral_colors_array
- id: unused_polygon_id
  type: u1
- id: alpha
  type: u1
- id: multicolored
  type: u1
- id: padding
  type: u1
