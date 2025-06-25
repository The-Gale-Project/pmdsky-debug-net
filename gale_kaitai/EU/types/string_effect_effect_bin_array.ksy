doc: Represents an array STRING_EFFECT_EFFECT_BIN defined within pmdsky.
meta:
  id: string_effect_effect_bin_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_effect_effect_bin_array_dim_0
types:
  string_effect_effect_bin_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 20
