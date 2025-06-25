doc: Represents a struct or union item defined within pmdsky-debug.
meta:
  id: item
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: f_exists
  type: b1
- id: f_in_shop
  type: b1
- id: f_unpaid
  type: b1
- id: f_sticky
  type: b1
- id: f_set
  type: b1
- id: flag_unk5
  type: b1
- id: f_unk_mission_item1
  type: b1
- id: f_unk_mission_item2
  type: b1
- id: held_by
  type: u1
- id: quantity
  type: u2
- id: id
  type: item_id_16
