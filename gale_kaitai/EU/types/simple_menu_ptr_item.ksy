doc: Represents a struct or union simple_menu_ptr_item defined within 
  pmdsky-debug.
meta:
  id: simple_menu_ptr_item
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: string
  type: pointer
- id: result_value
  type: s4
