doc: List of functions within OVERLAY1 with relative address locations as their values.
meta:
  id: overlay1_functions
  endian: le
instances:
  create_main_menus:
    value: 0x7bc4
    doc: |-
      Prepares the top menu and sub menu, adding the different options that compose them.

      Contains multiple calls to AddMainMenuOption and AddSubMenuOption. Some of them are conditionally executed depending on which options should be unlocked.

      No params.
  add_main_menu_option:
    value: 0x8038
    doc: |-
      Adds an option to the top menu.

      This function is called for each one of the options in the top menu. It loops the MAIN_MENU data field, if the specified action ID does not exist there, the option won't be added.

      r0: Action ID
      r1: True if the option should be enabled, false otherwise
  add_sub_menu_option:
    value: 0x8110
    doc: |-
      Adds an option to the "Other" submenu on the top menu.

      This function is called for each one of the options in the submenu. It loops the SUBMENU data field, if the specified action ID does not exist there, the option won't be added.

      r0: Action ID
      r1: True if the option should be enabled, false otherwise
  process_continue_screen_contents:
    value: 0x99d4
    doc: |-
      Fetches the required data and creates all the strings to display the contents shown in the window
      when choosing continue in the main menu.

      r0: undefined4
