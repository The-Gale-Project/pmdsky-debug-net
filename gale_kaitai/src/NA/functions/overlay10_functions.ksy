doc: List of functions within OVERLAY10 with relative address locations as their values.
meta:
  id: overlay10_functions
  endian: le
instances:
  create_inventory_menu:
    value: 0x0
    doc: |-
      Creates a window containing a menu for inventory management. Also see struct inventory_menu.

      This is used for the Treasure Bag menu, the item information/price window in dungeon Kecleon shops, and possibly other things.

      If window_params is NULL, INVENTORY_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: some function pointer?
      stack[0]: ?
      stack[1]: total number of items
      stack[2]: number of items per page
      stack[3]: ?
      return: window_id
  set_inventory_menu_state0:
    value: 0x24c
    doc: |-
      Sets an inventory menu to state 0.

      r0: window_id
  set_inventory_menu_state6:
    value: 0x260
    doc: |-
      Sets an inventory menu to state 6.

      r0: window_id
  close_inventory_menu:
    value: 0x274
    doc: |-
      Closes a window created with CreateInventoryMenu.

      r0: window_id
  is_inventory_menu_active:
    value: 0x2e8
    doc: |-
      This is a guess.

      Checks if the state of an inventory menu is something other than 7 or 8

      r0: window_id
      return: bool
  check_inventory_menu_field0x1_a0:
    value: 0x308
    doc: |-
      Checks if inventory_menu::field_0x1a0 is 0.

      r0: window_id
      return: bool
  pop_inventory_menu_field0x1_a3:
    value: 0x3d8
    doc: |-
      Sets inventory_menu::field_0x1a3 to 0 and returns the old value.

      r0: window_id
      return: old value
  update_inventory_menu:
    value: 0x3f4
    doc: |-
      Window update function for inventory menus.

      r0: window pointer
  is_inventory_menu_state3:
    value: 0x8f4
    doc: |-
      Checks if an inventory menu has a state value of 3.

      r0: window_id
      return: bool
  get_effect_animation_field0x19:
    value: 0x1434
    doc: |-
      Calls GetEffectAnimation and returns field 0x19.

      r0: anim_id
      return: GetEffectAnimation(anim_id)->field_0x19.
  animation_has_more_frames:
    value: 0x2e84
    doc: |-
      Just a guess. This is called in a loop in PlayEffectAnimation, and the output controls whether or not AdvanceFrame continues to be called.
      If the current effect animation's is_non_blocking field is set, the function will return false the very first time it is called.

      r0: ?
      return: whether or not the animation still has more frames left?
  get_effect_animation:
    value: 0x3420
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: anim_id
      return: effect animation pointer
  get_move_animation:
    value: 0x3434
    doc: |-
      Get the move animation corresponding to the given move ID.

      r0: move_id
      return: move animation pointer
  get_special_monster_move_animation:
    value: 0x3448
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: ent_id
      return: special monster move animation pointer
  get_trap_animation:
    value: 0x345c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: trap_id
      return: trap animation
  get_item_animation1:
    value: 0x3470
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_id
      return: first field of the item animation info
  get_item_animation2:
    value: 0x3484
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_id
      return: second field of the item animation info
  get_move_animation_speed:
    value: 0x3498
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move_id
      return: anim_ent_ptr (This might be a mistake? It seems to be an integer, not a pointer)
  draw_team_stats:
    value: 0x3f68
    doc: |-
      Handles creating the windows, sprites, etc. for the team stats top screen display.

      r0: undefined4
      r1: int
      r2: undefined4
      r3: uint32_t
      return: undefined4
  update_team_stats:
    value: 0x4260
    doc: |-
      Handles updating the team stats top screen display.

      No params.
  free_team_stats:
    value: 0x4934
    doc: |-
      Handles the procedure to close the team stats top screen display.

      First it deletes the sprites, then it closes the portrait boxes and then the text boxes containing the stats for all 4 team members.

      return: always 1, seems unused
  free_map_and_team:
    value: 0x4c58
    doc: |-
      Handles the procedure to close the map and team top screen display.

      return: always 1, seems unused
  process_team_stats_lv_hp:
    value: 0x4cc8
    doc: |-
      Appears to populate the Lv./HP row in the "Team stats" top screen.

      r0: index of some kind
  process_team_stats_name_gender:
    value: 0x4de4
    doc: |-
      Appears to populate the name/gender row in the "Team stats" top screen.

      r0: index of some kind
  is_background_tileset:
    value: 0x5af4
    doc: |-
      Given a tileset ID, returns whether it's a background or a regular tileset

      In particular, returns r0 >= 0xAA

      r0: Tileset ID
      return: True if the tileset ID corresponds to a background, false if it corresponds to a regular tileset
  init_tileset_buffer:
    value: 0x5c3c
    doc: |-
      Initializes a buffer that contains data related to tilesets (such as dungeon::unknown_file_buffer_0x102A8).

      Calls AllocAndLoadFileInPack and DecompressAtNormalVeneer.

      r0: Pointer to the buffer to init
      r1: Tileset ID
      r2: Memory allocation flags
  main_game:
    value: 0x5e0c
    doc: |-
      Contains several functions that handle switching between ground and dungeon mode. It also handles other situations, like what happens right after exiting a dungeon.

      The function doesn't get called until the player selects the option to resume a saved game and doesn't return until the player returns to the main menu.

      r0: End condition code? Seems to control what tasks get run and what transition happens when the dungeon ends
      return: return code?
