doc: Represents an array DEFAULT_MISSION_REWARD_TYPE_WEIGHTS defined within 
  pmdsky.
meta:
  id: default_mission_reward_type_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: default_mission_reward_type_weights_array_dim_0
types:
  default_mission_reward_type_weights_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 7
