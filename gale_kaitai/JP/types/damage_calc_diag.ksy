doc: Represents a struct or union damage_calc_diag defined within pmdsky-debug.
meta:
  id: damage_calc_diag
  endian: le
  bit-endian: le
  imports:
  - type_id_8
  - move_category
  - damage_calc_diag_move_indiv_type_matchups_array
seq:
- id: move_type
  type: type_id_8
- id: field_0x1
  type: u1
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: move_category
  type: move_category
- id: move_indiv_type_matchups
  type: damage_calc_diag_move_indiv_type_matchups_array
- id: offensive_stat_stage
  type: u1
- id: defensive_stat_stage
  type: u1
- id: offensive_stat
  type: u2
- id: defensive_stat
  type: u2
- id: flash_fire_boost
  type: u2
- id: offense_calc
  type: u2
- id: defense_calc
  type: u2
- id: attacker_level
  type: u2
- id: damage_calc_at
  type: u2
- id: damage_calc_def
  type: u2
- id: damage_calc_flv
  type: u2
- id: field_0x1e
  type: u1
- id: field_0x1f
  type: u1
- id: damage_calc
  type: s4
- id: damage_calc_base
  type: s4
- id: damage_calc_random_mult_pct
  type: s4
- id: static_damage_mult
  type: s4
- id: item_atk_modifier
  type: s1
- id: item_sp_atk_modifier
  type: s1
- id: ability_offense_modifier
  type: s1
- id: ability_defense_modifier
  type: s1
- id: iq_skill_offense_modifier
  type: s1
- id: iq_skill_defense_modifier
  type: s1
- id: item_def_modifier
  type: s1
- id: item_sp_def_modifier
  type: s1
- id: scope_lens_or_sharpshooter_activated
  type: u1
- id: patsy_band_activated
  type: u1
- id: half_physical_damage_activated
  type: u1
- id: half_special_damage_activated
  type: u1
- id: focus_energy_activated
  type: u1
- id: type_advantage_master_activated
  type: u1
- id: cloudy_drop_activated
  type: u1
- id: rain_multiplier_activated
  type: u1
- id: sunny_multiplier_activated
  type: u1
- id: fire_move_ability_drop_activated
  type: u1
- id: flash_fire_activated
  type: u1
- id: levitate_activated
  type: u1
- id: torrent_boost_activated
  type: u1
- id: overgrow_boost_activated
  type: u1
- id: swarm_boost_activated
  type: u1
- id: fire_move_ability_boost_activated
  type: u1
- id: scrappy_activated
  type: u1
- id: super_luck_activated
  type: u1
- id: sniper_activated
  type: u1
- id: stab_boost_activated
  type: u1
- id: electric_move_dampened
  type: u1
- id: water_sport_drop_activated
  type: u1
- id: charge_boost_activated
  type: u1
- id: field_0x4f
  type: u1
- id: ghost_immunity_activated
  type: u1
- id: skull_bash_defense_boost_activated
  type: u1
- id: field_0x52
  type: u1
- id: field_0x53
  type: u1
