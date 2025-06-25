doc: Represents a struct or union coroutine_info defined within pmdsky-debug.
meta:
  id: coroutine_info
  endian: le
  bit-endian: le
  imports:
  - pointer
  - coroutine_info_padding_array
seq:
- id: unionall_start
  type: pointer
- id: coroutine_start
  type: pointer
- id: field_0x8
  type: u4
- id: field_0xc
  type: u1
- id: field_0xd
  type: u1
- id: field_0xe
  type: u1
- id: field_0xf
  type: u1
- id: field_0x10
  type: u1
- id: field_0x11
  type: u1
- id: field_0x12
  type: u1
- id: field_0x13
  type: u1
- id: field_0x14
  type: u2
- id: field_0x16
  type: u1
- id: field_0x17
  type: u1
- id: field_0x18
  type: u2
- id: padding
  type: coroutine_info_padding_array
