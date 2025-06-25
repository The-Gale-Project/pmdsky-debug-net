doc: Represents a struct or union ground_entity_function_table defined within 
  pmdsky-debug.
meta:
  id: ground_entity_function_table
  endian: le
  bit-endian: le
  imports:
  - script_routine_kind_16
  - pointer
seq:
- id: routine_kind
  type: script_routine_kind_16
- id: padding
  type: u2
- id: get_id
  type: pointer
- id: get_collision_box
  type: pointer
- id: get_collision_box_center
  type: pointer
- id: get_height
  type: pointer
- id: get_direction
  type: pointer
- id: get_attribute_bitfield
  type: pointer
- id: set_position_initial
  type: pointer
- id: set_movement_range
  type: pointer
- id: set_position
  type: pointer
- id: set_height
  type: pointer
- id: set_direction
  type: pointer
- id: set_animation
  type: pointer
- id: set_effect
  type: pointer
- id: set_attribute_bitfield_wrapper
  type: pointer
- id: reset_attribute_bitfield_wrapper
  type: pointer
- id: set_blink
  type: pointer
- id: set_position_offset
  type: pointer
- id: get_animation_status
  type: pointer
- id: get_effect_status
  type: pointer
