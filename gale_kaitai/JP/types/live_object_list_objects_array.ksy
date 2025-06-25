doc: Represents an array live_object_list_objects defined within pmdsky.
meta:
  id: live_object_list_objects_array
  endian: le
  bit-endian: le
  imports:
  - live_object
seq:
- id: entries
  type: live_object_list_objects_array_dim_0
types:
  live_object_list_objects_array_dim_0:
    seq:
    - id: entries
      type: live_object
      repeat: expr
      repeat-expr: 16
