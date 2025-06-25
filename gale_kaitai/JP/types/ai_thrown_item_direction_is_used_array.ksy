doc: Represents an array AI_THROWN_ITEM_DIRECTION_IS_USED defined within pmdsky.
meta:
  id: ai_thrown_item_direction_is_used_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ai_thrown_item_direction_is_used_array_dim_0
types:
  ai_thrown_item_direction_is_used_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 8
