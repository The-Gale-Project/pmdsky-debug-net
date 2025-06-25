doc: Represents an array GUMMI_IQ_STRING_IDS defined within pmdsky.
meta:
  id: gummi_iq_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: gummi_iq_string_ids_array_dim_0
types:
  gummi_iq_string_ids_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 5
