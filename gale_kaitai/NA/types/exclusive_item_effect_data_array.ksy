doc: Represents an array EXCLUSIVE_ITEM_EFFECT_DATA defined within pmdsky.
meta:
  id: exclusive_item_effect_data_array
  endian: le
  bit-endian: le
  imports:
  - exclusive_item_effect_entry
seq:
- id: entries
  type: exclusive_item_effect_data_array_dim_0
types:
  exclusive_item_effect_data_array_dim_0:
    seq:
    - id: entries
      type: exclusive_item_effect_entry
      repeat: expr
      repeat-expr: 956
