doc: Represents an array OUTLAW_MISSION_REWARD_TYPE_WEIGHTS defined within 
  pmdsky.
meta:
  id: outlaw_mission_reward_type_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: outlaw_mission_reward_type_weights_array_dim_0
types:
  outlaw_mission_reward_type_weights_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 7
