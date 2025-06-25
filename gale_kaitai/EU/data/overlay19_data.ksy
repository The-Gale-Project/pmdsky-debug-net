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
    pos: 0x399c
    type: bar_unlockable_dungeons_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_id_16[6]
  bar_recruitable_monster_table:
    pos: 0x39a8
    type: bar_recruitable_monster_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct monster_id_16[108]
  bar_available_items:
    pos: 0x3a80
    type: bar_available_items_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct bar_item[66]
  bar_window_params_1:
    pos: 0x408c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_2:
    pos: 0x409c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_3:
    pos: 0x40ac
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_menu_items_confirm_1:
    pos: 0x40bc
    type: bar_menu_items_confirm_1_array
    doc: This symbol is missing documentation.
  bar_menu_items_confirm_2:
    pos: 0x40d4
    type: bar_menu_items_confirm_2_array
    doc: This symbol is missing documentation.
  bar_main_menu_items:
    pos: 0x4104
    type: bar_main_menu_items_array
    doc: This symbol is missing documentation.
  bar_submenu_items_1:
    pos: 0x4124
    type: bar_submenu_items_1_array
    doc: This symbol is missing documentation.
  bar_submenu_items_2:
    pos: 0x4144
    type: bar_submenu_items_2_array
    doc: This symbol is missing documentation.
