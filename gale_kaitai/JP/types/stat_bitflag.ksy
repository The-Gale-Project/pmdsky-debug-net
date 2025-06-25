doc: Represents a struct or union stat_bitflag defined within pmdsky-debug.
meta:
  id: stat_bitflag
  endian: le
  bit-endian: le
  imports: []
seq:
- id: f_attack
  type: b1
- id: f_special_attack
  type: b1
- id: f_defense
  type: b1
- id: f_special_defense
  type: b1
- id: f_unused
  type: b12
