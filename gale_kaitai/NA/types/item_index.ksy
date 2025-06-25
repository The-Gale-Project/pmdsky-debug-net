doc: Represents a struct or union item_index defined within pmdsky-debug.
meta:
  id: item_index
  endian: le
  bit-endian: le
  imports:
  - item_index_special
seq:
- id: bag_index
  type: s4
- id: special_index
  type: item_index_special
