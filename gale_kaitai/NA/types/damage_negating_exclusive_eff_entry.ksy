doc: Represents a struct or union damage_negating_exclusive_eff_entry defined 
  within pmdsky-debug.
meta:
  id: damage_negating_exclusive_eff_entry
  endian: le
  bit-endian: le
  imports:
  - type_id
  - exclusive_item_effect_id
seq:
- id: type
  type: type_id
- id: effect
  type: exclusive_item_effect_id
