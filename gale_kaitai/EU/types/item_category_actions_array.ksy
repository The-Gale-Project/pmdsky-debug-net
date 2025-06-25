doc: Represents an array ITEM_CATEGORY_ACTIONS defined within pmdsky.
meta:
  id: item_category_actions_array
  endian: le
  bit-endian: le
  imports:
  - action_16
seq:
- id: entries
  type: item_category_actions_array_dim_0
types:
  item_category_actions_array_dim_0:
    seq:
    - id: entries
      type: action_16
      repeat: expr
      repeat-expr: 16
