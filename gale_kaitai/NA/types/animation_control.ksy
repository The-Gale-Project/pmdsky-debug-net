doc: Represents a struct or union animation_control defined within pmdsky-debug.
meta:
  id: animation_control
  endian: le
  bit-endian: le
  imports:
  - animation_control_field9_0x10_array
  - vec2_16
  - pointer
  - monster_id_16
seq:
- id: some_bitfield
  type: u2
- id: field1_0x2
  type: u2
- id: field2_0x4
  type: u2
- id: anim_frame_duration
  type: u2
- id: field4_0x8
  type: u2
- id: field5_0xa
  type: u2
- id: field6_0xc
  type: u2
- id: field7_0xe
  type: u1
- id: field8_0xf
  type: u1
- id: field9_0x10
  type: animation_control_field9_0x10_array
- id: position
  type: vec2_16
- id: anim_frame_offset
  type: vec2_16
- id: anim_frame_shadow_offset
  type: vec2_16
- id: anim_frame_flag
  type: u4
- id: anim_frame_flag_sum
  type: u4
- id: animations_or_group_len
  type: u2
- id: field19_0x32
  type: u2
- id: field20_0x34
  type: u1
- id: field21_0x35
  type: u1
- id: field22_0x36
  type: u2
- id: field23_0x38
  type: u2
- id: frame_id
  type: u2
- id: field25_0x3c
  type: u2
- id: field26_0x3e
  type: u1
- id: field27_0x3f
  type: u1
- id: palette_pos_high
  type: u1
- id: palette_pos_low
  type: u1
- id: field30_0x42
  type: u1
- id: field31_0x43
  type: u1
- id: field32_0x44
  type: u1
- id: field33_0x45
  type: u1
- id: field34_0x46
  type: u1
- id: field35_0x47
  type: u1
- id: first_animation_frame
  type: pointer
- id: next_animation_frame
  type: pointer
- id: wan_offsets
  type: pointer
- id: wan_frames
  type: pointer
- id: wan_fragments_byte_store
  type: pointer
- id: wan_palettes
  type: pointer
- id: wan_is_256_color
  type: u2
- id: loop_start
  type: u2
- id: field44_0x64
  type: u1
- id: field45_0x65
  type: u1
- id: field46_0x66
  type: u1
- id: field47_0x67
  type: u1
- id: sprite_override
  type: pointer
- id: field49_0x6c
  type: u4
- id: loaded_sprite_id
  type: u2
- id: field51_0x72
  type: monster_id_16
- id: field52_0x74
  type: u1
- id: field53_0x75
  type: u1
- id: animation_group_id
  type: u2
- id: animation_id
  type: u2
- id: palette_bank
  type: u1
- id: field57_0x7b
  type: u1
