doc: Represents an array BAR_AVAILABLE_ITEMS defined within pmdsky.
meta:
  id: bar_available_items_array
  endian: le
  bit-endian: le
  imports:
  - bar_item
seq:
- id: entries
  type: bar_available_items_array_dim_0
types:
  bar_available_items_array_dim_0:
    seq:
    - id: entries
      type: bar_item
      repeat: expr
      repeat-expr: 66
