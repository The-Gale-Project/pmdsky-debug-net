doc: Holds the data for the enum script_var_type.
meta:
  id: script_var_type
  endian: le
  bit-endian: le
seq:
- id: script_var_type_value
  type: b32
  enum: script_var_type_enum
enums:
  script_var_type_enum:
    0: vartype_none
    1: vartype_bit
    2: vartype_string
    3: vartype_uint8
    4: vartype_int8
    5: vartype_uint16
    6: vartype_int16
    7: vartype_uint32
    8: vartype_int32
    9: vartype_special
