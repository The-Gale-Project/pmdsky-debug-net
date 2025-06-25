doc: Holds the data for the enum mission_template_client_case.
meta:
  id: mission_template_client_case
  endian: le
  bit-endian: le
seq:
- id: mission_template_client_case_value
  type: b32
  enum: mission_template_client_case_enum
enums:
  mission_template_client_case_enum:
    0: client_case_fixed_client_old
    1: client_case_fixed_client_new
    2: client_case_table_client
    3: client_case_unk_3
    4: client_case_random_client
