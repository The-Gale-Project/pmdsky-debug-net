doc: List of functions within OVERLAY30 with relative address locations as their
  values.
meta:
  id: overlay30_functions
  endian: le
instances:
  write_quicksave_data:
    value: 0x448
    doc: |-
      Function responsible for writing dungeon data when quicksaving.

      Among other things, it contains a loop that goes through all the monsters in the current dungeon, copying their data to the buffer. The data is not copied as-is though, the game uses a reduced version of the monster struct containing only the minimum required data to resume the game later.

      r0: Pointer to buffer where data should be written
      r1: Buffer size. Seems to be 0x5800 (22 KB) when the function is called.
