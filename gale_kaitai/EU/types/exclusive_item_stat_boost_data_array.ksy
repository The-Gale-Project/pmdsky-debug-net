doc: Represents an array EXCLUSIVE_ITEM_STAT_BOOST_DATA defined within pmdsky.
meta:
  id: exclusive_item_stat_boost_data_array
  endian: le
  bit-endian: le
  imports:
  - exclusive_item_stat_boost_entry
seq:
- id: entries
  type: exclusive_item_stat_boost_data_array_dim_0
types:
  exclusive_item_stat_boost_data_array_dim_0:
    seq:
    - id: entries
      type: exclusive_item_stat_boost_entry
      repeat: expr
      repeat-expr: 15
