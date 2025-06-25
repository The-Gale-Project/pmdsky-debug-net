doc: Represents a struct or union kaomado_buffer defined within pmdsky-debug.
meta:
  id: kaomado_buffer
  endian: le
  bit-endian: le
  imports:
  - kaomado_buffer_palette_array
  - kaomado_buffer_at4px_buffer_array
seq:
- id: palette
  type: kaomado_buffer_palette_array
- id: at4px_buffer
  type: kaomado_buffer_at4px_buffer_array
