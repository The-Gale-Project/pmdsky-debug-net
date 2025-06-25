doc: Represents a struct or union live_actor defined within pmdsky-debug.
meta:
  id: live_actor
  endian: le
  bit-endian: le
  imports:
  - live_entity
  - direction_id_8
  - vec2
  - animation
seq:
- id: entity
  type: live_entity
- id: field_0x124
  type: s2
- id: field_0x126
  type: u1
- id: field_0x127
  type: u1
- id: attribute_bitfield
  type: u4
- id: field_0x12c
  type: s4
- id: current_direction
  type: direction_id_8
- id: field_0x131
  type: u1
- id: field_0x132
  type: u1
- id: field_0x133
  type: u1
- id: field_0x134
  type: u1
- id: field_0x135
  type: u1
- id: field_0x136
  type: u1
- id: field_0x137
  type: u1
- id: field38_0x138
  type: vec2
- id: field_0x140
  type: u1
- id: field_0x141
  type: u1
- id: field_0x142
  type: u1
- id: field_0x143
  type: u1
- id: field_0x144
  type: u1
- id: field_0x145
  type: u1
- id: field_0x146
  type: u1
- id: field_0x147
  type: u1
- id: field_0x148
  type: u1
- id: field_0x149
  type: u1
- id: field_0x14a
  type: u1
- id: field_0x14b
  type: u1
- id: field_0x14c
  type: u4
- id: field_0x150
  type: s2
- id: field_0x152
  type: u1
- id: field_0x153
  type: u1
- id: field_0x154
  type: s2
- id: field_0x156
  type: u1
- id: field_0x157
  type: u1
- id: field_0x158
  type: s2
- id: direction
  type: direction_id_8
- id: field_0x15b
  type: u1
- id: coord_min
  type: vec2
- id: coord_max
  type: vec2
- id: height
  type: s4
- id: second_height
  type: s4
- id: direction_should_change
  type: u1
- id: field_0x175
  type: s1
- id: field_0x176
  type: s2
- id: field_0x178
  type: s2
- id: field_0x17a
  type: u1
- id: field_0x17b
  type: u1
- id: movement_related
  type: s4
- id: second_bitfield
  type: s2
- id: effect_flag
  type: s2
- id: effect_id
  type: s2
- id: field_0x186
  type: u1
- id: field_0x187
  type: u1
- id: effect_position_marker
  type: s4
- id: animation
  type: animation
