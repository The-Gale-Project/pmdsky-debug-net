doc: Represents a struct or union dse_fade defined within pmdsky-debug.
meta:
  id: dse_fade
  endian: le
  bit-endian: le
  imports: []
seq:
- id: current
  type: s4
- id: delta
  type: s4
- id: target
  type: s4
- id: ticks_remaining
  type: s2
- id: padding
  type: u2
