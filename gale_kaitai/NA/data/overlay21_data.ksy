meta:
  id: overlay21_data
  endian: le
  imports:
  - ../types/window_params
  - ../types/swap_shop_menu_items_confirm_array
  - ../types/swap_shop_submenu_items_1_array
  - ../types/swap_shop_submenu_items_2_array
  - ../types/swap_shop_main_menu_items_1_array
  - ../types/swap_shop_main_menu_items_2_array
  - ../types/swap_shop_submenu_items_3_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  swap_shop_window_params_1:
    pos: 0x28e8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_menu_items_confirm:
    pos: 0x28f8
    type: swap_shop_menu_items_confirm_array
    doc: This symbol is missing documentation.
  swap_shop_submenu_items_1:
    pos: 0x2910
    type: swap_shop_submenu_items_1_array
    doc: This symbol is missing documentation.
  swap_shop_submenu_items_2:
    pos: 0x2928
    type: swap_shop_submenu_items_2_array
    doc: This symbol is missing documentation.
  swap_shop_main_menu_items_1:
    pos: 0x2948
    type: swap_shop_main_menu_items_1_array
    doc: This symbol is missing documentation.
  swap_shop_main_menu_items_2:
    pos: 0x2968
    type: swap_shop_main_menu_items_2_array
    doc: This symbol is missing documentation.
  swap_shop_submenu_items_3:
    pos: 0x2990
    type: swap_shop_submenu_items_3_array
    doc: This symbol is missing documentation.
  overlay21_unknown_string_ids:
    pos: 0x29c0
    type: u1
    repeat: expr
    repeat-expr: 0x38
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_2:
    pos: 0x29f8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_3:
    pos: 0x2a08
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_4:
    pos: 0x2a18
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_5:
    pos: 0x2a28
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_6:
    pos: 0x2a38
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_7:
    pos: 0x2a48
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_8:
    pos: 0x2a58
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  swap_shop_window_params_9:
    pos: 0x2a68
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay21_jp_string:
    pos: 0x2ddc
    type: u1
    repeat: expr
    repeat-expr: 0x8
    doc: 合成：
  overlay21_reserved_space:
    pos: 0x2df8
    type: u1
    repeat: expr
    repeat-expr: 0x8
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay21_unknown_pointer__na_238cf40:
    pos: 0x2e00
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay21_unknown_pointer__na_238cf44:
    pos: 0x2e04
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
