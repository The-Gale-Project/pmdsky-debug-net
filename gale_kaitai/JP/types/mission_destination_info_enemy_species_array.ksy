doc: Represents an array mission_destination_info_enemy_species defined within 
  pmdsky.
meta:
  id: mission_destination_info_enemy_species_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: mission_destination_info_enemy_species_array_dim_0
types:
  mission_destination_info_enemy_species_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 3
