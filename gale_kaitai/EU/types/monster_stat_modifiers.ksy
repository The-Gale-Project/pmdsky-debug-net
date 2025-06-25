doc: Represents a struct or union monster_stat_modifiers defined within 
  pmdsky-debug.
meta:
  id: monster_stat_modifiers
  endian: le
  bit-endian: le
  imports:
  - monster_stat_modifiers_offensive_stages_array
  - monster_stat_modifiers_defensive_stages_array
  - monster_stat_modifiers_hit_chance_stages_array
  - monster_stat_modifiers_offensive_multipliers_array
  - monster_stat_modifiers_defensive_multipliers_array
seq:
- id: offensive_stages
  type: monster_stat_modifiers_offensive_stages_array
- id: defensive_stages
  type: monster_stat_modifiers_defensive_stages_array
- id: hit_chance_stages
  type: monster_stat_modifiers_hit_chance_stages_array
- id: flash_fire_boost
  type: s2
- id: field_0xe
  type: u1
- id: field_0xf
  type: u1
- id: offensive_multipliers
  type: monster_stat_modifiers_offensive_multipliers_array
- id: defensive_multipliers
  type: monster_stat_modifiers_defensive_multipliers_array
