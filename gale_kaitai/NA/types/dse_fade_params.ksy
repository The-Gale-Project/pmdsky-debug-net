doc: Represents a struct or union dse_fade_params defined within pmdsky-debug.
meta:
  id: dse_fade_params
  endian: le
  bit-endian: le
  imports: []
seq:
- id: use_fade_flags
  type: u1
- id: field_0x2
  type: u1
- id: unknown_msecs
  type: s2
- id: tempo_target
  type: s2
- id: tempo_fade_msec
  type: u2
- id: bend_target
  type: s2
- id: bend_fade_msec
  type: u2
- id: volume_target
  type: s2
- id: volume_fade_msec
  type: s2
- id: pan_target
  type: u2
- id: pan_fade_msec
  type: u2
