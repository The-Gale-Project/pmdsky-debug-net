meta:
  id: overlay9_data
  endian: le
instances:
  jukebox_track_menu_default_window_params:
    pos: 0x2d14
    doc: |-
      Default window_params for a jukebox_track_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateJukeboxTrackMenu.

      Additionally, width and height are 0, and will be computed in CreateJukeboxTrackMenu.
    size: 0x10
  playback_controls_menu_default_window_params:
    pos: 0x2d24
    doc: |-
      Default window_params for a playback_controls_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreatePlaybackControlsMenu.

      Additionally, width and height are 0, and will be computed in CreatePlaybackControlsMenu.
    size: 0x10
  input_lock_box_default_window_params:
    pos: 0x2d34
    doc: Default window_params for an input_lock_box.
    size: 0x10
types: {}
enums: {}
