doc: Represents a struct or union bulk_item defined within pmdsky-debug.
meta:
  id: bulk_item
  endian: le
  bit-endian: le
  imports:
  - item_id_16
seq:
- id: id
  type: item_id_16
- id: quantity
  type: u2
