doc: Represents a struct or union render_3d_element_hdr defined within 
  pmdsky-debug.
meta:
  id: render_3d_element_hdr
  endian: le
  bit-endian: le
  imports:
  - render_type_and_flags
seq:
- id: type
  type: render_type_and_flags
- id: z_index
  type: u2
