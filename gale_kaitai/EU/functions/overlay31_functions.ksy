doc: List of functions within OVERLAY31 with relative address locations as their
  values.
meta:
  id: overlay31_functions
  endian: le
instances:
  entry_overlay31:
    value: 0x0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  draw_dungeon_menu_status_window:
    value: 0x44
    doc: |-
      Draws the contents shown in the main dungeon menu status window showing the player's belly, money, play time, etc.

      r0: int
  dungeon_menu_switch:
    value: 0x2a0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: appears to be an index of some sort, probably the menu index based on the function name?
  create_stairs_menu_state:
    value: 0x6b4
    doc: |-
      Called when the leader steps on any stairs tile (regular, warp zone, rescue point, hidden stairs).

      Allocates a stairs_menu struct on the heap with information for HandleStairsMenu, which will be pointed to by STAIRS_MENU_PTR.

      r0: Entity pointer (in practice, always the leader)
  stairs_subheading_callback:
    value: 0x748
    doc: |-
      Callback function passed to CreateAdvancedTextBox for creating the subheading for the stairs menu.

      r0: window_id
  handle_stairs_menu:
    value: 0x79c
    doc: |-
      Handles displaying the stairs menu and is called on each frame while it is open, also updating the leader's action fields.

      Uses a switch statement based on the state field in stairs_menu to determine what actions to take.

      return: int
  moves_menu:
    value: 0x29a0
    doc: |-
      Displays a menu showing the moves of a monster. Does not return until the menu is closed.

      This function does not get called when opening the leader's move menu.

      r0: Pointer to an action struct containing the index of the monster whose moves will be checked in the action_use_idx field.
  handle_moves_menu_wrapper0:
    value: 0x2b9c
    doc: |-
      Sets some field on a struct to 0 and calls HandleMovesMenu.

      r0: struct pointer, see HandleMovesMenu
      r1: See HandleMovesMenu
      r2: See HandleMovesMenu
      r3: monster index, see HandleMovesMenu
      return: bool, see HandleMovesMenu
  handle_moves_menu_wrapper1:
    value: 0x2bc0
    doc: |-
      Sets some field on a struct to 1 and calls HandleMovesMenu.

      r0: struct pointer, see HandleMovesMenu
      r1: See HandleMovesMenu
      r2: See HandleMovesMenu
      r3: monster index, see HandleMovesMenu
      return: bool, see HandleMovesMenu
  handle_moves_menu:
    value: 0x2be4
    doc: |-
      Handles the different options on the moves menu. Does not return until the menu is closed.

      This function also takes care of updating the fields in the action_data struct it receives when a menu option is chosen.

      r0: Pointer to some struct that was created by a previous function. Contains a pointer to the monster whose moves are being displayed at offset 0x0.
      r1: ?
      r2: ?
      r3: Index of the monster whose moves are going to be displayed on the menu. Unused.
      return: True if the menu was closed without selecting anything, false if an option was chosen.
  team_menu:
    value: 0x4850
    doc: |-
      Called when the in-dungeon "team" menu is open. Does not return until the menu is closed.

      Note that selecting certain options in this menu (such as viewing the details or the moves of a pokémon) counts as switching to a different menu, which causes the function to return.

      r0: Pointer to the leader's entity struct
      return: ?
  rest_menu:
    value: 0x5f90
    doc: |-
      Called when the in-dungeon "rest" menu is open. Does not return until the menu is closed.

      No params.
  recruitment_search_menu_loop:
    value: 0x6408
    doc: |-
      Called on each frame while the in-dungeon "recruitment search" menu is open.

      return: int (Actually, this is probably some sort of enum shared by all the MenuLoop functions)
  help_menu_loop:
    value: 0x6a00
    doc: |-
      Called on each frame while the in-dungeon "help" menu is open.

      The menu is still considered open while one of the help pages is being viewed, so this function keeps being called even after choosing an option.

      return: int (Actually, this is probably some sort of enum shared by all the MenuLoop functions)
