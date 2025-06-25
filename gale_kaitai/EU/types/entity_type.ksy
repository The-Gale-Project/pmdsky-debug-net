doc: Holds the data for the enum entity_type.
meta:
  id: entity_type
  endian: le
  bit-endian: le
seq:
- id: entity_type_value
  type: b32
  enum: entity_type_enum
enums:
  entity_type_enum:
    0: entity_nothing
    1: entity_monster
    2: entity_trap
    3: entity_item
    5: entity_hidden_stairs
    6: entity_temporary
