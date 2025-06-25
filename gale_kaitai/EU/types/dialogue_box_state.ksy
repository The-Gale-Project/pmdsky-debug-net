doc: Holds the data for the enum dialogue_box_state.
meta:
  id: dialogue_box_state
  endian: le
  bit-endian: le
seq:
- id: dialogue_box_state_value
  type: b32
  enum: dialogue_box_state_enum
enums:
  dialogue_box_state_enum:
    0: dialogue_box_state_inactive
    1: dialogue_box_state_1
    2: dialogue_box_state_2
    3: dialogue_box_state_3
    4: dialogue_box_state_4
