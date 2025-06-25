doc: Represents a struct or union tileset_property defined within pmdsky-debug.
meta:
  id: tileset_property
  endian: le
  bit-endian: le
  imports:
  - nature_power_variant_16
seq:
- id: field_0x0
  type: s4
- id: field_0x4
  type: u1
- id: field_0x5
  type: u1
- id: field_0x6
  type: u1
- id: padding
  type: u1
- id: nature_power_variant
  type: nature_power_variant_16
- id: field_0xa
  type: u1
- id: is_water_tileset
  type: u1
