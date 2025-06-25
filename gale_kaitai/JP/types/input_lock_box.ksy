doc: Represents a struct or union input_lock_box defined within pmdsky-debug.
meta:
  id: input_lock_box
  endian: le
  bit-endian: le
  imports:
  - pointer
  - window_input_ctx
  - window_extra_info
  - input_lock_box_string_buffer_array
seq:
- id: update
  type: pointer
- id: field_0x4
  type: u4
- id: input_ctx
  type: window_input_ctx
- id: field_0x100
  type: u4
- id: extra_info
  type: window_extra_info
- id: state
  type: s4
- id: string_id
  type: u2
- id: field_0x1a2
  type: u1
- id: field_0x1a3
  type: u1
- id: text_width
  type: s4
- id: string_buffer
  type: input_lock_box_string_buffer_array
- id: y_padding
  type: s4
- id: x_padding
  type: s4
