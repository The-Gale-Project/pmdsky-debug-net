doc: Represents an array NO_SEND_ITEM_TABLE defined within pmdsky.
meta:
  id: no_send_item_table_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: no_send_item_table_array_dim_0
types:
  no_send_item_table_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 3
