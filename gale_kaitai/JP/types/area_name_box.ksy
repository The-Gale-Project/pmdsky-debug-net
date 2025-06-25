doc: Represents a struct or union area_name_box defined within pmdsky-debug.
meta:
  id: area_name_box
  endian: le
  bit-endian: le
  imports:
  - pointer
  - window_flags
  - window_extra_info
  - area_name_box_string_buffer_array
seq:
- id: update
  type: pointer
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: state
  type: s4
- id: id
  type: u4
- id: text_width
  type: s4
- id: string_buffer
  type: area_name_box_string_buffer_array
- id: y_padding
  type: s4
- id: x_padding
  type: s4
