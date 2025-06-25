doc: Represents an array POSITION_DISPLACEMENT_TO_DIRECTION defined within 
  pmdsky.
meta:
  id: position_displacement_to_direction_array
  endian: le
  bit-endian: le
  imports:
  - direction_id
seq:
- id: entries
  type: position_displacement_to_direction_array_dim_1
types:
  position_displacement_to_direction_array_dim_0:
    seq:
    - id: entries
      type: direction_id
      repeat: expr
      repeat-expr: 3
  position_displacement_to_direction_array_dim_1:
    seq:
    - id: entries
      type: position_displacement_to_direction_array_dim_0
      repeat: expr
      repeat-expr: 3
