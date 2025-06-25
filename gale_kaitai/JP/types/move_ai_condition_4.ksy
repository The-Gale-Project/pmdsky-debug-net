doc: Holds bitsized data for the parent enum move_ai_condition.
meta:
  id: move_ai_condition_4
  endian: le
  bit-endian: le
seq:
- id: move_ai_condition_4_value
  type: b4
  enum: move_ai_condition_4_enum
enums:
  move_ai_condition_4_enum:
    0: ai_condition_none
    1: ai_condition_random
    2: ai_condition_hp_25
    3: ai_condition_status
    4: ai_condition_asleep
    5: ai_condition_ghost
    6: ai_condition_hp_25_or_status
