doc: Holds the data for the enum portrait_box_state.
meta:
  id: portrait_box_state
  endian: le
  bit-endian: le
seq:
- id: portrait_box_state_value
  type: b32
  enum: portrait_box_state_enum
enums:
  portrait_box_state_enum:
    0: portrait_box_hidden
    1: portrait_box_try_update
    2: portrait_box_update
    3: portrait_box_standby
    4: portrait_box_hide
