doc: Represents an array MISSION_FLOORS_FORBIDDEN defined within pmdsky.
meta:
  id: mission_floors_forbidden_array
  endian: le
  bit-endian: le
  imports:
  - mission_floors_forbidden
seq:
- id: entries
  type: mission_floors_forbidden_array_dim_0
types:
  mission_floors_forbidden_array_dim_0:
    seq:
    - id: entries
      type: mission_floors_forbidden
      repeat: expr
      repeat-expr: 100
