doc: Represents an array TBL_TALK_GROUP_STRING_ID_START defined within pmdsky.
meta:
  id: tbl_talk_group_string_id_start_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: tbl_talk_group_string_id_start_array_dim_0
types:
  tbl_talk_group_string_id_start_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 6
