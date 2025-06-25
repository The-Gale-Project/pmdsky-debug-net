doc: Represents a struct or union move_data defined within pmdsky-debug.
meta:
  id: move_data
  endian: le
  bit-endian: le
  imports:
  - type_id_8
  - move_category_8
  - move_target_and_range
  - move_id_16
seq:
- id: base_power
  type: u2
- id: type
  type: type_id_8
- id: category
  type: move_category_8
- id: target_range
  type: move_target_and_range
- id: ai_target_range
  type: move_target_and_range
- id: pp
  type: u1
- id: ai_weight
  type: u1
- id: accuracy1
  type: u1
- id: accuracy2
  type: u1
- id: ai_condition_random_chance
  type: u1
- id: strikes
  type: u1
- id: max_ginseng_boost
  type: u1
- id: crit_chance
  type: u1
- id: reflected_by_magic_coat
  type: u1
- id: can_be_snatched
  type: u1
- id: fails_while_muzzled
  type: u1
- id: ai_can_use_against_frozen
  type: u1
- id: usable_while_taunted
  type: u1
- id: range_string_idx
  type: u1
- id: id
  type: move_id_16
- id: message_string_idx
  type: u2
