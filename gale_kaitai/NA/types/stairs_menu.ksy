doc: Represents a struct or union stairs_menu defined within pmdsky-debug.
meta:
  id: stairs_menu
  endian: le
  bit-endian: le
  imports:
  - pointer
  - stairs_type
seq:
- id: field_0x0
  type: u4
- id: field_0x4
  type: u4
- id: entity
  type: pointer
- id: state
  type: s4
- id: unk_info_menu_var
  type: u4
- id: stairs_type
  type: stairs_type
