doc: Represents a struct or union start_module_params defined within 
  pmdsky-debug.
meta:
  id: start_module_params
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: autoload_list
  type: pointer
- id: autoload_list_end
  type: pointer
- id: autoload_start
  type: pointer
- id: static_bss_start
  type: pointer
- id: static_bss_end
  type: pointer
- id: compressed_static_end
  type: u4
- id: version_id
  type: u4
- id: nitrocode_be
  type: u4
- id: nitrocode_le
  type: u4
