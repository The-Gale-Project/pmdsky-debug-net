doc: Represents an array ITEM_DELIVERY_TABLE defined within pmdsky.
meta:
  id: item_delivery_table_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: item_delivery_table_array_dim_0
types:
  item_delivery_table_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 23
