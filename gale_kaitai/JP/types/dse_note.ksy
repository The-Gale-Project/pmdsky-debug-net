doc: Represents a struct or union dse_note defined within pmdsky-debug.
meta:
  id: dse_note
  endian: le
  bit-endian: le
  imports: []
seq:
- id: is_note_on
  type: u1
- id: is_held
  type: u1
- id: note_number
  type: u1
- id: volume
  type: s1
- id: duration
  type: s4
