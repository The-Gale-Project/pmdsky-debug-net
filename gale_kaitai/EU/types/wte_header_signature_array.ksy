doc: Represents an array wte_header_signature defined within pmdsky.
meta:
  id: wte_header_signature_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: wte_header_signature_array_dim_0
types:
  wte_header_signature_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 4
