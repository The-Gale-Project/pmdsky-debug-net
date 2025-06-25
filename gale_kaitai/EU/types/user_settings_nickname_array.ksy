doc: Represents an array user_settings_nickname defined within pmdsky.
meta:
  id: user_settings_nickname_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: user_settings_nickname_array_dim_0
types:
  user_settings_nickname_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 10
