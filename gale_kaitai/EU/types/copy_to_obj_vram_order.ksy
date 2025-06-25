doc: Represents a struct or union copy_to_obj_vram_order defined within 
  pmdsky-debug.
meta:
  id: copy_to_obj_vram_order
  endian: le
  bit-endian: le
  imports:
  - pointer
  - copy_to_obj_vram_order_type_8
seq:
- id: len_output
  type: u4
- id: src
  type: pointer
- id: dst
  type: pointer
- id: interleave_with
  type: u2
- id: copy_type
  type: copy_to_obj_vram_order_type_8
- id: maybe_padding
  type: u1
