doc: Holds the data for the enum mission_template_item_case.
meta:
  id: mission_template_item_case
  endian: le
  bit-endian: le
seq:
- id: mission_template_item_case_value
  type: b32
  enum: mission_template_item_case_enum
enums:
  mission_template_item_case_enum:
    0: item_case_unk_0
    1: item_case_specific_item
    2: item_case_use_item_table
    3: item_case_unk_3
    4: item_case_no_item
