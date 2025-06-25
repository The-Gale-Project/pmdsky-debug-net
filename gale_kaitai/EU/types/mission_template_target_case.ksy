doc: Holds the data for the enum mission_template_target_case.
meta:
  id: mission_template_target_case
  endian: le
  bit-endian: le
seq:
- id: mission_template_target_case_value
  type: b32
  enum: mission_template_target_case_enum
enums:
  mission_template_target_case_enum:
    0: target_case_fixed_target_old
    1: target_case_fixed_target_new
    2: target_case_table_target
    3: target_case_unk_3
    4: case_random_target
    5: target_case_unk_5
    6: target_case_random_target_06
