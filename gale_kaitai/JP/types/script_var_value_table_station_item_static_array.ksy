doc: Represents an array script_var_value_table_station_item_static defined 
  within pmdsky.
meta:
  id: script_var_value_table_station_item_static_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_var_value_table_station_item_static_array_dim_0
types:
  script_var_value_table_station_item_static_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 4
