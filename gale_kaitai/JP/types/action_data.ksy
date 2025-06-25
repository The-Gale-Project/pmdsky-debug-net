doc: Represents a struct or union action_data defined within pmdsky-debug.
meta:
  id: action_data
  endian: le
  bit-endian: le
  imports:
  - action_16
  - direction_id_8
  - action_data_action_parameters_array
  - position
seq:
- id: action_id
  type: action_16
- id: direction
  type: direction_id_8
- id: field_0x3
  type: u1
- id: action_parameters
  type: action_data_action_parameters_array
- id: arc_item_target_pos
  type: position
