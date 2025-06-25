doc: Represents a struct or union render_3d_rectangle defined within 
  pmdsky-debug.
meta:
  id: render_3d_rectangle
  endian: le
  bit-endian: le
  imports:
  - render_3d_element_hdr
  - vec2_16
  - uvec2_16
  - render_3d_rectangle_colors_array
seq:
- id: hdr
  type: render_3d_element_hdr
- id: translation
  type: vec2_16
- id: size
  type: vec2_16
- id: negative_corner_pos
  type: vec2_16
- id: unused_v3
  type: vec2_16
- id: scale
  type: uvec2_16
- id: rotation
  type: u2
- id: colors
  type: render_3d_rectangle_colors_array
- id: polygon_id
  type: u1
- id: alpha
  type: u1
- id: multicolored
  type: u1
- id: padding
  type: u1
