doc: Represents an array alert_box_field_0x124 defined within pmdsky.
meta:
  id: alert_box_field_0x124_array
  endian: le
  bit-endian: le
  imports:
  - unk_alert_box_struct
seq:
- id: entries
  type: alert_box_field_0x124_array_dim_0
types:
  alert_box_field_0x124_array_dim_0:
    seq:
    - id: entries
      type: unk_alert_box_struct
      repeat: expr
      repeat-expr: 4
