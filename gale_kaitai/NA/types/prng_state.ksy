doc: Represents a struct or union prng_state defined within pmdsky-debug.
meta:
  id: prng_state
  endian: le
  bit-endian: le
  imports: []
seq:
- id: use_secondary
  type: s4
- id: seq_num_primary
  type: u4
- id: preseed
  type: u4
- id: last_value_primary
  type: u4
- id: idx_secondary
  type: s4
