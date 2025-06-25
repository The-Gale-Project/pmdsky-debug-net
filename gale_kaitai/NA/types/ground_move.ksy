doc: Represents a struct or union ground_move defined within pmdsky-debug.
meta:
  id: ground_move
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
- id: flags_unk6
  type: b2
- id: field_0x1
  type: u1
- id: id
  type: move_id_16
- id: ginseng
  type: u1
- id: field_0x5
  type: u1
