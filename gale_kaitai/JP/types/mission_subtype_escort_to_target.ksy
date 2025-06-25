doc: Holds the data for the enum mission_subtype_escort_to_target.
meta:
  id: mission_subtype_escort_to_target
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_escort_to_target_value
  type: b32
  enum: mission_subtype_escort_to_target_enum
enums:
  mission_subtype_escort_to_target_enum:
    0: mission_escort_client_target_random
    1: mission_escort_client_target_specific
