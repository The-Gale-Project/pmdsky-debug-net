doc: Represents an array STRING_DUNGEON_DUNGEON_BIN defined within pmdsky.
meta:
  id: string_dungeon_dungeon_bin_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_dungeon_dungeon_bin_array_dim_0
types:
  string_dungeon_dungeon_bin_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 20
