doc: Represents a struct or union exclusive_item_effect_entry defined within 
  pmdsky-debug.
meta:
  id: exclusive_item_effect_entry
  endian: le
  bit-endian: le
  imports:
  - exclusive_item_effect_id_8
seq:
- id: effect_id
  type: exclusive_item_effect_id_8
- id: foreign_idx
  type: u1
