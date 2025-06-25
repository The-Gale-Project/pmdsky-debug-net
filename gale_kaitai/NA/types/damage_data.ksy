doc: Represents a struct or union damage_data defined within pmdsky-debug.
meta:
  id: damage_data
  endian: le
  bit-endian: le
  imports:
  - damage_message
  - type_matchup
  - type_id_8
  - move_category_8
seq:
- id: damage
  type: s4
- id: damage_message
  type: damage_message
- id: type_matchup
  type: type_matchup
- id: type
  type: type_id_8
- id: category
  type: move_category_8
- id: critical_hit
  type: u1
- id: full_type_immunity
  type: u1
- id: no_damage
  type: u1
- id: field_0x11
  type: u1
- id: field_0x12
  type: u1
- id: field_0x13
  type: u1
