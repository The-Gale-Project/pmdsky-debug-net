doc: Represents an array PORTRAIT_LAYOUTS defined within pmdsky.
meta:
  id: portrait_layouts_array
  endian: le
  bit-endian: le
  imports:
  - portrait_layout
seq:
- id: entries
  type: portrait_layouts_array_dim_0
types:
  portrait_layouts_array_dim_0:
    seq:
    - id: entries
      type: portrait_layout
      repeat: expr
      repeat-expr: 32
