doc: Represents an array AUDIO_COMMANDS_BUFFER defined within pmdsky.
meta:
  id: audio_commands_buffer_array
  endian: le
  bit-endian: le
  imports:
  - audio_command
seq:
- id: entries
  type: audio_commands_buffer_array_dim_0
types:
  audio_commands_buffer_array_dim_0:
    seq:
    - id: entries
      type: audio_command
      repeat: expr
      repeat-expr: 16
