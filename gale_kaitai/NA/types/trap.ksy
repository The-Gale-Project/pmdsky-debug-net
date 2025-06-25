doc: Represents a struct or union trap defined within pmdsky-debug.
meta:
  id: trap
  endian: le
  bit-endian: le
  imports:
  - trap_id_8
seq:
- id: id
  type: trap_id_8
- id: team
  type: u1
- id: f_unbreakable
  type: b1
- id: flags_unk1
  type: b7
- id: field_0x3
  type: u1
