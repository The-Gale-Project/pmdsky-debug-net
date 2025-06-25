doc: Represents a struct or union script_var defined within pmdsky-debug.
meta:
  id: script_var
  endian: le
  bit-endian: le
  imports:
  - script_var_type_16
  - pointer
seq:
- id: type
  type: script_var_type_16
- id: field_0x1
  type: u2
- id: mem_offset
  type: u2
- id: bitshift
  type: u2
- id: n_values
  type: u2
- id: default_val
  type: s2
- id: name
  type: pointer
