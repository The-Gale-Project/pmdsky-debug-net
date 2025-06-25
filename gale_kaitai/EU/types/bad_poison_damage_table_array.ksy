doc: Represents an array BAD_POISON_DAMAGE_TABLE defined within pmdsky.
meta:
  id: bad_poison_damage_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: bad_poison_damage_table_array_dim_0
types:
  bad_poison_damage_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 30
