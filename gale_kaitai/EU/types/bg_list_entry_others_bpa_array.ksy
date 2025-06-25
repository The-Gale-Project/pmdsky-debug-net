doc: Represents an array bg_list_entry_others_bpa defined within pmdsky.
meta:
  id: bg_list_entry_others_bpa_array
  endian: le
  bit-endian: le
  imports:
  - bg_list_entry_sub_struct
seq:
- id: entries
  type: bg_list_entry_others_bpa_array_dim_0
types:
  bg_list_entry_others_bpa_array_dim_0:
    seq:
    - id: entries
      type: bg_list_entry_sub_struct
      repeat: expr
      repeat-expr: 8
