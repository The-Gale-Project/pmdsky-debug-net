doc: Represents a struct or union entity defined within pmdsky-debug.
meta:
  id: entity
  endian: le
  bit-endian: le
  imports:
  - entity_type
  - position
  - pixel_position
  - animation_control
  - pointer
seq:
- id: type
  type: entity_type
- id: pos
  type: position
- id: prev_pos
  type: position
- id: pixel_pos
  type: pixel_position
- id: pixel_pos_mirror
  type: pixel_position
- id: elevation
  type: s4
- id: is_visible
  type: u1
- id: field_0x21
  type: u1
- id: transparent
  type: u1
- id: end_walk_anim_frame
  type: u1
- id: field_0x24
  type: u1
- id: room_idx
  type: u1
- id: spawn_genid
  type: u2
- id: field_0x28
  type: u1
- id: field_0x29
  type: u1
- id: field_0x2a
  type: u1
- id: field_0x2b
  type: u1
- id: anim_ctrl
  type: animation_control
- id: sprite_index
  type: u2
- id: field_0xaa
  type: u1
- id: field_0xab
  type: u1
- id: field_0xac
  type: u1
- id: field_0xad
  type: u1
- id: animation_group_id
  type: u1
- id: animation_group_id_mirror
  type: u1
- id: animation_id
  type: u1
- id: animation_id_mirror0
  type: u1
- id: field_0xb2
  type: u1
- id: field_0xb3
  type: u1
- id: info
  type: pointer
