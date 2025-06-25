doc: Represents an array minimap_display_data_tile_matrix_1 defined within 
  pmdsky.
meta:
  id: minimap_display_data_tile_matrix_1_array
  endian: le
  bit-endian: le
  imports:
  - minimap_display_tile
seq:
- id: entries
  type: minimap_display_data_tile_matrix_1_array_dim_1
types:
  minimap_display_data_tile_matrix_1_array_dim_0:
    seq:
    - id: entries
      type: minimap_display_tile
      repeat: expr
      repeat-expr: 28
  minimap_display_data_tile_matrix_1_array_dim_1:
    seq:
    - id: entries
      type: minimap_display_data_tile_matrix_1_array_dim_0
      repeat: expr
      repeat-expr: 16
