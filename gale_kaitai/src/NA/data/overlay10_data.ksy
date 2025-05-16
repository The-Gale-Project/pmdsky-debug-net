meta:
  id: overlay10_data
  endian: le
instances:
  inventory_menu_default_window_params:
    pos: 0x7914
    doc: |-
      Default window_params for an inventory_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateInventoryMenu.

      Additionally, width and height are 0, and will be computed in CreateInventoryMenu.
    type: window_params
  first_dungeon_with_monster_house_traps:
    pos: 0x798c
    doc: |-
      The first dungeon that can have extra traps spawn in Monster Houses, Dark Hill

      type: struct dungeon_id_8
    size: 0x1
  bad_poison_damage_cooldown:
    pos: 0x7994
    doc: The number of turns between passive bad poison (toxic) damage.
    type: s2
  protein_stat_boost:
    pos: 0x79a0
    doc: The permanent attack boost from ingesting a Protein.
    type: s2
  waterfall_cringe_chance:
    pos: 0x79a4
    doc: The chance of Waterfall inflicting the cringe status, as a percentage (30%).
    type: s2
  aurora_beam_lower_attack_chance:
    pos: 0x79a8
    doc: The chance of Aurora Beam halving attack, as a percentage (60%).
    type: s2
  spawn_cap_no_monster_house:
    pos: 0x79b0
    doc: The maximum number of enemies that can spawn on a floor without a monster
      house (15).
    type: s2
  oren_berry_damage:
    pos: 0x79b8
    doc: Damage dealt by eating an Oren Berry.
    type: s2
  iron_tail_lower_defense_chance:
    pos: 0x79c0
    doc: The chance of Iron Tail lowering defense, as a percentage (30%).
    type: s2
  twineedle_poison_chance:
    pos: 0x79c4
    doc: The chance of Twineedle poisoning, as a percentage (20%).
    type: s2
  extrasensory_cringe_chance:
    pos: 0x79c8
    doc: The chance of Extrasensory (and others, see DoMoveDamageCringe10) inflicting
      the cringe status, as a percentage (10%).
    type: s2
  rock_slide_cringe_chance:
    pos: 0x79cc
    doc: The chance of Rock Slide (and others, see DoMoveDamageCringe30) inflicting
      the cringe status, as a percentage (30%).
    type: s2
  crunch_lower_defense_chance:
    pos: 0x79d0
    doc: The chance of Crunch (and others, see DoMoveDamageLowerDef20) lowering defense,
      as a percentage (20%).
    type: s2
  trap_buster_activation_chance:
    pos: 0x79dc
    doc: The chance of Trap Buster activating (30%).
    type: s2
  forewarn_forced_miss_chance:
    pos: 0x79e8
    doc: The chance of Forewarn forcing a move to miss, as a percentage (20%).
    type: s2
  unown_stone_drop_chance:
    pos: 0x79f4
    doc: The chance of an Unown dropping an Unown stone, as a percentage (33%).
    type: s2
  sitrus_berry_hp_restoration:
    pos: 0x79f8
    doc: The amount of HP restored by eating a Sitrus Berry.
    type: s2
  muddy_water_lower_accuracy_chance:
    pos: 0x7a04
    doc: The chance of Muddy Water (and others, see DoMoveDamageLowerAccuracy40) lowering
      accuracy, as a percentage (40%).
    type: s2
  silver_wind_boost_chance:
    pos: 0x7a08
    doc: The chance of Silver Wind (and others, see DoMoveDamageBoostAllStats) boosting
      all stats, as a percentage (20%).
    type: s2
  poison_tail_poison_chance:
    pos: 0x7a0c
    doc: The chance of Poison Tail poisoning, as a percentage (10%).
    type: s2
  thundershock_paralyze_chance:
    pos: 0x7a10
    doc: The chance of Thundershock paralyzing, as a percentage (10%).
    type: s2
  bounce_paralyze_chance:
    pos: 0x7a14
    doc: The chance of Bounce paralyzing, as a percentage (30%)
    type: s2
  headbutt_cringe_chance:
    pos: 0x7a18
    doc: The chance of Headbutt inflicting the cringe status, as a percentage (25%).
    type: s2
  fire_fang_cringe_chance:
    pos: 0x7a1c
    doc: The chance of Fire Fang inflicting the cringe status, as a percentage (25%).
    type: s2
  sacred_fire_burn_chance:
    pos: 0x7a20
    doc: The chance of Sacred Fire burning, as a percentage (50%).
    type: s2
  whirlpool_constriction_chance:
    pos: 0x7a24
    doc: The chance of Whirlpool inflicting the constriction status, as a percentage
      (10%).
    type: s2
  exp_elite_exp_boost:
    pos: 0x7a28
    doc: The percentage increase in experience from the Exp. Elite IQ skill
    type: s2
  monster_house_max_non_monster_spawns:
    pos: 0x7a2c
    doc: The maximum number of extra non-monster spawns (items/traps) in a Monster
      House, 7
    type: s2
  heal_order_hp_restoration:
    pos: 0x7a38
    doc: The amount of HP restored by Heal Order (40).
    type: s2
  steel_wing_boost_defense_chance:
    pos: 0x7a44
    doc: The chance of Steel Wing boosting defense, as a percentage (20%).
    type: s2
  gold_thorn_power:
    pos: 0x7a50
    doc: Attack power for Golden Thorns.
    type: s2
  burn_damage:
    pos: 0x7a54
    doc: Damage dealt by the burn status condition.
    type: s2
  poison_damage:
    pos: 0x7a58
    doc: Damage dealt by the poison status condition.
    type: s2
  spawn_cooldown:
    pos: 0x7a5c
    doc: The number of turns between enemy spawns under normal conditions.
    type: s2
  mist_ball_lower_special_attack_chance:
    pos: 0x7a60
    doc: The chance of Mist Ball lowering special attack, as a percentage (50%).
    type: s2
  charge_beam_boost_special_attack_chance:
    pos: 0x7a70
    doc: The chance of Charge Beam boosting special attack, as a percentage (40%).
    type: s2
  oran_berry_full_hp_boost:
    pos: 0x7a74
    doc: The permanent HP boost from eating an Oran Berry at full HP (0).
    type: s2
  life_seed_hp_boost:
    pos: 0x7a78
    doc: The permanent HP boost from eating a Life Seed.
    type: s2
  octazooka_lower_accuracy_chance:
    pos: 0x7a80
    doc: The chance of Octazooka lowering accuracy, as a percentage (60%).
    type: s2
  luster_purge_lower_special_defense_chance:
    pos: 0x7a8c
    doc: The chance of Luster Purge (and others, see DoMoveDamageLowerSpecialDefense50)
      lowering special defense, as a percentage (50%).
    type: s2
  super_luck_crit_rate_boost:
    pos: 0x7a90
    doc: The critical hit rate (additive) boost from Super Luck, 10%.
    type: s2
  constrict_lower_speed_chance:
    pos: 0x7a94
    doc: The chance of Constrict (and others, see DoMoveDamageLowerSpeed20) lowering
      speed, as a percentage (20%).
    type: s2
  ice_fang_freeze_chance:
    pos: 0x7a98
    doc: The chance of Ice Fang freezing, as a percentage (15%).
    type: s2
  smog_poison_chance:
    pos: 0x7a9c
    doc: The chance of Smog (and others, see DoMoveDamagePoison40) poisoning, as a
      percentage (40%).
    type: s2
  lick_paralyze_chance:
    pos: 0x7aa8
    doc: The chance of Lick (and others, see DoMoveDamageParalyze10) paralyzing, as
      a percentage (10%).
    type: s2
  thunder_fang_paralyze_chance:
    pos: 0x7aac
    doc: The chance of Thunder Fang paralyzing, as a percentage (10%).
    type: s2
  bite_cringe_chance:
    pos: 0x7ab4
    doc: The chance of Bite (and others, see DoMoveDamageCringe20) inflicting the
      cringe status, as a percentage (20%)
    type: s2
  sky_attack_cringe_chance:
    pos: 0x7ab8
    doc: The chance of Sky Attack inflicting the cringe status, as a percentage (25%).
    type: s2
  ice_fang_cringe_chance:
    pos: 0x7abc
    doc: The chance of Ice Fang inflicting the cringe status, as a percentage (25%).
    type: s2
  blaze_kick_burn_chance:
    pos: 0x7ac0
    doc: The chance of Blaze Kick burning, as a percentage (10%).
    type: s2
  flamethrower_burn_chance:
    pos: 0x7ac4
    doc: The chance of Flamethrower (and others, see DoMoveDamageBurn10) burning,
      as a percentage (10%).
    type: s2
  dizzy_punch_confuse_chance:
    pos: 0x7ac8
    doc: The chance of Dizzy Punch (and others, see DoMoveDamageConfuse30) confusing,
      as a percentage (30%).
    type: s2
  secret_power_effect_chance:
    pos: 0x7acc
    doc: The chance of Secret Power inflicting an effect, as a percentage (30%).
    type: s2
  metal_claw_boost_attack_chance:
    pos: 0x7ad4
    doc: The chance of Metal Claw boosting attack, as a percentage (20%).
    type: s2
  technician_move_power_threshold:
    pos: 0x7adc
    doc: The move power threshold for Technician (4). Moves whose base power doesn't
      exceed this value will receive a 50% damage boost.
    type: s2
  sonicboom_fixed_damage:
    pos: 0x7ae8
    doc: The amount of fixed damage dealt by SonicBoom (20).
    type: s2
  rain_ability_bonus_regen:
    pos: 0x7af8
    doc: The passive bonus health regen given when the weather is rain for the abilities
      rain dish and dry skin.
    type: s2
  leech_seed_hp_drain:
    pos: 0x7b08
    doc: The amount of health drained by leech seed status.
    type: s2
  exclusive_item_exp_boost:
    pos: 0x7b0c
    doc: The percentage increase in experience from exp-boosting exclusive items.
    type: s2
  aftermath_chance:
    pos: 0x7b14
    doc: The chance of the Aftermath ability activating, as a percentage (50%).
    type: s2
  set_damage_status_damage:
    pos: 0x7b18
    doc: The fixed amount of damage dealt when the Set Damage status condition is
      active (30).
    type: s2
  intimidator_activation_chance:
    pos: 0x7b38
    doc: The percentage chance that Intimidator will activate.
    type: s2
  type_advantage_master_crit_rate:
    pos: 0x7b60
    doc: The flat critical hit rate with Type-Advantage Master, 40%.
    type: s2
  oran_berry_hp_restoration:
    pos: 0x7b6c
    doc: The amount of HP restored by eating a Oran Berry.
    type: s2
  sitrus_berry_full_hp_boost:
    pos: 0x7b74
    doc: The permanent HP boost from eating a Sitrus Berry at full HP.
    type: s2
  snore_cringe_chance:
    pos: 0x7b80
    doc: The chance of Snore inflicting the cringe status, as a percentage (30%).
    type: s2
  meteor_mash_boost_attack_chance:
    pos: 0x7b84
    doc: The chance of Meteor Mash boosting attack, as a percentage (20%).
    type: s2
  crush_claw_lower_defense_chance:
    pos: 0x7b88
    doc: The chance of Crush Claw lowering defense, as a percentage (50%).
    type: s2
  burn_damage_cooldown:
    pos: 0x7b90
    doc: The number of turns between passive burn damage.
    type: s2
  shadow_ball_lower_special_defense_chance:
    pos: 0x7b9c
    doc: The chance of Shadow Ball lowering special defense, as a percentage (20%).
    type: s2
  stick_power:
    pos: 0x7ba4
    doc: Attack power for Sticks.
    type: s2
  bubble_lower_speed_chance:
    pos: 0x7bac
    doc: The chance of Bubble lowering speed, as a percentage (10%).
    type: s2
  ice_body_bonus_regen:
    pos: 0x7bb0
    doc: The passive bonus health regen given when the weather is hail for the ability
      ice body.
    type: s2
  powder_snow_freeze_chance:
    pos: 0x7bb4
    doc: The chance of Powder Snow (and others, see DoMoveDamageFreeze15) freezing,
      as a percentage (15%).
    type: s2
  poison_sting_poison_chance:
    pos: 0x7bbc
    doc: The chance of Poison Sting (and others, see DoMoveDamagePoison18) poisoning,
      as a percentage (18%).
    type: s2
  spawn_cooldown_thief_alert:
    pos: 0x7bc0
    doc: The number of turns between enemy spawns when the Thief Alert condition is
      active.
    type: s2
  poison_fang_poison_chance:
    pos: 0x7bc4
    doc: The chance of Poison Fang poisoning, as a percentage (30%).
    type: s2
  weather_move_turn_count:
    pos: 0x7bd4
    doc: The number of turns the moves rain dance, hail, sandstorm, sunny day and
      defog change the weather for. (3000)
    type: s2
  thunder_paralyze_chance:
    pos: 0x7bd8
    doc: The chance of Thunder (and others, see DoMoveDamageParalyze20) paralyzing,
      as a percentage (20%)
    type: s2
  thunderbolt_paralyze_chance:
    pos: 0x7bdc
    doc: The chance of Thunderbolt paralyzing, as a percentage (15%).
    type: s2
  monster_house_max_monster_spawns:
    pos: 0x7be0
    doc: The maximum number of monster spawns in a Monster House, 30, but multiplied
      by 2/3 for some reason (so the actual maximum is 45)
    type: s2
  twister_cringe_chance:
    pos: 0x7be8
    doc: The chance of Twister inflicting the cringe status, as a percentage (10%).
    type: s2
  speed_boost_turns:
    pos: 0x7bec
    doc: Number of turns (250) after which Speed Boost will trigger and increase speed
      by one stage.
    type: s2
  fake_out_cringe_chance:
    pos: 0x7bf0
    doc: The chance of Fake Out inflicting the cringe status, as a percentage (35%).
    type: s2
  thunder_fang_cringe_chance:
    pos: 0x7bf8
    doc: The chance of Thunder Fang inflicting the cringe status, as a percentage
      (25%).
    type: s2
  flare_blitz_burn_chance:
    pos: 0x7c04
    doc: The chance of Flare Blitz burning, as a percentage (25%). This value is also
      used for the Fire Fang burn chance.
    type: s2
  flame_wheel_burn_chance:
    pos: 0x7c08
    doc: The chance of Flame Wheel (and others, see DoMoveDamageBurn10FlameWheel)
      burning, as a percentage (10%).
    type: s2
  psybeam_confuse_chance:
    pos: 0x7c10
    doc: The chance of Psybeam (and others, see DoMoveDamageConfuse10) confusing,
      as a percentage (10%).
    type: s2
  tri_attack_status_chance:
    pos: 0x7c14
    doc: The chance of Tri Attack inflicting any status condition, as a percentage
      (20%).
    type: s2
  miracle_chest_exp_boost:
    pos: 0x7c18
    doc: The percentage increase in experience from the Miracle Chest item
    type: s2
  wonder_chest_exp_boost:
    pos: 0x7c1c
    doc: The percentage increase in experience from the Wonder Chest item
    type: s2
  spawn_cap_with_monster_house:
    pos: 0x7c24
    doc: The maximum number of enemies that can spawn on a floor with a monster house,
      not counting those in the monster house (4).
    type: s2
  poison_damage_cooldown:
    pos: 0x7c28
    doc: The number of turns between passive poison damage.
    type: s2
  leech_seed_damage_cooldown:
    pos: 0x7c2c
    doc: The number of turns between leech seed health drain.
    type: s2
  thrown_item_hit_chance:
    pos: 0x7c30
    doc: Chance of a hurled item hitting the target (90%).
    type: s2
  geo_pebble_damage:
    pos: 0x7c34
    doc: Damage dealt by Geo Pebbles.
    type: s2
  gravelerock_damage:
    pos: 0x7c38
    doc: Damage dealt by Gravelerocks.
    type: s2
  rare_fossil_damage:
    pos: 0x7c3c
    doc: Damage dealt by Rare Fossils.
    type: s2
  ginseng_chance_3:
    pos: 0x7c40
    doc: The percentage chance for Ginseng to boost a move's power by 3 (12%).
    type: s2
  zinc_stat_boost:
    pos: 0x7c44
    doc: The permanent special defense boost from ingesting a Zinc.
    type: s2
  iron_stat_boost:
    pos: 0x7c48
    doc: The permanent defense boost from ingesting an Iron.
    type: s2
  calcium_stat_boost:
    pos: 0x7c4c
    doc: The permanent special attack boost from ingesting a Calcium.
    type: s2
  wish_bonus_regen:
    pos: 0x7c50
    doc: The passive bonus regen given by the wish status condition.
    type: s2
  dragon_rage_fixed_damage:
    pos: 0x7c54
    doc: The amount of fixed damage dealt by Dragon Rage (30).
    type: s2
  corsola_twig_power:
    pos: 0x7c58
    doc: Attack power for Corsola Twigs.
    type: s2
  cacnea_spike_power:
    pos: 0x7c5c
    doc: Attack power for Cacnea Spikes.
    type: s2
  gold_fang_power:
    pos: 0x7c60
    doc: Attack power for Gold Fangs.
    type: s2
  silver_spike_power:
    pos: 0x7c64
    doc: Attack power for Silver Spikes.
    type: s2
  iron_thorn_power:
    pos: 0x7c68
    doc: Attack power for Iron Thorns.
    type: s2
  scope_lens_crit_rate_boost:
    pos: 0x7c70
    doc: The critical hit rate (additive) boost from the Scope Lens/Patsy Band items
      and the Sharpshooter IQ skill, 15%.
    type: s2
  healing_wish_hp_restoration:
    pos: 0x7c74
    doc: The amount of HP restored by Healing Wish (999). This also applies to Lunar
      Dance.
    type: s2
  me_first_multiplier:
    pos: 0x7c90
    doc: The damage multiplier applied to attacks copied by Me First, as a fixed-point
      number with 8 fraction bits (1.5).
    type: s4
  facade_damage_multiplier:
    pos: 0x7c98
    doc: The Facade damage multiplier for users with a status condition, as a binary
      fixed-point number with 8 fraction bits (0x200 -> 2x).
    type: s4
  imprison_turn_range:
    pos: 0x7c9c
    doc: |-
      The turn range for the Paused status inflicted by Imprison, [3, 6).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  sleep_turn_range:
    pos: 0x7ca0
    doc: |-
      Appears to control the range of turns for which the sleep condition can last.

      The first two bytes are the low value of the range, and the later two bytes are the high value.
    type: s2
    repeat: expr
    repeat-expr: 2
  nightmare_turn_range:
    pos: 0x7ca4
    doc: |-
      The turn range for the Nightmare status inflicted by Nightmare, [4, 8).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  burn_damage_multiplier:
    pos: 0x7cc4
    doc: |-
      The extra damage multiplier for moves when the attacker is burned, as a fixed-point number with 8 fraction bits (the raw value is 0xCC, which is close to 0.8).

      Unlike in the main series, this multiplier is applied regardless of whether the move being used is physical or special.
    type: s4
  rest_turn_range:
    pos: 0x7cc8
    doc: |-
      The turn range for the Napping status inflicted by Rest, [1, 4).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  matchup_super_effective_multiplier_erratic_player:
    pos: 0x7ccc
    doc: The damage multiplier corresponding to MATCHUP_SUPER_EFFECTIVE when Erratic
      Player is active, as a fixed-point number with 8 fraction bits (the raw value
      is 0x1B3, the closest possible representation of 1.7).
    type: s4
  matchup_immune_multiplier:
    pos: 0x7cd8
    doc: The damage multiplier corresponding to MATCHUP_IMMUNE, as a fixed-point number
      with 8 fraction bits (0.5).
    type: s4
  sport_condition_turn_range:
    pos: 0x7d0c
    doc: |-
      The turn range for the sport conditions activated by Mud Sport and Water Sport, [10, 12).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  sure_shot_turn_range:
    pos: 0x7d18
    doc: |-
      The turn range for the Sure Shot status inflicted by Mind Reader and Lock-On, [10, 12).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  detect_band_move_accuracy_drop:
    pos: 0x7d28
    doc: The (subtractive) move accuracy drop induced on an attacker if the defender
      is wearing a Detect Band (30).
    type: s4
  tinted_lens_multiplier:
    pos: 0x7d40
    doc: The extra damage multiplier for not-very-effective moves when Tinted Lens
      is active, as a fixed-point number with 8 fraction bits (the raw value is 0x133,
      the closest possible representation of 1.2).
    type: s4
  smokescreen_turn_range:
    pos: 0x7d44
    doc: |-
      The turn range for the Whiffer status inflicted by Smokescreen, [1, 4).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  perish_song_turn_range:
    pos: 0x7d50
    doc: |-
      The turn range for the status inflicted by Perish Song, [3, 3).

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  shadow_force_damage_multiplier:
    pos: 0x7d5c
    doc: The damage multiplier for Shadow Force, as a fixed-point number with 8 fraction
      bits (2).
    type: s4
  dig_damage_multiplier:
    pos: 0x7d64
    doc: The damage multiplier for Dig, as a fixed-point number with 8 fraction bits
      (2).
    type: s4
  dive_damage_multiplier:
    pos: 0x7d68
    doc: The damage multiplier for Dive, as a fixed-point number with 8 fraction bits
      (2).
    type: s4
  bounce_damage_multiplier:
    pos: 0x7d6c
    doc: The damage multiplier for Bounce, as a fixed-point number with 8 fraction
      bits (2).
    type: s4
  power_pitcher_damage_multiplier:
    pos: 0x7d78
    doc: The multiplier for projectile damage from Power Pitcher (1.5), as a binary
      fixed-point number (8 fraction bits)
    type: s4
  quick_dodger_move_accuracy_drop:
    pos: 0x7d88
    doc: The (subtractive) move accuracy drop induced on an attacker if the defender
      has the Quick Dodger IQ skill (10).
    type: s4
  matchup_not_very_effective_multiplier:
    pos: 0x7d90
    doc: The damage multiplier corresponding to MATCHUP_NOT_VERY_EFFECTIVE, as a fixed-point
      number with 8 fraction bits (the raw value is 0x1B4, the closest possible representation
      of 1/√2).
    type: s4
  matchup_super_effective_multiplier:
    pos: 0x7d98
    doc: The damage multiplier corresponding to MATCHUP_SUPER_EFFECTIVE, as a fixed-point
      number with 8 fraction bits (the raw value is 0x166, the closest possible representation
      of 1.4).
    type: s4
  matchup_neutral_multiplier:
    pos: 0x7d9c
    doc: The damage multiplier corresponding to MATCHUP_NEUTRAL, as a fixed-point
      number with 8 fraction bits (1).
    type: s4
  matchup_immune_multiplier_erratic_player:
    pos: 0x7da0
    doc: The damage multiplier corresponding to MATCHUP_IMMUNE when Erratic Player
      is active, as a fixed-point number with 8 fraction bits (0.25).
    type: s4
  matchup_not_very_effective_multiplier_erratic_player:
    pos: 0x7da4
    doc: The damage multiplier corresponding to MATCHUP_NOT_VERY_EFFECTIVE when Erratic
      Player is active, as a fixed-point number with 8 fraction bits (0.5).
    type: s4
  matchup_neutral_multiplier_erratic_player:
    pos: 0x7dac
    doc: The damage multiplier corresponding to MATCHUP_NEUTRAL when Erratic Player
      is active, as a fixed-point number with 8 fraction bits (1).
    type: s4
  air_blade_damage_multiplier:
    pos: 0x7dc4
    doc: The multiplier for damage from the Air Blade (1.5), as a binary fixed-point
      number (8 fraction bits)
    type: s4
  kecleon_shop_boost_chance_multiplier:
    pos: 0x7dcc
    doc: The boosted kecleon shop spawn chance multiplier (~1.2) as a binary fixed-point
      number (8 fraction bits).
    type: s4
  hidden_stairs_spawn_chance_multiplier:
    pos: 0x7dd0
    doc: The hidden stairs spawn chance multiplier (~1.2) as a binary fixed-point
      number (8 fraction bits), if applicable. See ShouldBoostHiddenStairsSpawnChance
      in overlay 29.
    type: s4
  yawn_turn_range:
    pos: 0x7de0
    doc: |-
      The turn range for the Yawning status inflicted by Yawn, [2, 2].

      type: int16_t[2]
    type: s2
    repeat: expr
    repeat-expr: 2
  speed_boost_turn_range:
    pos: 0x7e08
    doc: |-
      Appears to control the range of turns for which a speed boost can last.

      The first two bytes are the low value of the range, and the later two bytes are the high value.
    type: s2
    repeat: expr
    repeat-expr: 2
  solarbeam_damage_multiplier:
    pos: 0x7e24
    doc: The default damage multiplier for SolarBeam, as a fixed-point number with
      8 fraction bits (2).
    type: s4
  sky_attack_damage_multiplier:
    pos: 0x7e28
    doc: The damage multiplier for Sky Attack, as a fixed-point number with 8 fraction
      bits (2).
    type: s4
  razor_wind_damage_multiplier:
    pos: 0x7e30
    doc: The damage multiplier for Razor Wind, as a fixed-point number with 8 fraction
      bits (2).
    type: s4
  focus_punch_damage_multiplier:
    pos: 0x7e34
    doc: The damage multiplier for Focus Punch, as a fixed-point number with 8 fraction
      bits (2).
    type: s4
  skull_bash_damage_multiplier:
    pos: 0x7e3c
    doc: The damage multiplier for Skull Bash, as a fixed-point number with 8 fraction
      bits (2).
    type: s4
  fly_damage_multiplier:
    pos: 0x7e40
    doc: The damage multiplier for Fly, as a fixed-point number with 8 fraction bits
      (2).
    type: s4
  weather_ball_type_table:
    pos: 0x7e5c
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding Weather Ball type.

      type: struct type_id_8[8]
    size: 0x8
  last_resort_damage_mult_table:
    pos: 0x7ec4
    doc: |-
      Table of damage multipliers for Last Resort for different numbers of moves out of PP, where each entry is a binary fixed-point number with 8 fraction bits.

      If n is the number of moves out of PP not counting Last Resort itself, the table is indexed by (n - 1).

      type: int[4]
    type: s4
    repeat: expr
    repeat-expr: 4
  synthesis_hp_restoration_table:
    pos: 0x7ed4
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Synthesis.

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  roost_hp_restoration_table:
    pos: 0x7ee4
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Roost.

      Every entry in this table is 40.

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  moonlight_hp_restoration_table:
    pos: 0x7ef4
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Moonlight.

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  morning_sun_hp_restoration_table:
    pos: 0x7f04
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Morning Sun.

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  reversal_damage_mult_table:
    pos: 0x7f14
    doc: |-
      Table of damage multipliers for Reversal/Flail at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
    type: s4
    repeat: expr
    repeat-expr: 4
  water_spout_damage_mult_table:
    pos: 0x7f24
    doc: |-
      Table of damage multipliers for Water Spout at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
    type: s4
    repeat: expr
    repeat-expr: 4
  wring_out_damage_mult_table:
    pos: 0x7f34
    doc: |-
      Table of damage multipliers for Wring Out/Crush Grip at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
    type: s4
    repeat: expr
    repeat-expr: 4
  eruption_damage_mult_table:
    pos: 0x7f44
    doc: |-
      Table of damage multipliers for Eruption at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[4]
    type: s4
    repeat: expr
    repeat-expr: 4
  weather_ball_damage_mult_table:
    pos: 0x80d4
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding Weather Ball damage multiplier, where each entry is a binary fixed-point number with 8 fraction bits.

      type: int[8]
    type: s4
    repeat: expr
    repeat-expr: 8
  eat_item_effect_ignore_list:
    pos: 0x80f4
    doc: List of item IDs that should be ignored by the ShouldTryEatItem function.
      The last entry is null.
    size: 0x48
  castform_weather_attribute_table:
    pos: 0x81ec
    doc: |-
      Maps each weather type (by index, see enum weather_id) to the corresponding Castform type and form.

      type: struct castform_weather_attributes[8]
    type: castform_weather_attributes
    repeat: expr
    repeat-expr: 8
  bad_poison_damage_table:
    pos: 0x821c
    doc: Table for how much damage each tick of badly poisoned should deal. The table
      is filled with 0x0006, but could use different values for each entry.
    type: s2
    repeat: expr
    repeat-expr: 30
  type_matchup_combinator_table:
    pos: 0x8294
    doc: |-
      Table of type matchup combinations.

      Each row corresponds to a single type matchup that results from combining two individual type matchups together. For example, combining MATCHUP_NOT_VERY_EFFECTIVE with MATCHUP_SUPER_EFFECTIVE results in MATCHUP_NEUTRAL.

      type: struct type_matchup_combinator_table
    type: type_matchup_combinator_table
  offensive_stat_stage_multipliers:
    pos: 0x8318
    doc: Table of multipliers for offensive stats (attack/special attack) for each
      stage 0-20, as binary fixed-point numbers (8 fraction bits)
    type: s4
    repeat: expr
    repeat-expr: 21
  defensive_stat_stage_multipliers:
    pos: 0x836c
    doc: Table of multipliers for defensive stats (defense/special defense) for each
      stage 0-20, as binary fixed-point numbers (8 fraction bits)
    type: s4
    repeat: expr
    repeat-expr: 21
  nature_power_table:
    pos: 0x83c0
    doc: |-
      Maps enum nature_power_variant to the associated move ID and effect handler.

      type: struct wildcard_move_desc[15]
    type: wildcard_move_desc
    repeat: expr
    repeat-expr: 15
  apples_and_berries_item_ids:
    pos: 0x8438
    doc: |-
      Table of item IDs for Apples and Berries, which trigger the exclusive item effect EXCLUSIVE_EFF_RECOVER_HP_FROM_APPLES_AND_BERRIES.

      type: struct item_id_16[66]
    size: 0x84
  recruitment_level_boost_table:
    pos: 0x85e4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[102]
    type: s2
    repeat: expr
    repeat-expr: 102
  natural_gift_item_table:
    pos: 0x86b0
    doc: |-
      Maps items to their type and base power if used with Natural Gift.

      Any item not listed in this table explicitly will be Normal type with a base power of 1 when used with Natural Gift.

      type: struct natural_gift_item_info[34]
    type: natural_gift_item_info
    repeat: expr
    repeat-expr: 34
  random_music_id_table:
    pos: 0x877c
    doc: |-
      Table of music IDs for dungeons with a random assortment of music tracks.

      This is a table with 30 rows, each with 4 2-byte music IDs. Each row contains the possible music IDs for a given group, from which the music track will be selected randomly.

      type: struct music_id_16[30][4]
    size: 0xf0
  shop_item_chances:
    pos: 0x886c
    doc: |-
      8 * 6 * 3 * 0x2

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 144
  male_accuracy_stage_multipliers:
    pos: 0x898c
    doc: Table of multipliers for the accuracy stat for males for each stage 0-20,
      as binary fixed-point numbers (8 fraction bits)
    type: s4
    repeat: expr
    repeat-expr: 21
  male_evasion_stage_multipliers:
    pos: 0x89e0
    doc: Table of multipliers for the evasion stat for males for each stage 0-20,
      as binary fixed-point numbers (8 fraction bits)
    type: s4
    repeat: expr
    repeat-expr: 21
  female_accuracy_stage_multipliers:
    pos: 0x8a34
    doc: Table of multipliers for the accuracy stat for females for each stage 0-20,
      as binary fixed-point numbers (8 fraction bits)
    type: s4
    repeat: expr
    repeat-expr: 21
  female_evasion_stage_multipliers:
    pos: 0x8a88
    doc: Table of multipliers for the evasion stat for females for each stage 0-20,
      as binary fixed-point numbers (8 fraction bits)
    type: s4
    repeat: expr
    repeat-expr: 21
  music_id_table:
    pos: 0x8adc
    doc: |-
      List of music IDs used in dungeons with a single music track.

      This is an array of 170 2-byte music IDs, and is indexed into by the music value in the floor properties struct for a given floor. Music IDs with the highest bit set (0x8000) are indexes into the RANDOM_MUSIC_ID_TABLE.

      type: struct music_id_16[170] (or not a music ID if the highest bit is set)
    size: 0x154
  type_matchup_table:
    pos: 0x8c30
    doc: |-
      Table of type matchups.

      Each row corresponds to the type matchups of a specific attack type, with each entry within the row specifying the type's effectiveness against a target type.

      type: struct type_matchup_table
    type: type_matchup_table
  fixed_room_monster_spawn_stats_table:
    pos: 0x8eb8
    doc: |-
      Table of stats for monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_MONSTER_SPAWN_TABLE.

      This is an array of 99 12-byte entries containing stat spreads for one monster entry each.

      type: struct fixed_room_monster_spawn_stats_entry[99]
    type: fixed_room_monster_spawn_stats_entry
    repeat: expr
    repeat-expr: 99
  metronome_table:
    pos: 0x935c
    doc: |-
      Something to do with the moves that Metronome can turn into.

      type: struct wildcard_move_desc[168]
    type: wildcard_move_desc
    repeat: expr
    repeat-expr: 168
  tileset_properties:
    pos: 0x989c
    doc: 'type: struct tileset_property[199]'
    type: tileset_property
    repeat: expr
    repeat-expr: 199
  fixed_room_properties_table:
    pos: 0xa1f0
    doc: |-
      Table of properties for fixed rooms.

      This is an array of 256 12-byte entries containing properties for a given fixed room ID.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct fixed_room_properties_entry[256]
    type: fixed_room_properties_entry
    repeat: expr
    repeat-expr: 256
  trap_animation_info:
    pos: 0xafd0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct trap_animation[26]
    type: trap_animation
    repeat: expr
    repeat-expr: 26
  item_animation_info:
    pos: 0xb004
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct item_animation[1400]
    type: item_animation
    repeat: expr
    repeat-expr: 1400
  move_animation_info:
    pos: 0xc5e4
    doc: 'type: struct move_animation[563]'
    type: move_animation
    repeat: expr
    repeat-expr: 563
  effect_animation_info:
    pos: 0xfaac
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct effect_animation[700]
    type: effect_animation
    repeat: expr
    repeat-expr: 700
  special_monster_move_animation_info:
    pos: 0x1473c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct special_monster_move_animation[7422]
    type: special_monster_move_animation
    repeat: expr
    repeat-expr: 7422
