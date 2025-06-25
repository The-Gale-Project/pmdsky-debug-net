doc: Represents a struct or union entity_table_hdr defined within pmdsky-debug.
meta:
  id: entity_table_hdr
  endian: le
  bit-endian: le
  imports:
  - entity_table_hdr_monster_slot_ptrs_array
  - entity_table_hdr_active_monster_ptrs_array
  - entity_table_hdr_item_ptrs_array
  - entity_table_hdr_trap_ptrs_array
  - pointer
seq:
- id: monster_slot_ptrs
  type: entity_table_hdr_monster_slot_ptrs_array
- id: active_monster_ptrs
  type: entity_table_hdr_active_monster_ptrs_array
- id: item_ptrs
  type: entity_table_hdr_item_ptrs_array
- id: trap_ptrs
  type: entity_table_hdr_trap_ptrs_array
- id: hidden_stairs_ptr
  type: pointer
