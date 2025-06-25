doc: Represents an array OVERLAY11_OVERLAY_LOAD_TABLE defined within pmdsky.
meta:
  id: overlay11_overlay_load_table_array
  endian: le
  bit-endian: le
  imports:
  - overlay_load_entry
seq:
- id: entries
  type: overlay11_overlay_load_table_array_dim_0
types:
  overlay11_overlay_load_table_array_dim_0:
    seq:
    - id: entries
      type: overlay_load_entry
      repeat: expr
      repeat-expr: 21
