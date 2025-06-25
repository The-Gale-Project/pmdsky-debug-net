doc: Represents a struct or union render_3d_texture_params defined within 
  pmdsky-debug.
meta:
  id: render_3d_texture_params
  endian: le
  bit-endian: le
  imports: []
seq:
- id: texture_s_size
  type: b3
- id: texture_t_size
  type: b3
- id: teximage_param_flags_6
  type: b2
- id: texture_format
  type: b3
- id: repeat_s
  type: b1
- id: repeat_t
  type: b1
- id: teximage_param_flags_d
  type: b3
