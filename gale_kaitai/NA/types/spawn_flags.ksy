doc: Represents a struct or union spawn_flags defined within pmdsky-debug.
meta:
  id: spawn_flags
  endian: le
  bit-endian: le
  imports: []
seq:
- id: f_stairs
  type: b1
- id: f_item
  type: b1
- id: f_trap
  type: b1
- id: f_monster
  type: b1
- id: spawn_flags_unk4
  type: b12
