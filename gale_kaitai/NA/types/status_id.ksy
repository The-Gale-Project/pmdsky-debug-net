doc: Holds the data for the enum status_id.
meta:
  id: status_id
  endian: le
  bit-endian: le
seq:
- id: status_id_value
  type: b32
  enum: status_id_enum
enums:
  status_id_enum:
    0: status_none
    1: status_sleep
    2: status_sleepless
    3: status_nightmare
    4: status_yawning
    5: status_napping
    6: status_low_hp
    7: status_burn
    8: status_poisoned
    9: status_badly_poisoned
    10: status_paralysis
    11: status_identifying
    12: status_frozen
    13: status_shadow_hold
    14: status_wrap
    15: status_wrapped
    16: status_ingrain
    17: status_petrified
    18: status_constriction
    19: status_famished
    20: status_cringe
    21: status_confused
    22: status_paused
    23: status_cowering
    24: status_taunted
    25: status_encore
    26: status_infatuated
    27: status_double_speed
    28: status_bide
    29: status_solarbeam
    30: status_sky_attack
    31: status_razor_wind
    32: status_focus_punch
    33: status_skull_bash
    34: status_flying
    35: status_bouncing
    36: status_diving
    37: status_digging
    38: status_charging
    39: status_enraged
    40: status_shadow_force
    41: status_half_speed
    42: status_reflect
    43: status_safeguard
    44: status_light_screen
    45: status_counter
    46: status_magic_coat
    47: status_wish
    48: status_protect
    49: status_mirror_coat
    50: status_enduring
    51: status_mini_counter
    52: status_mirror_move
    53: status_conversion2
    54: status_vital_throw
    55: status_mist
    56: status_metal_burst
    57: status_aqua_ring
    58: status_lucky_chant
    59: status_weakened
    60: status_cursed
    61: status_decoy
    62: status_snatch
    63: status_gastro_acid
    64: status_heal_block
    65: status_embargo
    66: status_hungry_pal
    67: status_leech_seed
    68: status_destiny_bond
    69: status_powered_up
    70: status_sure_shot
    71: status_whiffer
    72: status_set_damage
    73: status_focus_energy
    74: status_unnamed_0x4a
    75: status_long_toss
    76: status_pierce
    77: status_unnamed_0x4d
    78: status_invisible
    79: status_transformed
    80: status_mobile
    81: status_slip
    82: status_unnamed_0x52
    83: status_blinker
    84: status_cross_eyed
    85: status_eyedrops
    86: status_dropeye
    87: status_unnamed_0x57
    88: status_muzzled
    89: status_unnamed_0x59
    90: status_miracle_eye
    91: status_unnamed_0x5b
    92: status_magnet_rise
    93: status_stockpiling
    94: status_power_ears
    95: status_scanning
    96: status_grudge
    97: status_exposed
    98: status_terrified
    99: status_perish_song
    100: status_doubled_attack
    101: status_stair_spotter
