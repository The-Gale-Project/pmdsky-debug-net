doc: Holds the data for the enum damage_message.
meta:
  id: damage_message
  endian: le
  bit-endian: le
seq:
- id: damage_message_value
  type: b32
  enum: damage_message_enum
enums:
  damage_message_enum:
    0: damage_message_move
    1: damage_message_burn
    2: damage_message_constriction
    3: damage_message_poison
    4: damage_message_recoil_1
    5: damage_message_wrap
    6: damage_message_counter
    7: damage_message_curse
    8: damage_message_nightmare
    9: damage_message_leech_seed
    10: damage_message_spikes
    11: damage_message_perish_song
    12: damage_message_destiny_bond
    13: damage_message_sludge
    14: damage_message_hunger
    15: damage_message_chestnut_1
    16: damage_message_chestnut_2
    17: damage_message_pitfall_trap
    18: damage_message_bad_weather
    19: damage_message_missed_move
    20: damage_message_recoil_2
    21: damage_message_stealth_rock
    22: damage_message_toxic_spikes
    23: damage_message_almost_fainted
    24: damage_message_bad_dreams
    25: damage_message_solar_power
    26: damage_message_dry_skin
