doc: Represents a struct or union minimap_display_data defined within 
  pmdsky-debug.
meta:
  id: minimap_display_data
  endian: le
  bit-endian: le
  imports:
  - minimap_display_data_tile_matrix_1_array
  - minimap_display_data_tile_matrix_2_array
  - minimap_display_data_field_0xe000_array
  - minimap_display_data_overwritten_extra_bytes_array
  - minimap_display_data_field_0xe39c_array
seq:
- id: tile_matrix_1
  type: minimap_display_data_tile_matrix_1_array
- id: tile_matrix_2
  type: minimap_display_data_tile_matrix_2_array
- id: field_0xe000
  type: minimap_display_data_field_0xe000_array
- id: overwritten_extra_bytes
  type: minimap_display_data_overwritten_extra_bytes_array
- id: field_0xe39c
  type: minimap_display_data_field_0xe39c_array
- id: field_0xe440
  type: u4
- id: field_0xe444
  type: u1
- id: field_0xe445
  type: u1
- id: field_0xe446
  type: u1
- id: field_0xe447
  type: u1
- id: field_0xe448
  type: u1
- id: field_0xe449
  type: u1
- id: field_0xe44a
  type: u1
- id: field_0xe44b
  type: u1
