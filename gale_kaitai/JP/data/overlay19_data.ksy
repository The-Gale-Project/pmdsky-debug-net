meta:
  id: overlay19_data
  endian: le
  imports:
  - ../types/bar_unlockable_dungeons_table_array
  - ../types/bar_recruitable_monster_table_array
  - ../types/bar_available_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/bar_menu_items_confirm_1_array
  - ../types/bar_menu_items_confirm_2_array
  - ../types/bar_main_menu_items_array
  - ../types/bar_submenu_items_1_array
  - ../types/bar_submenu_items_2_array
instances:
  bar_unlockable_dungeons_table:
    pos: 0x39a0
    type: bar_unlockable_dungeons_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_id_16[6]
  bar_recruitable_monster_table:
    pos: 0x39ac
    type: bar_recruitable_monster_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct monster_id_16[108]
  bar_available_items:
    pos: 0x3a84
    type: bar_available_items_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct bar_item[66]
  bar_window_params_1:
    pos: 0x4090
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_2:
    pos: 0x40a0
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_3:
    pos: 0x40b0
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_menu_items_confirm_1:
    pos: 0x40c0
    type: bar_menu_items_confirm_1_array
    doc: This symbol is missing documentation.
  bar_menu_items_confirm_2:
    pos: 0x40d8
    type: bar_menu_items_confirm_2_array
    doc: This symbol is missing documentation.
  bar_main_menu_items:
    pos: 0x4108
    type: bar_main_menu_items_array
    doc: This symbol is missing documentation.
  bar_submenu_items_1:
    pos: 0x4128
    type: bar_submenu_items_1_array
    doc: This symbol is missing documentation.
  bar_submenu_items_2:
    pos: 0x4148
    type: bar_submenu_items_2_array
    doc: This symbol is missing documentation.
