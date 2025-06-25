doc: Represents an array NATURAL_GIFT_ITEM_TABLE defined within pmdsky.
meta:
  id: natural_gift_item_table_array
  endian: le
  bit-endian: le
  imports:
  - natural_gift_item_info
seq:
- id: entries
  type: natural_gift_item_table_array_dim_0
types:
  natural_gift_item_table_array_dim_0:
    seq:
    - id: entries
      type: natural_gift_item_info
      repeat: expr
      repeat-expr: 34
