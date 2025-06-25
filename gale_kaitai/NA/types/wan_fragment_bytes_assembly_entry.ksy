doc: Represents a struct or union wan_fragment_bytes_assembly_entry defined 
  within pmdsky-debug.
meta:
  id: wan_fragment_bytes_assembly_entry
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: pixel_src
  type: pointer
- id: byte_amount
  type: u4
- id: z_index
  type: u4
