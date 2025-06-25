doc: Represents a struct or union script_var_desc defined within pmdsky-debug.
meta:
  id: script_var_desc
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: desc
  type: pointer
- id: value
  type: pointer
