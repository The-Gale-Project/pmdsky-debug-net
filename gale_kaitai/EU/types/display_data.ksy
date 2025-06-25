doc: Represents a struct or union display_data defined within pmdsky-debug.
meta:
  id: display_data
  endian: le
  bit-endian: le
  imports:
  - position
  - pointer
  - direction_id_8
seq:
- id: camera_pos
  type: position
- id: camera_pos_mirror
  type: position
- id: camera_pixel_pos
  type: position
- id: camera_pixel_pos_mirror
  type: position
- id: camera_target
  type: pointer
- id: screen_shake_offset
  type: u4
- id: screen_shake_intensity
  type: u4
- id: screen_shake_intensity_reset
  type: u4
- id: field_0x20
  type: u1
- id: visibility_range
  type: u1
- id: blinded
  type: u1
- id: luminous
  type: u1
- id: natural_lighting
  type: u1
- id: map_surveyor
  type: u1
- id: can_see_enemies
  type: u1
- id: can_see_items
  type: u1
- id: can_see_traps
  type: u1
- id: hallucinating
  type: u1
- id: can_see_stairs
  type: u1
- id: field_0x2b
  type: u1
- id: field_0x2c
  type: u1
- id: darkness
  type: u1
- id: field_0x2e
  type: u1
- id: leader_pointed
  type: u1
- id: field_0x30
  type: u1
- id: unk_fade_to_black_tracker
  type: u1
- id: field_0x32
  type: u1
- id: field_0x33
  type: u1
- id: field_0x34
  type: u1
- id: team_menu_or_grid
  type: u1
- id: leader_target_direction
  type: direction_id_8
- id: leader_target_direction_mirror
  type: direction_id_8
- id: field_0x38
  type: u2
- id: field_0x3a
  type: u2
- id: floor_touch_screen
  type: s2
- id: leader_level_touch_screen
  type: s2
- id: leader_hp_touch_screen
  type: s2
- id: leader_max_hp_touch_screen
  type: s2
- id: field_0x44
  type: u2
- id: field_0x46
  type: u1
- id: field_0x47
  type: u1
