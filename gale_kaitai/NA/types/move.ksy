doc: Represents a struct or union move defined within pmdsky-debug.
meta:
  id: move
  endian: le
  bit-endian: le
  imports:
  - move_id_16
seq:
- id: f_exists
  type: b1
- id: f_subsequent_in_link_chain
  type: b1
- id: f_enabled_for_ai
  type: b1
- id: f_set
  type: b1
- id: f_last_used
  type: b1
- id: f_disabled
  type: b1
- id: flags0_unk6
  type: b2
- id: field_0x1
  type: u1
- id: f_sealed
  type: b1
- id: flags2_unk1
  type: b2
- id: f_consume_pp
  type: b1
- id: f_consume_2_pp
  type: b1
- id: flags2_unk5
  type: b1
- id: f_consume_4_pp
  type: b1
- id: flags2_unk7
  type: b1
- id: f_multitalent_pp_boost
  type: b1
- id: f_exclusive_item_pp_boost
  type: b1
- id: f_unknown_pp_boost
  type: b1
- id: flags3_unk11
  type: b5
- id: id
  type: move_id_16
- id: pp
  type: u1
- id: ginseng
  type: u1
