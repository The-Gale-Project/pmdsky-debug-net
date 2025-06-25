doc: Holds the data for the enum monster_gender.
meta:
  id: monster_gender
  endian: le
  bit-endian: le
seq:
- id: monster_gender_value
  type: b32
  enum: monster_gender_enum
enums:
  monster_gender_enum:
    0: gender_invalid
    1: gender_male
    2: gender_female
    3: gender_genderless
