doc: Represents an array EVO_MENU_STRING_IDS defined within pmdsky.
meta:
  id: evo_menu_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: evo_menu_string_ids_array_dim_0
types:
  evo_menu_string_ids_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 26
