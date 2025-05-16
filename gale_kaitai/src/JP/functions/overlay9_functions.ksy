doc: List of functions within OVERLAY9 with relative address locations as their values.
meta:
  id: overlay9_functions
  endian: le
instances:
  create_jukebox_track_menu:
    value: 0x1558
    doc: |-
      Creates a window containing the track selection menu for the Sky Jukebox. Also see struct jukebox_track_menu.

      If window_params is NULL, JUKEBOX_TRACK_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: simple_menu_id_item struct array, terminated with an item with string_id 0
      stack[0]: number of menu items
      return: window_id
  close_jukebox_track_menu:
    value: 0x1874
    doc: |-
      Closes a window created with CreateJukeboxTrackMenu.

      r0: window_id
  is_jukebox_track_menu_active:
    value: 0x18ac
    doc: |-
      This is a guess.

      Checks if the state of a jukebox track menu is something other than 7 or 8.

      r0: window_id
      return: bool
  update_jukebox_track_menu:
    value: 0x1904
    doc: |-
      Window update function for jukebox track menus.

      r0: window pointer
  create_playback_controls_menu:
    value: 0x1e44
    doc: |-
      Creates a window containing the playback controls menu for a selected song. Also see struct playback_controls_menu.

      If window_params is NULL, PLAYBACK_CONTROLS_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: ?
      stack[0]: simple_menu_id_item struct array 1, terminated with an item with string_id 0
      stack[1]: simple_menu_id_item struct array 2, terminated with an item with string_id 0
      return: window_id
  close_playback_controls_menu:
    value: 0x2184
    doc: |-
      Closes a window created with CreatePlaybackControlsMenu.

      r0: window_id
  is_playback_controls_menu_active:
    value: 0x2228
    doc: |-
      This is a guess.

      Checks if the state of a playback controls menu is something other than 7 or 8.

      r0: window_id
      return: bool
  update_playback_controls_menu:
    value: 0x22b0
    doc: |-
      Window update function for playback controls menus.

      r0: window pointer
  create_input_lock_box:
    value: 0x273c
    doc: |-
      Creates a window containing the "Locked" text when inputs are locked while a song is playing. Also see struct input_lock_box.

      If window_params is NULL, INPUT_LOCK_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::height is 0, it will default to 2.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: ?
      stack[0]: string ID
      return: window_id
  close_input_lock_box:
    value: 0x28ec
    doc: |-
      Closes a window created with InputLockBox.

      r0: window_id
  is_input_lock_box_active:
    value: 0x2908
    doc: |-
      This is a guess.

      Checks if the state of an input lock box is not 4.

      r0: window_id
      return: bool
  update_input_lock_box:
    value: 0x2928
    doc: |-
      Window update function for input lock boxes.

      r0: window pointer
