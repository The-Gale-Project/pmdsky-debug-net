doc: Represents a struct or union guest_monster defined within pmdsky-debug.
meta:
  id: guest_monster
  endian: le
  bit-endian: le
  imports:
  - pointer
  - monster_id_16
  - dungeon_id_8
  - guest_monster_moves_array
seq:
- id: name
  type: pointer
- id: id
  type: monster_id_16
- id: joined_at
  type: dungeon_id_8
- id: joined_at_floor
  type: u1
- id: moves
  type: guest_monster_moves_array
- id: max_hp
  type: s2
- id: level
  type: u1
- id: field_0x13
  type: u1
- id: iq
  type: s2
- id: atk
  type: u1
- id: field_0x17
  type: u1
- id: sp_atk
  type: u1
- id: field_0x19
  type: u1
- id: def
  type: u1
- id: field_0x1b
  type: u1
- id: sp_def
  type: u1
- id: field_0x1d
  type: u1
- id: field_0x1e
  type: u1
- id: field_0x1f
  type: u1
- id: exp
  type: s4
