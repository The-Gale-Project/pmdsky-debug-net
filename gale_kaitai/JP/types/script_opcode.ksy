doc: Represents a struct or union script_opcode defined within pmdsky-debug.
meta:
  id: script_opcode
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: n_params
  type: s1
- id: string_idx
  type: s1
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: name
  type: pointer
