doc: Represents an array BAG_ITEMS defined within pmdsky.
meta:
  id: bag_items_array
  endian: le
  bit-endian: le
  imports:
  - item
seq:
- id: entries
  type: bag_items_array_dim_0
types:
  bag_items_array_dim_0:
    seq:
    - id: entries
      type: item
      repeat: expr
      repeat-expr: 50
