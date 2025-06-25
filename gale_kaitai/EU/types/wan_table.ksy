doc: Represents a struct or union wan_table defined within pmdsky-debug.
meta:
  id: wan_table
  endian: le
  bit-endian: le
  imports:
  - wan_table_sprites_array
  - pointer
seq:
- id: sprites
  type: wan_table_sprites_array
- id: at_decompress_scratch_space
  type: pointer
- id: field2_0x1504
  type: u1
- id: field3_0x1505
  type: u1
- id: field4_0x1506
  type: u1
- id: field5_0x1507
  type: u1
- id: total_nb_of_entries
  type: s2
- id: next_alloc_start_pos
  type: s2
- id: field8_0x150c
  type: s2
- id: field9_0x150e
  type: u1
- id: field10_0x150f
  type: u1
