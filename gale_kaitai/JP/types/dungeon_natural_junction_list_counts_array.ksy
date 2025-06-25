doc: Represents an array dungeon_natural_junction_list_counts defined within 
  pmdsky.
meta:
  id: dungeon_natural_junction_list_counts_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_natural_junction_list_counts_array_dim_0
types:
  dungeon_natural_junction_list_counts_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 32
