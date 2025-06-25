doc: Represents a struct or union dse_track defined within pmdsky-debug.
meta:
  id: dse_track
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_track_loop_stack_array
seq:
- id: field_0x0
  type: u2
- id: is_playing
  type: s1
- id: field_0x3
  type: u1
- id: current_octave
  type: u1
- id: note_duration_multiplier
  type: u1
- id: loop_stack_index
  type: u1
- id: previous_note_number
  type: u1
- id: ignore_playnote
  type: u1
- id: field_0x9
  type: u1
- id: main_loop_count
  type: u2
- id: wait_ticks_left
  type: s4
- id: previous_wait_ticks
  type: s4
- id: previous_duration
  type: s4
- id: track_data_location
  type: pointer
- id: position
  type: pointer
- id: loop_stack
  type: dse_track_loop_stack_array
- id: field_0x50
  type: u4
- id: channel
  type: pointer
- id: field_0x58
  type: u4
