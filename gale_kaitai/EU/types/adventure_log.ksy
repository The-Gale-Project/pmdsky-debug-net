doc: Represents a struct or union adventure_log defined within pmdsky-debug.
meta:
  id: adventure_log
  endian: le
  bit-endian: le
  imports:
  - adventure_log_completion_flags_array
  - adventure_log_pokemon_joined_flags_array
  - adventure_log_pokemon_battled_flags_array
  - adventure_log_moves_learned_flags_array
  - adventure_log_items_acquired_flags_array
  - adventure_log_sentry_duty_game_points_array
  - dungeon_floor_pair
seq:
- id: completion_flags
  type: adventure_log_completion_flags_array
- id: nb_dungeons_cleared
  type: u4
- id: nb_friend_rescues
  type: u4
- id: nb_evolutions
  type: u4
- id: nb_eggs_hatched
  type: u4
- id: successful_steals
  type: u4
- id: nb_faints
  type: u4
- id: nb_victories_on_one_floor
  type: u4
- id: pokemon_joined_counter
  type: u4
- id: pokemon_battled_counter
  type: u4
- id: moves_learned_counter
  type: u4
- id: nb_big_treasure_wins
  type: u4
- id: nb_recycled
  type: u4
- id: nb_gifts_sent
  type: u4
- id: pokemon_joined_flags
  type: adventure_log_pokemon_joined_flags_array
- id: pokemon_battled_flags
  type: adventure_log_pokemon_battled_flags_array
- id: moves_learned_flags
  type: adventure_log_moves_learned_flags_array
- id: items_acquired_flags
  type: adventure_log_items_acquired_flags_array
- id: special_challenge_flags
  type: u4
- id: sentry_duty_game_points
  type: adventure_log_sentry_duty_game_points_array
- id: current_floor
  type: dungeon_floor_pair
- id: padding
  type: u2
