doc: Represents an array TYPE_DAMAGE_NEGATING_EXCLUSIVE_ITEM_EFFECTS defined 
  within pmdsky.
meta:
  id: type_damage_negating_exclusive_item_effects_array
  endian: le
  bit-endian: le
  imports:
  - damage_negating_exclusive_eff_entry
seq:
- id: entries
  type: type_damage_negating_exclusive_item_effects_array_dim_0
types:
  type_damage_negating_exclusive_item_effects_array_dim_0:
    seq:
    - id: entries
      type: damage_negating_exclusive_eff_entry
      repeat: expr
      repeat-expr: 28
