meta:
  id: overlay9_data
  endian: le
instances:
  jukebox_track_menu_default_window_params:
    pos: 0x2cc0
    doc: |-
      Default window_params for a jukebox_track_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateJukeboxTrackMenu.

      Additionally, width and height are 0, and will be computed in CreateJukeboxTrackMenu.
    type: window_params
  playback_controls_menu_default_window_params:
    pos: 0x2cd0
    doc: |-
      Default window_params for a playback_controls_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreatePlaybackControlsMenu.

      Additionally, width and height are 0, and will be computed in CreatePlaybackControlsMenu.
    type: window_params
  input_lock_box_default_window_params:
    pos: 0x2ce0
    doc: Default window_params for an input_lock_box.
    type: window_params
types:
  window_params:
  - id: update
    type: update_window_fn_t
  - id: x_offset
    type: u1
  - id: y_offset
    type: u1
  - id: width
    type: u1
  - id: height
    type: u1
  - id: screen
    type: screen_8
  - id: box_type
    type: box_type_8
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
enums: {}
