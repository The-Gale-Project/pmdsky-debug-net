doc: Represents an array IQ_GUMMI_GAIN_TABLE defined within pmdsky.
meta:
  id: iq_gummi_gain_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: iq_gummi_gain_table_array_dim_1
types:
  iq_gummi_gain_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 18
  iq_gummi_gain_table_array_dim_1:
    seq:
    - id: entries
      type: iq_gummi_gain_table_array_dim_0
      repeat: expr
      repeat-expr: 18
