doc: Represents an array target_list_targets defined within pmdsky.
meta:
  id: target_list_targets_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: target_list_targets_array_dim_0
types:
  target_list_targets_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 64
