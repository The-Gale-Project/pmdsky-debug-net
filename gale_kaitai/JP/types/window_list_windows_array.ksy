doc: Represents an array window_list_windows defined within pmdsky.
meta:
  id: window_list_windows_array
  endian: le
  bit-endian: le
  imports:
  - window
seq:
- id: entries
  type: window_list_windows_array_dim_0
types:
  window_list_windows_array_dim_0:
    seq:
    - id: entries
      type: window
      repeat: expr
      repeat-expr: 20
