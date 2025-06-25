doc: Represents a struct or union wan_image_header defined within pmdsky-debug.
meta:
  id: wan_image_header
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: fragments_bytes_store
  type: pointer
- id: palettes
  type: pointer
- id: unk1
  type: u2
- id: is_256_color
  type: u1
- id: padding1
  type: u1
- id: unk2
  type: u2
- id: nb_fragments
  type: u2
