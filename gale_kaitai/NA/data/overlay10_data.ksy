meta:
  id: overlay10_data
  endian: le
  imports:
  - ../types/window_params
  - ../types/dungeon_id_8
  - ../types/imprison_turn_range_array
  - ../types/sleep_turn_range_array
  - ../types/nightmare_turn_range_array
  - ../types/rest_turn_range_array
  - ../types/sport_condition_turn_range_array
  - ../types/sure_shot_turn_range_array
  - ../types/smokescreen_turn_range_array
  - ../types/perish_song_turn_range_array
  - ../types/yawn_turn_range_array
  - ../types/speed_boost_turn_range_array
  - ../types/weather_ball_type_table_array
  - ../types/ai_regular_attack_weights_array
  - ../types/last_resort_damage_mult_table_array
  - ../types/synthesis_hp_restoration_table_array
  - ../types/roost_hp_restoration_table_array
  - ../types/moonlight_hp_restoration_table_array
  - ../types/morning_sun_hp_restoration_table_array
  - ../types/reversal_damage_mult_table_array
  - ../types/water_spout_damage_mult_table_array
  - ../types/wring_out_damage_mult_table_array
  - ../types/eruption_damage_mult_table_array
  - ../types/weather_ball_damage_mult_table_array
  - ../types/eat_item_effect_ignore_list_array
  - ../types/castform_weather_attribute_table_array
  - ../types/bad_poison_damage_table_array
  - ../types/type_matchup_combinator_table
  - ../types/offensive_stat_stage_multipliers_array
  - ../types/defensive_stat_stage_multipliers_array
  - ../types/nature_power_table_array
  - ../types/apples_and_berries_item_ids_array
  - ../types/recruitment_level_boost_table_array
  - ../types/natural_gift_item_table_array
  - ../types/random_music_id_table_array
  - ../types/shop_item_chances_array
  - ../types/male_accuracy_stage_multipliers_array
  - ../types/male_evasion_stage_multipliers_array
  - ../types/female_accuracy_stage_multipliers_array
  - ../types/female_evasion_stage_multipliers_array
  - ../types/music_id_table_array
  - ../types/type_matchup_table
  - ../types/fixed_room_monster_spawn_stats_table_array
  - ../types/metronome_table_array
  - ../types/tileset_properties_array
  - ../types/fixed_room_properties_table_array
  - ../types/trap_animation_info_array
  - ../types/item_animation_info_array
  - ../types/move_animation_info_array
  - ../types/effect_animation_info_array
  - ../types/special_monster_move_animation_info_array
