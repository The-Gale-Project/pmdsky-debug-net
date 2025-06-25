doc: Holds the data for the enum shopkeeper_mode.
meta:
  id: shopkeeper_mode
  endian: le
  bit-endian: le
seq:
- id: shopkeeper_mode_value
  type: b32
  enum: shopkeeper_mode_enum
enums:
  shopkeeper_mode_enum:
    0: shopkeeper_mode_normal
    1: shopkeeper_mode_shopkeeper
    2: shopkeeper_mode_attack_enemies
    3: shopkeeper_mode_attack_team
