doc: Represents a struct or union dialogue_display_state defined within 
  pmdsky-debug.
meta:
  id: dialogue_display_state
  endian: le
  bit-endian: le
  imports:
  - dialogue_display_state_fields_0x8_array
  - pointer
  - dialogue_display_state_fields_0x34_array
  - preprocessor_flags
  - dialogue_display_state_field_0x99_array
  - dialogue_display_state_field_0xac_array
seq:
- id: field_0x0
  type: s4
- id: field_0x4
  type: s4
- id: fields_0x8
  type: dialogue_display_state_fields_0x8_array
- id: field_0x30
  type: pointer
- id: fields_0x34
  type: dialogue_display_state_fields_0x34_array
- id: parent_ctx
  type: pointer
- id: field_0x58
  type: u1
- id: field_0x59
  type: u1
- id: field_0x5a
  type: u1
- id: field_0x5b
  type: u1
- id: field_0x5c
  type: s4
- id: flags
  type: preprocessor_flags
- id: field_0x62
  type: u1
- id: field_0x63
  type: u1
- id: text_speed
  type: s4
- id: field_0x68
  type: s4
- id: field_0x6c
  type: s4
- id: field_0x70
  type: u1
- id: field_0x71
  type: u1
- id: field_0x72
  type: u1
- id: field_0x73
  type: u1
- id: field_0x74
  type: u1
- id: field_0x75
  type: u1
- id: field_0x76
  type: u1
- id: field_0x77
  type: u1
- id: text_scroll_anim_frame
  type: u4
- id: page_transition_anim_frame
  type: u4
- id: text_scrolling_done
  type: s4
- id: string
  type: pointer
- id: cursor
  type: pointer
- id: field_0x8c
  type: u2
- id: field_0x8e
  type: u1
- id: field_0x8f
  type: u1
- id: field_0x90
  type: s4
- id: field_0x94
  type: s4
- id: field_0x98
  type: u1
- id: field_0x99
  type: dialogue_display_state_field_0x99_array
- id: field_0x9d
  type: u1
- id: field_0x9e
  type: u1
- id: field_0x9f
  type: u1
- id: field_0xa0
  type: s4
- id: field_0xa4
  type: s4
- id: field_0xa8
  type: u1
- id: field_0xa9
  type: u1
- id: field_0xaa
  type: u1
- id: field_0xab
  type: u1
- id: field_0xac
  type: dialogue_display_state_field_0xac_array
- id: field_0x10c
  type: s4
- id: field_0x110
  type: u1
- id: field_0x111
  type: u1
- id: field_0x112
  type: u1
- id: field_0x113
  type: u1
- id: field_0x114
  type: u1
- id: field_0x115
  type: u1
- id: field_0x116
  type: u1
- id: field_0x117
  type: u1
