doc: Represents an array JOB_MENU_ITEMS_3 defined within pmdsky.
meta:
  id: job_menu_items_3_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: job_menu_items_3_array_dim_0
types:
  job_menu_items_3_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 3
