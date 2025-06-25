doc: Represents an array BAG_CAPACITY_TABLE_SPECIAL_EPISODES defined within 
  pmdsky.
meta:
  id: bag_capacity_table_special_episodes_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: bag_capacity_table_special_episodes_array_dim_0
types:
  bag_capacity_table_special_episodes_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 5
