doc: Represents an array EAT_ITEM_EFFECT_IGNORE_LIST defined within pmdsky.
meta:
  id: eat_item_effect_ignore_list_array
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: entries
  type: eat_item_effect_ignore_list_array_dim_0
types:
  eat_item_effect_ignore_list_array_dim_0:
    seq:
    - id: entries
      type: item_id_16
      repeat: expr
      repeat-expr: 36
