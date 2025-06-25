doc: Represents a struct or union mission_subtype defined within pmdsky-debug.
meta:
  id: mission_subtype
  endian: le
  bit-endian: le
  imports:
  - mission_subtype_rescue_target_8
  - mission_subtype_escort_to_target_8
  - mission_subtype_explore_8
  - mission_subtype_find_item_8
  - mission_subtype_take_item_8
  - mission_subtype_outlaw_8
  - mission_subtype_challenge_8
  - mission_subtype_consumable_8
seq:
- id: rescue_target
  type: mission_subtype_rescue_target_8
- id: escort
  type: mission_subtype_escort_to_target_8
- id: explore
  type: mission_subtype_explore_8
- id: find_item
  type: mission_subtype_find_item_8
- id: take_item
  type: mission_subtype_take_item_8
- id: outlaw
  type: mission_subtype_outlaw_8
- id: challenge
  type: mission_subtype_challenge_8
- id: consumable
  type: mission_subtype_consumable_8
- id: other
  type: u1
