doc: Represents a struct or union bar_item defined within pmdsky-debug.
meta:
  id: bar_item
  endian: le
  bit-endian: le
  imports:
  - item_id_16
  - bar_item_field_0xe_array
seq:
- id: id
  type: item_id_16
- id: field_0x2
  type: s2
- id: field_0x4
  type: s2
- id: field_0x6
  type: s2
- id: field_0x8
  type: s2
- id: field_0xa
  type: s2
- id: field_0xc
  type: s2
- id: field_0xe
  type: bar_item_field_0xe_array
