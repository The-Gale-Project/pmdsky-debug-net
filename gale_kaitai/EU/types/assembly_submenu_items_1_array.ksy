doc: Represents an array ASSEMBLY_SUBMENU_ITEMS_1 defined within pmdsky.
meta:
  id: assembly_submenu_items_1_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: assembly_submenu_items_1_array_dim_0
types:
  assembly_submenu_items_1_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 5
