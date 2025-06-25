doc: Represents a struct or union dse_note_list_node defined within 
  pmdsky-debug.
meta:
  id: dse_note_list_node
  endian: le
  bit-endian: le
  imports:
  - dse_note
  - pointer
seq:
- id: note
  type: dse_note
- id: next
  type: pointer
