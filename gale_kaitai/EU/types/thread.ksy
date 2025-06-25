doc: Represents a struct or union thread defined within pmdsky-debug.
meta:
  id: thread
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: flags
  type: s4
- id: field_0x4
  type: pointer
- id: field_0x8
  type: u4
- id: field_0xc
  type: u4
- id: field_0x10
  type: u4
- id: field_0x14
  type: u4
- id: field_0x18
  type: u4
- id: field_0x1c
  type: u4
- id: field_0x20
  type: u4
- id: field_0x24
  type: u4
- id: field_0x28
  type: u4
- id: field_0x2c
  type: u4
- id: field_0x30
  type: u4
- id: field_0x34
  type: u4
- id: usable_stack_pointer
  type: pointer
- id: exit_function
  type: pointer
- id: function_address_plus_4
  type: pointer
- id: stack_pointer_minus_4
  type: pointer
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
  type: u1
- id: field_0x61
  type: u1
- id: field_0x62
  type: u1
- id: field_0x63
  type: u1
- id: field_0x64
  type: u4
- id: next_thread
  type: pointer
- id: thread_id
  type: s4
- id: sorting_order
  type: s4
- id: field_0x74
  type: u4
- id: field_0x78
  type: u4
- id: field_0x7c
  type: u4
- id: field_0x80
  type: u4
- id: field_0x84
  type: u4
- id: field_0x88
  type: u4
- id: field_0x8c
  type: u4
- id: stack_end_pointer
  type: pointer
- id: stack_pointer
  type: pointer
- id: field_0x98
  type: u4
- id: field_0x9c
  type: u4
- id: field_0xa0
  type: u4
- id: field_0xa4
  type: u4
- id: field_0xa8
  type: u4
- id: field_0xac
  type: u4
- id: field_0xb0
  type: u4
- id: field_0xb4
  type: u4
- id: field_0xb8
  type: u1
- id: field_0xb9
  type: u1
- id: field_0xba
  type: u1
- id: field_0xbb
  type: u1
- id: field_0xbc
  type: u1
- id: field_0xbd
  type: u1
- id: field_0xbe
  type: u1
- id: field_0xbf
  type: u1
