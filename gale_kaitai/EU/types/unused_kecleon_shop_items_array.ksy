doc: Represents an array UNUSED_KECLEON_SHOP_ITEMS defined within pmdsky.
meta:
  id: unused_kecleon_shop_items_array
  endian: le
  bit-endian: le
  imports:
  - bulk_item
seq:
- id: entries
  type: unused_kecleon_shop_items_array_dim_0
types:
  unused_kecleon_shop_items_array_dim_0:
    seq:
    - id: entries
      type: bulk_item
      repeat: expr
      repeat-expr: 8
