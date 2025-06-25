doc: Holds the data for the enum ai_objective.
meta:
  id: ai_objective
  endian: le
  bit-endian: le
seq:
- id: ai_objective_value
  type: b32
  enum: ai_objective_enum
enums:
  ai_objective_enum:
    0: ai_unknown
    1: ai_chase_target
    2: ai_chase_remembered_target
    3: ai_roam
    4: ai_leave_room
    5: ai_run_away
    6: ai_stand_still
    7: ai_take_item
