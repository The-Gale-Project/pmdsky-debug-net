doc: Represents a struct or union overlay_info_entry defined within 
  pmdsky-debug.
meta:
  id: overlay_info_entry
  endian: le
  bit-endian: le
  imports: []
seq:
- id: overlay_id
  type: s4
- id: ram_address
  type: s4
- id: size
  type: s4
- id: bss_size
  type: s4
- id: static_init_start_address
  type: s4
- id: static_init_end_address
  type: s4
- id: file_id
  type: s4
- id: unused
  type: s4
