doc: Represents a struct or union delayed_texture_vram_container defined within 
  pmdsky-debug.
meta:
  id: delayed_texture_vram_container
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: orders
  type: pointer
- id: address_in_bank_d_3dtex
  type: u4
- id: address_in_bank_f_3dpal
  type: u4
- id: next_order_to_use
  type: u2
