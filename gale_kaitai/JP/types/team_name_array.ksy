doc: Represents an array TEAM_NAME defined within pmdsky.
meta:
  id: team_name_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: team_name_array_dim_0
types:
  team_name_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 5
