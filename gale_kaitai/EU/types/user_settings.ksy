doc: Represents a struct or union user_settings defined within pmdsky-debug.
meta:
  id: user_settings
  endian: le
  bit-endian: le
  imports:
  - language_and_flags
  - user_settings_nickname_array
  - user_settings_message_array
seq:
- id: language_and_flags
  type: language_and_flags
- id: favorite_color
  type: u1
- id: birthday_month
  type: u1
- id: birthday_day
  type: u1
- id: nickname
  type: user_settings_nickname_array
- id: field_0x18
  type: u2
- id: nickname_length
  type: u2
- id: message
  type: user_settings_message_array
- id: field_0x50
  type: u2
- id: message_length
  type: u2
