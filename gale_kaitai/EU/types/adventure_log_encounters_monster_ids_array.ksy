doc: Represents an array ADVENTURE_LOG_ENCOUNTERS_MONSTER_IDS defined within 
  pmdsky.
meta:
  id: adventure_log_encounters_monster_ids_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: adventure_log_encounters_monster_ids_array_dim_0
types:
  adventure_log_encounters_monster_ids_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 38
