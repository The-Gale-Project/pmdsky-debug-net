doc: Represents a struct or union ssb_runtime_info defined within pmdsky-debug.
meta:
  id: ssb_runtime_info
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: file
  type: pointer
- id: opcodes
  type: pointer
- id: next_opcode_addr
  type: pointer
- id: strings
  type: pointer
