doc: Represents a struct or union dse_mainbank_reading defined within 
  pmdsky-debug.
meta:
  id: dse_mainbank_reading
  endian: le
  bit-endian: le
  imports: []
seq:
- id: size
  type: s4
- id: size_plus_loaded_size
  type: s4
- id: want_size
  type: s4
- id: loaded_size
  type: s4
