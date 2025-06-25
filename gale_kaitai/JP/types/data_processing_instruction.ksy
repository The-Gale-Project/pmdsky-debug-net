doc: Represents a struct or union data_processing_instruction defined within 
  pmdsky-debug.
meta:
  id: data_processing_instruction
  endian: le
  bit-endian: le
  imports: []
seq:
- id: shifter_operand
  type: b12
- id: rd
  type: b4
- id: rn
  type: b4
- id: s
  type: b1
- id: opcode
  type: b4
- id: i
  type: b1
- id: zero
  type: b2
- id: cond
  type: b4
