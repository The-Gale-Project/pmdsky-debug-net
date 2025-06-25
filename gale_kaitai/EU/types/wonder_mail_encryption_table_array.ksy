doc: Represents an array WONDER_MAIL_ENCRYPTION_TABLE defined within pmdsky.
meta:
  id: wonder_mail_encryption_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: wonder_mail_encryption_table_array_dim_0
types:
  wonder_mail_encryption_table_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 256
