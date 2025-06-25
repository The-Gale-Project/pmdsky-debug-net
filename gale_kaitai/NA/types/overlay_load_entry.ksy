doc: Represents a struct or union overlay_load_entry defined within 
  pmdsky-debug.
meta:
  id: overlay_load_entry
  endian: le
  bit-endian: le
  imports:
  - overlay_group_id
  - pointer
seq:
- id: group
  type: overlay_group_id
- id: entrypoint
  type: pointer
- id: destructor
  type: pointer
- id: frame_update
  type: pointer
