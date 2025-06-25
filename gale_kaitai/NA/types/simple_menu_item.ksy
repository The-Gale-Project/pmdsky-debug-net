doc: Represents a struct or union simple_menu_item defined within pmdsky-debug.
meta:
  id: simple_menu_item
  endian: le
  bit-endian: le
  imports:
  - simple_menu_item_string_array
seq:
- id: string
  type: simple_menu_item_string_array
- id: result_value
  type: s4
