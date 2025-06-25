meta:
  id: overlay9_data
  endian: le
  imports:
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  jukebox_track_menu_default_window_params:
    pos: 0x2d1c
    type: window_params
    doc: |-
      Default window_params for a jukebox_track_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateJukeboxTrackMenu.

      Additionally, width and height are 0, and will be computed in CreateJukeboxTrackMenu.
  playback_controls_menu_default_window_params:
    pos: 0x2d2c
    type: window_params
    doc: |-
      Default window_params for a playback_controls_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreatePlaybackControlsMenu.

      Additionally, width and height are 0, and will be computed in CreatePlaybackControlsMenu.
  input_lock_box_default_window_params:
    pos: 0x2d3c
    type: window_params
    doc: Default window_params for an input_lock_box.
