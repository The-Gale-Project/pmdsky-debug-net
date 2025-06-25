doc: Represents an array EGG_STAT_BONUSES defined within pmdsky.
meta:
  id: egg_stat_bonuses_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: egg_stat_bonuses_array_dim_0
types:
  egg_stat_bonuses_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 4
