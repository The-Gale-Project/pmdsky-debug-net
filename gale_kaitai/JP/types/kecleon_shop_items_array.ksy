doc: Represents an array KECLEON_SHOP_ITEMS defined within pmdsky.
meta:
  id: kecleon_shop_items_array
  endian: le
  bit-endian: le
  imports:
  - bulk_item
seq:
- id: entries
  type: kecleon_shop_items_array_dim_0
types:
  kecleon_shop_items_array_dim_0:
    seq:
    - id: entries
      type: bulk_item
      repeat: expr
      repeat-expr: 8
