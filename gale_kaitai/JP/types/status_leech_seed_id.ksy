doc: Holds the data for the enum status_leech_seed_id.
meta:
  id: status_leech_seed_id
  endian: le
  bit-endian: le
seq:
- id: status_leech_seed_id_value
  type: b32
  enum: status_leech_seed_id_enum
enums:
  status_leech_seed_id_enum:
    0: status_leech_seed_none
    1: status_leech_seed_leech_seed
    2: status_leech_seed_destiny_bond
