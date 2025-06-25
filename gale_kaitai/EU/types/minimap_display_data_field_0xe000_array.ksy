doc: Represents an array minimap_display_data_field_0xE000 defined within 
  pmdsky.
meta:
  id: minimap_display_data_field_0xe000_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: minimap_display_data_field_0xe000_array_dim_1
types:
  minimap_display_data_field_0xe000_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 28
  minimap_display_data_field_0xe000_array_dim_1:
    seq:
    - id: entries
      type: minimap_display_data_field_0xe000_array_dim_0
      repeat: expr
      repeat-expr: 32