types:
  window_params:
  - id: update
    type: update_window_fn_t
  - id: x_offset
    type: u1
  - id: y_offset
    type: u1
  - id: width
    type: u1
  - id: height
    type: u1
  - id: screen
    type: screen_8
  - id: box_type
    type: box_type_8
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  castform_weather_attributes:
  - id: castform_type
    type: type_id_8
  - id: _padding
    type: u1
  - id: castform_male_id
    type: monster_id_16
  - id: castform_female_id
    type: monster_id_16
  type_matchup_combinator_table: []
  wildcard_move_desc:
  - id: move_id
    type: move_id_16
  - id: _padding
    type: u2
  - id: do_move
    type: move_effect_fn_t
  natural_gift_item_info:
  - id: item_id
    type: item_id_16
  - id: type_id
    type: type_id_8
  - id: _padding
    type: u1
  - id: base_power_boost
    type: s2
  type_matchup_table: []
  fixed_room_monster_spawn_stats_entry:
  - id: level
    type: u2
  - id: hp
    type: u2
  - id: exp_yield
    type: s2
  - id: atk
    type: u1
  - id: sp_atk
    type: u1
  - id: def
    type: u1
  - id: sp_def
    type: u1
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  tileset_property:
  - id: field_0x0
    type: s4
  - id: field_0x4
    type: u1
  - id: field_0x5
    type: u1
  - id: field_0x6
    type: u1
  - id: _padding
    type: u1
  - id: nature_power_variant
    type: nature_power_variant_16
  - id: field_0xa
    type: u1
  - id: is_water_tileset
    type: bool
  fixed_room_properties_entry:
  - id: music
    type: music_id_16
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: illuminated
    type: bool
  - id: enable_lategame_traps
    type: bool
  - id: moves_enabled
    type: bool
  - id: orbs_allowed
    type: bool
  - id: tile_jumps_allowed
    type: bool
  - id: trawl_orbs_allowed
    type: bool
  - id: exit_after_enemies_defeated
    type: bool
  - id: field_0xb
    type: u1
  trap_animation:
  - id: field_0x0
    type: s2
  item_animation:
  - id: field_0x0
    type: s2
  - id: field_0x2
    type: s2
  move_animation:
  - id: field_0x0
    type: s2
  - id: field_0x2
    type: s2
  - id: field_0x4
    type: s2
  - id: field_0x6
    type: s2
  - id: field_0x8
    type: u1
  - id: field_0x9
    type: u1
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  - id: field_0xc
    type: u1
  - id: field_0xd
    type: u1
  - id: field_0xe
    type: u1
  - id: field_0xf
    type: u1
  - id: field_0x10
    type: u1
  - id: field_0x11
    type: s1
  - id: field_0x12
    type: u2
  - id: field_0x14
    type: s2
  - id: field_0x16
    type: u2
  effect_animation:
  - id: field_0x0
    type: s4
  - id: file_index
    type: s4
  - id: field_0x8
    type: s4
  - id: animation_index
    type: s4
  - id: se_id
    type: s4
  - id: field_0x14
    type: s4
  - id: field_0x18
    type: u1
  - id: field_0x19
    type: s1
  - id: is_non_blocking
    type: u1
  - id: unk_repeat
    type: u1
  special_monster_move_animation:
  - id: field_0x0
    type: s2
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: s1
  - id: field_0x4
    type: s2
enums: {}
