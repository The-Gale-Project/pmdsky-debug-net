doc: Represents an array bg_list_entry_sub_struct_name defined within pmdsky.
meta:
  id: bg_list_entry_sub_struct_name_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: bg_list_entry_sub_struct_name_array_dim_0
types:
  bg_list_entry_sub_struct_name_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 10
