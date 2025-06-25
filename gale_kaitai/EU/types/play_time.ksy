doc: Represents a struct or union play_time defined within pmdsky-debug.
meta:
  id: play_time
  endian: le
  bit-endian: le
  imports:
  - play_time__padding_array
seq:
- id: seconds
  type: u4
- id: frames
  type: u1
- id: padding
  type: play_time__padding_array
