doc: Represents a struct or union global_progress defined within pmdsky-debug.
meta:
  id: global_progress
  endian: le
  bit-endian: le
  imports:
  - global_progress_unk_pokemon_flags1_array
  - global_progress_field_0x94_array
  - global_progress_unk_pokemon_flags2_array
  - global_progress_exclusive_pokemon_flags_array
  - global_progress_dungeon_max_reached_floor_array
  - global_progress_field_0x1fc_array
seq:
- id: unk_pokemon_flags1
  type: global_progress_unk_pokemon_flags1_array
- id: field_0x94
  type: global_progress_field_0x94_array
- id: unk_pokemon_flags2
  type: global_progress_unk_pokemon_flags2_array
- id: exclusive_pokemon_flags
  type: global_progress_exclusive_pokemon_flags_array
- id: dungeon_max_reached_floor
  type: global_progress_dungeon_max_reached_floor_array
- id: field_0x1f7
  type: u1
- id: nb_adventures
  type: u4
- id: field_0x1fc
  type: global_progress_field_0x1fc_array
