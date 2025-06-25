doc: |-
  Likely controls the top menu.

  This is loaded together with overlay 0 while in the top menu. Since it's in overlay group 1 (together with other "main" overlays like overlay 11 and overlay 29), this is probably the controller.

  Seems to contain code related to Wi-Fi rescue. It mentions several files from the GROUND and BACK folders.
meta:
  id: overlay1
  tags: NA
  endian: le
  imports:
  - functions/overlay1_functions
  - data/overlay1_data
instances:
  functions:
    type: overlay1_functions
  data:
    type: overlay1_data
