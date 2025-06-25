doc: Represents an array scroll_box_unk_coords defined within pmdsky.
meta:
  id: scroll_box_unk_coords_array
  endian: le
  bit-endian: le
  imports:
  - unk_scroll_box_coords
seq:
- id: entries
  type: scroll_box_unk_coords_array_dim_0
types:
  scroll_box_unk_coords_array_dim_0:
    seq:
    - id: entries
      type: unk_scroll_box_coords
      repeat: expr
      repeat-expr: 4
