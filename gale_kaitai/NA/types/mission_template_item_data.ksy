doc: Represents a struct or union mission_template_item_data defined within 
  pmdsky-debug.
meta:
  id: mission_template_item_data
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: none
  type: u2
- id: template_item_table_id
  type: u2
- id: mission_item_id
  type: item_id_16
