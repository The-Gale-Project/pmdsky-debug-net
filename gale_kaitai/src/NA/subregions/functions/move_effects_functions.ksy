doc: List of functions within MOVE_EFFECTS with relative address locations as their
  values.
meta:
  id: move_effects_functions
  endian: le
instances:
  do_move_iron_tail:
    value: 0x24
    doc: |-
      Move effect: Iron Tail

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_multihit_until_miss:
    value: 0xa4
    doc: |-
      Move effect: Deal multihit damage until a strike misses
      Relevant moves: Ice Ball, Rollout

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_yawn:
    value: 0x104
    doc: |-
      Move effect: Yawn

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sleep:
    value: 0x140
    doc: |-
      Move effect: Put target enemies to sleep
      Relevant moves: Lovely Kiss, Sing, Spore, Grasswhistle, Hypnosis, Sleep Powder, Dark Void

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_nightmare:
    value: 0x17c
    doc: |-
      Move effect: Nightmare

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_morning_sun:
    value: 0x1b4
    doc: |-
      Move effect: Morning Sun

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_vital_throw:
    value: 0x1f4
    doc: |-
      Move effect: Vital Throw

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_dig:
    value: 0x204
    doc: |-
      Move effect: Dig

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sweet_scent:
    value: 0x2c8
    doc: |-
      Move effect: Sweet Scent

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_charm:
    value: 0x2e8
    doc: |-
      Move effect: Charm

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_rain_dance:
    value: 0x310
    doc: |-
      Move effect: Rain Dance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_hail:
    value: 0x36c
    doc: |-
      Move effect: Hail

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_heal_status:
    value: 0x3c8
    doc: |-
      Move effect: Heal the team's status conditions
      Relevant moves: Aromatherapy, Heal Bell, Refresh

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_bubble:
    value: 0x3e0
    doc: |-
      Move effect: Bubble

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_encore:
    value: 0x44c
    doc: |-
      Move effect: Encore

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_rage:
    value: 0x460
    doc: |-
      Move effect: Rage

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_super_fang:
    value: 0x4a4
    doc: |-
      Move effect: Super Fang

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_pain_split:
    value: 0x55c
    doc: |-
      Move effect: Pain Split

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_torment:
    value: 0x648
    doc: |-
      Move effect: Torment

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_string_shot:
    value: 0x790
    doc: |-
      Move effect: String Shot

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_swagger:
    value: 0x7a8
    doc: |-
      Move effect: Swagger

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_snore:
    value: 0x7e4
    doc: |-
      Move effect: Snore

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_screech:
    value: 0x888
    doc: |-
      Move effect: Screech

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_cringe30:
    value: 0x8b0
    doc: |-
      Move effect: Deal damage with a 30% chance (ROCK_SLIDE_CRINGE_CHANCE) of inflicting the cringe status on the defender.
      Relevant moves: Rock Slide, Astonish, Iron Head, Dark Pulse, Air Slash, Zen Headbutt, Dragon Rush

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_weather_ball:
    value: 0x91c
    doc: |-
      Move effect: Weather Ball

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_whirlpool:
    value: 0x990
    doc: |-
      Move effect: Whirlpool

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_fake_tears:
    value: 0xa18
    doc: |-
      Move effect: Fake Tears

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_spite:
    value: 0xa4c
    doc: |-
      Move effect: Spite

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_focus_energy:
    value: 0xafc
    doc: |-
      Move effect: Focus Energy
      Relevant moves: Focus Energy, MOVE_TAG_0x1AC

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_smokescreen:
    value: 0xb0c
    doc: |-
      Move effect: Smokescreen

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_mirror_move:
    value: 0xb48
    doc: |-
      Move effect: Mirror Move

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_overheat:
    value: 0xb6c
    doc: |-
      Move effect: Overheat

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_aurora_beam:
    value: 0xbd0
    doc: |-
      Move effect: Aurora Beam

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_memento:
    value: 0xc4c
    doc: |-
      Move effect: Memento

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_octazooka:
    value: 0xcb4
    doc: |-
      Move effect: Octazooka

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_flatter:
    value: 0xd28
    doc: |-
      Move effect: Flatter

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_will_o_wisp:
    value: 0xd64
    doc: |-
      Move effect: Will-O-Wisp

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_return:
    value: 0xe00
    doc: |-
      Move effect: Return

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_grudge:
    value: 0xee4
    doc: |-
      Move effect: Grudge

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_counter:
    value: 0xef4
    doc: |-
      Move effect: Give the user the Counter status
      Relevant moves: Pursuit, Counter, Payback

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_burn10_flame_wheel:
    value: 0xf08
    doc: |-
      Move effect: Deal damage with a 10% chance (FLAME_WHEEL_BURN_CHANCE) of burning the defender.
      Relevant moves: Flame Wheel, Lava Plume

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_burn10:
    value: 0xf90
    doc: |-
      Move effect: Deal damage with a 10% chance (FLAMETHROWER_BURN_CHANCE) of burning the defender.
      Relevant moves: Flamethrower, Fire Blast, Heat Wave, Ember, Fire Punch

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_expose:
    value: 0x1018
    doc: |-
      Move effect: Expose all Ghost-type enemies, and reset evasion boosts
      Relevant moves: Odor Sleuth, Foresight

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_double_team:
    value: 0x1044
    doc: |-
      Move effect: Double Team

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_gust:
    value: 0x1060
    doc: |-
      Move effect: Gust

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_boost_defense1:
    value: 0x10a0
    doc: |-
      Move effect: Boost the user's defense by one stage
      Relevant moves: Harden, Withdraw

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_boost_attack1:
    value: 0x10d8
    doc: |-
      Move effect: Boost the user's attack by one stage
      Relevant moves: Sharpen, Howl, Meditate

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_razor_wind:
    value: 0x10f8
    doc: |-
      Move effect: Razor Wind

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_bide:
    value: 0x1188
    doc: |-
      Move effect: Give the user the Bide status
      Relevant moves: Bide, Revenge, Avalanche

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_bide_unleash:
    value: 0x11cc
    doc: |-
      Move effect: Unleashes the Bide status
      Relevant moves: Bide (unleashing), Revenge (unleashing), Avalanche (unleashing)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_crunch:
    value: 0x1274
    doc: |-
      Move effect: Deal damage with a 20% chance (CRUNCH_LOWER_DEFENSE_CHANCE) of lowering the defender's defense.
      Relevant moves: Crunch, Shadow Ball via Nature Power

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_damage_cringe20:
    value: 0x12f4
    doc: |-
      Move effect: Deal damage with a 20% chance (BITE_CRINGE_CHANCE) of inflicting the cringe status on the defender.
      Relevant moves: Bite, Needle Arm, Stomp, Rolling Kick

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_paralyze20:
    value: 0x1360
    doc: |-
      Move effect: Deal damage with a 20% chance (THUNDER_PARALYZE_CHANCE) of paralyzing the defender.
      Relevant moves: Thunder, ThunderPunch, Force Palm, Discharge

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_endeavor:
    value: 0x13cc
    doc: |-
      Move effect: Endeavor

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_facade:
    value: 0x148c
    doc: |-
      Move effect: Facade

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_lower_speed20:
    value: 0x14cc
    doc: |-
      Move effect: Deal damage with a 20% chance (CONSTRICT_LOWER_SPEED_CHANCE) of lowering the defender's speed.
      Relevant moves: Constrict, Bubblebeam

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_brick_break:
    value: 0x1538
    doc: |-
      Move effect: Brick Break

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_lower_speed100:
    value: 0x15a8
    doc: |-
      Move effect: Deal damage and lower the defender's speed.
      Relevant moves: Rock Tomb, Icy Wind, Mud Shot

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_focus_punch:
    value: 0x160c
    doc: |-
      Move effect: Focus Punch

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_drain:
    value: 0x1698
    doc: |-
      Move effect: Deal draining damage, healing the attacker by a proportion of the damage dealt.
      Relevant moves: Giga Drain, Leech Life, Mega Drain, Drain Punch

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_reversal:
    value: 0x17d8
    doc: |-
      Move effect: Deal damage with a higher multiplier the lower the attacker's HP is.
      Relevant moves: Reversal, Flail

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_smelling_salt:
    value: 0x188c
    doc: |-
      Move effect: SmellingSalt

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_metal_sound:
    value: 0x18f4
    doc: |-
      Move effect: Metal Sound

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_tickle:
    value: 0x1928
    doc: |-
      Move effect: Tickle

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_shadow_hold:
    value: 0x1984
    doc: |-
      Move effect: Inflict the Shadow Hold status on the defender
      Relevant moves: Spider Web, Mean Look

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_haze:
    value: 0x1998
    doc: |-
      Move effect: Haze

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_multihit_fatigue:
    value: 0x19ac
    doc: |-
      Move effect: Deal multihit damage, then confuse the attacker
      Relevant moves: Outrage, Petal Dance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_weight_dependent:
    value: 0x19f8
    doc: |-
      Move effect: Deal damage, multiplied by a weight-dependent factor.
      Relevant moves: Low Kick, Grass Knot

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_damage_boost_all_stats:
    value: 0x1a44
    doc: |-
      Move effect: Deal damage, with a 20% (SILVER_WIND_BOOST_CHANCE) to boost the user's attack, special attack, defense, special defense, and speed.
      Relevant moves: Silver Wind, AncientPower, Ominous Wind

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_synthesis:
    value: 0x1b28
    doc: |-
      Move effect: Synthesis

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_boost_speed1:
    value: 0x1b68
    doc: |-
      Move effect: Boost the team's movement speed by one stage
      Relevant moves: Agility, Speed Boost (item effect), MOVE_TAG_0x1AA, Tailwind

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_rapid_spin:
    value: 0x1b80
    doc: |-
      Move effect: Rapid Spin

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sure_shot:
    value: 0x1bec
    doc: |-
      Move effect: Give the user the Sure-Shot status
      Relevant moves: Mind Reader, Lock-On

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_cosmic_power:
    value: 0x1c24
    doc: |-
      Move effect: Cosmic Power

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sky_attack:
    value: 0x1c68
    doc: |-
      Move effect: Sky Attack

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_freeze15:
    value: 0x1d34
    doc: |-
      Move effect: Deal damage with a 15% chance (POWDER_SNOW_FREEZE_CHANCE) of freezing the defender.
      Relevant moves: Powder Snow, Blizzard, Ice Punch, Ice Beam

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_meteor_mash:
    value: 0x1d9c
    doc: |-
      Move effect: Meteor Mash

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_endure:
    value: 0x1e20
    doc: |-
      Move effect: Endure

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_lower_speed1:
    value: 0x1e30
    doc: |-
      Move effect: Lower the defender's defense by one stage
      Relevant moves: Scary Face, Cotton Spore

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_confuse10:
    value: 0x1e48
    doc: |-
      Move effect: Deal damage with a 10% chance (PSYBEAM_CONFUSE_CHANCE) of confusing the defender.
      Relevant moves: Psybeam, Signal Beam, Confusion, Chatter, Rock Climb

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_psywave:
    value: 0x1eb4
    doc: |-
      Move effect: Psywave

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_lower_defensive_stat_variable:
    value: 0x1f18
    doc: |-
      Move effect: Deal damage with some chance of lowering one of the defender's defensive stats.
      Relevant moves: Psychic, Acid, Seed Flare, Earth Power, Bug Buzz, Flash Cannon

      Note that this move effect handler has a slightly different parameter list than all the others. Which defensive stat is lowered, the chance of lowering, and the number of stages to lower are all specified as arguments by the caller.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: stat index for the defensive stat to lower
      stack[0]: number of defensive stat stages to lower
      stack[1]: percentage chance of lowering the defensive stat
      stack[2]: item ID
      return: whether the move was successfully used
  do_move_psycho_boost:
    value: 0x1fa0
    doc: |-
      Move effect: Psycho Boost

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_uproar:
    value: 0x2010
    doc: |-
      Move effect: Uproar

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_water_spout:
    value: 0x2020
    doc: |-
      Move effect: Water Spout

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_psych_up:
    value: 0x20d4
    doc: |-
      Move effect: Psych Up

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_with_recoil:
    value: 0x2174
    doc: |-
      Move effect: Deals damage, inflicting recoil damage on the attacker.
      Relevant moves: Submission, Take Down, Volt Tackle, Wood Hammer, Brave Bird

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: bool, whether or not damage was dealt
  do_move_recover_hp:
    value: 0x2270
    doc: |-
      Move effect: Recover 50% of the user's max HP
      Relevant moves: Recover, Slack Off

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_earthquake:
    value: 0x22b4
    doc: |-
      Move effect: Earthquake

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  get_nature_power_variant:
    value: 0x2314
    doc: |-
      Gets the nature power variant for the current dungeon, based on the tileset ID.

      return: nature power variant
  do_move_nature_power:
    value: 0x2350
    doc: |-
      Move effect: Nature Power

      r0: attacker pointer
      r1: defender pointer
      r2: move (unused)
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_paralyze10:
    value: 0x23ac
    doc: |-
      Move effect: Deal damage with a 10% chance (LICK_PARALZYE_CHANCE) of paralyzing the defender.
      Relevant moves: Lick, Spark, Body Slam, DragonBreath

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_selfdestruct:
    value: 0x2418
    doc: |-
      Move effect: Selfdestruct

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_shadow_ball:
    value: 0x2488
    doc: |-
      Move effect: Shadow Ball

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_charge:
    value: 0x2508
    doc: |-
      Move effect: Charge

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_thunderbolt:
    value: 0x2568
    doc: |-
      Move effect: Thunderbolt

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_mist:
    value: 0x25d4
    doc: |-
      Move effect: Mist

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_fissure:
    value: 0x25e4
    doc: |-
      Move effect: Fissure

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_cringe10:
    value: 0x26fc
    doc: |-
      Move effect: Deal damage with a 10% chance (EXTRASENSORY_CRINGE_CHANCE) to inflict the cringe status on the defender.
      Relevant moves: Extrasensory, Hyper Fang, Bone Club

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_safeguard:
    value: 0x2768
    doc: |-
      Move effect: Safeguard

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_absorb:
    value: 0x2778
    doc: |-
      Move effect: Absorb

      This is essentially identical to DoMoveDamageDrain, except the ordering of the instructions is slightly different enough to introduce subtle variations in functionality.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_skill_swap:
    value: 0x28d8
    doc: |-
      Move effect: Skill Swap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sketch:
    value: 0x29d4
    doc: |-
      Move effect: Sketch

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_headbutt:
    value: 0x2b04
    doc: |-
      Move effect: Headbutt

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_double_edge:
    value: 0x2b70
    doc: |-
      Move effect: Double-Edge

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sandstorm:
    value: 0x2c38
    doc: |-
      Move effect: Sandstorm

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_lower_accuracy1:
    value: 0x2c94
    doc: |-
      Move effect: Lower the defender's accuracy by one stage
      Relevant moves: Sand-Attack, Kinesis, Flash

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_poison40:
    value: 0x2cb4
    doc: |-
      Move effect: Deal damage with a 40% chance (SMOG_POISON_CHANCE) of poisoning the defender.
      Relevant moves: Smog, Cross Poison, Gunk Shot, Poison Jab

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_growth:
    value: 0x2d20
    doc: |-
      Move effect: Growth

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sacred_fire:
    value: 0x2d40
    doc: |-
      Move effect: Sacred Fire

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_ohko:
    value: 0x2dc8
    doc: |-
      Move effect: Possibly one-hit KO the defender
      Relevant moves: Sheer Cold, Guillotine

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_solar_beam:
    value: 0x2eb4
    doc: |-
      Move effect: SolarBeam

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sonic_boom:
    value: 0x2f84
    doc: |-
      Move effect: SonicBoom

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_fly:
    value: 0x3024
    doc: |-
      Move effect: Fly

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_explosion:
    value: 0x30b4
    doc: |-
      Move effect: Explosion

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_dive:
    value: 0x310c
    doc: |-
      Move effect: Dive

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_waterfall:
    value: 0x31d4
    doc: |-
      Move effect: Waterfall

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_lower_accuracy40:
    value: 0x3240
    doc: |-
      Move effect: Deal damage with a 40% chance (MUDDY_WATER_LOWER_ACCURACY_CHANCE) of lowering the defender's accuracy.
      Relevant moves: Muddy Water, Mud Bomb, Mirror Shot

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_stockpile:
    value: 0x32b4
    doc: |-
      Move effect: Stockpile

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_twister:
    value: 0x330c
    doc: |-
      Move effect: Twister

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_twineedle:
    value: 0x339c
    doc: |-
      Move effect: Twineedle

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_recover_hp_team:
    value: 0x3434
    doc: |-
      Move effect: Recover 25% HP for all team members
      Relevant moves: Softboiled, Milk Drink

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_minimize:
    value: 0x347c
    doc: |-
      Move effect: Minimize

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_seismic_toss:
    value: 0x3498
    doc: |-
      Move effect: Seismic Toss

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_confuse:
    value: 0x360c
    doc: |-
      Move effect: Confuse target enemies if possible.
      Relevant moves: Confuse Ray, Supersonic, Sweet Kiss, Teeter Dance, Totter (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_taunt:
    value: 0x3624
    doc: |-
      Move effect: Taunt

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_moonlight:
    value: 0x3638
    doc: |-
      Move effect: Moonlight

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_horn_drill:
    value: 0x3678
    doc: |-
      Move effect: Horn Drill

      This is exactly the same as DoMoveOhko, except there's a call to SubstitutePlaceholderStringTags at the end.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_swords_dance:
    value: 0x3774
    doc: |-
      Move effect: Swords Dance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_conversion:
    value: 0x3794
    doc: |-
      Move effect: Conversion

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_conversion2:
    value: 0x38a4
    doc: |-
      Move effect: Conversion 2

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_helping_hand:
    value: 0x38b4
    doc: |-
      Move effect: Helping Hand

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_boost_defense2:
    value: 0x3918
    doc: |-
      Move effect: Boost the defender's defense stat by two stages
      Relevant moves: Iron Defense, Acid Armor, Barrier

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_warp:
    value: 0x3938
    doc: |-
      Move effect: Warp the target to another tile on the floor
      Relevant moves: Teleport, Warp (item effect), MOVE_TAG_0x1A8

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_thundershock:
    value: 0x3950
    doc: |-
      Move effect: Thundershock

      This is identical to DoMoveDamageParalyze10, except it uses a different data symbol for the paralysis chance (but it's still 10%).

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_thunder_wave:
    value: 0x39bc
    doc: |-
      Move effect: Thunder Wave

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_zap_cannon:
    value: 0x3a30
    doc: |-
      Move effect: Zap Cannon

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_block:
    value: 0x3a94
    doc: |-
      Move effect: Block

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_poison:
    value: 0x3aa8
    doc: |-
      Move effect: Poison the defender if possible
      Relevant moves: Poison Gas, PoisonPowder

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_toxic:
    value: 0x3ac0
    doc: |-
      Move effect: Toxic

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_poison_fang:
    value: 0x3ad8
    doc: |-
      Move effect: Poison Fang

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_poison18:
    value: 0x3b44
    doc: |-
      Move effect: Deal damage with an 18% chance (POISON_STING_POISON_CHANCE) to poison the defender.
      Relevant moves: Poison Sting, Sludge, Sludge Bomb

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_jump_kick:
    value: 0x3bb0
    doc: |-
      Move effect: Jump Kick

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_bounce:
    value: 0x3cdc
    doc: |-
      Move effect: Bounce

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_hi_jump_kick:
    value: 0x3da8
    doc: |-
      Move effect: Hi Jump Kick

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_tri_attack:
    value: 0x3ed4
    doc: |-
      Move effect: Tri Attack

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_swap_items:
    value: 0x3f90
    doc: |-
      Move effect: Swaps the held items of the attacker and defender.
      Relevant moves: Trick, Switcheroo

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_triple_kick:
    value: 0x41b8
    doc: |-
      Move effect: Triple Kick

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sport:
    value: 0x41f4
    doc: |-
      Move effect: Activate the relevant sport condition (Mud Sport, Water Sport) on the floor
      Relevant moves: Mud Sport, Water Sport

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_mud_slap:
    value: 0x4220
    doc: |-
      Move effect: Mud-Slap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_steal_item:
    value: 0x428c
    doc: |-
      Move effect: Deal damage and steal the defender's item if possible.
      Relevant moves: Thief, Covet

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_amnesia:
    value: 0x4298
    doc: |-
      Move effect: Amnesia

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_night_shade:
    value: 0x42b8
    doc: |-
      Move effect: Night Shade

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_growl:
    value: 0x4358
    doc: |-
      Move effect: Growl

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_surf:
    value: 0x4388
    doc: |-
      Move effect: Surf

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_role_play:
    value: 0x43c8
    doc: |-
      Move effect: Role Play

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sunny_day:
    value: 0x4460
    doc: |-
      Move effect: Sunny Day

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_lower_defense1:
    value: 0x44bc
    doc: |-
      Move effect: Lower the defender's defense by one stage
      Relevant moves: Tail Whip, Leer

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_wish:
    value: 0x44ec
    doc: |-
      Move effect: Wish

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_fake_out:
    value: 0x44fc
    doc: |-
      Move effect: Fake Out

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_sleep_talk:
    value: 0x4568
    doc: |-
      Move effect: Sleep Talk

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_pay_day:
    value: 0x4580
    doc: |-
      Move effect: Pay Day

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_assist:
    value: 0x463c
    doc: |-
      Move effect: Assist

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_rest:
    value: 0x4654
    doc: |-
      Move effect: Rest

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_ingrain:
    value: 0x46c0
    doc: |-
      Move effect: Ingrain

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_swallow:
    value: 0x46d0
    doc: |-
      Move effect: Swallow

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_curse:
    value: 0x4728
    doc: |-
      Move effect: Curse

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_superpower:
    value: 0x4764
    doc: |-
      Move effect: Superpower

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_steel_wing:
    value: 0x47ec
    doc: |-
      Move effect: Steel Wing

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_spit_up:
    value: 0x4880
    doc: |-
      Move effect: Spit Up

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_dynamic_punch:
    value: 0x48c8
    doc: |-
      Move effect: DynamicPunch

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_knock_off:
    value: 0x492c
    doc: |-
      Move effect: Knock Off

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_splash:
    value: 0x4b2c
    doc: |-
      Move effect: Splash

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_set_damage:
    value: 0x4e84
    doc: |-
      Move effect: Give the user the Set Damage status
      Relevant moves: Doom Desire, Future Sight

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_belly_drum:
    value: 0x4e94
    doc: |-
      Move effect: Belly Drum

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_light_screen:
    value: 0x4f48
    doc: |-
      Move effect: Light Screen

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_secret_power:
    value: 0x4f58
    doc: |-
      Move effect: Secret Power

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_confuse30:
    value: 0x5130
    doc: |-
      Move effect: Deal damage with a 30% chance (DIZZY_PUNCH_CONFUSE_CHANCE) to confuse the defender.
      Relevant moves: Dizzy Punch, Water Pulse

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_bulk_up:
    value: 0x519c
    doc: |-
      Move effect: Bulk Up

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_pause:
    value: 0x51e0
    doc: |-
      Move effect: Inflicts the Paused status on the defender
      Relevant moves: Imprison, Observer (item effect), MOVE_TAG_0x1AD

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_feather_dance:
    value: 0x5230
    doc: |-
      Move effect: FeatherDance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_beat_up:
    value: 0x5264
    doc: |-
      Move effect: Beat Up

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_blast_burn:
    value: 0x5358
    doc: |-
      Move effect: Blast Burn

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_crush_claw:
    value: 0x53a4
    doc: |-
      Move effect: Crush Claw

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_blaze_kick:
    value: 0x5424
    doc: |-
      Move effect: Blaze Kick

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_present:
    value: 0x54ac
    doc: |-
      Move effect: Present

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_eruption:
    value: 0x55a8
    doc: |-
      Move effect: Eruption

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_transform:
    value: 0x568c
    doc: |-
      Move effect: Transform

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_poison_tail:
    value: 0x56d4
    doc: |-
      Move effect: Poison Tail

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_blowback:
    value: 0x5740
    doc: |-
      Move effect: Blows the defender back
      Relevant moves: Whirlwind, Roar, Blowback (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_camouflage:
    value: 0x5758
    doc: |-
      Move effect: Camouflage

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_tail_glow:
    value: 0x5808
    doc: |-
      Move effect: Tail Glow

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_constrict10:
    value: 0x5828
    doc: |-
      Move effect: Deal damage with a 10% (WHIRLPOOL_CONSTRICT_CHANCE) chance to constrict, and with a damage multiplier dependent on the move used.
      Relevant moves: Clamp, Bind, Sand Tomb, Fire Spin, Magma Storm

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  do_move_perish_song:
    value: 0x58e4
    doc: |-
      Move effect: Perish Song

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_wrap:
    value: 0x58f8
    doc: |-
      Move effect: Wrap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_spikes:
    value: 0x5908
    doc: |-
      Move effect: Spikes

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_magnitude:
    value: 0x5978
    doc: |-
      Move effect: Magnitude

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_magic_coat:
    value: 0x5a00
    doc: |-
      Move effect: Magic Coat

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_protect:
    value: 0x5a10
    doc: |-
      Move effect: Try to give the user the Protect status
      Relevant moves: Protect, Detect

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_defense_curl:
    value: 0x5a20
    doc: |-
      Move effect: Defense Curl

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_decoy:
    value: 0x5a40
    doc: |-
      Move effect: Inflict the Decoy status on the target
      Relevant moves: Follow Me, Substitute, Decoy Maker (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_mist_ball:
    value: 0x5a60
    doc: |-
      Move effect: Mist Ball

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_destiny_bond:
    value: 0x5ae0
    doc: |-
      Move effect: Destiny Bond

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_mirror_coat:
    value: 0x5b14
    doc: |-
      Move effect: Mirror Coat

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_calm_mind:
    value: 0x5b24
    doc: |-
      Move effect: Calm Mind

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_hidden_power:
    value: 0x5b68
    doc: |-
      Move effect: Hidden Power

      This is exactly the same as DoMoveDamage (both are wrappers around DealDamage), except this function always returns true.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_metal_claw:
    value: 0x5b80
    doc: |-
      Move effect: Metal Claw

       Note that this move effect handler has a slightly different parameter list than all the others. Which offensive stat is boosted is specified by the caller.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: stat index for the offensive stat to boost
      stack[0]: item ID
      return: whether the move was successfully used
  do_move_attract:
    value: 0x5c10
    doc: |-
      Move effect: Attract

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_copycat:
    value: 0x5c84
    doc: |-
      Move effect: The attacker uses the move last used by enemy it's facing.
      Relevant moves: Mimic, Copycat

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_frustration:
    value: 0x5d8c
    doc: |-
      Move effect: Frustration

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_leech_seed:
    value: 0x5e74
    doc: |-
      Move effect: Leech Seed

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_metronome:
    value: 0x5ea4
    doc: |-
      Move effect: Metronome

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_dream_eater:
    value: 0x5f04
    doc: |-
      Move effect: Dream Eater

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_snatch:
    value: 0x6074
    doc: |-
      Move effect: Snatch

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_recycle:
    value: 0x6084
    doc: |-
      Move effect: Recycle

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_reflect:
    value: 0x61b8
    doc: |-
      Move effect: Reflect

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_dragon_rage:
    value: 0x61c8
    doc: |-
      Move effect: Dragon Rage

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_dragon_dance:
    value: 0x6268
    doc: |-
      Move effect: Dragon Dance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_skull_bash:
    value: 0x62a4
    doc: |-
      Move effect: Skull Bash

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_lower_special_defense50:
    value: 0x6334
    doc: |-
      Move effect: Deal damage with a 50% (LUSTER_PURGE_LOWER_SPECIAL_DEFENSE_CHANCE) chance to lower special defense.
      Relevant moves: Luster Purge, Energy Ball, Focus Blast

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_struggle:
    value: 0x63e4
    doc: |-
      Move effect: Struggle

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_rock_smash:
    value: 0x64bc
    doc: |-
      Move effect: Rock Smash
      Relevant moves: Rock Smash, MOVE_UNNAMED_0x169

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_see_trap:
    value: 0x6540
    doc: |-
      Move effect: See-Trap (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_takeaway:
    value: 0x6550
    doc: |-
      Move effect: Takeaway (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_rebound:
    value: 0x6764
    doc: |-
      Move effect: Rebound (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_switch_positions:
    value: 0x6778
    doc: |-
      Move effect: Switches the user's position with positions of other monsters in the room.
      Relevant moves: Baton Pass, Switcher (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_stay_away:
    value: 0x67a0
    doc: |-
      Move effect: Stay Away (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_cleanse:
    value: 0x67b8
    doc: |-
      Move effect: Cleanse (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_siesta:
    value: 0x68f4
    doc: |-
      Move effect: Siesta (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_two_edge:
    value: 0x6930
    doc: |-
      Move effect: Two-Edge (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_no_move:
    value: 0x6a58
    doc: |-
      Move effect: No-Move (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_scan:
    value: 0x6a6c
    doc: |-
      Move effect: Scan (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_power_ears:
    value: 0x6a7c
    doc: |-
      Move effect: Power-Ears (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_transfer:
    value: 0x6a8c
    doc: |-
      Move effect: Transfer (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_slow_down:
    value: 0x6c54
    doc: |-
      Move effect: Slow Down (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_searchlight:
    value: 0x6c6c
    doc: |-
      Move effect: Searchlight (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_petrify:
    value: 0x6c7c
    doc: |-
      Move effect: Petrifies the target
      Relevant moves: Petrify (item effect), MOVE_TAG_0x1A9

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_pounce:
    value: 0x6c8c
    doc: |-
      Move effect: Pounce (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_trawl:
    value: 0x6ca0
    doc: |-
      Move effect: Trawl (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_escape:
    value: 0x6cb0
    doc: |-
      Move effect: Escape (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_drought:
    value: 0x6d48
    doc: |-
      Move effect: Drought (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_trap_buster:
    value: 0x6d58
    doc: |-
      Move effect: Trap Buster (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_wild_call:
    value: 0x6f04
    doc: |-
      Move effect: Wild Call (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_invisify:
    value: 0x6fd0
    doc: |-
      Move effect: Invisify (item effect)

      This function sets r1 = r0 before calling TryInvisify, so the effect will always be applied to the user regardless of the move settings.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_one_shot:
    value: 0x6fe4
    doc: |-
      Move effect: One-Shot (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_hp_gauge:
    value: 0x7080
    doc: |-
      Move effect: HP Gauge (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_vacuum_cut:
    value: 0x7090
    doc: |-
      Move effect: Vacuum Cut

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_reviver:
    value: 0x70bc
    doc: |-
      Move effect: Reviver (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_shocker:
    value: 0x70d4
    doc: |-
      Move effect: Shocker (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_echo:
    value: 0x70ec
    doc: |-
      Move effect: Echo (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_famish:
    value: 0x7194
    doc: |-
      Move effect: Famish (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_one_room:
    value: 0x71b4
    doc: |-
      Move effect: One-Room (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_fill_in:
    value: 0x71c4
    doc: |-
      Move effect: Fill-In (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_trapper:
    value: 0x7330
    doc: |-
      Move effect: Trapper (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_itemize:
    value: 0x7388
    doc: |-
      Move effect: Itemize (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_hurl:
    value: 0x741c
    doc: |-
      Move effect: Hurls the target
      Relevant moves: Strength, Hurl (item effect), Fling

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_mobile:
    value: 0x742c
    doc: |-
      Move effect: Mobile (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_see_stairs:
    value: 0x743c
    doc: |-
      Move effect: See Stairs (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_long_toss:
    value: 0x744c
    doc: |-
      Move effect: Long Toss (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_pierce:
    value: 0x745c
    doc: |-
      Move effect: Pierce (item effect)

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_hammer_arm:
    value: 0x746c
    doc: |-
      Move effect: Hammer Arm

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_aqua_ring:
    value: 0x74b0
    doc: |-
      Move effect: Aqua Ring

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_gastro_acid:
    value: 0x74c0
    doc: |-
      Move effect: Gastro Acid

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_healing_wish:
    value: 0x74d8
    doc: |-
      Move effect: Healing Wish

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_close_combat:
    value: 0x7528
    doc: |-
      Move effect: Close Combat

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_lucky_chant:
    value: 0x75a8
    doc: |-
      Move effect: Lucky Chant

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_guard_swap:
    value: 0x75b8
    doc: |-
      Move effect: Guard Swap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_heal_order:
    value: 0x7618
    doc: |-
      Move effect: Heal Order

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_heal_block:
    value: 0x7640
    doc: |-
      Move effect: Heal Block

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_thunder_fang:
    value: 0x7658
    doc: |-
      Move effect: Thunder Fang

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_defog:
    value: 0x76ec
    doc: |-
      Move effect: Defog

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_trump_card:
    value: 0x77a0
    doc: |-
      Move effect: Trump Card

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_ice_fang:
    value: 0x7860
    doc: |-
      Move effect: Ice Fang

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_psycho_shift:
    value: 0x78f0
    doc: |-
      Move effect: Psycho Shift

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_embargo:
    value: 0x7910
    doc: |-
      Move effect: Embargo

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_brine:
    value: 0x7928
    doc: |-
      Move effect: Deal damage, with a 2x multiplier if the defender is at or below half HP.
      Relevant moves: Brine, Assurance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_natural_gift:
    value: 0x7978
    doc: |-
      Move effect: Natural Gift

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_gyro_ball:
    value: 0x7a38
    doc: |-
      Move effect: Gyro Ball

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_shadow_force:
    value: 0x7aa0
    doc: |-
      Move effect: Shadow Force

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_gravity:
    value: 0x7b3c
    doc: |-
      Move effect: Gravity

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_stealth_rock:
    value: 0x7b4c
    doc: |-
      Move effect: Stealth Rock

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_charge_beam:
    value: 0x7bbc
    doc: |-
      Move effect: Charge Beam

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_eat_item:
    value: 0x7c24
    doc: |-
      Move effect: Deals damage, and eats any beneficial items the defender is holding.
      Relevant moves: Pluck, Bug Bite

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_acupressure:
    value: 0x7d10
    doc: |-
      Move effect: Acupressure

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_magnet_rise:
    value: 0x7e94
    doc: |-
      Move effect: Magnet Rise

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_toxic_spikes:
    value: 0x7ea4
    doc: |-
      Move effect: Toxic Spikes

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_last_resort:
    value: 0x7f14
    doc: |-
      Move effect: Last Resort

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_trick_room:
    value: 0x7fb8
    doc: |-
      Move effect: Trick Room

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_worry_seed:
    value: 0x7fec
    doc: |-
      Move effect: Worry Seed

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_damage_hp_dependent:
    value: 0x80c4
    doc: |-
      Move effect: Deal damage, with a multiplier dependent on the defender's current HP.
      Relevant moves: Wring Out, Crush Grip

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_heart_swap:
    value: 0x8178
    doc: |-
      Move effect: Heart Swap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_roost:
    value: 0x8208
    doc: |-
      Move effect: Roost

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_power_swap:
    value: 0x82c4
    doc: |-
      Move effect: Power Swap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_power_trick:
    value: 0x8324
    doc: |-
      Move effect: Power Trick

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_feint:
    value: 0x8338
    doc: |-
      Move effect: Feint

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_flare_blitz:
    value: 0x8370
    doc: |-
      Move effect: Flare Blitz

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_defend_order:
    value: 0x84b4
    doc: |-
      Move effect: Defend Order

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_fire_fang:
    value: 0x84f8
    doc: |-
      Move effect: Fire Fang

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_lunar_dance:
    value: 0x85a8
    doc: |-
      Move effect: Lunar Dance

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_miracle_eye:
    value: 0x8610
    doc: |-
      Move effect: Miracle Eye

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_wake_up_slap:
    value: 0x8640
    doc: |-
      Move effect: Wake-Up Slap

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_metal_burst:
    value: 0x86cc
    doc: |-
      Move effect: Metal Burst

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_head_smash:
    value: 0x86e0
    doc: |-
      Move effect: Head Smash

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_captivate:
    value: 0x87a0
    doc: |-
      Move effect: Captivate

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_leaf_storm:
    value: 0x8864
    doc: |-
      Move effect: Leaf Storm

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_draco_meteor:
    value: 0x88bc
    doc: |-
      Move effect: Draco Meteor

      Note that this move effect handler has an extra parameter that can be used to disable the special attack drop.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      r4: disable special attack drop
      return: whether the move was successfully used
  do_move_rock_polish:
    value: 0x8920
    doc: |-
      Move effect: Rock Polish

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_nasty_plot:
    value: 0x8954
    doc: |-
      Move effect: Nasty Plot

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_tag0x1_ab:
    value: 0x8974
    doc: |-
      Move effect: MOVE_TAG_0x1AB

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_tag0x1_a6:
    value: 0x8990
    doc: |-
      Move effect: MOVE_TAG_0x1A6

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
  do_move_tag0x1_a7:
    value: 0x89d4
    doc: |-
      Move effect: MOVE_TAG_0x1A7

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether the move was successfully used
