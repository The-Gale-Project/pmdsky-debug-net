doc: Represents a struct or union animation_data defined within pmdsky-debug.
meta:
  id: animation_data
  endian: le
  bit-endian: le
  imports:
  - animation_speed_2
seq:
- id: animation_id
  type: u1
- id: animation_speed
  type: animation_speed_2
- id: f_unk1
  type: b1
- id: loop
  type: b1
- id: f_unk3
  type: b1
- id: f_unused
  type: b3
