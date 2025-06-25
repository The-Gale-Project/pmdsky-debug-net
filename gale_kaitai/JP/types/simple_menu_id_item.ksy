doc: Represents a struct or union simple_menu_id_item defined within 
  pmdsky-debug.
meta:
  id: simple_menu_id_item
  endian: le
  bit-endian: le
  imports: []
seq:
- id: string_id
  type: u2
- id: padding
  type: u2
- id: result_value
  type: s4
