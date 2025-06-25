doc: Represents an array CAFE_MISSION_REWARD_TYPE_WEIGHTS defined within pmdsky.
meta:
  id: cafe_mission_reward_type_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: cafe_mission_reward_type_weights_array_dim_0
types:
  cafe_mission_reward_type_weights_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 7
