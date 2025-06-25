doc: Represents a struct or union language_and_flags defined within 
  pmdsky-debug.
meta:
  id: language_and_flags
  endian: le
  bit-endian: le
  imports: []
seq:
- id: language
  type: b3
- id: gba_mode_screen
  type: b1
- id: backlight_level
  type: b2
- id: bootmenu_disable
  type: b1
- id: field_0x7
  type: b1