instances:
  inventory_menu_default_window_params:
    pos: 0x7914
    type: window_params
    doc: |-
      Default window_params for an inventory_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateInventoryMenu.

      Additionally, width and height are 0, and will be computed in CreateInventoryMenu.
  first_dungeon_with_monster_house_traps:
    pos: 0x798c
    type: dungeon_id_8
    doc: |-
      The first dungeon that can have extra traps spawn in Monster Houses, Dark Hill

      type: struct dungeon_id_8
  bad_poison_damage_cooldown:
    pos: 0x7994
    type: s2
    doc: The number of turns between passive bad poison (toxic) damage.
  protein_stat_boost:
    pos: 0x79a0
    type: s2
    doc: The permanent attack boost from ingesting a Protein.
  waterfall_cringe_chance:
    pos: 0x79a4
    type: s2
    doc: The chance of Waterfall inflicting the cringe status, as a percentage 
      (30%).
  aurora_beam_lower_attack_chance:
    pos: 0x79a8
    type: s2
    doc: The chance of Aurora Beam halving attack, as a percentage (60%).
  spawn_cap_no_monster_house:
    pos: 0x79b0
    type: s2
    doc: The maximum number of enemies that can spawn on a floor without a 
      monster house (15).
  oren_berry_damage:
    pos: 0x79b8
    type: s2
    doc: Damage dealt by eating an Oren Berry.
  iron_tail_lower_defense_chance:
    pos: 0x79c0
    type: s2
    doc: The chance of Iron Tail lowering defense, as a percentage (30%).
  twineedle_poison_chance:
    pos: 0x79c4
    type: s2
    doc: The chance of Twineedle poisoning, as a percentage (20%).
  extrasensory_cringe_chance:
    pos: 0x79c8
    type: s2
    doc: The chance of Extrasensory (and others, see DoMoveDamageCringe10) 
      inflicting the cringe status, as a percentage (10%).
  rock_slide_cringe_chance:
    pos: 0x79cc
    type: s2
    doc: The chance of Rock Slide (and others, see DoMoveDamageCringe30) 
      inflicting the cringe status, as a percentage (30%).
  crunch_lower_defense_chance:
    pos: 0x79d0
    type: s2
    doc: The chance of Crunch (and others, see DoMoveDamageLowerDef20) lowering 
      defense, as a percentage (20%).
  trap_buster_activation_chance:
    pos: 0x79dc
    type: s2
    doc: The chance of Trap Buster activating (30%).
  forewarn_forced_miss_chance:
    pos: 0x79e8
    type: s2
    doc: The chance of Forewarn forcing a move to miss, as a percentage (20%).
  unown_stone_drop_chance:
    pos: 0x79f4
    type: s2
    doc: The chance of an Unown dropping an Unown stone, as a percentage (33%).
  sitrus_berry_hp_restoration:
    pos: 0x79f8
    type: s2
    doc: The amount of HP restored by eating a Sitrus Berry.
  muddy_water_lower_accuracy_chance:
    pos: 0x7a04
    type: s2
    doc: The chance of Muddy Water (and others, see DoMoveDamageLowerAccuracy40)
      lowering accuracy, as a percentage (40%).
  silver_wind_boost_chance:
    pos: 0x7a08
    type: s2
    doc: The chance of Silver Wind (and others, see DoMoveDamageBoostAllStats) 
      boosting all stats, as a percentage (20%).
  poison_tail_poison_chance:
    pos: 0x7a0c
    type: s2
    doc: The chance of Poison Tail poisoning, as a percentage (10%).
  thundershock_paralyze_chance:
    pos: 0x7a10
    type: s2
    doc: The chance of Thundershock paralyzing, as a percentage (10%).
  bounce_paralyze_chance:
    pos: 0x7a14
    type: s2
    doc: The chance of Bounce paralyzing, as a percentage (30%)
  headbutt_cringe_chance:
    pos: 0x7a18
    type: s2
    doc: The chance of Headbutt inflicting the cringe status, as a percentage 
      (25%).
  fire_fang_cringe_chance:
    pos: 0x7a1c
    type: s2
    doc: The chance of Fire Fang inflicting the cringe status, as a percentage 
      (25%).
  sacred_fire_burn_chance:
    pos: 0x7a20
    type: s2
    doc: The chance of Sacred Fire burning, as a percentage (50%).
  whirlpool_constriction_chance:
    pos: 0x7a24
    type: s2
    doc: The chance of Whirlpool inflicting the constriction status, as a 
      percentage (10%).
  exp_elite_exp_boost:
    pos: 0x7a28
    type: s2
    doc: The percentage increase in experience from the Exp. Elite IQ skill
  monster_house_max_non_monster_spawns:
    pos: 0x7a2c
    type: s2
    doc: The maximum number of extra non-monster spawns (items/traps) in a 
      Monster House, 7
  heal_order_hp_restoration:
    pos: 0x7a38
    type: s2
    doc: The amount of HP restored by Heal Order (40).
  steel_wing_boost_defense_chance:
    pos: 0x7a44
    type: s2
    doc: The chance of Steel Wing boosting defense, as a percentage (20%).
  gold_thorn_power:
    pos: 0x7a50
    type: s2
    doc: Attack power for Golden Thorns.
  burn_damage:
    pos: 0x7a54
    type: s2
    doc: Damage dealt by the burn status condition.
  poison_damage:
    pos: 0x7a58
    type: s2
    doc: Damage dealt by the poison status condition.
  spawn_cooldown:
    pos: 0x7a5c
    type: s2
    doc: The number of turns between enemy spawns under normal conditions.
  mist_ball_lower_special_attack_chance:
    pos: 0x7a60
    type: s2
    doc: The chance of Mist Ball lowering special attack, as a percentage (50%).
  charge_beam_boost_special_attack_chance:
    pos: 0x7a70
    type: s2
    doc: The chance of Charge Beam boosting special attack, as a percentage 
      (40%).
  oran_berry_full_hp_boost:
    pos: 0x7a74
    type: s2
    doc: The permanent HP boost from eating an Oran Berry at full HP (0).
  life_seed_hp_boost:
    pos: 0x7a78
    type: s2
    doc: The permanent HP boost from eating a Life Seed.
  octazooka_lower_accuracy_chance:
    pos: 0x7a80
    type: s2
    doc: The chance of Octazooka lowering accuracy, as a percentage (60%).
  luster_purge_lower_special_defense_chance:
    pos: 0x7a8c
    type: s2
    doc: The chance of Luster Purge (and others, see 
      DoMoveDamageLowerSpecialDefense50) lowering special defense, as a 
      percentage (50%).
  super_luck_crit_rate_boost:
    pos: 0x7a90
    type: s2
    doc: The critical hit rate (additive) boost from Super Luck, 10%.
  constrict_lower_speed_chance:
    pos: 0x7a94
    type: s2
    doc: The chance of Constrict (and others, see DoMoveDamageLowerSpeed20) 
      lowering speed, as a percentage (20%).
  ice_fang_freeze_chance:
    pos: 0x7a98
    type: s2
    doc: The chance of Ice Fang freezing, as a percentage (15%).
  smog_poison_chance:
    pos: 0x7a9c
    type: s2
    doc: The chance of Smog (and others, see DoMoveDamagePoison40) poisoning, as
      a percentage (40%).
  lick_paralyze_chance:
    pos: 0x7aa8
    type: s2
    doc: The chance of Lick (and others, see DoMoveDamageParalyze10) paralyzing,
      as a percentage (10%).
  thunder_fang_paralyze_chance:
    pos: 0x7aac
    type: s2
    doc: The chance of Thunder Fang paralyzing, as a percentage (10%).
  bite_cringe_chance:
    pos: 0x7ab4
    type: s2
    doc: The chance of Bite (and others, see DoMoveDamageCringe20) inflicting 
      the cringe status, as a percentage (20%)
  sky_attack_cringe_chance:
    pos: 0x7ab8
    type: s2
    doc: The chance of Sky Attack inflicting the cringe status, as a percentage 
      (25%).
  ice_fang_cringe_chance:
    pos: 0x7abc
    type: s2
    doc: The chance of Ice Fang inflicting the cringe status, as a percentage 
      (25%).
  blaze_kick_burn_chance:
    pos: 0x7ac0
    type: s2
    doc: The chance of Blaze Kick burning, as a percentage (10%).
  flamethrower_burn_chance:
    pos: 0x7ac4
    type: s2
    doc: The chance of Flamethrower (and others, see DoMoveDamageBurn10) 
      burning, as a percentage (10%).
  dizzy_punch_confuse_chance:
    pos: 0x7ac8
    type: s2
    doc: The chance of Dizzy Punch (and others, see DoMoveDamageConfuse30) 
      confusing, as a percentage (30%).
  secret_power_effect_chance:
    pos: 0x7acc
    type: s2
    doc: The chance of Secret Power inflicting an effect, as a percentage (30%).
  metal_claw_boost_attack_chance:
    pos: 0x7ad4
    type: s2
    doc: The chance of Metal Claw boosting attack, as a percentage (20%).
  technician_move_power_threshold:
    pos: 0x7adc
    type: s2
    doc: The move power threshold for Technician (4). Moves whose base power 
      doesn't exceed this value will receive a 50% damage boost.
  sonicboom_fixed_damage:
    pos: 0x7ae8
    type: s2
    doc: The amount of fixed damage dealt by SonicBoom (20).
  rain_ability_bonus_regen:
    pos: 0x7af8
    type: s2
    doc: The passive bonus health regen given when the weather is rain for the 
      abilities rain dish and dry skin.
  ai_confused_no_attack_chance:
    pos: 0x7b00
    type: s2
    doc: The percentage chance of the AI not attacking when it is confused.
  leech_seed_hp_drain:
    pos: 0x7b08
    type: s2
    doc: The amount of health drained by leech seed status.
  exclusive_item_exp_boost:
    pos: 0x7b0c
    type: s2
    doc: The percentage increase in experience from exp-boosting exclusive 
      items.
  aftermath_chance:
    pos: 0x7b14
    type: s2
    doc: The chance of the Aftermath ability activating, as a percentage (50%).
  set_damage_status_damage:
    pos: 0x7b18
    type: s2
    doc: The fixed amount of damage dealt when the Set Damage status condition 
      is active (30).
  intimidator_activation_chance:
    pos: 0x7b38
    type: s2
    doc: The percentage chance that Intimidator will activate.
  type_advantage_master_crit_rate:
    pos: 0x7b60
    type: s2
    doc: The flat critical hit rate with Type-Advantage Master, 40%.
  oran_berry_hp_restoration:
    pos: 0x7b6c
    type: s2
    doc: The amount of HP restored by eating a Oran Berry.
  sitrus_berry_full_hp_boost:
    pos: 0x7b74
    type: s2
    doc: The permanent HP boost from eating a Sitrus Berry at full HP.
  snore_cringe_chance:
    pos: 0x7b80
    type: s2
    doc: The chance of Snore inflicting the cringe status, as a percentage 
      (30%).
  meteor_mash_boost_attack_chance:
    pos: 0x7b84
    type: s2
    doc: The chance of Meteor Mash boosting attack, as a percentage (20%).
  crush_claw_lower_defense_chance:
    pos: 0x7b88
    type: s2
    doc: The chance of Crush Claw lowering defense, as a percentage (50%).
  burn_damage_cooldown:
    pos: 0x7b90
    type: s2
    doc: The number of turns between passive burn damage.
  shadow_ball_lower_special_defense_chance:
    pos: 0x7b9c
    type: s2
    doc: The chance of Shadow Ball lowering special defense, as a percentage 
      (20%).
  stick_power:
    pos: 0x7ba4
    type: s2
    doc: Attack power for Sticks.
  bubble_lower_speed_chance:
    pos: 0x7bac
    type: s2
    doc: The chance of Bubble lowering speed, as a percentage (10%).
  ice_body_bonus_regen:
    pos: 0x7bb0
    type: s2
    doc: The passive bonus health regen given when the weather is hail for the 
      ability ice body.
  powder_snow_freeze_chance:
    pos: 0x7bb4
    type: s2
    doc: The chance of Powder Snow (and others, see DoMoveDamageFreeze15) 
      freezing, as a percentage (15%).
  poison_sting_poison_chance:
    pos: 0x7bbc
    type: s2
    doc: The chance of Poison Sting (and others, see DoMoveDamagePoison18) 
      poisoning, as a percentage (18%).
  spawn_cooldown_thief_alert:
    pos: 0x7bc0
    type: s2
    doc: The number of turns between enemy spawns when the Thief Alert condition
      is active.
  poison_fang_poison_chance:
    pos: 0x7bc4
    type: s2
    doc: The chance of Poison Fang poisoning, as a percentage (30%).
  weather_move_turn_count:
    pos: 0x7bd4
    type: s2
    doc: The number of turns the moves rain dance, hail, sandstorm, sunny day 
      and defog change the weather for. (3000)
  thunder_paralyze_chance:
    pos: 0x7bd8
    type: s2
    doc: The chance of Thunder (and others, see DoMoveDamageParalyze20) 
      paralyzing, as a percentage (20%)
  thunderbolt_paralyze_chance:
    pos: 0x7bdc
    type: s2
    doc: The chance of Thunderbolt paralyzing, as a percentage (15%).
  monster_house_max_monster_spawns:
    pos: 0x7be0
    type: s2
    doc: The maximum number of monster spawns in a Monster House, 30, but 
      multiplied by 2/3 for some reason (so the actual maximum is 45)
  twister_cringe_chance:
    pos: 0x7be8
    type: s2
    doc: The chance of Twister inflicting the cringe status, as a percentage 
      (10%).
  speed_boost_turns:
    pos: 0x7bec
    type: s2
    doc: Number of turns (250) after which Speed Boost will trigger and increase
      speed by one stage.
  fake_out_cringe_chance:
    pos: 0x7bf0
    type: s2
    doc: The chance of Fake Out inflicting the cringe status, as a percentage 
      (35%).
  thunder_fang_cringe_chance:
    pos: 0x7bf8
    type: s2
    doc: The chance of Thunder Fang inflicting the cringe status, as a 
      percentage (25%).
  flare_blitz_burn_chance:
    pos: 0x7c04
    type: s2
    doc: The chance of Flare Blitz burning, as a percentage (25%). This value is
      also used for the Fire Fang burn chance.
  flame_wheel_burn_chance:
    pos: 0x7c08
    type: s2
    doc: The chance of Flame Wheel (and others, see 
      DoMoveDamageBurn10FlameWheel) burning, as a percentage (10%).
  psybeam_confuse_chance:
    pos: 0x7c10
    type: s2
    doc: The chance of Psybeam (and others, see DoMoveDamageConfuse10) 
      confusing, as a percentage (10%).
  tri_attack_status_chance:
    pos: 0x7c14
    type: s2
    doc: The chance of Tri Attack inflicting any status condition, as a 
      percentage (20%).
  miracle_chest_exp_boost:
    pos: 0x7c18
    type: s2
    doc: The percentage increase in experience from the Miracle Chest item
  wonder_chest_exp_boost:
    pos: 0x7c1c
    type: s2
    doc: The percentage increase in experience from the Wonder Chest item
  spawn_cap_with_monster_house:
    pos: 0x7c24
    type: s2
    doc: The maximum number of enemies that can spawn on a floor with a monster 
      house, not counting those in the monster house (4).
  poison_damage_cooldown:
    pos: 0x7c28
    type: s2
    doc: The number of turns between passive poison damage.
  leech_seed_damage_cooldown:
    pos: 0x7c2c
    type: s2
    doc: The number of turns between leech seed health drain.
  thrown_item_hit_chance:
    pos: 0x7c30
    type: s2
    doc: Chance of a hurled item hitting the target (90%).
  geo_pebble_damage:
    pos: 0x7c34
    type: s2
    doc: Damage dealt by Geo Pebbles.
  gravelerock_damage:
    pos: 0x7c38
    type: s2
    doc: Damage dealt by Gravelerocks.
  rare_fossil_damage:
    pos: 0x7c3c
    type: s2
    doc: Damage dealt by Rare Fossils.
  ginseng_chance_3:
    pos: 0x7c40
    type: s2
    doc: The percentage chance for Ginseng to boost a move's power by 3 (12%).
  zinc_stat_boost:
    pos: 0x7c44
    type: s2
    doc: The permanent special defense boost from ingesting a Zinc.
  iron_stat_boost:
    pos: 0x7c48
    type: s2
    doc: The permanent defense boost from ingesting an Iron.
  calcium_stat_boost:
    pos: 0x7c4c
    type: s2
    doc: The permanent special attack boost from ingesting a Calcium.
  wish_bonus_regen:
    pos: 0x7c50
    type: s2
    doc: The passive bonus regen given by the wish status condition.
  dragon_rage_fixed_damage:
    pos: 0x7c54
    type: s2
    doc: The amount of fixed damage dealt by Dragon Rage (30).
  corsola_twig_power:
    pos: 0x7c58
    type: s2
    doc: Attack power for Corsola Twigs.
  cacnea_spike_power:
    pos: 0x7c5c
    type: s2
    doc: Attack power for Cacnea Spikes.
  gold_fang_power:
    pos: 0x7c60
    type: s2
    doc: Attack power for Gold Fangs.
  silver_spike_power:
    pos: 0x7c64
    type: s2
    doc: Attack power for Silver Spikes.
  iron_thorn_power:
    pos: 0x7c68
    type: s2
    doc: Attack power for Iron Thorns.
  scope_lens_crit_rate_boost:
    pos: 0x7c70
    type: s2
    doc: The critical hit rate (additive) boost from the Scope Lens/Patsy Band 
      items and the Sharpshooter IQ skill, 15%.
  healing_wish_hp_restoration:
    pos: 0x7c74
    type: s2
    doc: The amount of HP restored by Healing Wish (999). This also applies to 
      Lunar Dance.
  me_first_multiplier:
    pos: 0x7c90
    type: s4
    doc: The damage multiplier applied to attacks copied by Me First, as a 
      fixed-point number with 8 fraction bits (1.5).
  facade_damage_multiplier:
    pos: 0x7c98
    type: s4
    doc: The Facade damage multiplier for users with a status condition, as a 
      binary fixed-point number with 8 fraction bits (0x200 -> 2x).
  imprison_turn_range:
    pos: 0x7c9c
    type: imprison_turn_range_array
    doc: |-
      The turn range for the Paused status inflicted by Imprison, [3, 6).

      type: int16_t[2]
  sleep_turn_range:
    pos: 0x7ca0
    type: sleep_turn_range_array
    doc: |-
      Appears to control the range of turns for which the sleep condition can last.

      The first two bytes are the low value of the range, and the later two bytes are the high value.
  nightmare_turn_range:
    pos: 0x7ca4
    type: nightmare_turn_range_array
    doc: |-
      The turn range for the Nightmare status inflicted by Nightmare, [4, 8).

      type: int16_t[2]
  burn_damage_multiplier:
    pos: 0x7cc4
    type: s4
    doc: |-
      The extra damage multiplier for moves when the attacker is burned, as a fixed-point number with 8 fraction bits (the raw value is 0xCC, which is close to 0.8).

      Unlike in the main series, this multiplier is applied regardless of whether the move being used is physical or special.
  rest_turn_range:
    pos: 0x7cc8
    type: rest_turn_range_array
    doc: |-
      The turn range for the Napping status inflicted by Rest, [1, 4).

      type: int16_t[2]
  matchup_super_effective_multiplier_erratic_player:
    pos: 0x7ccc
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_SUPER_EFFECTIVE when 
      Erratic Player is active, as a fixed-point number with 8 fraction bits 
      (the raw value is 0x1B3, the closest possible representation of 1.7).
  matchup_immune_multiplier:
    pos: 0x7cd8
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_IMMUNE, as a fixed-point
      number with 8 fraction bits (0.5).
  sport_condition_turn_range:
    pos: 0x7d0c
    type: sport_condition_turn_range_array
    doc: |-
      The turn range for the sport conditions activated by Mud Sport and Water Sport, [10, 12).

      type: int16_t[2]
  sure_shot_turn_range:
    pos: 0x7d18
    type: sure_shot_turn_range_array
    doc: |-
      The turn range for the Sure Shot status inflicted by Mind Reader and Lock-On, [10, 12).

      type: int16_t[2]
  detect_band_move_accuracy_drop:
    pos: 0x7d28
    type: s4
    doc: The (subtractive) move accuracy drop induced on an attacker if the 
      defender is wearing a Detect Band (30).
  tinted_lens_multiplier:
    pos: 0x7d40
    type: s4
    doc: The extra damage multiplier for not-very-effective moves when Tinted 
      Lens is active, as a fixed-point number with 8 fraction bits (the raw 
      value is 0x133, the closest possible representation of 1.2).
  smokescreen_turn_range:
    pos: 0x7d44
    type: smokescreen_turn_range_array
    doc: |-
      The turn range for the Whiffer status inflicted by Smokescreen, [1, 4).

      type: int16_t[2]
  perish_song_turn_range:
    pos: 0x7d50
    type: perish_song_turn_range_array
    doc: |-
      The turn range for the status inflicted by Perish Song, [3, 3).

      type: int16_t[2]
  shadow_force_damage_multiplier:
    pos: 0x7d5c
    type: s4
    doc: The damage multiplier for Shadow Force, as a fixed-point number with 8 
      fraction bits (2).
  dig_damage_multiplier:
    pos: 0x7d64
    type: s4
    doc: The damage multiplier for Dig, as a fixed-point number with 8 fraction 
      bits (2).
  dive_damage_multiplier:
    pos: 0x7d68
    type: s4
    doc: The damage multiplier for Dive, as a fixed-point number with 8 fraction
      bits (2).
  bounce_damage_multiplier:
    pos: 0x7d6c
    type: s4
    doc: The damage multiplier for Bounce, as a fixed-point number with 8 
      fraction bits (2).
  power_pitcher_damage_multiplier:
    pos: 0x7d78
    type: s4
    doc: The multiplier for projectile damage from Power Pitcher (1.5), as a 
      binary fixed-point number (8 fraction bits)
  quick_dodger_move_accuracy_drop:
    pos: 0x7d88
    type: s4
    doc: The (subtractive) move accuracy drop induced on an attacker if the 
      defender has the Quick Dodger IQ skill (10).
  matchup_not_very_effective_multiplier:
    pos: 0x7d90
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_NOT_VERY_EFFECTIVE, as a
      fixed-point number with 8 fraction bits (the raw value is 0x1B4, the 
      closest possible representation of 1/√2).
  matchup_super_effective_multiplier:
    pos: 0x7d98
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_SUPER_EFFECTIVE, as a 
      fixed-point number with 8 fraction bits (the raw value is 0x166, the 
      closest possible representation of 1.4).
  matchup_neutral_multiplier:
    pos: 0x7d9c
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_NEUTRAL, as a 
      fixed-point number with 8 fraction bits (1).
  matchup_immune_multiplier_erratic_player:
    pos: 0x7da0
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_IMMUNE when Erratic 
      Player is active, as a fixed-point number with 8 fraction bits (0.25).
  matchup_not_very_effective_multiplier_erratic_player:
    pos: 0x7da4
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_NOT_VERY_EFFECTIVE when 
      Erratic Player is active, as a fixed-point number with 8 fraction bits 
      (0.5).
  matchup_neutral_multiplier_erratic_player:
    pos: 0x7dac
    type: s4
    doc: The damage multiplier corresponding to MATCHUP_NEUTRAL when Erratic 
      Player is active, as a fixed-point number with 8 fraction bits (1).
  air_blade_damage_multiplier:
    pos: 0x7dc4
    type: s4
    doc: The multiplier for damage from the Air Blade (1.5), as a binary 
      fixed-point number (8 fraction bits)
  kecleon_shop_boost_chance_multiplier:
    pos: 0x7dcc
    type: s4
    doc: The boosted kecleon shop spawn chance multiplier (~1.2) as a binary 
      fixed-point number (8 fraction bits).
  hidden_stairs_spawn_chance_multiplier:
    pos: 0x7dd0
    type: s4
    doc: The hidden stairs spawn chance multiplier (~1.2) as a binary 
      fixed-point number (8 fraction bits), if applicable. See 
      ShouldBoostHiddenStairsSpawnChance in overlay 29.
  yawn_turn_range:
    pos: 0x7de0
    type: yawn_turn_range_array
    doc: |-
      The turn range for the Yawning status inflicted by Yawn, [2, 2].

      type: int16_t[2]
  speed_boost_turn_range:
    pos: 0x7e08
    type: speed_boost_turn_range_array
    doc: |-
      Appears to control the range of turns for which a speed boost can last.

      The first two bytes are the low value of the range, and the later two bytes are the high value.
  solarbeam_damage_multiplier:
    pos: 0x7e24
    type: s4
    doc: The default damage multiplier for SolarBeam, as a fixed-point number 
      with 8 fraction bits (2).
  sky_attack_damage_multiplier:
    pos: 0x7e28
    type: s4
    doc: The damage multiplier for Sky Attack, as a fixed-point number with 8 
      fraction bits (2).
  razor_wind_damage_multiplier:
    pos: 0x7e30
    type: s4
    doc: The damage multiplier for Razor Wind, as a fixed-point number with 8 
      fraction bits (2).
  focus_punch_damage_multiplier:
    pos: 0x7e34
    type: s4
    doc: The damage multiplier for Focus Punch, as a fixed-point number with 8 
      fraction bits (2).
  skull_bash_damage_multiplier:
    pos: 0x7e3c
    type: s4
    doc: The damage multiplier for Skull Bash, as a fixed-point number with 8 
      fraction bits (2).
  fly_damage_multiplier:
    pos: 0x7e40
    type: s4
    doc: The damage multiplier for Fly, as a fixed-point number with 8 fraction 
      bits (2).
  weather_ball_type_table:
    pos: 0x7e5c
    type: weather_ball_type_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding Weather Ball type.

      type: struct type_id_8[8]
  ai_regular_attack_weights:
    pos: 0x7e80
    type: ai_regular_attack_weights_array
    doc: |-
      The weight of the regular attack in the weighted random when the AI is deciding which move to use, depending on how many other attacks the AI can currently use.
      Each index in the array corresponds to the number of attacks (0-4) the AI can use (i.e., is enabled and has PP remaining).

      type: uint16_t[5]
  last_resort_damage_mult_table:
    pos: 0x7ec4
    type: last_resort_damage_mult_table_array
    doc: |-
      Table of damage multipliers for Last Resort for different numbers of moves out of PP, where each entry is a binary fixed-point number with 8 fraction bits.

      If n is the number of moves out of PP not counting Last Resort itself, the table is indexed by (n - 1).

      type: int[4]
  synthesis_hp_restoration_table:
    pos: 0x7ed4
    type: synthesis_hp_restoration_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Synthesis.

      type: int16_t[8]
  roost_hp_restoration_table:
    pos: 0x7ee4
    type: roost_hp_restoration_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Roost.

      Every entry in this table is 40.

      type: int16_t[8]
  moonlight_hp_restoration_table:
    pos: 0x7ef4
    type: moonlight_hp_restoration_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Moonlight.

      type: int16_t[8]
  morning_sun_hp_restoration_table:
    pos: 0x7f04
    type: morning_sun_hp_restoration_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Morning Sun.

      type: int16_t[8]
  reversal_damage_mult_table:
    pos: 0x7f14
    type: reversal_damage_mult_table_array
    doc: |-
      Table of damage multipliers for Reversal/Flail at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
  water_spout_damage_mult_table:
    pos: 0x7f24
    type: water_spout_damage_mult_table_array
    doc: |-
      Table of damage multipliers for Water Spout at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
  wring_out_damage_mult_table:
    pos: 0x7f34
    type: wring_out_damage_mult_table_array
    doc: |-
      Table of damage multipliers for Wring Out/Crush Grip at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
  eruption_damage_mult_table:
    pos: 0x7f44
    type: eruption_damage_mult_table_array
    doc: |-
      Table of damage multipliers for Eruption at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
  weather_ball_damage_mult_table:
    pos: 0x80d4
    type: weather_ball_damage_mult_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding Weather Ball damage multiplier, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[8]
  eat_item_effect_ignore_list:
    pos: 0x80f4
    type: eat_item_effect_ignore_list_array
    doc: List of item IDs that should be ignored by the ShouldTryEatItem 
      function. The last entry is null.
  castform_weather_attribute_table:
    pos: 0x81ec
    type: castform_weather_attribute_table_array
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding Castform type and form.

      type: struct castform_weather_attributes[8]
  bad_poison_damage_table:
    pos: 0x821c
    type: bad_poison_damage_table_array
    doc: Table for how much damage each tick of badly poisoned should deal. The 
      table is filled with 0x0006, but could use different values for each 
      entry.
  type_matchup_combinator_table:
    pos: 0x8294
    type: type_matchup_combinator_table
    doc: |-
      Table of type matchup combinations.

      Each row corresponds to a single type matchup that results from combining two individual type matchups together. For example, combining MATCHUP_NOT_VERY_EFFECTIVE with MATCHUP_SUPER_EFFECTIVE results in MATCHUP_NEUTRAL.

      type: struct type_matchup_combinator_table
  offensive_stat_stage_multipliers:
    pos: 0x8318
    type: offensive_stat_stage_multipliers_array
    doc: Table of multipliers for offensive stats (attack/special attack) for 
      each stage 0-20, as binary fixed-point numbers (8 fraction bits)
  defensive_stat_stage_multipliers:
    pos: 0x836c
    type: defensive_stat_stage_multipliers_array
    doc: Table of multipliers for defensive stats (defense/special defense) for 
      each stage 0-20, as binary fixed-point numbers (8 fraction bits)
  nature_power_table:
    pos: 0x83c0
    type: nature_power_table_array
    doc: |-
      Maps enum nature_power_variant to the associated move ID and effect handler.

      type: struct wildcard_move_desc[15]
  apples_and_berries_item_ids:
    pos: 0x8438
    type: apples_and_berries_item_ids_array
    doc: |-
      Table of item IDs for Apples and Berries, which trigger the exclusive item effect EXCLUSIVE_EFF_RECOVER_HP_FROM_APPLES_AND_BERRIES.

      type: struct item_id_16[66]
  recruitment_level_boost_table:
    pos: 0x85e4
    type: recruitment_level_boost_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[102]
  natural_gift_item_table:
    pos: 0x86b0
    type: natural_gift_item_table_array
    doc: |-
      Maps items to their type and base power if used with Natural Gift.

      Any item not listed in this table explicitly will be Normal type with a base power of 1 when used with Natural Gift.

      type: struct natural_gift_item_info[34]
  random_music_id_table:
    pos: 0x877c
    type: random_music_id_table_array
    doc: |-
      Table of music IDs for dungeons with a random assortment of music tracks.

      This is a table with 30 rows, each with 4 2-byte music IDs. Each row contains the possible music IDs for a given group, from which the music track will be selected randomly.

      type: struct music_id_16[30][4]
  shop_item_chances:
    pos: 0x886c
    type: shop_item_chances_array
    doc: |-
      8 * 6 * 3 * 0x2

      Note: unverified, ported from Irdkwia's notes
  male_accuracy_stage_multipliers:
    pos: 0x898c
    type: male_accuracy_stage_multipliers_array
    doc: Table of multipliers for the accuracy stat for males for each stage 
      0-20, as binary fixed-point numbers (8 fraction bits)
  male_evasion_stage_multipliers:
    pos: 0x89e0
    type: male_evasion_stage_multipliers_array
    doc: Table of multipliers for the evasion stat for males for each stage 
      0-20, as binary fixed-point numbers (8 fraction bits)
  female_accuracy_stage_multipliers:
    pos: 0x8a34
    type: female_accuracy_stage_multipliers_array
    doc: Table of multipliers for the accuracy stat for females for each stage 
      0-20, as binary fixed-point numbers (8 fraction bits)
  female_evasion_stage_multipliers:
    pos: 0x8a88
    type: female_evasion_stage_multipliers_array
    doc: Table of multipliers for the evasion stat for females for each stage 
      0-20, as binary fixed-point numbers (8 fraction bits)
  music_id_table:
    pos: 0x8adc
    type: music_id_table_array
    doc: |-
      List of music IDs used in dungeons with a single music track.

      This is an array of 170 2-byte music IDs, and is indexed into by the music value in the floor properties struct for a given floor. Music IDs with the highest bit set (0x8000) are indexes into the RANDOM_MUSIC_ID_TABLE.

      type: struct music_id_16[170] (or not a music ID if the highest bit is set)
  type_matchup_table:
    pos: 0x8c30
    type: type_matchup_table
    doc: |-
      Table of type matchups.

      Each row corresponds to the type matchups of a specific attack type, with each entry within the row specifying the type's effectiveness against a target type.

      type: struct type_matchup_table
  fixed_room_monster_spawn_stats_table:
    pos: 0x8eb8
    type: fixed_room_monster_spawn_stats_table_array
    doc: |-
      Table of stats for monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_MONSTER_SPAWN_TABLE.

      This is an array of 99 12-byte entries containing stat spreads for one monster entry each.

      type: struct fixed_room_monster_spawn_stats_entry[99]
  metronome_table:
    pos: 0x935c
    type: metronome_table_array
    doc: |-
      Something to do with the moves that Metronome can turn into.

      type: struct wildcard_move_desc[168]
  tileset_properties:
    pos: 0x989c
    type: tileset_properties_array
    doc: 'type: struct tileset_property[199]'
  fixed_room_properties_table:
    pos: 0xa1f0
    type: fixed_room_properties_table_array
    doc: |-
      Table of properties for fixed rooms.

      This is an array of 256 12-byte entries containing properties for a given fixed room ID.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct fixed_room_properties_entry[256]
  trap_animation_info:
    pos: 0xafd0
    type: trap_animation_info_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct trap_animation[26]
  item_animation_info:
    pos: 0xb004
    type: item_animation_info_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct item_animation[1400]
  move_animation_info:
    pos: 0xc5e4
    type: move_animation_info_array
    doc: 'type: struct move_animation[563]'
  effect_animation_info:
    pos: 0xfaac
    type: effect_animation_info_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct effect_animation[700]
  special_monster_move_animation_info:
    pos: 0x1473c
    type: special_monster_move_animation_info_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct special_monster_move_animation[7422]
