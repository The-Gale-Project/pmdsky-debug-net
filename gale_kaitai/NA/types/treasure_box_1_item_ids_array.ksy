doc: Represents an array TREASURE_BOX_1_ITEM_IDS defined within pmdsky.
meta:
  id: treasure_box_1_item_ids_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: treasure_box_1_item_ids_array_dim_0
types:
  treasure_box_1_item_ids_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 12
