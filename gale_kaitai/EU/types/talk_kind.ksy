doc: Holds the data for the enum talk_kind.
meta:
  id: talk_kind
  endian: le
  bit-endian: le
seq:
- id: talk_kind_value
  type: b32
  enum: talk_kind_enum
enums:
  talk_kind_enum:
    0: talk_none
    1: talk_partner_male_special
    2: talk_partner_default
    3: talk_partner_female_special
    4: talk_hero_male
    5: talk_hero_female
