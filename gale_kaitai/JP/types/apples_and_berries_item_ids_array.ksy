doc: Represents an array APPLES_AND_BERRIES_ITEM_IDS defined within pmdsky.
meta:
  id: apples_and_berries_item_ids_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: apples_and_berries_item_ids_array_dim_0
types:
  apples_and_berries_item_ids_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 66
