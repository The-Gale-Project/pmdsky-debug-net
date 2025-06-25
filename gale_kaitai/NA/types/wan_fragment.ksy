doc: Represents a struct or union wan_fragment defined within pmdsky-debug.
meta:
  id: wan_fragment
  endian: le
  bit-endian: le
  imports: []
seq:
- id: fragment_bytes_index
  type: s2
- id: unk1
  type: s1
- id: unk2
  type: s1
- id: offset_y
  type: b8
- id: unk3
  type: b1
- id: unk4
  type: b1
- id: likely_padding_1
  type: b3
- id: is_mosaic
  type: b1
- id: shape_indice
  type: b2
- id: offset_x
  type: b9
- id: likely_padding_2
  type: b1
- id: unk5
  type: b1
- id: is_last
  type: b1
- id: h_flip
  type: b1
- id: v_flip
  type: b1
- id: size_indice
  type: b2
- id: fragment_alloc_counter
  type: b10
- id: likely_padding_3
  type: b2
- id: palette_id
  type: b4
