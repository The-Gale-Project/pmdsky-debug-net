doc: Represents an array dungeon_fainted_monster_cause_entity_name defined 
  within pmdsky.
meta:
  id: dungeon_fainted_monster_cause_entity_name_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_fainted_monster_cause_entity_name_array_dim_0
types:
  dungeon_fainted_monster_cause_entity_name_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 30
