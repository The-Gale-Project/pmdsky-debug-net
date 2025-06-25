doc: Represents a struct or union dungeon_data_list_entry defined within 
  pmdsky-debug.
meta:
  id: dungeon_data_list_entry
  endian: le
  bit-endian: le
  imports: []
seq:
- id: n_floors
  type: u1
- id: dungeon_data_index_mappa_s
  type: u1
- id: n_preceding_floors_group
  type: u1
- id: n_total_floors_group
  type: u1
