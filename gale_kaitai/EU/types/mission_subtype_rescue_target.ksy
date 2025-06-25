doc: Holds the data for the enum mission_subtype_rescue_target.
meta:
  id: mission_subtype_rescue_target
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_rescue_target_value
  type: b32
  enum: mission_subtype_rescue_target_enum
enums:
  mission_subtype_rescue_target_enum:
    0: mission_rescue_client_target_random
    1: mission_rescue_client_target_child
    2: mission_rescue_client_target_similar_friends
    3: mission_rescue_client_target_lovers_rivals
