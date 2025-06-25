doc: Represents an array dse_voice_update_flags_flags defined within pmdsky.
meta:
  id: dse_voice_update_flags_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_voice_update_flags_flags_array_dim_0
types:
  dse_voice_update_flags_flags_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 8
