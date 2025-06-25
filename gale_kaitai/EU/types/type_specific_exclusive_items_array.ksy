doc: Represents an array TYPE_SPECIFIC_EXCLUSIVE_ITEMS defined within pmdsky.
meta:
  id: type_specific_exclusive_items_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: type_specific_exclusive_items_array_dim_1
types:
  type_specific_exclusive_items_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 4
  type_specific_exclusive_items_array_dim_1:
    seq:
    - id: entries
      type: type_specific_exclusive_items_array_dim_0
      repeat: expr
      repeat-expr: 17
