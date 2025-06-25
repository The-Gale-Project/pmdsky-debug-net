doc: Represents a struct or union script_routine defined within pmdsky-debug.
meta:
  id: script_routine
  endian: le
  bit-endian: le
  imports:
  - pointer
  - script_routine_kind_16
  - script_routine_states_array
seq:
- id: function_table
  type: pointer
- id: parent_entity
  type: pointer
- id: routine_kind
  type: script_routine_kind_16
- id: id
  type: s2
- id: states
  type: script_routine_states_array
