meta:
  id: overlay14_data
  endian: le
instances:
  sentry_debug_menu_items:
    pos: 0x39c0
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  sentry_duty_ptr:
    pos: 0x3aa0
    doc: Pointer to the SENTRY_DUTY_STRUCT.
    type: u4
types:
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
enums: {}
