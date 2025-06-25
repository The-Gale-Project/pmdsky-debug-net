doc: Represents an array STORAGE_ITEM_QUANTITIES defined within pmdsky.
meta:
  id: storage_item_quantities_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: storage_item_quantities_array_dim_0
types:
  storage_item_quantities_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 1000
