doc: Represents a struct or union dialogue_box defined within pmdsky-debug.
meta:
  id: dialogue_box
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dialogue_box_state
  - dialogue_display_ctx
  - dialogue_box_string_data_array
seq:
- id: update
  type: pointer
- id: state
  type: dialogue_box_state
- id: active
  type: u1
- id: field_0x9
  type: u1
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: display_ctx
  type: dialogue_display_ctx
- id: string_data
  type: dialogue_box_string_data_array
