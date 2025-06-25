doc: Represents an array dse_driver_work_notes defined within pmdsky.
meta:
  id: dse_driver_work_notes_array
  endian: le
  bit-endian: le
  imports:
  - dse_note_list_node
seq:
- id: entries
  type: dse_driver_work_notes_array_dim_0
types:
  dse_driver_work_notes_array_dim_0:
    seq:
    - id: entries
      type: dse_note_list_node
      repeat: expr
      repeat-expr: 128
