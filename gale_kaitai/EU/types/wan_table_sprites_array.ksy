doc: Represents an array wan_table_sprites defined within pmdsky.
meta:
  id: wan_table_sprites_array
  endian: le
  bit-endian: le
  imports:
  - wan_table_entry
seq:
- id: entries
  type: wan_table_sprites_array_dim_0
types:
  wan_table_sprites_array_dim_0:
    seq:
    - id: entries
      type: wan_table_entry
      repeat: expr
      repeat-expr: 96
