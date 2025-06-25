doc: Represents an array LEVEL_UP_DATA_DECOMPRESS_BUFFER defined within pmdsky.
meta:
  id: level_up_data_decompress_buffer_array
  endian: le
  bit-endian: le
  imports:
  - level_up_entry
seq:
- id: entries
  type: level_up_data_decompress_buffer_array_dim_0
types:
  level_up_data_decompress_buffer_array_dim_0:
    seq:
    - id: entries
      type: level_up_entry
      repeat: expr
      repeat-expr: 100
