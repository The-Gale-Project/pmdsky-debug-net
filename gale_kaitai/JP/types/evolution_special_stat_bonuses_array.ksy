doc: Represents an array EVOLUTION_SPECIAL_STAT_BONUSES defined within pmdsky.
meta:
  id: evolution_special_stat_bonuses_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: evolution_special_stat_bonuses_array_dim_0
types:
  evolution_special_stat_bonuses_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
