doc: Represents an array STRING_MONSTER_M_GROUND_BIN defined within pmdsky.
meta:
  id: string_monster_m_ground_bin_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_monster_m_ground_bin_array_dim_0
types:
  string_monster_m_ground_bin_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 24
