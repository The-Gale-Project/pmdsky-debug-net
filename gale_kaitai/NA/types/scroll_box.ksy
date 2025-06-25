doc: Represents a struct or union scroll_box defined within pmdsky-debug.
meta:
  id: scroll_box
  endian: le
  bit-endian: le
  imports:
  - pointer
  - window_input_ctx
  - window_flags
  - window_extra_info
  - scroll_box_string_ids1_array
  - scroll_box_preprocessor_args1_array
  - scroll_box_string_ids2_array
  - scroll_box_preprocessor_args2_array
  - scroll_box_unk_struct_arr_array
  - preprocessor_args
  - scroll_box_strings1_array
  - scroll_box_strings2_array
  - scroll_box_unk_coords_array
  - scroll_box_field_0x1568_array
  - scroll_box_string_buffer1_array
  - scroll_box_string_buffer2_array
seq:
- id: update
  type: pointer
- id: input_ctx
  type: window_input_ctx
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: n_strings
  type: s4
- id: page
  type: s4
- id: string_ids1
  type: scroll_box_string_ids1_array
- id: preprocessor_args1
  type: scroll_box_preprocessor_args1_array
- id: string_ids2
  type: scroll_box_string_ids2_array
- id: preprocessor_args2
  type: scroll_box_preprocessor_args2_array
- id: unk_struct_arr_len
  type: s4
- id: unk_struct_arr
  type: scroll_box_unk_struct_arr_array
- id: state
  type: s4
- id: field_0x1468
  type: u1
- id: field_0x1469
  type: u1
- id: field_0x146a
  type: u1
- id: field_0x146b
  type: u1
- id: preprocessor_args3
  type: preprocessor_args
- id: field_0x14bc
  type: s4
- id: field_0x14c0
  type: u4
- id: strings1
  type: scroll_box_strings1_array
- id: strings2
  type: scroll_box_strings2_array
- id: unk_coords_len
  type: s4
- id: unk_coords
  type: scroll_box_unk_coords_array
- id: field_0x1568
  type: scroll_box_field_0x1568_array
- id: string_buffer1
  type: scroll_box_string_buffer1_array
- id: string_buffer2
  type: scroll_box_string_buffer2_array
