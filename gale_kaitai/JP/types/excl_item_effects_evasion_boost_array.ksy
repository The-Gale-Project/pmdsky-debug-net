doc: Represents an array EXCL_ITEM_EFFECTS_EVASION_BOOST defined within pmdsky.
meta:
  id: excl_item_effects_evasion_boost_array
  endian: le
  bit-endian: le
  imports:
  - exclusive_item_effect_id_8
seq:
- id: entries
  type: excl_item_effects_evasion_boost_array_dim_0
types:
  excl_item_effects_evasion_boost_array_dim_0:
    seq:
    - id: entries
      type: exclusive_item_effect_id_8
      repeat: expr
      repeat-expr: 8
