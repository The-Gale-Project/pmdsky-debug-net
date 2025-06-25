doc: Represents an array IQ_SKILL_RESTRICTIONS defined within pmdsky.
meta:
  id: iq_skill_restrictions_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: iq_skill_restrictions_array_dim_0
types:
  iq_skill_restrictions_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 69
