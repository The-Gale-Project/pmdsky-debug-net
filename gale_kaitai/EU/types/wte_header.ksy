doc: Represents a struct or union wte_header defined within pmdsky-debug.
meta:
  id: wte_header
  endian: le
  bit-endian: le
  imports:
  - wte_header_signature_array
  - pointer
  - wte_texture_params
  - rect16_xywh
seq:
- id: signature
  type: wte_header_signature_array
- id: texture
  type: pointer
- id: texture_size
  type: u4
- id: params
  type: wte_texture_params
- id: padding_0xe
  type: u2
- id: texture_bounds
  type: rect16_xywh
- id: palette
  type: pointer
- id: color_amt
  type: u2
- id: padding_0x1e
  type: u2
