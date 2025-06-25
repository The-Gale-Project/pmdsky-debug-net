doc: Represents an array MAP_MARKER_PLACEMENTS defined within pmdsky.
meta:
  id: map_marker_placements_array
  endian: le
  bit-endian: le
  imports:
  - map_marker
seq:
- id: entries
  type: map_marker_placements_array_dim_0
types:
  map_marker_placements_array_dim_0:
    seq:
    - id: entries
      type: map_marker
      repeat: expr
      repeat-expr: 310
