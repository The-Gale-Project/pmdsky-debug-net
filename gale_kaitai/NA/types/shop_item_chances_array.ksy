doc: Represents an array SHOP_ITEM_CHANCES defined within pmdsky.
meta:
  id: shop_item_chances_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: shop_item_chances_array_dim_0
types:
  shop_item_chances_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 144
