doc: Represents a struct or union options_menu_id_item defined within 
  pmdsky-debug.
meta:
  id: options_menu_id_item
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: string_id
  type: u2
- id: padding
  type: u2
- id: n_choices
  type: s4
- id: choices
  type: pointer
