doc: |-
  Likely contains supporting data and code related to the top menu.

  This is loaded together with overlay 1 while in the top menu. Since it's in overlay group 2 (together with overlay 10, which is another "data" overlay), this overlay probably plays a similar role. It mentions several files from the BACK folder that are known backgrounds for the top menu.
meta:
  id: overlay0
  tags: JP
  endian: le
  imports:
  - functions/overlay0_functions
instances:
  functions:
    type: overlay0_functions
