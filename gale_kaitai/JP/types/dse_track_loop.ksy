doc: Represents a struct or union dse_track_loop defined within pmdsky-debug.
meta:
  id: dse_track_loop
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_track_loop_padding_array
seq:
- id: start_pos
  type: pointer
- id: continue_pos
  type: pointer
- id: loops_left
  type: u1
- id: padding
  type: dse_track_loop_padding_array
