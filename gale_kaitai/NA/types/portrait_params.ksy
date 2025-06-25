doc: Represents a struct or union portrait_params defined within pmdsky-debug.
meta:
  id: portrait_params
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - portrait_emotion_8
seq:
- id: monster_id
  type: monster_id_16
- id: portrait_emotion
  type: portrait_emotion_8
- id: layout_idx
  type: u1
- id: offset_x
  type: u4
- id: offset_y
  type: u4
- id: try_flip
  type: u1
- id: has_flip
  type: u1
- id: hw_flip
  type: u1
- id: allow_default
  type: u1
