doc: Represents a struct or union bg_list_entry defined within pmdsky-debug.
meta:
  id: bg_list_entry
  endian: le
  bit-endian: le
  imports:
  - bg_list_entry_sub_struct
  - bg_list_entry_others_bpa_array
seq:
- id: bpl
  type: bg_list_entry_sub_struct
- id: bpc
  type: bg_list_entry_sub_struct
- id: bma
  type: bg_list_entry_sub_struct
- id: others_bpa
  type: bg_list_entry_others_bpa_array
