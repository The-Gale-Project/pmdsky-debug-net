doc: Holds the data for the enum delayed_texture_vram_order_type.
meta:
  id: delayed_texture_vram_order_type
  endian: le
  bit-endian: le
seq:
- id: delayed_texture_vram_order_type_value
  type: b32
  enum: delayed_texture_vram_order_type_enum
enums:
  delayed_texture_vram_order_type_enum:
    0: place_vram_order_type0
    1: place_vram_order_type1
    2: place_vram_order_free
