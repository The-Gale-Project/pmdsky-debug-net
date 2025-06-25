doc: Represents a struct or union render_3d_element_64 defined within 
  pmdsky-debug.
meta:
  id: render_3d_element_64
  endian: le
  bit-endian: le
  imports:
  - render_3d_element_64_vec_array
  - uvec2_16
  - render_3d_texture_params
  - vec2_16
  - render_3d_element_64_color_array
  - render_type_64_8
seq:
- id: vec
  type: render_3d_element_64_vec_array
- id: scale
  type: uvec2_16
- id: texture_params
  type: render_3d_texture_params
- id: texture_top_left
  type: vec2_16
- id: texture_size
  type: vec2_16
- id: field_0x1e
  type: u1
- id: field_0x1f
  type: u1
- id: texture_vram_offset
  type: s4
- id: palette_base_addr
  type: s4
- id: rotation
  type: u2
- id: z_index
  type: u2
- id: color
  type: render_3d_element_64_color_array
- id: type
  type: render_type_64_8
- id: flags_0x3d_0
  type: b1
- id: multicolored
  type: b1
- id: flags_0x3d_2
  type: b6
- id: polygon_id
  type: u1
- id: field_0x3f
  type: u1
