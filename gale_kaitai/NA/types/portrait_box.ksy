doc: Represents a struct or union portrait_box defined within pmdsky-debug.
meta:
  id: portrait_box
  endian: le
  bit-endian: le
  imports:
  - portrait_box_state
  - portrait_params
  - kaomado_buffer
seq:
- id: window_id
  type: u1
- id: padding_0x1
  type: u1
- id: padding_0x2
  type: u1
- id: padding_0x3
  type: u1
- id: state
  type: portrait_box_state
- id: render_state
  type: portrait_params
- id: buffer_state
  type: portrait_params
- id: updated
  type: u1
- id: hide
  type: u1
- id: framed
  type: u1
- id: padding_0x2b
  type: u1
- id: palette_idx
  type: u4
- id: buffer
  type: kaomado_buffer
