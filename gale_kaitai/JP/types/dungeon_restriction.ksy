doc: Represents a struct or union dungeon_restriction defined within 
  pmdsky-debug.
meta:
  id: dungeon_restriction
  endian: le
  bit-endian: le
  imports: []
seq:
- id: f_dungeon_goes_up
  type: b1
- id: f_enemies_evolve
  type: b1
- id: f_enemies_give_exp
  type: b1
- id: f_recruitment_allowed
  type: b1
- id: f_reset_to_level_1
  type: b1
- id: f_money_allowed
  type: b1
- id: f_leader_change_enabled
  type: b1
- id: f_enter_without_saving
  type: b1
- id: f_disable_iq_skills
  type: b1
- id: f_no_trap_uncovering
  type: b1
- id: f_treasure_box_drops
  type: b1
- id: flags_unused
  type: b5
- id: unused
  type: u2
- id: max_rescue_attempts
  type: u1
- id: max_items_allowed
  type: u1
- id: max_party_size
  type: u1
- id: field_0x7
  type: u1
- id: turn_limit_per_floor
  type: u2
- id: random_movement_chance
  type: s2
