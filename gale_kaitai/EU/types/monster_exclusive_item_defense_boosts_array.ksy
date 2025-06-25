doc: Represents an array monster_exclusive_item_defense_boosts defined within 
  pmdsky.
meta:
  id: monster_exclusive_item_defense_boosts_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: monster_exclusive_item_defense_boosts_array_dim_0
types:
  monster_exclusive_item_defense_boosts_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
