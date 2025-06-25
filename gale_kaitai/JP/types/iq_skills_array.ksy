doc: Represents an array IQ_SKILLS defined within pmdsky.
meta:
  id: iq_skills_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: iq_skills_array_dim_0
types:
  iq_skills_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 69
