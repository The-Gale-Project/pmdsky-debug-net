doc: Holds the data for the enum status_curse_id.
meta:
  id: status_curse_id
  endian: le
  bit-endian: le
seq:
- id: status_curse_id_value
  type: b32
  enum: status_curse_id_enum
enums:
  status_curse_id_enum:
    0: status_curse_none
    1: status_curse_cursed
    2: status_curse_decoy
    3: status_curse_snatch
    4: status_curse_gastro_acid
    5: status_curse_heal_block
    6: status_curse_embargo
