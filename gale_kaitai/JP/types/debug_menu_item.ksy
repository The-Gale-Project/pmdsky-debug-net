doc: Represents a struct or union debug_menu_item defined within pmdsky-debug.
meta:
  id: debug_menu_item
  endian: le
  bit-endian: le
  imports:
  - debug_menu_item_string_array
seq:
- id: string
  type: debug_menu_item_string_array
- id: field_0x100
  type: u1
