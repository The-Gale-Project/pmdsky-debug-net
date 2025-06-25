doc: Represents a struct or union gummi_result defined within pmdsky-debug.
meta:
  id: gummi_result
  endian: le
  bit-endian: le
  imports:
  - gummi_compatability_16
  - stat_bitflag
seq:
- id: gummi_compatability
  type: gummi_compatability_16
- id: stats_increased
  type: stat_bitflag
