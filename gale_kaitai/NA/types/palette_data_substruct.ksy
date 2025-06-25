doc: Represents a struct or union palette_data_substruct defined within 
  pmdsky-debug.
meta:
  id: palette_data_substruct
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: skip_certain_color_for_effect
  type: u4
- id: count
  type: s4
- id: field2_0x8
  type: u1
- id: field3_0x9
  type: u1
- id: field4_0xa
  type: u1
- id: field5_0xb
  type: u1
- id: field6_0xc
  type: u4
- id: palettes
  type: pointer
