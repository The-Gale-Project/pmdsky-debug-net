doc: Represents an array KECLEON_SHOP_ITEM_TABLE_LISTS_2 defined within pmdsky.
meta:
  id: kecleon_shop_item_table_lists_2_array
  endian: le
  bit-endian: le
  imports:
  - item_id
seq:
- id: entries
  type: kecleon_shop_item_table_lists_2_array_dim_0
types:
  kecleon_shop_item_table_lists_2_array_dim_0:
    seq:
    - id: entries
      type: item_id
      repeat: expr
      repeat-expr: 4
