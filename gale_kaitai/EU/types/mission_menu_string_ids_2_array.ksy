doc: Represents an array MISSION_MENU_STRING_IDS_2 defined within pmdsky.
meta:
  id: mission_menu_string_ids_2_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: mission_menu_string_ids_2_array_dim_0
types:
  mission_menu_string_ids_2_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 8
