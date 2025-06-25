doc: Represents a struct or union options_menu_item defined within pmdsky-debug.
meta:
  id: options_menu_item
  endian: le
  bit-endian: le
  imports:
  - options_menu_item_string_array
  - pointer
seq:
- id: string
  type: options_menu_item_string_array
- id: choices
  type: pointer
- id: n_choices
  type: s4
- id: field_0x108
  type: s4
