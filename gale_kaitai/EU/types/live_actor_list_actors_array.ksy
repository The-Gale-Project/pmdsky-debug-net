doc: Represents an array live_actor_list_actors defined within pmdsky.
meta:
  id: live_actor_list_actors_array
  endian: le
  bit-endian: le
  imports:
  - live_actor
seq:
- id: entries
  type: live_actor_list_actors_array_dim_0
types:
  live_actor_list_actors_array_dim_0:
    seq:
    - id: entries
      type: live_actor
      repeat: expr
      repeat-expr: 24
