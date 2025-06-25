doc: Represents an array delayed_texture_vram_order_unk2 defined within pmdsky.
meta:
  id: delayed_texture_vram_order_unk2_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: delayed_texture_vram_order_unk2_array_dim_0
types:
  delayed_texture_vram_order_unk2_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 4
