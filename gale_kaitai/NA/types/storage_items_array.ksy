doc: Represents an array STORAGE_ITEMS defined within pmdsky.
meta:
  id: storage_items_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: storage_items_array_dim_0
types:
  storage_items_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 1000
