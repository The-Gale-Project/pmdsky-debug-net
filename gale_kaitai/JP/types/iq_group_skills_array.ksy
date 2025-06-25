doc: Represents an array IQ_GROUP_SKILLS defined within pmdsky.
meta:
  id: iq_group_skills_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: iq_group_skills_array_dim_0
types:
  iq_group_skills_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 400
