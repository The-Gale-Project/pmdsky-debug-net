doc: Holds the data for the enum gummi_compatability.
meta:
  id: gummi_compatability
  endian: le
  bit-endian: le
seq:
- id: gummi_compatability_value
  type: b32
  enum: gummi_compatability_enum
enums:
  gummi_compatability_enum:
    0: gummi_big_favorite
    1: gummi_favorite
    2: gummi_doesnt_dislike
    3: gummi_lttle_satisfied
