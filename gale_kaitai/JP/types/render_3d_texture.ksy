doc: Represents a struct or union render_3d_texture defined within pmdsky-debug.
meta:
  id: render_3d_texture
  endian: le
  bit-endian: le
  imports:
  - render_3d_element_hdr
  - vec2_16
  - render_3d_texture_params
  - uvec2_16
  - rgb5
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
- id: translation
  type: vec2_16
- id: negative_corner_pos
  type: vec2_16
- id: scale
  type: uvec2_16
- id: color
  type: rgb5
- id: rotation
  type: u2
- id: polygon_id
  type: u1
- id: alpha
  type: u1
