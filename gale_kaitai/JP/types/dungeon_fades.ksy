doc: Represents a struct or union dungeon_fades defined within pmdsky-debug.
meta:
  id: dungeon_fades
  endian: le
  bit-endian: le
  imports:
  - dungeon_fade
  - top_screen_status
seq:
- id: bottom_screen_dungeon_fade
  type: dungeon_fade
- id: top_screen_dungeon_fade
  type: dungeon_fade
- id: bottom_screen_status
  type: s4
- id: top_screen_status
  type: top_screen_status
