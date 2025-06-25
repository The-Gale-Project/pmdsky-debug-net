doc: Represents a struct or union delayed_texture_vram_order defined within 
  pmdsky-debug.
meta:
  id: delayed_texture_vram_order
  endian: le
  bit-endian: le
  imports:
  - pointer
  - delayed_texture_vram_order_type
  - delayed_texture_vram_order_unk2_array
seq:
- id: unk1
  type: u4
- id: bytes_length
  type: u4
- id: source_image_pointer
  type: pointer
- id: vram_offset
  type: u4
- id: task_type
  type: delayed_texture_vram_order_type
- id: unk2
  type: delayed_texture_vram_order_unk2_array
- id: unk3
  type: u4
