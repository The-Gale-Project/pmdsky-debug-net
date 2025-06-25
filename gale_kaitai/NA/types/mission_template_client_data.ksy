doc: Represents a struct or union mission_template_client_data defined within 
  pmdsky-debug.
meta:
  id: mission_template_client_data
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: none
  type: u2
- id: template_client_table_id
  type: u2
- id: client
  type: monster_id_16
