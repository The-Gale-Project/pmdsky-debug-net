doc: Represents a struct or union iovec defined within pmdsky-debug.
meta:
  id: iovec
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: iov_base
  type: pointer
- id: iov_len
  type: u4
