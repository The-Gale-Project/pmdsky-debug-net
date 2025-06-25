doc: Holds the data for the enum move_ai_condition.
meta:
  id: move_ai_condition
  endian: le
  bit-endian: le
seq:
- id: move_ai_condition_value
  type: b32
  enum: move_ai_condition_enum
enums:
  move_ai_condition_enum:
    0: ai_condition_none
    1: ai_condition_random
    2: ai_condition_hp_25
    3: ai_condition_status
    4: ai_condition_asleep
    5: ai_condition_ghost
    6: ai_condition_hp_25_or_status
