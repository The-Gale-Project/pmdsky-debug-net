doc: Represents an array ASSEMBLY_MAIN_MENU_ITEMS_2 defined within pmdsky.
meta:
  id: assembly_main_menu_items_2_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: assembly_main_menu_items_2_array_dim_0
types:
  assembly_main_menu_items_2_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 4
