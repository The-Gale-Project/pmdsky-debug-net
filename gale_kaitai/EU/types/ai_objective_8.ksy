doc: Holds bitsized data for the parent enum ai_objective.
meta:
  id: ai_objective_8
  endian: le
  bit-endian: le
seq:
- id: ai_objective_8_value
  type: b8
  enum: ai_objective_8_enum
enums:
  ai_objective_8_enum:
    0: ai_unknown
    1: ai_chase_target
    2: ai_chase_remembered_target
    3: ai_roam
    4: ai_leave_room
    5: ai_run_away
    6: ai_stand_still
    7: ai_take_item
