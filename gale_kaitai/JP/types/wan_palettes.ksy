doc: Represents a struct or union wan_palettes defined within pmdsky-debug.
meta:
  id: wan_palettes
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: palette_bytes
  type: pointer
- id: unk1
  type: u2
- id: nb_color
  type: u2
- id: unk2
  type: u2
- id: unk3
  type: u1
- id: unk4
  type: u1
- id: unk5
  type: u4
