doc: Represents a struct or union natural_gift_item_info defined within 
  pmdsky-debug.
meta:
  id: natural_gift_item_info
  endian: le
  bit-endian: le
  imports:
  - item_id_16
  - type_id_8
seq:
- id: item_id
  type: item_id_16
- id: type_id
  type: type_id_8
- id: padding
  type: u1
- id: base_power_boost
  type: s2
