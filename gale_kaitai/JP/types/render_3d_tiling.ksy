doc: Represents a struct or union render_3d_tiling defined within pmdsky-debug.
meta:
  id: render_3d_tiling
  endian: le
  bit-endian: le
  imports:
  - render_3d_element_hdr
  - vec2_16
  - render_3d_texture_params
  - render_3d_tiling_vertices_array
  - render_3d_tiling_colors_array
seq:
- id: hdr
  type: render_3d_element_hdr
- id: texture_vram_offset
  type: s4
- id: palette_base_addr
  type: s4
- id: texture_top_left
  type: vec2_16
- id: texture_size
  type: vec2_16
- id: texture_params
  type: render_3d_texture_params
- id: vertices
  type: render_3d_tiling_vertices_array
- id: colors
  type: render_3d_tiling_colors_array
- id: unused_rotation
  type: u2
- id: polygon_id
  type: u1
- id: alpha
  type: u1
- id: multicolored
  type: u1
- id: padding
  type: u1
