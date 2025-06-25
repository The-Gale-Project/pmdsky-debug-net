doc: Represents a struct or union wan_header defined within pmdsky-debug.
meta:
  id: wan_header
  endian: le
  bit-endian: le
  imports:
  - pointer
  - wan_sprite_type_16
seq:
- id: anim_header
  type: pointer
- id: image_header
  type: pointer
- id: sprite_type
  type: wan_sprite_type_16
