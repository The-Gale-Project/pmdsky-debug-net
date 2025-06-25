doc: Represents a struct or union palette_data defined within pmdsky-debug.
meta:
  id: palette_data
  endian: le
  bit-endian: le
  imports:
  - pointer
  - rgba
seq:
- id: palette_data_sub
  type: pointer
- id: nb_color
  type: s4
- id: need_update
  type: u1
- id: field3_0x9
  type: u1
- id: fade_opposite
  type: u2
- id: flush_colors
  type: rgba
- id: field6_0x10
  type: u4
- id: refresh_command
  type: pointer
- id: rgba_palette
  type: pointer
- id: raw_palette
  type: pointer
- id: previous_palette
  type: pointer
- id: next_palette
  type: pointer
