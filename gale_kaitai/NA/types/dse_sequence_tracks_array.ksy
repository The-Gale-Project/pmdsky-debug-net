doc: Represents an array dse_sequence_tracks defined within pmdsky.
meta:
  id: dse_sequence_tracks_array
  endian: le
  bit-endian: le
  imports:
  - dse_track
seq:
- id: entries
  type: dse_sequence_tracks_array_dim_0
types:
  dse_sequence_tracks_array_dim_0:
    seq:
    - id: entries
      type: dse_track
      repeat: eos
