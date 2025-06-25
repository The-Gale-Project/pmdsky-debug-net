doc: Holds the data for the enum copy_to_obj_vram_order_type.
meta:
  id: copy_to_obj_vram_order_type
  endian: le
  bit-endian: le
seq:
- id: copy_to_obj_vram_order_type_value
  type: b32
  enum: copy_to_obj_vram_order_type_enum
enums:
  copy_to_obj_vram_order_type_enum:
    0: copy_to_flat_vram_standard
    1: copy_to_flat_vram_interleaved
    2: copy_to_flat_vram_interleaved0
