doc: Represents an array minimap_display_data_overwritten_extra_bytes defined 
  within pmdsky.
meta:
  id: minimap_display_data_overwritten_extra_bytes_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: minimap_display_data_overwritten_extra_bytes_array_dim_0
types:
  minimap_display_data_overwritten_extra_bytes_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 28
