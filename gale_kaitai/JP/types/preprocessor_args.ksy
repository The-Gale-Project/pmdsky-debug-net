doc: Represents a struct or union preprocessor_args defined within pmdsky-debug.
meta:
  id: preprocessor_args
  endian: le
  bit-endian: le
  imports:
  - preprocessor_args_flag_vals_array
  - preprocessor_args_id_vals_array
  - preprocessor_args_number_vals_array
  - preprocessor_args_strings_array
seq:
- id: flag_vals
  type: preprocessor_args_flag_vals_array
- id: id_vals
  type: preprocessor_args_id_vals_array
- id: number_vals
  type: preprocessor_args_number_vals_array
- id: strings
  type: preprocessor_args_strings_array
- id: speaker_id
  type: u4
