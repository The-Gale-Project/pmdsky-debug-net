doc: Represents an array MONEY_QUANTITY_TABLE defined within pmdsky.
meta:
  id: money_quantity_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: money_quantity_table_array_dim_0
types:
  money_quantity_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 100
