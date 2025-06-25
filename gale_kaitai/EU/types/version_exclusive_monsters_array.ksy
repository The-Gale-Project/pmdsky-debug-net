doc: Represents an array VERSION_EXCLUSIVE_MONSTERS defined within pmdsky.
meta:
  id: version_exclusive_monsters_array
  endian: le
  bit-endian: le
  imports:
  - version_exclusive_monster
seq:
- id: entries
  type: version_exclusive_monsters_array_dim_0
types:
  version_exclusive_monsters_array_dim_0:
    seq:
    - id: entries
      type: version_exclusive_monster
      repeat: expr
      repeat-expr: 23
