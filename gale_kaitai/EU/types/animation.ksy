doc: Represents a struct or union animation defined within pmdsky-debug.
meta:
  id: animation
  endian: le
  bit-endian: le
  imports:
  - animation_field_0x0_array
  - animation_control
  - animation_fields_array
seq:
- id: field_0x0
  type: animation_field_0x0_array
- id: ctrl
  type: animation_control
- id: fields
  type: animation_fields_array
