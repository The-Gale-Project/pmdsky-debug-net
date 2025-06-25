doc: Represents a struct or union script_routine_state defined within 
  pmdsky-debug.
meta:
  id: script_routine_state
  endian: le
  bit-endian: le
  imports:
  - script_routine_state_ssb_info_array
  - pointer
  - script_routine_state_field_0x60_array
seq:
- id: execution_status
  type: s2
- id: last_return_val
  type: s2
- id: field_0x4
  type: s2
- id: field_0x6
  type: s1
- id: field_0x7
  type: u1
- id: ssb_info
  type: script_routine_state_ssb_info_array
- id: current_opcode_addr
  type: pointer
- id: current_param_addr
  type: pointer
- id: opcode_param_count
  type: s2
- id: lock_id
  type: s2
- id: field_0x34
  type: s2
- id: field_0x36
  type: s1
- id: field_0x37
  type: u1
- id: field_0x38
  type: s2
- id: timer
  type: s2
- id: field_0x3c
  type: s2
- id: field_0x3e
  type: u1
- id: field_0x3f
  type: u1
- id: current_variadic_param
  type: s4
- id: field_0x44
  type: u1
- id: field_0x45
  type: u1
- id: field_0x46
  type: u1
- id: field_0x47
  type: u1
- id: field_0x48
  type: u1
- id: field_0x49
  type: u1
- id: field_0x4a
  type: u1
- id: field_0x4b
  type: u1
- id: field_0x4c
  type: u1
- id: field_0x4d
  type: u1
- id: field_0x4e
  type: u1
- id: field_0x4f
  type: u1
- id: field_0x50
  type: u1
- id: field_0x51
  type: u1
- id: field_0x52
  type: u1
- id: field_0x53
  type: u1
- id: field_0x54
  type: u1
- id: field_0x55
  type: u1
- id: field_0x56
  type: u1
- id: field_0x57
  type: u1
- id: field_0x58
  type: u1
- id: field_0x59
  type: u1
- id: field_0x5a
  type: u1
- id: field_0x5b
  type: u1
- id: field_0x5c
  type: u1
- id: field_0x5d
  type: u1
- id: field_0x5e
  type: u1
- id: field_0x5f
  type: u1
- id: field_0x60
  type: script_routine_state_field_0x60_array
