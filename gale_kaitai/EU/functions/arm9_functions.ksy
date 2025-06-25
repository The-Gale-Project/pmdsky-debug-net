doc: List of functions within ARM9 with relative address locations as their 
  values.
meta:
  id: arm9_functions
  endian: le
instances:
  svc__soft_reset:
    value: 0x1a4
    doc: Software interrupt.
  svc__wait_by_loop:
    value: 0x6b0
    doc: Software interrupt.
  svc__cpu_set:
    value: 0x79e
    doc: Software interrupt.
  start:
    value: 0x800
    doc: |-
      The entrypoint for the ARM9 CPU. This is like the "main" function for the ARM9 subsystem.

      Once the entry function reaches the end, a constant containing the address to NitroMain is loaded into a register (r1), and a `bx` branch will jump to NitroMain.

      No params.
  init_i__cpu_clear32:
    value: 0x954
  m_ii__uncompress_backward:
    value: 0x970
    doc: Startup routine in the program's crt0 
      (https://en.wikipedia.org/wiki/Crt0).
  do_autoload:
    value: 0xa1c
    doc: Startup routine in the program's crt0 
      (https://en.wikipedia.org/wiki/Crt0).
  start_autoload_done_callback:
    value: 0xaac
    doc: Startup routine in the program's crt0 
      (https://en.wikipedia.org/wiki/Crt0).
  init_cp15:
    value: 0xab0
  o_si__refer_symbol:
    value: 0xb9c
    doc: Startup routine in the program's crt0 
      (https://en.wikipedia.org/wiki/Crt0).
  nitro_main:
    value: 0xc6c
    doc: Entrypoint into NitroSDK, the DS devkit library.
  init_mem_alloc_table:
    value: 0xde0
    doc: |-
      Initializes MEMORY_ALLOCATION_TABLE.

      Sets up the default memory arena, sets the default memory allocator parameters (calls SetMemAllocatorParams(0, 0)), and does some other stuff.

      No params.
  set_mem_allocator_params:
    value: 0xe70
    doc: |-
      Sets global parameters for the memory allocator.

      This includes MEMORY_ALLOCATION_ARENA_GETTERS and some other stuff.

      Dungeon mode uses the default arena getters. Ground mode uses its own arena getters that return custom arenas for some flag values, which are defined in overlay 11 and set (by calling this function) at the start of GroundMainLoop. Note that the sound memory arena is provided explicitly to MemLocateSet in the sound code, so doesn't go through this path.

      r0: GetAllocArena function pointer (GetAllocArenaDefault is used if null)
      r1: GetFreeArena function pointer (GetFreeArenaDefault is used if null)
  get_alloc_arena_default:
    value: 0xec0
    doc: |-
      The default function for retrieving the arena for memory allocations. This function always just returns the initial arena pointer.

      r0: initial memory arena pointer, or null
      r1: flags (see MemAlloc)
      return: memory arena pointer, or null
  get_free_arena_default:
    value: 0xec4
    doc: |-
      The default function for retrieving the arena for memory freeing. This function always just returns the initial arena pointer.

      r0: initial memory arena pointer, or null
      r1: pointer to free
      return: memory arena pointer, or null
  init_mem_arena:
    value: 0xec8
    doc: |-
      Initializes a new memory arena with the given specifications, and records it in the global MEMORY_ALLOCATION_TABLE.

      r0: arena struct to be initialized
      r1: memory region to be owned by the arena, as {pointer, length}
      r2: pointer to block metadata array for the arena to use
      r3: maximum number of blocks that the arena can hold
  mem_alloc_flags_to_block_type:
    value: 0xf44
    doc: |-
      Converts the internal alloc flags bitfield (struct mem_block field 0x4) to the block type bitfield (struct mem_block field 0x0).

      r0: internal alloc flags
      return: block type flags
  find_available_mem_block:
    value: 0xf88
    doc: |-
      Searches through the given memory arena for a block with enough free space.

      Blocks are searched in reverse order. For object allocations (i.e., not arenas), the block with the smallest amount of free space that still suffices is returned. For arena allocations, the first satisfactory block found is returned.

      r0: memory arena to search
      r1: internal alloc flags
      r2: amount of space needed, in bytes
      return: index of the located block in the arena's block array, or -1 if nothing is available
  split_mem_block:
    value: 0x1070
    doc: |-
      Given a memory block at a given index, splits off another memory block of the specified size from the end.

      Since blocks are stored in an array on the memory arena struct, this is essentially an insertion operation, plus some processing on the block being split and its child.

      r0: memory arena
      r1: block index
      r2: internal alloc flags
      r3: number of bytes to split off
      stack[0]: user alloc flags (to assign to the new block)
      return: the newly split-off memory block
  mem_alloc:
    value: 0x1170
    doc: |-
      Allocates some memory on the heap, returning a pointer to the starting address.

      Memory allocation is done with region-based memory management. See MEMORY_ALLOCATION_TABLE for more information.

      This function is just a wrapper around MemLocateSet.

      r0: length in bytes
      r1: flags (see the comment on struct mem_block::user_flags)
      return: pointer
  mem_free:
    value: 0x1188
    doc: |-
      Frees heap-allocated memory.

      This function is just a wrapper around MemLocateUnset.

      r0: pointer
  mem_arena_alloc:
    value: 0x119c
    doc: |-
      Allocates some memory on the heap and creates a new global memory arena with it.

      The actual allocation part works similarly to the normal MemAlloc.

      r0: desired parent memory arena, or null
      r1: length of the arena in bytes
      r2: maximum number of blocks that the arena can hold
      r3: flags (see MemAlloc)
      return: memory arena pointer
  create_mem_arena:
    value: 0x1280
    doc: |-
      Creates a new memory arena within a given block of memory.

      This is essentially a wrapper around InitMemArena, accounting for the space needed by the arena metadata.

      r0: memory region in which to create the arena, as {pointer, length}
      r1: maximum number of blocks that the arena can hold
      return: memory arena pointer
  mem_locate_set:
    value: 0x1390
    doc: |-
      The implementation for MemAlloc.

      At a high level, memory is allocated by choosing a memory arena, looking through blocks in the memory arena until a free one that's large enough is found, then splitting off a new memory block of the needed size.

      This function is not fallible, i.e., it hangs the whole program on failure, so callers can assume it never fails.

      The name for this function comes from the error message logged on failure, and it reflects what the function does: locate an available block of memory and set it up for the caller.

      r0: desired memory arena for allocation, or null (MemAlloc passes null)
      r1: length in bytes
      r2: flags (see MemAlloc)
      return: pointer to allocated memory
  mem_locate_unset:
    value: 0x1638
    doc: |-
      The implementation for MemFree.

      At a high level, memory is freed by locating the pointer in its memory arena (searching block-by-block) and emptying the block so it's available for future allocations, and merging it with neighboring blocks if they're available.

      r0: desired memory arena for freeing, or null (MemFree passes null)
      r1: pointer to free
  round_up_div256:
    value: 0x1894
    doc: |-
      Divide a number by 256 and round up to the nearest integer.

      r0: number
      return: number // 256
  u_fixed_point64_cmp_lt:
    value: 0x1a30
    doc: |-
      Compares two unsigned 64-bit fixed-point numbers (16 fraction bits) x and y.

      r0: upper 32 bits of x
      r1: lower 32 bits of x
      r2: upper 32 bits of y
      r3: lower 32 bits of y
      return: x < y
  multiply_by_fixed_point:
    value: 0x1a54
    doc: |-
      Multiply a signed integer x by a signed binary fixed-point multiplier (8 fraction bits).

      r0: x
      r1: multiplier
      return: x * multiplier
  u_multiply_by_fixed_point:
    value: 0x1b0c
    doc: |-
      Multiplies an unsigned integer x by an unsigned binary fixed-point multiplier (8 fraction bits).

      r0: x
      r1: multiplier
      return: x * multiplier
  int_to_fixed_point64:
    value: 0x1c80
    doc: |-
      Converts a signed integer to a 64-bit fixed-point number (16 fraction bits).

      Note that this function appears to be bugged: it appears to try to sign-extend if the input is negative, but in a nonsensical way, checking the sign bit for a 16-bit signed integer, but then doing the sign extension as if the input were a 32-bit signed integer.

      r0: [output] 64-bit fixed-point number
      r1: 32-bit signed int
  fixed_point64_to_int:
    value: 0x1cb0
    doc: |-
      Converts a 64-bit fixed-point number (16 fraction bits) to a signed integer.

      r0: 64-bit fixed-point number
      return: 32-bit signed
  fixed_point32_to64:
    value: 0x1cd4
    doc: |-
      Converts a 32-bit fixed-point number (8 fraction bits) to a 64-bit fixed point number (16 fraction bits). Sign-extends as necessary.

      r0: [output] 64-bit fixed-point number
      r1: 32-bit signed fixed-point number
  negate_fixed_point64:
    value: 0x1cf8
    doc: |-
      Negates a 64-bit fixed-point number (16 fraction bits) in-place.

      r0: 64-bit fixed-point number to negate
  fixed_point64_is_zero:
    value: 0x1d28
    doc: |-
      Checks whether a 64-bit fixed-point number (16 fraction bits) is zero.

      r0: 64-bit fixed-point number
      return: bool
  fixed_point64_is_negative:
    value: 0x1d50
    doc: |-
      Checks whether a 64-bit fixed-point number (16 fraction bits) is negative.

      r0: 64-bit fixed-point number
      return: bool
  fixed_point64_cmp_lt:
    value: 0x1d68
    doc: |-
      Compares two signed 64-bit fixed-point numbers (16 fraction bits) x and y.

      r0: x
      r1: y
      return: x < y
  multiply_fixed_point64:
    value: 0x1df4
    doc: |-
      Multiplies two signed 64-bit fixed-point numbers (16 fraction bits) x and y.

      r0: [output] product (x * y)
      r1: x
      r2: y
  divide_fixed_point64:
    value: 0x1ec8
    doc: |-
      Divides two signed 64-bit fixed-point numbers (16 fraction bits).

      Returns the maximum positive value ((INT64_MAX >> 16) + (UINT16_MAX * 2^-16)) if the divisor is zero.

      r0: [output] quotient (dividend / divisor)
      r1: dividend
      r2: divisor
  u_multiply_fixed_point64:
    value: 0x1fa0
    doc: |-
      Multiplies two unsigned 64-bit fixed-point numbers (16 fraction bits) x and y.

      r0: [output] product (x * y)
      r1: x
      r2: y
  u_divide_fixed_point64:
    value: 0x2084
    doc: |-
      Divides two unsigned 64-bit fixed-point numbers (16 fraction bits).

      Returns the maximum positive value for a signed fixed-point number ((INT64_MAX >> 16) + (UINT16_MAX * 2^-16)) if the divisor is zero.

      r0: [output] quotient (dividend / divisor)
      r1: dividend
      r2: divisor
  add_fixed_point64:
    value: 0x21c8
    doc: |-
      Adds two 64-bit fixed-point numbers (16 fraction bits) x and y.

      r0: [output] sum (x + y)
      r1: x
      r2: y
  clamped_ln:
    value: 0x21f4
    doc: |-
      The natural log function over the domain of [1, 2047]. The input is clamped to this domain.

      r0: [output] ln(x)
      r1: x
  get_rng_seed:
    value: 0x222c
    doc: Get the current value of PRNG_SEQUENCE_NUM.
  set_rng_seed:
    value: 0x223c
    doc: |-
      Seed PRNG_SEQUENCE_NUM to a given value.

      r0: seed
  rand16_bit:
    value: 0x224c
    doc: |-
      Computes a pseudorandom 16-bit integer using the general-purpose PRNG.

      Note that much of dungeon mode uses its own (slightly higher-quality) PRNG within overlay 29. See overlay29.yml for more information.

      Random numbers are generated with a linear congruential generator (LCG), using a modulus of 2^16, a multiplier of 109, and an increment of 1021. I.e., the recurrence relation is `x = (109*x_prev + 1021) % 2^16`.

      The LCG has a hard-coded seed of 13452 (0x348C), but can be seeded with a call to SetRngSeed.

      return: pseudorandom int on the interval [0, 65535]
  rand_int:
    value: 0x2274
    doc: |-
      Compute a pseudorandom integer under a given maximum value using the general-purpose PRNG.

      This function relies on a single call to Rand16Bit. Even though it takes a 32-bit integer as input, the number of unique outcomes is capped at 2^16.

      r0: high
      return: pseudorandom integer on the interval [0, high - 1]
  rand_range:
    value: 0x228c
    doc: |-
      Compute a pseudorandom value between two integers using the general-purpose PRNG.

      This function relies on a single call to Rand16Bit. Even though it takes 32-bit integers as input, the number of unique outcomes is capped at 2^16.

      r0: x
      r1: y
      return: pseudorandom integer on the interval [x, y - 1]
  rand32_bit:
    value: 0x22ac
    doc: |-
      Computes a random 32-bit integer using the general-purpose PRNG. The upper and lower 16 bits are each generated with a separate call to Rand16Bit (so this function advances the PRNG twice).

      return: pseudorandom int on the interval [0, 4294967295]
  rand_int_safe:
    value: 0x22f8
    doc: |-
      Same as RandInt, except explicitly masking out the upper 16 bits of the output from Rand16Bit (which should be zero anyway).

      r0: high
      return: pseudorandom integer on the interval [0, high - 1]
  rand_range_safe:
    value: 0x2318
    doc: |-
      Like RandRange, except reordering the inputs as needed, and explicitly masking out the upper 16 bits of the output from Rand16Bit (which should be zero anyway).

      r0: x
      r1: y
      return: pseudorandom integer on the interval [min(x, y), max(x, y) - 1]
  wait_forever:
    value: 0x2438
    doc: |-
      Sets some program state and calls WaitForInterrupt in an infinite loop.

      This is called on fatal errors to hang the program indefinitely.

      No params.
  interrupt_master_disable:
    value: 0x30cc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: previous state
  interrupt_master_enable:
    value: 0x30e4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: previous state
  init_mem_alloc_table_veneer:
    value: 0x321c
    doc: |-
      Likely a linker-generated veneer for InitMemAllocTable.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      No params.
  z_init8:
    value: 0x3228
    doc: |-
      Zeroes an 8-byte buffer.

      r0: ptr
  points_to_zero:
    value: 0x3238
    doc: |-
      Checks whether a pointer points to zero.

      r0: ptr
      return: bool
  mem_zero:
    value: 0x3250
    doc: |-
      Zeroes a buffer.

      r0: ptr
      r1: len
  mem_zero16:
    value: 0x326c
    doc: |-
      Zeros a buffer of 16-bit values.

      r0: ptr
      r1: len (# bytes)
  mem_zero32:
    value: 0x3288
    doc: |-
      Zeros a buffer of 32-bit values.

      r0: ptr
      r1: len (# bytes)
  memset_simple:
    value: 0x32a4
    doc: |-
      A simple implementation of the memset(3) C library function.

      This function was probably manually implemented by the developers. See memset for what's probably the real libc function.

      r0: ptr
      r1: value
      r2: len (# bytes)
  memset32:
    value: 0x32bc
    doc: |-
      Fills a buffer of 32-bit values with a given value.

      r0: ptr
      r1: value
      r2: len (# bytes)
  memcpy_simple:
    value: 0x32d4
    doc: |-
      A simple implementation of the memcpy(3) C library function.

      This function was probably manually implemented by the developers. See memcpy for what's probably the real libc function.

      This function copies from src to dst in backwards byte order, so this is safe to call for overlapping src and dst if src <= dst.

      r0: dest
      r1: src
      r2: n
  memcpy16:
    value: 0x32f0
    doc: |-
      Copies 16-bit values from one buffer to another.

      r0: dest
      r1: src
      r2: n (# bytes)
  memcpy32:
    value: 0x330c
    doc: |-
      Copies 32-bit values from one buffer to another.

      r0: dest
      r1: src
      r2: n (# bytes)
  task_proc_boot:
    value: 0x3328
    doc: |-
      Boot the game and run the main loop. Use dynamic code dispatch to run code depending on the context (like dungeon mode, ground mode, menu mode, etc.).

      This function prints the debug message "task proc boot".

      No params.
  enable_all_interrupts:
    value: 0x3608
    doc: |-
      Sets the Interrupt Master Enable (IME) register to 1, which enables all CPU interrupts (if enabled in the Interrupt Enable (IE) register).

      See https://problemkaputt.de/gbatek.htm#dsiomaps.

      return: old value in the IME register
  get_time:
    value: 0x37b4
    doc: |-
      Seems to get the current (system?) time as an IEEE 754 floating-point number.

      return: current time (maybe in seconds?)
  disable_all_interrupts:
    value: 0x3824
    doc: |-
      Sets the Interrupt Master Enable (IME) register to 0, which disables all CPU interrupts (even if enabled in the Interrupt Enable (IE) register).

      See https://problemkaputt.de/gbatek.htm#dsiomaps.

      return: old value in the IME register
  sound_resume:
    value: 0x3cc4
    doc: |-
      Probably resumes the sound player if paused?

      This function prints the debug string "sound resume".
  card_pull_out_with_status:
    value: 0x3d2c
    doc: |-
      Probably aborts the program with some status code? It seems to serve a similar purpose to the exit(3) function.

      This function prints the debug string "card pull out %d" with the status code.

      r0: status code
  card_pull_out:
    value: 0x3d70
    doc: |-
      Sets some global flag that probably triggers system exit?

      This function prints the debug string "card pull out".

      No params.
  card_backup_error:
    value: 0x3d94
    doc: |-
      Sets some global flag that maybe indicates a save error?

      This function prints the debug string "card backup error".

      No params.
  halt_process_disp:
    value: 0x3db8
    doc: |-
      Maybe halts the process display?

      This function prints the debug string "halt process disp %d" with the status code.

      r0: status code
  overlay_is_loaded:
    value: 0x3ed0
    doc: |-
      Checks if an overlay with a certain group ID is currently loaded.

      See the LOADED_OVERLAY_GROUP_* data symbols or enum overlay_group_id in the C headers for a mapping between group ID and overlay number.

      r0: group ID of the overlay to check. A group ID of 0 denotes no overlay, and the return value will always be true in this case.
      return: bool
  load_overlay:
    value: 0x40ac
    doc: |-
      Loads an overlay from ROM by its group ID.

      See the LOADED_OVERLAY_GROUP_* data symbols or enum overlay_group_id in the C headers for a mapping between group ID and overlay number.

      r0: group ID of the overlay to load
  unload_overlay:
    value: 0x4868
    doc: |-
      Unloads an overlay from ROM by its group ID.

      See the LOADED_OVERLAY_GROUP_* data symbols or enum overlay_group_id in the C headers for a mapping between group ID and overlay number.

      r0: group ID of the overlay to unload
      others: ?
  get_ds_firmware_user_settings_veneer:
    value: 0x4f74
    doc: |-
      Likely a linker-generated veneer for GetDsFirmwareUserSettings.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: user_settings pointer
  rgb8_to_rgb5:
    value: 0x4fcc
    doc: |-
      Transform the input rgb8 color to a rgb5 color

      r0: pointer to target rgb5 (2 bytes, aligned to LSB)
      r1: pointer to source rgb8
  clamp_component_abs:
    value: 0x5110
    doc: |-
      Clamps the absolute values in a two-component integer array.

      Given an integer array [x, y] and a maximum absolute value M, clamps each element of the array to M such that the output array is [min(max(x, -M), M), min(max(y, -M), M)].

      r0: 2-element integer array, will be mutated
      r1: max absolute value
  get_held_buttons:
    value: 0x61ec
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: controller
      r1: btn_ptr
      return: any_activated
  get_pressed_buttons:
    value: 0x625c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: controller
      r1: btn_ptr
      return: any_activated
  get_released_stylus:
    value: 0x6c1c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: stylus_ptr
      return: any_activated
  key_wait_init:
    value: 0x6da4
    doc: |-
      Implements (most of?) SPECIAL_PROC_KEY_WAIT_INIT (see ScriptSpecialProcessCall).

      No params.
  debug_print_system_clock:
    value: 0x6ef8
    doc: |-
      This function prints the debug message "Now date & time" followed by the current date and time of the DS system clock. Called on boot.

      No params.
  get_system_clock:
    value: 0x6f68
    doc: |-
      Gets information surrounding the DS system clock, such as the current month, day, etc.

      r0: system_clock pointer
  sprintf_system_clock:
    value: 0x6fb8
    doc: |-
      Calls sprintf to format a string using the fields of the DS system clock as "year/month/day hour:minute:second". Used in DebugPrintSystemClock.

      r0: system_clock pointer
      r1: str
  data_transfer_init:
    value: 0x8168
    doc: |-
      Initializes data transfer mode to get data from the ROM cartridge.

      No params.
  data_transfer_stop:
    value: 0x8194
    doc: |-
      Finalizes data transfer from the ROM cartridge.

      This function must always be called if DataTransferInit was called, or the game will crash.

      No params.
  file_init_veneer:
    value: 0x8204
    doc: |-
      Likely a linker-generated veneer for FileInit.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: file_stream pointer
  file_open:
    value: 0x8210
    doc: |-
      Opens a file from the ROM file system at the given path, sort of like C's fopen(3) library function.

      r0: file_stream pointer
      r1: file path string
  file_get_size:
    value: 0x8244
    doc: |-
      Gets the size of an open file.

      r0: file_stream pointer
      return: file size
  file_read:
    value: 0x8254
    doc: |-
      Reads the contents of a file into the given buffer, and moves the file cursor accordingly.

      Data transfer mode must have been initialized (with DataTransferInit) prior to calling this function. This function looks like it's doing something akin to calling read(2) or fread(3) in a loop until all the bytes have been successfully read.

      Note: If code is running from IRQ mode, it appears that FileRead hangs the game. When the processor mode is forced into SYSTEM mode FileRead once again works, so it appears that ROM access only works in certain processor modes. Note that forcing the processor into a different mode is generally a bad idea and should be avoided as it will easily corrupt that processor mode's states.

      r0: file_stream pointer
      r1: [output] buffer
      r2: number of bytes to read
      return: number of bytes read
  file_seek:
    value: 0x82a8
    doc: |-
      Sets a file stream's position indicator.

      This function has the a similar API to the fseek(3) library function from C, including using the same codes for the `whence` parameter:
      - SEEK_SET=0
      - SEEK_CUR=1
      - SEEK_END=2

      r0: file_stream pointer
      r1: offset
      r2: whence
  file_close:
    value: 0x82c4
    doc: |-
      Closes a file.

      Data transfer mode must have been initialized (with DataTransferInit) prior to calling this function.

      Note: It is possible to keep a file stream open even if data transfer mode has been stopped, in which case the file stream can be used again if data transfer mode is reinitialized.

      r0: file_stream pointer
  unload_file:
    value: 0x8bd4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: addr_ptr
  load_file_from_rom:
    value: 0x8c3c
    doc: |-
      Loads a file from ROM by filepath into a heap-allocated buffer.

      r0: [output] pointer to an IO struct {ptr, len}
      r1: file path string pointer
      r2: flags
  transform_palette_data_with_flush_divide_fade:
    value: 0xae38
    doc: 'r0: palette_data'
  update_fade_status:
    value: 0xba18
    doc: |-
      Updates the given screen_fade struct to initiate a fade for example.

      In addition to initiating a fade this is called when a fade out is complete to set a flag for that in the struct.

      r0: screen_fade
      r1: probably the type of the fade
      r2: duration
  handle_fades:
    value: 0xba90
    doc: |-
      Handles updating the screen_fade struct in all modes except dungeon mode.

      Gets called every frame for both screens, analyzes the fade_struct and does appropriate actions. If there's a fade in progress, it calculates the brightness on the next frame and updates the structure accordingly.

      r0: screen_fade
      return: bool
  get_fade_status:
    value: 0xbdb4
    doc: |-
      Returns 1 if fading to black, 2 if fading to white, 0 otherwise.

      r0: screen_fade
      return: int
  init_debug:
    value: 0xc15c
    doc: |-
      Would have initialized debugging-related things, if they were not removed.
      As for the release version, does nothing but set DEBUG_IS_INITIALIZED to true.
  init_debug_flag:
    value: 0xc194
    doc: |-
      Would have initialized the debug flags.
      Does nothing in release binary.
  get_debug_flag:
    value: 0xc198
    doc: |-
      Should return the value of the specified debug flag. Just returns 0 in the final binary.

      r0: flag ID
      return: flag value
  set_debug_flag:
    value: 0xc1a0
    doc: |-
      Should set the value of a debug flag. A no-op in the final binary.

      r0: flag ID
      r1: flag value
  init_debug_stripped6:
    value: 0xc1a4
    doc: Does nothing, only called in the debug initialization function.
  append_prog_pos:
    value: 0xc1a8
    doc: |-
      Write a base message into a string and append the file name and line number to the end in the format "file = '%s'  line = %5d\n".

      If no program position info is given, "ProgPos info NULL\n" is appended instead.

      r0: [output] str
      r1: program position info
      r2: base message
      return: number of characters printed, excluding the null-terminator
  init_debug_stripped5:
    value: 0xc1f0
    doc: Does nothing, only called in the debug initialization function.
  debug_print_trace:
    value: 0xc1f4
    doc: |-
      Would log a printf format string tagged with the file name and line number in the debug binary.

      This still constructs the string, but doesn't actually do anything with it in the final binary.

      If message is a null pointer, the string "  Print  " is used instead.

      r0: message
      r1: program position info (can be null)
  debug_display:
    value: 0xc250
    doc: |-
      Would display a printf format string on the top screen in the debug binary.

      This still constructs the string with vsprintf, but doesn't actually do anything with it in the final binary.

      Identical to DebugPrint0 in release builds.

      r0: format
      ...: variadic
  debug_print0:
    value: 0xc284
    doc: |-
      Would log a printf format string in the debug binary.

      This still constructs the string with vsprintf, but doesn't actually do anything with it in the final binary.

      Identical to DebugDisplay in release builds.

      r0: format
      ...: variadic
  init_debug_log_flag:
    value: 0xc2b8
    doc: |-
      Would have initialized the debug log flags.
      Does nothing in release binary.
  get_debug_log_flag:
    value: 0xc2bc
    doc: |-
      Should return the value of the specified debug log flag. Just returns 0 in the final binary.

      r0: flag ID
      return: flag value
  set_debug_log_flag:
    value: 0xc2c4
    doc: |-
      Should set the value of a debug log flag. A no-op in the final binary.

      r0: flag ID
      r1: flag value
  debug_print:
    value: 0xc2c8
    doc: |-
      Would log a printf format string in the debug binary. A no-op in the final binary.

      r0: log level
      r1: format
      ...: variadic
  init_debug_stripped4:
    value: 0xc2d4
    doc: Does nothing, only called in the debug initialization function.
  init_debug_stripped3:
    value: 0xc2d8
    doc: Does nothing, only called in the debug initialization function.
  init_debug_stripped2:
    value: 0xc2dc
    doc: Does nothing, only called in the debug initialization function.
  init_debug_stripped1:
    value: 0xc2e0
    doc: Does nothing, only called in the debug initialization function.
  fatal_error:
    value: 0xc2e4
    doc: |-
      Logs some debug messages, then hangs the process.

      This function is called in lots of places to bail on a fatal error. Looking at the static data callers use to fill in the program position info is informative, as it tells you the original file name (probably from the standard __FILE__ macro) and line number (probably from the standard __LINE__ macro) in the source code.

      r0: program position info
      r1: format
      ...: variadic
  open_all_pack_files:
    value: 0xc364
    doc: |-
      Open the 6 files at PACK_FILE_PATHS_TABLE into PACK_FILES_OPENED. Called during game initialization.

      No params.
  get_file_length_in_pack_with_pack_nb:
    value: 0xc3c4
    doc: |-
      Call GetFileLengthInPack after looking up the global Pack archive by its number

      r0: pack file number
      r1: file number
      return: size of the file in bytes from the Pack Table of Content
  load_file_in_pack_with_pack_id:
    value: 0xc3e4
    doc: |-
      Call LoadFileInPack after looking up the global Pack archive by its identifier

      r0: pack file identifier
      r1: file index
      r2: [output] target buffer
      return: number of read bytes (identical to the length of the pack from the Table of Content)
  alloc_and_load_file_in_pack:
    value: 0xc410
    doc: |-
      Allocate a file and load a file from the pack archive inside.
      The data pointed by the pointer in the output need to be freed once is not needed anymore.

      r0: pack file identifier
      r1: file index
      r2: [output] result struct (will contain length and pointer)
      r3: allocation flags
  open_pack_file:
    value: 0xc468
    doc: |-
      Open a Pack file, to be read later. Initialize the output structure.

      r0: [output] pack file struct
      r1: file name
  get_file_length_in_pack:
    value: 0xc4fc
    doc: |-
      Get the length of a file entry from a Pack archive

      r0: pack file struct
      r1: file index
      return: size of the file in bytes from the Pack Table of Content
  load_file_in_pack:
    value: 0xc50c
    doc: |-
      Load the indexed file from the Pack archive, itself loaded from the ROM.

      r0: pack file struct
      r1: [output] target buffer
      r2: file index
      return: number of read bytes (identical to the length of the pack from the Table of Content)
  get_dungeon_result_msg:
    value: 0xc584
    doc: |-
      Gets the message that is shown on the dungeon results ("The Last Outing") screen, right after the leader's name.

      r0: Damage source value to use when displaying the cause of fainting or the result of the expedition
      r1: [output] Buffer where the resulting message will be stored
      r2: Buffer size
      r3: (?) Seems to point to a buffer
  get_damage_source:
    value: 0xcadc
    doc: |-
      Gets the damage source for a given move-item combination.

      If there's no item, the source is the move ID. If the item is an orb, return DAMAGE_SOURCE_ORB_ITEM. Otherwise, return DAMAGE_SOURCE_NON_ORB_ITEM.

      r0: move ID
      r1: item ID
      return: damage source
  get_item_category_veneer:
    value: 0xcb78
    doc: |-
      Likely a linker-generated veneer for GetItemCategory.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: Item ID
      return: Category ID
  get_item_move_id16:
    value: 0xcb84
    doc: |-
      Wraps GetItemMoveId, ensuring that the return value is 16-bit.

      r0: item ID
      return: move ID
  is_thrown_item:
    value: 0xcb98
    doc: |-
      Checks if a given item ID is a thrown item (CATEGORY_THROWN_LINE or CATEGORY_THROWN_ARC).

      r0: item ID
      return: bool
  is_not_money:
    value: 0xcbb4
    doc: |-
      Checks if an item ID is not ITEM_POKE.

      r0: item ID
      return: bool
  is_edible:
    value: 0xcbd4
    doc: |-
      Checks if an item has an item category of CATEGORY_BERRIES_SEEDS_VITAMINS or CATEGORY_FOOD_GUMMIES.

      r0: item ID
      return: bool
  is_hm:
    value: 0xcbf8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: bool
  is_gummi:
    value: 0xcc7c
    doc: |-
      Checks if an item is a Gummi.

      r0: item ID
      return: bool
  is_aura_bow:
    value: 0xcc9c
    doc: |-
      Checks if an item is one of the aura bows received at the start of the game.

      r0: item ID
      return: bool
  is_losable_item:
    value: 0xccc0
    doc: |-
      Checks if an item can be lost after fainting in a dungeon. Specifically calls IsAuraBow and checks item::f_in_shop
      so that the player can't keep an aura bow they haven't paid for yet.

      r0: item pointer
      return: bool
  is_treasure_box:
    value: 0xcd0c
    doc: |-
      Checks if the given item ID is a treasure box

      In particular, it checks if the category of the item is CATEGORY_TREASURE_BOXES_1, CATEGORY_TREASURE_BOXES_2 or CATEGORY_TREASURE_BOXES_3.

      r0: item ID
      return: True if the item is a treasure box, false otherwise
  is_storable_item:
    value: 0xcd30
    doc: |-
      Checks if an item can be put into storage. Specifically checks for the Wonder Egg, Poke, and Used TMs. Used TMs
      likely can't be stored because the move the TM teaches would be lost when sent to storage.

      r0: item_id
      return: bool
  is_shoppable_item:
    value: 0xcd68
    doc: |-
      Checks if an item can be bought and sold from a Kecleon shop. Includes items like the Gold Thorn, Poke, Golden
      Mask, Amber Tear, etc. Also has a special check to make sure an item's buy and sell price is more than 0.

      r0: item_id
      return: bool
  is_valid_target_item:
    value: 0xce34
    doc: |-
      Checks if an item is a valid target item for missions. Returns true for any item less than ITEM_UNNAMED_0x16B.
      Appears to check a list for valid items above ITEM_UNNAMED_0x16B, but the list is empty?

      r0: item_id
      return: bool
  is_item_usable_now:
    value: 0xce80
    doc: |-
      Checks if an item can be used right now. Returns true for all items that are not in a shop. If the item is in a
      shop, specifically checks for TMs/HMs and items that provide permanent buffs (Gummis, Sitrus Berry, Ginseng, etc).

      r0: item pointer
      return: bool
  is_ticket_item:
    value: 0xcefc
    doc: |-
      Checks if an item is a ticket that can be used in the recycle shop (ITEM_PRIZE_TICKET, ITEM_SILVER_TICKET,
      ITEM_GOLD_TICKET, and ITEM_PRISM_TICKET).

      r0: item_id
      return: bool
  init_item:
    value: 0xcf24
    doc: |-
      Initialize an item struct with the given information.

      This will resolve the quantity based on the item type. For Poké, the quantity code will always be set to 1. For thrown items, the quantity code will be randomly generated on the range of valid quantities for that item type. For non-stackable items, the quantity code will always be set to 0. Otherwise, the quantity will be assigned from the quantity argument.

      r0: pointer to item to initialize
      r1: item ID
      r2: quantity
      r3: sticky flag
  init_standard_item:
    value: 0xcfe0
    doc: |-
      Wrapper around InitItem with quantity set to 0.

      r0: pointer to item to initialize
      r1: item ID
      r2: sticky flag
  init_bulk_item:
    value: 0xd000
    doc: |-
      Initialize a struct bulk_item with the given information.

      This will resolve the quantity based on the item type. For Poké, the quantity code will always be set to 1. For thrown items, the quantity code will be randomly generated on the range of valid quantities for that item type. For non-stackable items, the quantity code will always be set to 0.

      r0: pointer to bulk item to initialize
      r1: item ID
  bulk_item_to_item:
    value: 0xd078
    doc: |-
      Convert a bulk_item into an equivalent item.

      r0: pointer to item to initialize
      r1: pointer to bulk_item
  item_to_bulk_item:
    value: 0xd128
    doc: |-
      Convert an item into an equivalent bulk_item.

      r0: pointer to bulk_item to initialize
      r1: pointer to item
  get_displayed_buy_price:
    value: 0xd158
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item
      return: buy price
  get_displayed_sell_price:
    value: 0xd1a0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item
      return: sell price
  get_actual_buy_price:
    value: 0xd1e8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item
      return: buy price
  get_actual_sell_price:
    value: 0xd230
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item
      return: sell price
  find_item_in_inventory:
    value: 0xd300
    doc: |-
      Returns x if item_id is at position x in the bag
      Returns 0x8000+x if item_id is at position x in storage
      Returns -1 if item is not found

      Note: unverified, ported from Irdkwia's notes

      r0: item_id
      return: inventory index
  item_z_init:
    value: 0xd8a4
    doc: |-
      Zero-initializes an item struct.

      r0: item
  are_items_equivalent:
    value: 0xd8bc
    doc: |-
      Checks whether two items are equivalent and only checks the bitflags specified by the bitmask.

      r0: item
      r1: item
      r2: bitmask
      return: bool
  write_items_to_save:
    value: 0xd9e4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: start_address
      r1: total_length
      return: ?
  read_items_from_save:
    value: 0xdccc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: start_address
      r1: total_length
      return: ?
  is_item_available_in_dungeon_group:
    value: 0xe094
    doc: |-
      Checks one specific bit from AVAILABLE_ITEMS_IN_GROUP_TABLE?

      r0: dungeon ID
      r1: item ID
      return: bool
  get_item_id_from_list:
    value: 0xe0dc
    doc: |-
      category_num and item_num are numbers in range 0-10000

      Note: unverified, ported from Irdkwia's notes

      r0: list_id
      r1: category_num
      r2: item_num
      return: item ID
  normalize_treasure_box:
    value: 0xe280
    doc: |-
      If the item is a treasure box return the first version of the treasure box in the item list.
      Otherwise, return the same item ID.

      r0: item ID
      return: normalized item ID
  sort_item_list:
    value: 0xe428
    doc: |-
      Attempts to combine stacks of throwable items, sort the list, and then remove empty items.
      Appears to use selection sort to sort the list in place.

      r0: item array
      r1: number of items in array
  remove_empty_items:
    value: 0xe698
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: list_pointer
      r1: size
  load_item_pspi2n:
    value: 0xe760
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  get_exclusive_item_type:
    value: 0xe830
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: ?
  get_exclusive_item_offset_ensure_valid:
    value: 0xe84c
    doc: |-
      Gets the exclusive item offset, which is the item ID relative to that of the first exclusive item, the Prism Ruff.

      If the given item ID is not a valid item ID, ITEM_PLAIN_SEED (0x55) is returned. This is a bug, since 0x55 is the valid exclusive item offset for the Icy Globe.

      r0: item ID
      return: offset
  is_item_valid:
    value: 0xe890
    doc: |-
      Checks if an item is valid given its ID.

      In particular, checks if the "is valid" flag is set on its item_p.bin entry.

      r0: item ID
      return: bool
  get_exclusive_item_parameter:
    value: 0xe8b8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: ?
  get_item_category:
    value: 0xe8d8
    doc: |-
      Returns the category of the specified item

      r0: Item ID
      return: Item category
  ensure_valid_item:
    value: 0xe8f8
    doc: |-
      Checks if the given item ID is valid (using IsItemValid). If so, return the given item ID. Otherwise, return ITEM_PLAIN_SEED.

      r0: item ID
      return: valid item ID
  get_item_name:
    value: 0xe934
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: item name
  get_item_name_formatted:
    value: 0xe954
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: [output] name
      r1: item_id
      r2: flag
      r3: flag2
  get_item_buy_price:
    value: 0xea60
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: buy price
  get_item_sell_price:
    value: 0xea80
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: sell price
  get_item_sprite_id:
    value: 0xeaa0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: sprite ID
  get_item_palette_id:
    value: 0xeac0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: palette ID
  get_item_action_name:
    value: 0xeae0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: action name ID
  get_thrown_item_quantity_limit:
    value: 0xeb00
    doc: |-
      Get the minimum or maximum quantity for a given thrown item ID.

      r0: item ID
      r1: 0 for minimum, 1 for maximum
      return: minimum/maximum quantity for the given item ID
  get_item_move_id:
    value: 0xeb28
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: move ID
  test_item_ai_flag:
    value: 0xeb48
    doc: |-
      Returns a boolean indicating whether the item is consumable, throwable at an ally, or throwable at an enemy, depending on item_flag.
      The table used for this is inaccessible in the code, as it is loaded from a file in the ROM at runtime.
      Bit 7 in the table corresponds to ITEM_FLAG_CONSUMABLE, bit 6 to ITEM_FLAG_THROWABLE_AT_ALLY, and bit 5 to ITEM_FLAG_THROWABLE_AT_ENEMY.

      r0: item_id enum
      r1: item_flag enum. Function will test a different allowed AI action depending on the value.
      return: bool
  is_item_in_time_darkness:
    value: 0xebd8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: bool
  is_item_valid_veneer:
    value: 0xec00
    doc: |-
      Likely a linker-generated veneer for IsItemValid.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: item ID
      return: bool
  set_active_inventory_to_main:
    value: 0xec74
    doc: |-
      Changes the currently active inventory to TEAM_MAIN.

      No params.
  all_inventories_z_init:
    value: 0xec84
    doc: |-
      Initializes all inventories (TEAM_MAIN, TEAM_SPECIAL_EPISODE, TEAM_RESCUE) to empty and sets the active inventory
      to TEAM_MAIN.

      No params.
  special_episode_inventory_z_init:
    value: 0xecf0
    doc: |-
      Initializes the TEAM_SPECIAL_EPISODE inventory to be empty.

      No params.
  rescue_inventory_z_init:
    value: 0xed38
    doc: |-
      Initializes the TEAM_RESCUE inventory to be empty.

      No params.
  set_active_inventory:
    value: 0xed80
    doc: |-
      Changes the currently active inventory. Has one for the main team, rescue team, and the special
      episode team.

      r0: team ID
  get_money_carried:
    value: 0xeda4
    doc: |-
      Gets the amount of money the player is carrying.

      return: value
  set_money_carried:
    value: 0xedc4
    doc: |-
      Sets the amount of money the player is carrying, clamping the value to the range [0, MAX_MONEY_CARRIED].

      r0: new value
  add_money_carried:
    value: 0xee00
    doc: |-
      Adds the amount of money to the player's current amount of money. Just calls
      SetMoneyCarried with the current money + money gained.

      r0: money gained (can be negative)
  get_current_bag_capacity:
    value: 0xee2c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: bag capacity
  is_bag_full:
    value: 0xee68
    doc: |-
      Implements SPECIAL_PROC_IS_BAG_FULL (see ScriptSpecialProcessCall).

      return: bool
  get_nb_items_in_bag:
    value: 0xeea4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: # items
  count_nb_items_of_type_in_bag:
    value: 0xeef4
    doc: |-
      Returns the number of items of the given kind in the bag

      r0: item ID
      return: count
  count_item_type_in_bag:
    value: 0xef30
    doc: |-
      Implements SPECIAL_PROC_COUNT_ITEM_TYPE_IN_BAG (see ScriptSpecialProcessCall).

      Irdkwia's notes: Count also stackable

      r0: item ID
      return: number of items of the specified ID in the bag
  is_item_in_bag:
    value: 0xef88
    doc: |-
      Checks if an item is in the player's bag.

      r0: item ID
      return: bool
  is_item_with_flags_in_bag:
    value: 0xefc8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      r1: flags
      return: bool
  is_item_in_treasure_boxes:
    value: 0xf014
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: bool
  is_held_item_in_bag:
    value: 0xf074
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item
      return: bool
  is_item_for_special_spawn_in_bag:
    value: 0xf0f8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: bool
  has_storable_items:
    value: 0xf18c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: bool
  get_item_index:
    value: 0xf1f4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_ptr
      return: index
  get_equiv_item_index:
    value: 0xf234
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_ptr
      return: index
  get_equipped_throwable_item:
    value: 0xf2b0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: index
  get_first_unequipped_item_of_type:
    value: 0xf314
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: index
  copy_item_at_idx:
    value: 0xf388
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: index
      r1: [output] item_ptr
      return: exists
  get_item_at_idx:
    value: 0xf3f0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: index
      return: item pointer
  remove_empty_items_in_bag:
    value: 0xf418
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  remove_item_no_hole:
    value: 0xf438
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: index
      return: ?
  remove_item:
    value: 0xf4ac
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: index
  remove_held_item_no_hole:
    value: 0xf4fc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: held_index
  remove_item_by_id_and_stack_no_hole:
    value: 0xf57c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_ptr
      return: ?
  remove_equiv_item:
    value: 0xf600
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_ptr
      return: ?
  remove_equiv_item_no_hole:
    value: 0xf6a8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_ptr
      return: ?
  decrement_stack_item:
    value: 0xf73c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item_ptr
      return: ?
  remove_item_no_hole_check:
    value: 0xf7c0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: index
      return: ?
  remove_first_unequipped_item_of_type:
    value: 0xf840
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      return: ?
  remove_all_items:
    value: 0xf850
    doc: |-
      WARNING! Does not remove from party items

      Note: unverified, ported from Irdkwia's notes
  remove_all_items_starting_at:
    value: 0xf884
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: index
  special_proc_add_item_to_bag:
    value: 0xf8f4
    doc: |-
      Implements SPECIAL_PROC_ADD_ITEM_TO_BAG (see ScriptSpecialProcessCall).

      r0: pointer to an owned_item
      return: bool
  add_item_to_bag_no_held:
    value: 0xf91c
    doc: |-
      A wrapper around AddItemToBag with held_by being 0 (no holder).

      r0: item_str
      return: bool item was successfully added to the bag
  add_item_to_bag:
    value: 0xf92c
    doc: |-
      Attempts to add an item to the bag.

      r0: item_str
      r1: held_by
      return: bool item was successfully added to the bag
  clean_sticky_items_in_bag:
    value: 0xf9b8
    doc: |-
      Removes the sticky flag from all the items currently in the bag.

      No params.
  count_sticky_items_in_bag:
    value: 0xf9e8
    doc: |-
      Counts the number of sticky items currently in the bag.

      return: number of sticky items
  transmute_held_item_in_bag:
    value: 0xfb10
    doc: |-
      Looks for an item in the bag that has the same holder (held_by) as the transmute item and convert
      their equivalent item in the treasure bag into the transmute item. The monster's held item on
      their struct should be updated accordingly directly before or after calling this function.

      r0: transmute_item
      return: bool whether or not the item could be transmuted
  set_flags_for_held_item_in_bag:
    value: 0xfb94
    doc: |-
      Looks for an item in the bag that has the holder (held_by) as the item and make their equivalent
      item in the treasure bag sticky. The monster's held item on their struct should be updated
      accordingly directly before or after calling this function. Mostly used for making existing items
      sticky.

      r0: held_by
      r1: item bitflags
  remove_holder_for_item_in_bag:
    value: 0xfbfc
    doc: |-
      Looks for an item in the bag that is equivalent and make the holder none. The monster's held item
      on their struct should be updated accordingly directly before or after calling this function.

      r0: pointer to an item
  set_holder_for_item_in_bag:
    value: 0xfc88
    doc: |-
      Modifies the item at the index to be held by the monster specified and updates the item with the
      holder as well. This only modifies the flags and held_by of the item.

      r0: item index
      r1: pointer to an item
      r2: held_by
  sort_items_in_bag:
    value: 0xfccc
    doc: |-
      Sorts the current items in the item bag but first checks if any Poke is in the bag to remove. If
      Poke is found, add it to money carried.

      No params.
  remove_poke_items_in_bag:
    value: 0xfd54
    doc: |-
      Checks the bag for any Poke and removes it after adding it to money carried.

      No params.
  is_storage_full:
    value: 0xfdfc
    doc: |-
      Checks if the storage is full accounting for the current rank of the team.
      Implements SPECIAL_PROC_0x39 (see ScriptSpecialProcessCall).

      return: bool
  count_nb_of_items_in_storage:
    value: 0xfe20
    doc: |-
      Counts the number of items currently in storage (including invalid items).

      return: number of items in storage
  count_nb_of_valid_items_in_storage:
    value: 0xfe58
    doc: |-
      Counts the number of items currently in storage that are valid.

      return: number of valid items in storage
  count_nb_of_valid_items_in_time_darkness_in_storage:
    value: 0xfea8
    doc: |-
      Counts the number of items currently in storage that are valid and in time and darkness.

      return: number of valid items in storage
  count_nb_items_of_type_in_storage:
    value: 0xff50
    doc: |-
      Counts the number of instances of an item in storage not accounting for the number of items
      in a stack.

      r0: item ID
      return: count
  count_item_type_in_storage:
    value: 0xff8c
    doc: |-
      Counts the number of a certain item in storage accounting for stackable items.
      Implements SPECIAL_PROC_COUNT_ITEM_TYPE_IN_STORAGE (see ScriptSpecialProcessCall).

      r0: pointer to an bulk_item
      return: number of items of the specified ID in storage
  get_equiv_bulk_item_idx_in_storage:
    value: 0xfff8
    doc: |-
      Checks for a storage item equivalent to the bulk_item and returns the index of the item in storage.
      Returns -1 if unable to find an equivalent item.

      r0: pointer to a bulk_item
      return: index in storage
  convert_storage_item_at_idx_to_bulk_item:
    value: 0x10054
    doc: |-
      Get an item in storage and converts it into an equivalent bulk_item. This does not remove the
      item from storage.

      r0: item index
      r1: [output] pointer to a bulk_item
      return: bool whether or not the item id is not 0
  convert_storage_item_at_idx_to_item:
    value: 0x1009c
    doc: |-
      Get an item in storage and converts it into an equivalent item. The item does NOT have the exists
      flag set to true. This does not remove the item from storage.

      r0: item index
      r1: [output] pointer to an item
      return: bool whether or not the item id is not 0
  remove_item_at_idx_in_storage:
    value: 0x10248
    doc: |-
      Remove an item at the specified index from storage.

      r0: storage item idx
      return: bool whether or not the item was removed (fails if there is no storage item at the index)
  remove_bulk_item_in_storage:
    value: 0x1028c
    doc: |-
      Removes a storage item equivalent to the bulk_item passed from storage.
      Probably? Implements SPECIAL_PROC_REMOVE_ITEM_TYPE_IN_STORAGE (see ScriptSpecialProcessCall).

      r0: pointer to a bulk_item
      return: bool whether an item was removed
  remove_item_in_storage:
    value: 0x10308
    doc: |-
      Removes a storage item equivalent to the item passed from storage.

      r0: pointer to an item
      return: bool whether an item was removed
  storage_z_init:
    value: 0x10384
    doc: |-
      Initializes the storage to be empty.

      No params.
  add_bulk_item_to_storage:
    value: 0x103c4
    doc: |-
      Attempts to add the bulk_item to storage.
      Implements SPECIAL_PROC_ADD_ITEM_TO_STORAGE (see ScriptSpecialProcessCall).

      r0: pointer to a bulk_item
      return: bool whether an item was added
  add_item_to_storage:
    value: 0x10454
    doc: |-
      Attempts to add the item to storage.

      r0: pointer to an item
      return: bool whether an item was added
  sort_items_in_storage:
    value: 0x104cc
    doc: |-
      Sorts the item in storage by making converting them into normal items in a temporary list and
      using SortItemList on them. After, it puts the list of items back into storage. This may also have
      another use or do something broader than just sorting because it outputs a bool array.

      r0: [output] bool array?
      r1: number of items to sort (usually just the current size of storage)
  all_kecleon_shops_z_init:
    value: 0x1063c
    doc: |-
      Empties the Kecleon shop for both TEAM_MAIN and TEAM_SPECIAL_EPISODE. TEAM_RESCUE does not appear to have its own
      Kecleon shop.

      No params.
  special_episode_kecleon_shop_z_init:
    value: 0x106fc
    doc: |-
      Empties the special episode Kecleon shop.

      No params.
  set_active_kecleon_shop:
    value: 0x1076c
    doc: |-
      Changes the currently active Kecleon shop. Has one for TEAM_MAIN and TEAM_SPECIAL_EPISODE. TEAM_RESCUE does not
      appear to have its own copy of the Kecleon shop it seems to use TEAM_MAIN intead of TEAM_RESCUE.

      r0: team ID
  get_money_stored:
    value: 0x107b4
    doc: |-
      Gets the amount of money the player has stored in the Duskull Bank.

      return: amount of money stored
  set_money_stored:
    value: 0x107cc
    doc: |-
      Sets the amount of money the player has stored in the Duskull Bank, clamping the value to the range [0, MAX_MONEY_STORED].

      r0: new value
  add_money_stored:
    value: 0x10800
    doc: |-
      Adds money to the amount of money the player has stored in the Duskull Bank. Just calls SetMoneyStored with the current money + money gained.

      r0: money gained (can be negative)
  remove_item_from_kecleon_shop1:
    value: 0x10914
    doc: |-
      Removes an item from the first Kecleon Shop at a specific slot in the shop list.

      r0: item slot (0-7)
  sort_kecleon_items1:
    value: 0x109fc
    doc: |-
      Sorts the items for the normal Kecleon Shop items in Treasure Town.

      No params.
  generate_kecleon_items1:
    value: 0x10af4
    doc: |-
      Generates the Kecleon Shop items for both shopkeepers in Treasure Town. This function also calls
      GenerateKecleonItems2 despite GenerateKecleonItems2 being called directly after. This means that
      any items generated for the Orb/TM shop will be overwritten by the subsequent call to
      GenerateKecleonItems2.

      r0: kecleon_shop_version to use
  add_item_to_kecleon_shop1:
    value: 0x10b70
    doc: |-
      Tries to add the item to the first Kecleon shop. If there is no space, no item is added.

      r0: item ID
      return: whether the item was added succesfully
  remove_item_from_kecleon_shop2:
    value: 0x10c20
    doc: |-
      Removes an item from the second Kecleon Shop at a specific slot in the shop list.

      r0: item slot (0-4)
  sort_kecleon_items2:
    value: 0x10d08
    doc: |-
      Sorts the items for the Orb/TM Kecleon Shop items in Treasure Town.

      No params.
  generate_kecleon_items2:
    value: 0x10e00
    doc: |-
      Generates the Kecleon Shop items for the TMs/Orbs shop in Treasure Town.

      r0: kecleon_shop_version to use
  add_item_to_kecleon_shop2:
    value: 0x10e74
    doc: |-
      Tries to add the item to the second Kecleon shop. If there is no space, no item is added.

      r0: item ID
      return: whether the item was added succesfully
  get_exclusive_item_offset:
    value: 0x10ee8
    doc: |-
      Gets the exclusive item offset, which is the item ID relative to that of the first exclusive item, the Prism Ruff.

      r0: item ID
      return: offset
  apply_exclusive_item_stat_boosts:
    value: 0x10f0c
    doc: |-
      Applies stat boosts from an exclusive item.

      r0: item ID
      r1: pointer to attack stat to modify
      r2: pointer to special attack stat to modify
      r3: pointer to defense stat to modify
      stack[0]: pointer to special defense stat to modify
  set_exclusive_item_effect:
    value: 0x11028
    doc: |-
      Sets the bit for an exclusive item effect.

      r0: pointer to the effects bitvector to modify
      r1: exclusive item effect ID
  exclusive_item_effect_flag_test:
    value: 0x1104c
    doc: |-
      Tests the exclusive item bitvector for a specific exclusive item effect.

      r0: the effects bitvector to test
      r1: exclusive item effect ID
      return: bool
  is_exclusive_item_id_for_monster:
    value: 0x1106c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item ID
      r1: monster ID
      r2: type ID 1
      r3: type ID 2
      return: bool
  is_exclusive_item_for_monster:
    value: 0x1113c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: item
      r1: monster ID
      r2: type ID 1
      r3: type ID 2
      return: bool
  bag_has_exclusive_item_type_for_monster:
    value: 0x11180
    doc: |-
      Checks the bag for any exclusive item that applies to the monster or type(s) and gets the item ID.

      r0: excl_type
      r1: monster ID
      r2: type ID 1
      r3: type ID 2
      return: exclusive item ID
  get_exclusive_item_for_monster_from_bag:
    value: 0x11214
    doc: |-
      Checks the bag for any exclusive item that applies to the monster or type(s) and copies that item
      into the passed item struct.

      r0: [output] item_struct
      r1: excl_type
      r2: monster ID
      r3: type ID 1
      stack[0]: type ID 2
      return: bool whether an exclusive item was found
  get_hp_boost_from_exclusive_items:
    value: 0x1143c
    doc: |-
      Calculates the current HP boost from exclusive items. If none are active, return 0.

      r0: some struct that has species ID in it?
      return: max HP boost from exclusive items
  apply_gummi_boosts_to_ground_monster:
    value: 0x115d0
    doc: |-
      Applies the IQ boosts from eating a Gummi to the target monster. Basically a wrapper around
      ApplyGummiBoostsGroundMode for struct ground_monster.

      r0: ground monster pointer
      r1: Item ID
      r2: bool to NOT increase stats
      r3: [output] pointer to a struct gummi_result to fill out
  apply_gummi_boosts_to_team_member:
    value: 0x115fc
    doc: |-
      Applies the IQ boosts from eating a Gummi to the target monster. Basically a wrapper around
      ApplyGummiBoostsGroundMode for struct team_member.

      r0: team member pointer
      r1: Item ID
      r2: bool to NOT increase stats
      r3: [output] pointer to a struct gummi_result to fill out
  apply_sitrus_berry_boost_to_ground_monster:
    value: 0x11628
    doc: |-
      Applies the hp boost from the Sitrus Berry to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted hp boost, if not NULL
      return: actual hp boost
  apply_life_seed_boost_to_ground_monster:
    value: 0x11664
    doc: |-
      Applies the hp boost from the Life Seed to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted hp boost, if not NULL
      return: actual hp boost
  apply_ginseng_to_ground_monster:
    value: 0x116a0
    doc: |-
      Attempts to apply a ginseng boost to the highest valid move that the ground monster knows.

      r0: ground monster pointer
      r1: [output] move ID
      r2: [output] move boost
      return: actual move boost
  apply_protein_boost_to_ground_monster:
    value: 0x117b4
    doc: |-
      Applies the attack boost from Protein to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted attack boost, if not NULL
      return: actual attack boost
  apply_calcium_boost_to_ground_monster:
    value: 0x117f0
    doc: |-
      Applies the special attack boost from Calcium to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted special attack boost, if not NULL
      return: actual special attack boost
  apply_iron_boost_to_ground_monster:
    value: 0x1182c
    doc: |-
      Applies the defense boost from Iron to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted defense boost, if not NULL
      return: actual defense boost
  apply_zinc_boost_to_ground_monster:
    value: 0x11868
    doc: |-
      Applies the special defense boost from Zinc to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted special defense boost, if not NULL
      return: actual special defense boost
  apply_nectar_boost_to_ground_monster:
    value: 0x118a4
    doc: |-
      Applies the iq boost from Nectar to the target monster.

      r0: ground monster pointer
      r1: [output] pointer to attempted iq boost, if not NULL
      return: actual iq boost
  is_monster_affected_by_gravelyrock_ground_mode:
    value: 0x118d8
    doc: |-
      Checks if the monster is Bonsly or Sudowoodo.

      r0: ground monster pointer
      return: bool
  apply_gravelyrock_boost_to_ground_monster:
    value: 0x118f8
    doc: |-
      Applies the iq boost from Gravelyrock to the target monster. Only Bonsly and Sudowoodo gain IQ from the Gravelyrock.

      r0: ground monster pointer
      r1: [output] pointer to attempted iq boost, if not NULL
      return: actual iq boost
  apply_gummi_boosts_ground_mode:
    value: 0x11944
    doc: |-
      Applies the IQ boosts from eating a Gummi to the monster's data. Generally called with not increasing stats true outside of the cafe.

      r0: Pointer to monster id
      r1: Pointer to monster iq
      r2: Pointer to monster offensive stats
      r3: Pointer to monster defensive stats
      stack[0]: Item ID
      stack[1]: bool to NOT increase stats
      stack[2]: [output] pointer to a struct gummi_result
  load_synth_bin:
    value: 0x12b88
    doc: "Note: unverified, ported from Irdkwia's notes"
  close_synth_bin:
    value: 0x12bdc
    doc: "Note: unverified, ported from Irdkwia's notes"
  get_synth_item:
    value: 0x132f8
    doc: "Note: unverified, ported from Irdkwia's notes"
  load_waza_p:
    value: 0x1346c
    doc: "Note: unverified, ported from Irdkwia's notes"
  load_waza_p2:
    value: 0x13494
    doc: "Note: unverified, ported from Irdkwia's notes"
  unload_current_waza_p:
    value: 0x134bc
    doc: "Note: unverified, ported from Irdkwia's notes"
  get_move_name:
    value: 0x134fc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: move name
  format_move_string:
    value: 0x13520
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: string_buffer
      r1: move
      r2: type_print
  format_move_string_more:
    value: 0x13828
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: ???
      r1: ???
      r2: move
      r3: type_print
  init_move:
    value: 0x13860
    doc: |-
      Initializes a move info struct.

      This sets f_exists and f_enabled_for_ai on the flags, the ID to the given ID, the PP to the max PP for the move ID, and the ginseng boost to 0.

      r0: pointer to move to initialize
      r1: move ID
  init_move_check_id:
    value: 0x13890
    doc: |-
      Same as InitMove, but the function ensures that the specified ID is not 0. If it is, the move is initialized as invalid and nothing else happens.

      r0: move
      r1: move ID
  get_info_move_ground:
    value: 0x138d0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: ground move
      r1: move ID
  get_move_target_and_range:
    value: 0x138e8
    doc: |-
      Gets the move target-and-range field. See struct move_target_and_range in the C headers.

      r0: move pointer
      r1: AI flag (every move has two target-and-range fields, one for players and one for AI)
      return: move target and range
  get_move_type:
    value: 0x1390c
    doc: |-
      Gets the type of a move

      r0: Pointer to move data
      return: Type of the move
  get_moveset_level_up_ptr:
    value: 0x1392c
    doc: |-
      Given the ID of a monster in the current dungeon, returns a pointer to the list of moves it learns by leveling up and the level in which each move is learnt.

      The list contains pairs of <encoded move ID, level>. The move ID is encoded and can be 1 or 2 bytes long. GetEncodedHalfword must be used to decode it. The end of the list is marked by a null byte.

      r0: monster ID
      return: Pointer to encoded level-up move list
  is_invalid_moveset:
    value: 0x13974
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_id
      return: bool
  get_moveset_hm_tm_ptr:
    value: 0x1399c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: ?
  get_moveset_egg_ptr:
    value: 0x139e8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: ?
  get_move_ai_weight:
    value: 0x13a34
    doc: |-
      Gets the AI weight of a move

      r0: Pointer to move data
      return: AI weight of the move
  get_move_nb_strikes:
    value: 0x13a54
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move
      return: # strikes
  get_move_base_power:
    value: 0x13a74
    doc: |-
      Gets the base power of a move from the move data table.

      r0: move pointer
      return: base power
  get_move_base_power_ground:
    value: 0x13a94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: ground_move
      return: base power
  get_move_accuracy_or_ai_chance:
    value: 0x13ab4
    doc: |-
      Gets one of the two accuracy values of a move or its ai_condition_random_chance field.

      r0: Move pointer
      r1: 0 to get the move's first accuracy1 field, 1 to get its accuracy2, 2 to get its ai_condition_random_chance.
      return: Move's accuracy1, accuracy2 or ai_condition_random_chance
  get_move_base_pp:
    value: 0x13ad8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move
      return: base PP
  get_max_pp:
    value: 0x13af8
    doc: |-
      Gets the maximum PP for a given move.

      Irkdwia's notes: GetMovePPWithBonus

      r0: move pointer
      return: max PP for the given move, capped at 99
  get_move_max_ginseng_boost:
    value: 0x13b78
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move
      return: max ginseng boost
  get_move_max_ginseng_boost_ground:
    value: 0x13b98
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: ground_move
      return: max ginseng boost
  get_move_crit_chance:
    value: 0x13bb8
    doc: |-
      Gets the critical hit chance of a move.

      r0: move pointer
      return: critical hit chance
  is_thawing_move:
    value: 0x13bd8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move
      return: bool
  is_affected_by_taunt:
    value: 0x13bf8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      Based on struct move_data, maybe this should be IsUsableWhileTaunted?

      r0: move
      return: bool
  get_move_range_id:
    value: 0x13c18
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move
      return: range ID
  get_move_actual_accuracy:
    value: 0x13c38
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: accuracy
  get_move_base_power_from_id:
    value: 0x13c90
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: base power
  is_move_range_string_user:
    value: 0x13cac
    doc: |-
      Returns whether a move's range string is 19 ("User").

      r0: Move pointer
      return: True if the move's range string field has a value of 19.
  get_move_message_from_id:
    value: 0x13cd8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID?
      return: string
  get_nb_moves:
    value: 0x13d0c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      return: # moves
  is_reflected_by_magic_coat:
    value: 0x13db0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  can_be_snatched:
    value: 0x13dcc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  fails_while_muzzled:
    value: 0x13de8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      Called IsMouthMove in Irdkwia's notes, which presumably is relevant to the Muzzled status.

      r0: move ID
      return: bool
  is_sound_move:
    value: 0x13e04
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move
      return: bool
  is_recoil_move:
    value: 0x13ebc
    doc: |-
      Checks if the given move is a recoil move (affected by Reckless).

      r0: move ID
      return: bool
  all_manip1:
    value: 0x14288
    doc: "Note: unverified, ported from Irdkwia's notes"
  all_manip2:
    value: 0x142b0
    doc: "Note: unverified, ported from Irdkwia's notes"
  manip_moves1v1:
    value: 0x14344
    doc: "Note: unverified, ported from Irdkwia's notes"
  manip_moves1v2:
    value: 0x143e4
    doc: "Note: unverified, ported from Irdkwia's notes"
  manip_moves2v1:
    value: 0x1454c
    doc: "Note: unverified, ported from Irdkwia's notes"
  manip_moves2v2:
    value: 0x145ec
    doc: "Note: unverified, ported from Irdkwia's notes"
  dungeon_move_to_ground_move:
    value: 0x14754
    doc: |-
      Converts a struct move to a struct ground_move.

      r0: [output] ground_move
      r1: move
  ground_to_dungeon_moveset:
    value: 0x1478c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: [output] moveset_dun_str
      r1: moveset_str
  dungeon_to_ground_moveset:
    value: 0x14820
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: [output] moveset_str
      r1: moveset_dun_str
  get_info_ground_moveset:
    value: 0x14860
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      r1: moves_id
  find_first_free_moveset_idx:
    value: 0x14908
    doc: |-
      Returns the first position of an empty move in the moveset if it is found, -1 otherwise

      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      return: index
  learn_moves:
    value: 0x14954
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      r1: moves_id
  copy_move_to:
    value: 0x14af4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: write_info
      r1: buffer_write
  copy_move_from:
    value: 0x14b2c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
      r1: buffer_read
  copy_moveset_to:
    value: 0x14b64
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: write_info
      r1: buffer_write
  copy_moveset_from:
    value: 0x14b94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
      r1: buffer_read
  is2_turns_move:
    value: 0x14d0c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  is_regular_attack_or_projectile:
    value: 0x14d94
    doc: |-
      Checks if a move ID is MOVE_REGULAR_ATTACK or MOVE_PROJECTILE.

      r0: move ID
      return: bool
  is_punch_move:
    value: 0x14dc0
    doc: |-
      Checks if the given move is a punch move (affected by Iron Fist).

      r0: move ID
      return: bool
  is_healing_wish_or_lunar_dance:
    value: 0x14e00
    doc: |-
      Checks if a move ID is MOVE_HEALING_WISH or MOVE_LUNAR_DANCE.

      r0: move ID
      return: bool
  is_copying_move:
    value: 0x14e2c
    doc: |-
      Checks if a move ID is MOVE_MIMIC, MOVE_SKETCH, or MOVE_COPYCAT.

      r0: move ID
      return: bool
  is_trapping_move:
    value: 0x14e64
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  is_one_hit_ko_move:
    value: 0x14ea8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  is_not2_turns_move_or_sketch:
    value: 0x14ee0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  is_real_move:
    value: 0x14f0c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  is_moveset_valid:
    value: 0x14fa0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      return: bool
  is_real_move_in_time_darkness:
    value: 0x1500c
    doc: |-
      Seed Flare isn't a real move in Time/Darkness

      Note: unverified, ported from Irdkwia's notes

      r0: move ID
      return: bool
  is_moveset_valid_in_time_darkness:
    value: 0x150ac
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      return: bool
  get_first_not_real_move_in_time_darkness:
    value: 0x150cc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_str
      return: index
  is_same_move:
    value: 0x151f4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: moveset_dun_str
      r1: move_data_dun_str
      return: bool
  get_move_category:
    value: 0x15270
    doc: |-
      Gets a move's category (physical, special, status).

      r0: move ID
      return: move category enum
  get_pp_increase:
    value: 0x1528c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      r1: IQ skills bitvector
      return: PP increase
  open_waza:
    value: 0x1533c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: waza_id
  select_waza:
    value: 0x153a4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: waza_id
  play_bgm_by_id_veneer:
    value: 0x17bf4
    doc: |-
      Likely a linker-generated veneer for PlayBgmById.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: Music ID
  play_bgm_by_id_volume_veneer:
    value: 0x17c00
    doc: |-
      Likely a linker-generated veneer for PlayBgmByIdVolume.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: Music ID
      r1: (?) Stored on byte 8 on the struct passed to SendAudioCommand
      r2: Volume (0-255)
  play_se_volume_wrapper:
    value: 0x17d68
    doc: |-
      Wrapper for PlaySeVolume. Takes an index and uses it to determine the ID of the sound to play.

      r0: Index
  play_bgm_by_id:
    value: 0x17e90
    doc: |-
      Initializes some values and then calls SendAudioCommand to play a BGM track.

      Checks for DEBUG_FLAG_BGM_OFF. The volume is set to either 0 or 255 depending on the flag before calling SendAudioCommand.

      r0: Music ID
  play_bgm_by_id_volume:
    value: 0x17f0c
    doc: |-
      Initializes some values and then calls SendAudioCommand to play a BGM track.

      Checks for DEBUG_FLAG_BGM_OFF. If 1, sets the volume to 0 before calling SendAudioCommand.

      r0: Music ID
      r1: (?) Stored on byte 8 on the struct passed to SendAudioCommand
      r2: Volume (0-255)
  stop_bgm_command:
    value: 0x17f84
    doc: |-
      Stops the BGM that is being currently played by calling SendAudioCommand.

      No params.
  play_se_by_id_volume:
    value: 0x18354
    doc: |-
      Plays the specified sound effect with the specified volume.

      Checks for DEBUG_FLAG_SE_OFF and sets the volume to 0 if the flag is set. Calls SendAudioCommand2.

      r0: Sound effect ID
      r1: Volume (0-255)
  send_audio_command2:
    value: 0x18b80
    doc: |-
      Very similar to SendAudioCommand. Contains an additional function call.

      r0: Command to send
  alloc_audio_command:
    value: 0x18c08
    doc: |-
      Searches for an entry in AUDIO_COMMANDS_BUFFER that's not currently in use (audio_command::status == 0). Returns the first entry not in use, or null if none was found.

      Also sets the status of the found entry to the value specified in r0.

      The game doesn't bother checking if the result of the function is null, so the buffer is not supposed to ever get filled.

      r0: Status to set the found entry to
      return: The first unused entry, or null if none was found
  send_audio_command:
    value: 0x18c44
    doc: |-
      Used to send commands to the audio engine (seems to be used mainly to play and stop music)

      This function calls a stubbed-out one with the string "audio command list"

      r0: Command to send
  init_sound_system:
    value: 0x18cc4
    doc: |-
      Initialize the DSE sound engine?

      This function is called somewhere in the hierarchy under TaskProcBoot and appears to allocate a bunch of memory (including a dedicated memory arena, see SOUND_MEMORY_ARENA) for sound data, and reads a bunch of core sound files.

      File paths referenced:
      - SOUND/SYSTEM/se_sys.swd
      - SOUND/SYSTEM/se_sys.sed
      - SOUND/SE/motion.swd
      - SOUND/SE/motion.sed
      - SOUND/BGM/bgm.swd (this is the main sample bank, see https://projectpokemon.org/home/docs/mystery-dungeon-nds/pok%C3%A9mon-mystery-dungeon-explorers-r78/)

      Debug strings:
      - entry system se swd %04x\n
      - entry system se sed %04x\n
      - entry motion se swd %04x\n
      - entry motion se sed %04x\n
  manip_bgm_playback:
    value: 0x18f40
    doc: |-
      Uncertain. More like bgm1&2 end

      Note: unverified, ported from Irdkwia's notes
  sound_driver_reset:
    value: 0x19164
    doc: |-
      Uncertain.

      Note: unverified, ported from Irdkwia's notes
  load_dse_file:
    value: 0x19428
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: [output] iovec
      r1: filename
      return: bytes read
  play_se_load:
    value: 0x19610
    doc: "Note: unverified, ported from Irdkwia's notes"
  is_song_over:
    value: 0x198ec
    doc: |-
      True if the song that is currently being played has finished playing.

      return: True if the current song is over
  play_bgm:
    value: 0x19954
    doc: "Note: unverified, ported from Irdkwia's notes"
  stop_bgm:
    value: 0x19bc4
    doc: "Note: unverified, ported from Irdkwia's notes"
  change_bgm:
    value: 0x19cec
    doc: "Note: unverified, ported from Irdkwia's notes"
  play_bgm2:
    value: 0x19e20
    doc: "Note: unverified, ported from Irdkwia's notes"
  stop_bgm2:
    value: 0x1a084
    doc: "Note: unverified, ported from Irdkwia's notes"
  change_bgm2:
    value: 0x1a184
    doc: "Note: unverified, ported from Irdkwia's notes"
  play_me:
    value: 0x1a264
    doc: "Note: unverified, ported from Irdkwia's notes"
  stop_me:
    value: 0x1a4a8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: fade_out
  play_se:
    value: 0x1a598
    doc: "Note: unverified, ported from Irdkwia's notes"
  play_se_full_spec:
    value: 0x1a708
    doc: "Note: unverified, ported from Irdkwia's notes"
  se_change_volume:
    value: 0x1a8c4
    doc: "Note: unverified, ported from Irdkwia's notes"
  se_change_pan:
    value: 0x1a99c
    doc: "Note: unverified, ported from Irdkwia's notes"
  stop_se:
    value: 0x1aa80
    doc: "Note: unverified, ported from Irdkwia's notes"
  execute_copy_to_flat_vram_command:
    value: 0x1aba8
    doc: |-
      Immediately execute the command contained in a copy_to_obj_vram_order struct, copying content as described.

      r0: command
  decode_fragment_byte_assembly_table:
    value: 0x1ac48
    doc: |-
      Decode the sprite texture stored in each fragment byte assembly entry into the dst output, until the final one is reached.

      r0: pointer to array of fragment byte assembly entry, final (otherwise unused) one should have byte_amount = 0
      r1: dst
      return: number of decoded bytes
  copy_and_interleave_wrapper:
    value: 0x1c08c
    doc: |-
      Calls CopyAndInterleave with the passed len divided by 2.

      r0: dst
      r1: src
      r2: len (in bytes, will be divided by 2 in the call to CopyAndInterleave)
      r3: val
  init_animation_control:
    value: 0x1c0ec
    doc: |-
      Initialize the animation_control structure

      r0: animation_control
  set_sprite_id_for_animation_control:
    value: 0x1c184
    doc: |-
      Set the sprite id (from WAN_TABLE) in the given animation control
      Also set field 0x72 to the sprite id if they differ
      If they differ, it’ll also set field 0x43 to 0xFF

      r0: animation control
      r1: sprite id in WAN_TABLE
  set_animation_for_animation_control_internal:
    value: 0x1c218
    doc: |-
      Set the wan animation (and other related settings) of an animation_control
      Used by SetAnimationForAnimationControl

      r0: animation_control
      r1: wan_header
      r2: animation group id
      r3: animation id
      stack[0]: ?
      stack[1] (0x4): palette pos low (see the field on animation_control)
      stack[2] (0x8): ?
      stack[3] (0xC): ?
      stack[4] (0x10): palette_bank (directly set to the animation_control field with said name)
  set_animation_for_animation_control:
    value: 0x1c368
    doc: |-
      Set the animation to play with this animation control, but do not start it.

      (args same as SetAndPlayAnimationForAnimationControl)
      r0: animation_control
      r1: animation key (either an animation or animation group depending on the type of sprite and if it does have animation group with this animation key as index)
      r2: direction_id (unsure) (the key to the wan_animation in itself, only used when animation key represent a wan_animation_group)
      r3: ?
      stack[0]: low_palette_pos
      stack[1] (0x4): ?
      stack[2] (0x8): ?
      stack[3] (0xC): ?
  get_wan_for_animation_control:
    value: 0x1c484
    doc: |-
      Return the WAN to use for the given animation control
      Return the override if it exists, otherwise look up the sprite id in WAN_TABLE

      r0: animation_control
      return: wan_header
  set_and_play_animation_for_animation_control:
    value: 0x1c4b4
    doc: |-
      Set the animation to play with the animation control, and start it.

      r0: animation_control
      r1: animation key (either an animation or animation group depending on the type of sprite and if it does have animation group with this animation key as index)
      r2: direction_id (unsure) (the key to the wan_animation in itself, only used when animation key represent a wan_animation_group)
      r3: ?
      stack[0]: low_palette_pos
      stack[1] (0x4): ?
      stack[2] (0x8): ?
      stack[3] (0xC): ?
  switch_animation_control_to_next_frame:
    value: 0x1c4f4
    doc: |-
      Handle switching to the next frame of an animation control, including looping.

      r0: animation_control
  load_animation_frame_and_increment_in_animation_control:
    value: 0x1c5fc
    doc: |-
      Read some value of the input animation frame, and update animation control with it.
      Also switch next_animation_frame of animation_control to the next animation frame
      Seems to only be called on said next_animation_frame
      Also set bit of some_bitfield at 0x0800 to 1

      r0: animation_control
      r1: animation_frame
  animation_control_get_alloc_for_max_frame:
    value: 0x1d20c
    doc: |-
      Return the maximum allocation for a frame of this sprite, as stored in the WAN file
      Return 0 if missing and takes sprite override into account

      r0: animation_control
      return: allocation for max frame
  delete_wan_table_entry:
    value: 0x1d278
    doc: |-
      Always delete an entry if the file is allocated externally (file_externally_allocated is set), otherwise, decrease the reference counter. If it reach 0, delete the sprite.

      r0: wan_table_ptr
      r1: wan_id
  allocate_wan_table_entry:
    value: 0x1d2e0
    doc: |-
      Return the identifier to a free wan table entry (-1 if none are avalaible). The entry is zeroed.

      r0: wan_table_ptr
      return: the entry id in wan_table
  find_wan_table_entry:
    value: 0x1d370
    doc: |-
      Search in the given table (in practice always seems to be WAN_TABLE) for an entry with the given file name.

      r0: table pointer
      r1: file name
      return: index of the found file, if found, or -1 if not found
  get_loaded_wan_table_entry:
    value: 0x1d3d0
    doc: |-
      Look up a sprite with the provided pack_id and file_index in the wan table.

      r0: wan_table_ptr
      r1: pack_id
      r2: file_index
      return: sprite id in the wan table, -1 if not found
  init_wan_table:
    value: 0x1d458
    doc: |-
      Initialize the input WAN table with 0x60 free entries (it needs a length of 0x1510 bytes)

      r0: wan_table_ptr
  load_wan_table_entry:
    value: 0x1d478
    doc: |-
      Appears to load data from the given file (in practice always seems to be animation data), using previously loaded data in the given table (see FindWanTableEntry) if possible.

      r0: table pointer
      r1: file name
      r2: flags
      return: table index of the loaded data
  load_wan_table_entry_from_pack:
    value: 0x1d520
    doc: |-
      Return an already allocated entry for this sprite if it exists, otherwise allocate a new one and load the optionally compressed sprite.

      r0: wan_table_ptr
      r1: pack_id
      r2: file_index
      r3: allocation flags
      stack[0]: compressed
      return: the entry id in wan_table
  load_wan_table_entry_from_pack_use_provided_memory:
    value: 0x1d62c
    doc: |-
      Return an already allocated entry for this sprite if it exists, otherwise allocate a new one and load the optionally compressed sprite into the provided memory area. Mark the sprite as externally allocated.

      r0: wan_table_ptr
      r1: pack_id
      r2: file_index
      r3: sprite_storage_ptr
      stack[0]: compressed
      return: the entry id in wan_table
  replace_wan_from_bin_file:
    value: 0x1d720
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: wan_table_ptr
      r1: wan_id
      r2: bin_file_id
      r3: file_id
      stack[0]: compressed
  delete_wan_table_entry_veneer:
    value: 0x1d7c8
    doc: |-
      Likely a linker-generated veneer for DeleteWanTableEntry.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: wan_table_ptr
      r1: wan_id
  wan_has_animation_group:
    value: 0x1dae0
    doc: |-
      Check if the input WAN file loaded in memory has an animation group with this ID
      Valid means that the animation group is in the range of existing animation, and that it has at least one animation.

      r0: pointer to the header of the WAN
      r1: id of the animation group
      return: whether the WAN file has the given animation group
  wan_table_sprite_has_animation_group:
    value: 0x1db1c
    doc: |-
      Check if the sprite in the global WAN table has the given animation group
      see WanHasAnimationGroup for more detail

      r0: sprite id in the WAN table
      r1: animation group id
      return: whether the associated sprite has the given animation group
  sprite_type_in_wan_table:
    value: 0x1dd0c
    doc: |-
      Look up the sprite in the WAN table, and return its type

      r0: sprite id in the WAN table
      return: sprite type
  load_wte_from_rom:
    value: 0x1dee8
    doc: |-
      Loads a SIR0-wrapped WTE file from ROM, and returns a handle to it

      r0: [output] pointer to wte handle
      r1: file path string
      r2: load file flags
  load_wte_from_file_directory:
    value: 0x1df60
    doc: |-
      Loads a SIR0-wrapped WTE file from a file directory, and returns a handle to it

      r0: [output] pointer to wte handle
      r1: file directory id
      r2: file index
      r3: malloc flags
  unload_wte:
    value: 0x1dfb4
    doc: |-
      Frees the buffer used to store the WTE data in the handle, and sets both pointers to null

      r0: pointer to wte handle
  load_wtu_from_bin:
    value: 0x1e050
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: bin_file_id
      r1: file_id
      r2: load_type
      return: ?
  process_wte:
    value: 0x1e14c
    doc: |-
      Prepare and plan a WTE data to be loaded into VRAM.
      It skips the texture and/or the palette if missing from the file. The texture VRAM has 128KiB of space, and palette has 16KiB.
      The true palette VRAM offset will be upper_part*0x100+lower_part.
      Will ensure it gets copied next time PerformPlannedTextureVramTransfer is called by the game.
      Will not automatically free the data once done. That can be done with DelayWteFree, which seems systematically called in the game’s code.

      r0: pointer to the WTE file header loaded in memory
      r1: where the WTE texture will be loaded in the VRAM (from 0 to 0x1FFFF)
      r2: upper part of the palette VRAM
      r3: lower part of the palette VRAM
  delay_wte_free:
    value: 0x1e1d8
    doc: |-
      Add a command to free the input WTE handle once all previously registered commands that would edit the texture VRAM have been executed.
      Also nullify the structure’s two pointers.
      The error caused by the lack of place to store the command is ignored.

      r0: wte handle to eventually free
  reset_planned_vram_transfer:
    value: 0x1e270
    doc: |-
      Reset the command array of input container
      Does not reset its other field

      r0: the container to reset
  plan_copy_texture_to_texture_vram:
    value: 0x1e27c
    doc: |-
      Add a command in the container (r1) that will be executed later by PerformPlannedTextureVramTransfer to copy part of the RAM into the texture VRAM (or free the source allocated memory depending of the specified type of command).
      Check for overflow. If an overflow would occur, do not add the command to the container, and return -1 instead.

      r0: Container that contain the command list to add to
      r1: pointer to the bytes to be copied in CPU-accessible RAM
      r2: offset to copy too in texture VRAM
      r3: number of bytes to copy
      stack[0]: type of command to perform
  perform_planned_texture_vram_transfer:
    value: 0x1e2cc
    doc: |-
      Execute the texture VRAM edition command of the input container. Does not reset it, or alter its state in any way.

      r0: container that contains the command list to execute
  geom_set_tex_image_param:
    value: 0x1e530
    doc: |-
      Send the TEXIMAGE_PARAM geometry engine command, that defines some parameters for the texture
      See http://problemkaputt.de/gbatek.htm#ds3dtextureattributes for more information on the parameters

      r0: texture format
      r1: texture coordinates transformation modes
      r2: texture S-Size
      r3: texture T-Size
      stack[0] (0x0): repeat in S (bit 0) and/or T (bit 1) direction
      stack[1] (0x4): flip in S (bit 0) and/or T (bit 1) direction
      stack[2] (0x8): What to make of color 0 (bit 29)
      stack[3] (0xC): Texture VRAM offset divided by 8
  geom_set_vertex_coord16:
    value: 0x1e570
    doc: |-
      Send the "VTX_16" geometry engine command, that defines the coordinate of a point of a polygon, using 16 bits.
      Inputs are clamped over their 16 lower bits

      r0: x coordinate
      r1: y coordinate
      r2: z coordinate
  init_render3d_data:
    value: 0x1e5a0
    doc: |-
      Initialize the global "RENDER_3D" structure.

      No params.
  geom_swap_buffers:
    value: 0x1e7b8
    doc: |-
      Call the "SWAP_BUFFERS" command. This will swap the geometry buffer. The parameter of 1 is provided, which enables manual Y-sorting of translucent polygons.

      No params.
  init_render3d_element64:
    value: 0x1e7cc
    doc: |-
      Initialize the render_3d_element_64 structure (without performing any drawing or external data access)

      r0: render_3d_element_64
  render3d64_texture0x7:
    value: 0x1e8e0
    doc: |-
      RENDER_3D_FUNCTIONS_64[7]. Renders a render_3d_element_64 with type RENDER64_TEXTURE_0x7.

      Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TEXTURE.

      r0: render_3d_element_64
  render3d64_window_frame:
    value: 0x1ea88
    doc: |-
      Draw the frame for a window, using the 3D engine.

      The render_3d_element_64 contains certain value that needs to be set to a correct value for it to work.
      The element is not immediately sent to the geometry engine, but is converted to a render_3d_element and queued up in RENDER_3D.

      RENDER_3D_FUNCTIONS_64[6], corresponding to a type of RENDER64_WINDOW_FRAME.

      r0: render_3d_element_64
  enqueue_render3d64_tiling:
    value: 0x1ed38
    doc: |-
      Converts a render_3d_element_64 with type RENDER64_TILING to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TILING.

      r0: render_3d_element_64
  render3d64_tiling:
    value: 0x1ee24
    doc: |-
      RENDER_3D_FUNCTIONS_64[5]. Renders a render_3d_element_64 with type RENDER64_TILING.

      Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TILING.

      r0: render_3d_element_64
  render3d64_quadrilateral:
    value: 0x1eeec
    doc: |-
      RENDER_3D_FUNCTIONS_64[4]. Renders a render_3d_element_64 with type RENDER64_QUADRILATERAL.

      Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_QUADRILATERAL.

      r0: render_3d_element_64
  render3d64_rectangle_multicolor:
    value: 0x1ef8c
    doc: |-
      RENDER_3D_FUNCTIONS_64[3]. Renders a render_3d_element_64 with type RENDER64_RECTANGLE_MULTICOLOR.

      Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_RECTANGLE.

      r0: render_3d_element_64
  render3d64_rectangle:
    value: 0x1f0f8
    doc: |-
      RENDER_3D_FUNCTIONS_64[2]. Renders a render_3d_element_64 with type RENDER64_RECTANGLE.

      Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_RECTANGLE.

      r0: render_3d_element_64
  render3d64_nothing:
    value: 0x1f1a4
    doc: |-
      RENDER_3D_FUNCTIONS_64[1]. Renders a render_3d_element_64 with type RENDER64_NOTHING. This function is entirely empty.

      r0: render_3d_element_64
  render3d64_texture:
    value: 0x1f1a8
    doc: |-
      RENDER_3D_FUNCTIONS_64[0]. Renders a render_3d_element_64 with type RENDER64_TEXTURE.

      Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TEXTURE.

      r0: render_3d_element_64
  render3d_element64:
    value: 0x1f270
    doc: |-
      Dispatches a render_3d_element_64 to the render function corresponding to its type.

      r0: render_3d_element_64
  handle_sir0_translation:
    value: 0x1f550
    doc: |-
      Translates the offsets in a SIR0 file into NDS memory addresses, changes the magic number to SirO (opened), and returns a pointer to the first pointer specified in the SIR0 header (beginning of the data).

      Irkdiwa's notes:
        ret_code = 0 if it wasn't a SIR0 file
        ret_code = 1 if it has been transformed in SIRO file
        ret_code = 2 if it was already a SIRO file
        [output] contains a pointer to the header of the SIRO file if ret_code = 1 or 2
        [output] contains a pointer which is exactly the same as the sir0_ptr if ret_code = 0

      r0: [output] double pointer to beginning of data
      r1: pointer to source file buffer
      return: return code
  convert_pointers_sir0:
    value: 0x1f5d0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: sir0_ptr
  handle_sir0_translation_veneer:
    value: 0x1f628
    doc: |-
      Likely a linker-generated veneer for HandleSir0Translation.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: [output] double pointer to beginning of data
      r1: pointer to source file buffer
      return: return code
  decompress_at_normal_veneer:
    value: 0x1f65c
    doc: |-
      Likely a linker-generated veneer for DecompressAtNormal.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: addr_decomp
      r1: expected_size
      r2: AT pointer
      return: ?
  decompress_at_normal:
    value: 0x1f668
    doc: |-
      Overwrites r3 probably passed to match DecompressAtHalf's definition.

      Note: unverified, ported from Irdkwia's notes

      r0: addr_decomp
      r1: expected_size
      r2: AT pointer
      return: ?
  decompress_at_half:
    value: 0x1faac
    doc: |-
      Same as DecompressAtNormal, except it stores each nibble as a byte
      and adds the high nibble (r3).

      Note: unverified, ported from Irdkwia's notes

      r0: addr_decomp
      r1: expected_size
      r2: AT pointer
      r3: high_nibble
      return: ?
  decompress_at_from_memory_pointer_veneer:
    value: 0x1ffe8
    doc: |-
      Likely a linker-generated veneer for DecompressAtFromMemoryPointer.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: addr_decomp
      r1: expected_size
      r2: AT pointer
      return: ?
  decompress_at_from_memory_pointer:
    value: 0x1fff4
    doc: |-
      Overwrites r3 probably passed to match DecompressAtHalf's definition.

      Note: unverified, ported from Irdkwia's notes

      r0: addr_decomp
      r1: expected_size
      r2: AT pointer
      return: ?
  write_byte_from_memory_pointer:
    value: 0x2050c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: byte
  get_at_size:
    value: 0x20588
    doc: |-
      Doesn't work for AT3PX and AT4PN

      Note: unverified, ported from Irdkwia's notes

      r0: AT pointer
      r1: ?
      return: ?
  get_language_type:
    value: 0x20688
    doc: |-
      Gets the language type.

      This is the value backing the special LANGUAGE_TYPE script variable.

      return: language type
  get_language:
    value: 0x206b0
    doc: |-
      Gets the single-byte language ID of the current program.

      The language ID appears to be used to index some global tables.

      return: language ID
  strcmp_tag:
    value: 0x20a20
    doc: |-
      Checks if a null-terminated string s1 either exactly equals a null-terminated string s2, or starts with s2 followed by a ':' or a ']'.

      r0: s1
      r1: s2
      return: bool
  atoi_tag:
    value: 0x20a64
    doc: |-
      Parses a null-terminated string to a base-10 integer, reading digit characters between '0' and '9' until ':', ']', or the end of the string is encountered.

      Any characters that are not digits, ':', or ']' are ignored, and the string is converted as if those characters were removed from the string.

      r0: string to convert
      return: int
  analyze_text:
    value: 0x20f20
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: buffer
      return: ?
  preprocess_string:
    value: 0x225ec
    doc: |-
      An enhanced sprintf, which recognizes certain tags and replaces them with appropiate game values.
      This function can also be used to simply insert values passed within the preprocessor args

      The tags utilized for this function are lowercase, it might produce uppercase tags
      that only are used when the text is being typewrited into a message box

      Irdkwia's notes: MenuCreateOptionString

      r0: [output] formatted string
      r1: maximum capacity of the output buffer
      r2: input format string
      r3: preprocessor flags
      stack[0]: pointer to preprocessor args
  preprocess_string_from_id:
    value: 0x237b4
    doc: |-
      Calls PreprocessString after resolving the given string ID to a string.

      r0: [output] formatted string
      r1: maximum capacity of the output buffer
      r2: string ID
      r3: preprocessor flags
      stack[0]: pointer to preprocessor args
  strcmp_tag_veneer:
    value: 0x237f4
    doc: |-
      Likely a linker-generated veneer for StrcmpTag.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: s1
      r1: s2
      return: bool
  atoi_tag_veneer:
    value: 0x23800
    doc: |-
      Likely a linker-generated veneer for AtoiTag.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: s
      return: int
  init_preprocessor_args:
    value: 0x238b4
    doc: |-
      Initializes a struct preprocess_args.

      r0: preprocessor args pointer
  set_string_accuracy:
    value: 0x245c0
    doc: "Note: unverified, ported from Irdkwia's notes"
  set_string_power:
    value: 0x24688
    doc: "Note: unverified, ported from Irdkwia's notes"
  get_rank_string:
    value: 0x24d88
    doc: |-
      Gets the string corresponding to the player's current explorer rank.

      r0: [output] Pointer to the buffer where the string will be written (if flags are 0)
      r1: First 16 bits contain the rank, next 4 are some sort of bitflags
      return: r0 if flags are 0, pointer to some static address otherwise
  get_current_team_name_string:
    value: 0x24f00
    doc: |-
      Returns the current team name with a check for special episodes and story progression. If the story
      has not progressed enough or the special episode is not for Team Charm, "???" will be displayed.
      During the Team Charm special episode, it will return "Team Charm".

      r0: [output] Pointer to the buffer where the string will be written
      r1: 0, 1 or 2???
      return: Pointer to the buffer where the string was written (in other words, the same value passed in r0)
  get_bag_name_string:
    value: 0x250c8
    doc: |-
      Returns "One-Item Inventory" or "Treasure Bag" depending on the size of the bag.

      r0: [output] Pointer to the buffer where the string will be written
      return: Pointer to the buffer where the string was written (in other words, the same value passed in r0)
  get_dungeon_result_string:
    value: 0x252a4
    doc: |-
      Returns a string containing some information to be used when displaying the dungeon results screen.

      The exact string returned depends on the value of r0:
      0: Name of the move that fainted the leader. Empty string if the leader didn't faint.
      1-3: Seems to always result in an empty string.
      4: Name of the pokémon that fainted the leader, or name of the leader if the leader didn't faint.
      5: Name of the fainted leader. Empty string if the leader didn't faint.

      r0: String to return
      return: Pointer to resulting string
  set_question_marks:
    value: 0x253b0
    doc: |-
      Fills the buffer with the string '???'

      Note: unverified, ported from Irdkwia's notes

      r0: buffer
  strcpy_simple:
    value: 0x253cc
    doc: |-
      A simple implementation of the strcpy(3) C library function.

      This function was probably manually implemented by the developers. See strcpy for what's probably the real libc function.

      r0: dest
      r1: src
  strncpy_simple:
    value: 0x253e8
    doc: |-
      A simple implementation of the strncpy(3) C library function.

      This function was probably manually implemented by the developers. See strncpy for what's probably the real libc function.

      r0: dest
      r1: src
      r2: n
  strncpy_simple_no_pad:
    value: 0x2543c
    doc: |-
      Similar to StrncpySimple, but does not zero-pad the end of dest beyond the null-terminator.

      r0: dest
      r1: src
      r2: n
  strncmp_simple:
    value: 0x25478
    doc: |-
      A simple implementation of the strncmp(3) C library function.

      This function was probably manually implemented by the developers. See strncmp for what's probably the real libc function.

      r0: s1
      r1: s2
      r2: n
      return: comparison value
  strncpy_simple_no_pad_safe:
    value: 0x254c0
    doc: |-
      Like StrncpySimpleNoPad, except there's a useless check on that each character is less than 0x100 (which is impossible for the result of a ldrb instruction).

      r0: dest
      r1: src
      r2: n
  strcpy_name:
    value: 0x254fc
    doc: |-
      A special version of strcpy for handling names. Appears to use character 0x7E as some kind of
      formatting character in NA?

      r0: dst
      r1: src
  strncpy_name:
    value: 0x255e0
    doc: |-
      A special version of strncpy for handling names. Appears to use character 0x7E as some kind of
      formatting character in NA? Copies at most n characters.

      r0: dst
      r1: src
      r2: n
  get_string_from_file:
    value: 0x25a54
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: Buffer
      r1: String ID
  load_string_file:
    value: 0x25ae4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  allocate_temp1024_byte_buffer_from_pool:
    value: 0x25b54
    doc: 'return: Pointer to byte buffer'
  get_string_from_file_veneer:
    value: 0x25b84
    doc: |-
      Likely a linker-generated veneer for GetStringFromFile.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: Buffer
      r1: String ID
  string_from_id:
    value: 0x25b90
    doc: |-
      Gets the string corresponding to a given string ID.

      r0: string ID
      return: string from the string files with the given string ID
  copy_string_from_id:
    value: 0x25bb0
    doc: |-
      Gets the string corresponding to a given string ID and copies it to the buffer specified in r0.

      r0: buffer
      r1: string ID
  copy_n_string_from_id:
    value: 0x25bd8
    doc: |-
      Gets the string corresponding to a given string ID and copies it to the buffer specified in r0.

      This function won't write more than <buffer length> bytes.

      r0: buffer
      r1: string ID
      r2: buffer length
  load_tbl_talk:
    value: 0x25c08
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  get_talk_line:
    value: 0x25c58
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: personality_index
      r1: group_id
      r2: restrictions
      return: ?
  is_a_or_b_pressed:
    value: 0x261cc
    doc: |-
      Checks if A or B is currently being held.

      return: bool
  draw_text_in_window:
    value: 0x264f8
    doc: |-
      Seems to be responsible for drawing the text in a window.

      Needs a call to UpdateWindow after to actually display the contents.
      Unclear if this is generic for windows or just text boxes.

      r0: window_id
      r1: x offset within window
      r2: y offset within window
      r3: text to draw
  get_char_width:
    value: 0x26830
    doc: |-
      Gets the width of a text char.

      r0: char
      return: char width
  get_color_code_palette_offset:
    value: 0x268a8
    doc: |-
      Gets the offset of a text color symbol's 2-byte RGB5 color in the palette stored in VRAM at 0x6882000.

      The offset minus 0x10 will also be the corresponding 4-byte RGBX color's position in FONT/text_pal.pal.

      r0: char
      return: offset
  draw_char:
    value: 0x26a50
    doc: |-
      Draws a single char within a window. This function is also responsible for drawing the shadows of a char.

      r0: window_id
      r1: x offset within window
      r2: y offset within window
      r3: char
      stack[0]: color offset
      return: char width
  get_window:
    value: 0x278ec
    doc: |-
      Get the window with a given ID from WINDOW_LIST.

      r0: window_id
      return: window
  new_window_screen_check:
    value: 0x2793c
    doc: |-
      Calls NewWindow, with a pre-check for any valid existing windows in WINDOW_LIST on each screen.

      r0: window_params (see NewWindow)
      r1: ?
      return: window_id
  new_window:
    value: 0x279b4
    doc: |-
      Seems to return the ID of a newly initialized window in the next available slot in WINDOW_LIST, given some starting information.

      If WINDOW_LIST is full, it will be overflowed, with the slot with an ID of 20 being initialized and returned.

      r0: window_params pointer to be copied by value into window::hdr in the new window
      r1: ?
      return: window_id
  set_screen_windows_color:
    value: 0x27d5c
    doc: |-
      Sets the palette of the frames of windows in the specified screen

      r0: palette index
      r1: is upper screen
  set_both_screens_windows_color:
    value: 0x27d74
    doc: |-
      Sets the palette of the frames of windows in both screens

      r0: palette index
  update_window:
    value: 0x27de4
    doc: |-
      Seems to cause updated window contents to be displayed.
         
      Gets called for example at the end of a text box window update and seems to "commit" the update, but in general also gets called with all kinds of window updates. 

      r0: window_id
  clear_window:
    value: 0x27e4c
    doc: |-
      Clears the window, at least in the case of a text box.

      The low number of XREFs makes it seem like there might be more such functions.

      r0: window_id
  delete_window:
    value: 0x28488
    doc: |-
      Seems to uninitialize an active window in WINDOW_LIST with a given ID, freeing the slot for reuse by another window.

      r0: window_id
  get_window_rectangle:
    value: 0x28578
    doc: |-
      Get the rectangle defined by a window.

      r0: window_id
      r1: [output] rectangle
  get_window_contents:
    value: 0x28630
    doc: |-
      Gets the contents structure from the window with the given ID.

      r0: window_id
      return: contents
  load_cursors:
    value: 0x29800
    doc: |-
      Load and initialize the cursor and cursor16 sprites, storing the result in CURSOR_ANIMATION_CONTROL and CURSOR_16_ANIMATION_CONTROL

      No params.
  init_window_trailer:
    value: 0x29964
    doc: |-
      Seems to initialize a window_trailer within a new window.

      r0: window_trailer pointer
  arm9_load_unk_field_na0x2029_ec8:
    value: 0x2a1bc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
  arm9_store_unk_field_na0x2029_ed8:
    value: 0x2a1cc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: value
  load_alert:
    value: 0x2a1dc
    doc: |-
      Load and initialize the alert sprite, storing the result in ALERT_ANIMATION_CONTROL

      No params.
  print_clear_mark:
    value: 0x2a6d8
    doc: |-
      Prints the specified clear mark on the screen.

      Clear marks are shown on the save file load screen. They are used to show which plot milestones have already been completed.

      r0: Clear mark ID
      r1: X pos (unknown units, usually ranges between 3 and 27)
      r2: Y pos (unknown units, normally 14)
      r3: ?
  print_badge_mark:
    value: 0x2a728
    doc: |-
      Prints the specified badge mark on the screen.

      The badge mark is shown when opening the menu in the overworld.

      r0: Badge ID
      r1: X pos (unknown units, always 3)
      r2: Y pos (unknown units, always 18)
      r3: ? (always 3)
  print_mark:
    value: 0x2a750
    doc: |-
      Prints a mark from one of the .w16 files in FONT.

      r0: 0 if file is clrmark1.w16, 1 if file is clrmark2.w16, 2 if file is rankmark.w16.
      r1: Mark ID in file
      r2: X pos (unknown units)
      r3: Y pos (unknown units)
      stack[0]: ?
  create_parent_menu_from_string_ids:
    value: 0x2a8c0
    doc: |-
      A wrapper around CreateParentMenuInternal, where the menu items can be defined by string ID instead of as strings.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: simple_menu_id_item struct array, terminated with an item with string_id 0
      return: window_id
  is_empty_string:
    value: 0x2a960
    doc: |-
      Checks if a null-terminated string is empty. A NULL pointer counts as empty.

      r0: string
      return: whether the string is NULL or empty
  create_parent_menu:
    value: 0x2a984
    doc: |-
      A wrapper around CreateParentMenuInternal where ownership of the items array parameter won't be transferred to the menu.

      The menu item array will be copied onto a new array on the heap. This means the argument doesn't need to remain valid after the function returns (e.g., it can be stack-allocated).

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: simple_menu_ptr_item struct array, terminated with an item with an NULL string pointer
      return: window_id
  create_parent_menu_wrapper:
    value: 0x2aa24
    doc: |-
      A wrapper around CreateParentMenu that sets field_0x1b0 to 1 if the returned window_id is not -2.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: simple_menu_ptr_item struct array, terminated with an item with an NULL string pointer
      return: window_id
  create_parent_menu_internal:
    value: 0x2aa50
    doc: |-
      Creates a window containing a simple textual menu with a list of options that might open submenus when selected. Also see struct simple_menu.

      Multiple levels of nesting is possible, i.e., a submenu could itself be a parent menu.

      This is used in various menus that lead to submenus. For example, the top-level ground and dungeon mode menus.

      If window_params is NULL, PARENT_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: heap-allocated simple_menu_items array, the menu takes ownership
      return: window_id
  resume_parent_menu:
    value: 0x2ac48
    doc: |-
      Resumes input for a window created with CreateParentMenuInternal. Used for menus that do not close even after selecting an option.

      r0: window_id
  set_parent_menu_state7:
    value: 0x2ad9c
    doc: |-
      Sets the state of a parent menu to 7.

      r0: window_id
  close_parent_menu:
    value: 0x2adb0
    doc: |-
      Closes a window created with CreateParentMenu or CreateParentMenuFromStringIds.

      r0: window_id
  is_parent_menu_active:
    value: 0x2ae34
    doc: |-
      This is a guess.

      Checks if the state of a parent menu is something other than 8 or 9.

      r0: window_id
      return: bool
  check_parent_menu_field0x1_a0:
    value: 0x2ae54
    doc: |-
      Checks if a parent menu's field_0x1a0 is 0.

      r0: window_id
      return: bool
  update_parent_menu:
    value: 0x2aef0
    doc: |-
      Window update function for parent menus.

      r0: window pointer
  create_simple_menu_from_string_ids:
    value: 0x2b3e0
    doc: |-
      A wrapper around CreateSimpleMenuInternal, where the menu items can be defined by string ID instead of as strings.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: simple_menu_id_item struct array, terminated with an item with string_id 0
      stack[0]: number of items
      return: window_id
  create_simple_menu:
    value: 0x2b4a0
    doc: |-
      A wrapper around CreateSimpleMenuInternal where ownership of the simple_menu_items array parameter won't be transferred to the menu.

      The menu item array will be copied onto a new array on the heap. This means the argument doesn't need to remain valid after the function returns (e.g., it can be stack-allocated).

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: simple_menu_items array
      stack[0]: number of items
      return: window_id
  create_simple_menu_internal:
    value: 0x2b578
    doc: |-
      Creates a window containing a simple textual menu with a list of options. Also see struct simple_menu.

      This is used in lots of places. For example, some simple Yes/No prompts.

      If window_params is NULL, SIMPLE_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: heap-allocated simple_menu_items array, the menu takes ownership
      stack[0]: number of items
      return: window_id
  resume_simple_menu:
    value: 0x2b784
    doc: |-
      Resumes input for a window created with CreateSimpleMenuInternal. Used for menus that do not close even after selecting an option.

      r0: window_id
  close_simple_menu:
    value: 0x2b7b8
    doc: |-
      Closes a window created with CreateSimpleMenu or CreateSimpleMenuFromStringIds.

      r0: window_id
  is_simple_menu_active:
    value: 0x2b7e4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      Checks if the menu state is anything other than 7 or 8.

      r0: window_id
      return: bool
  check_simple_menu_field0x1_a0:
    value: 0x2b804
    doc: |-
      Checks if simple_menu::field_0x1a0 is 0.

      r0: window_id
      return: bool
  get_simple_menu_field0x1_a4:
    value: 0x2b84c
    doc: |-
      Gets the value of simple_menu::field_0x1a4.

      r0: window_id
      return: field_0x1a4
  get_simple_menu_result:
    value: 0x2b870
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: window_id
      return: ?
  update_simple_menu:
    value: 0x2b8bc
    doc: |-
      Window update function for simple menus.

      r0: window pointer
  set_simple_menu_field0x1_ac:
    value: 0x2bd00
    doc: |-
      Sets simple_menu::field_0x1ac to the given value.

      r0: window_id
      r1: value
  create_advanced_menu:
    value: 0x2bd14
    doc: |-
      Creates a window containing a textual menu with complex layout and functionality (e.g., paging through multiple pages). Also see struct advanced_menu.

      This is used for menus like the IQ skills menu, and the dungeon selection menu from the overworld crossroads. Curiously, it's also used in some non-interactive contexts like the Adventure Log.

      If window_params is NULL, ADVANCED_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      The entry function is used to get the strings for all currently available options, so when the page is flipped the entry function is used to get the strings for the entries on the other page?

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: entry_function
      stack[0]: total number of options
      stack[1]: number of options per page
      return: window_id
  resume_advanced_menu:
    value: 0x2bee4
    doc: |-
      Resumes input for a window created with CreateAdvancedMenu. Used for menus that do not close even after selecting an option.

      r0: window_id
  close_advanced_menu:
    value: 0x2bf38
    doc: |-
      Closes a window created with CreateAdvancedMenu.

      r0: window_id
  is_advanced_menu_active2:
    value: 0x2bfb0
    doc: |-
      This is a guess, by analogy to IsSimpleMenuActive, which does the same thing. Most of window types also have an analogous function that checks the state value. It's unclear how this relates to the other IsAdvancedMenuActive, or if this guess is completely wrong.

      Checks if the state of an advanced menu is something other than 7 or 8.

      r0: window_id
      return: bool
  is_advanced_menu_active:
    value: 0x2bfd0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      Checks if advanced_menu::field_0x1a0 is 0.

      This seems to resemble the Check*Field* functions of some of the other menu types. It's unclear whether these are the real "IsActive" functions, or whether the ones that check the state value are. It may be noteworthy that all menu types seem to have a variant of the "state checking" function, but only some menu types seem to have a variant of the "check field" function.

      r0: window_id
      return: bool
  get_advanced_menu_current_option:
    value: 0x2bff0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: window_id
      return: ?
  get_advanced_menu_result:
    value: 0x2c004
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: window_id
      return: ?
  update_advanced_menu:
    value: 0x2c058
    doc: |-
      Window update function for advanced menus.

      r0: window pointer
  create_collection_menu:
    value: 0x2c69c
    doc: |-
      Creates a window containing a menu for manipulating a collection of objects, with complex layout and functionality (e.g., paging). Also see struct collection_menu.

      Collection menus seem similar to advanced menus, but are used for certain menus involving item management (Kangaskhan Storage, Kecleon shop, Croagunk Swap Shop), missions (job selection, bulletin board), and possibly other things.

      If window_params is NULL, COLLECTION_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: some function pointer?
      stack[0]: ?
      stack[1]: total number of options
      stack[2]: number of options per page
      return: window_id
  set_collection_menu_field0x1_bc:
    value: 0x2c8d4
    doc: |-
      Sets collection_menu::field_0x1bc to the given value.

      r0: window_id
      r1: value
  set_collection_menu_width:
    value: 0x2c8e8
    doc: |-
      Sets collection_menu::width to a new value, clamped to be no greater than (window_params::width * 8 - 1) for the window.

      r0: window_id
      r1: width
  close_collection_menu:
    value: 0x2ca00
    doc: |-
      Closes a window created with CreateCollectionMenu.

      r0: window_id
  is_collection_menu_active:
    value: 0x2ca1c
    doc: |-
      This is a guess.

      Checks if the state of a collection menu is something other than 6 or 7.

      r0: window_id
      return: bool
  set_collection_menu_field0x1_c8:
    value: 0x2ca88
    doc: |-
      Sets collection_menu::field_0x1c8 to the given value.

      r0: window_id
      r1: value
  set_collection_menu_field0x1_a0:
    value: 0x2ca9c
    doc: |-
      Sets collection_menu::field_0x1a0 to the given value.

      r0: window_id
      r1: value
  set_collection_menu_field0x1_a4:
    value: 0x2cab0
    doc: |-
      Sets collection_menu::field_0x1a4 to the given value.

      r0: window_id
      r1: value
  set_collection_menu_void_fn:
    value: 0x2cac4
    doc: |-
      Sets collection_menu::field_0x1a8 to the given function pointer.

      r0: window_id
      r1: some function pointer?
  update_collection_menu:
    value: 0x2cafc
    doc: |-
      Window update function for collection menus.

      r0: window pointer
  set_collection_menu_field0x1_b2:
    value: 0x2d3cc
    doc: |-
      Sets collection_menu::field_0x1b2 to the given value.

      r0: window_id
      r1: value
  is_collection_menu_state3:
    value: 0x2d408
    doc: |-
      Checks if a collection menu has a state value of 3.

      r0: window_id
      return: bool
  create_options_menu:
    value: 0x2d4e4
    doc: |-
      Creates a window containing a menu controlling game options. Also see struct options_menu.

      This is used for the options and window options menus, among other things.

      If window_params is NULL, OPTIONS_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: options_menu_id_item struct array, terminated with an item with msg_id 0
      stack[0]: number of items
      stack[1]: option_states pointer
      return: window_id
  close_options_menu:
    value: 0x2d824
    doc: |-
      Closes a window created with CreateOptionsMenu.

      r0: window_id
  is_options_menu_active:
    value: 0x2d850
    doc: |-
      This is a guess.

      Checks if the state of an options menu is something other than 6 or 7.

      r0: window_id
      return: bool
  check_options_menu_field0x1_a4:
    value: 0x2d870
    doc: |-
      Checks if options_menu::field_0x1a4 is 0.

      r0: window_id
      return: bool
  get_options_menu_states:
    value: 0x2d8a4
    doc: |-
      Gets all the option menu states; used to determine what options the user has selected in a menu. Each option state corresponds a options_menu_id_item.

      r0: window_id
      r1: option_states pointer
  get_options_menu_result:
    value: 0x2d8d8
    doc: |-
      Returns whether or not the options menu was confirmed or canceled (e.g., by pressing the B button).

      r0: window_id
      return: bool
  update_options_menu:
    value: 0x2d90c
    doc: |-
      Window update function for options menus.

      r0: window pointer
  create_debug_menu:
    value: 0x2df44
    doc: |-
      Creates a window containing the debug menu (probably). Also see struct debug_menu.

      This is an educated guess, since this function references string IDs of debug menu strings.

      See enum debug_flag and enum debug_log_flag.

      If window_params is NULL, DEBUG_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: array of menu item string IDs
      stack[0]: number of menu items
      stack[1]: ?
      return: window_id
  close_debug_menu:
    value: 0x2e1ec
    doc: |-
      Closes a window created with CreateDebugMenu.

      r0: window_id
  is_debug_menu_active:
    value: 0x2e218
    doc: |-
      This is a guess.

      Checks if the state of a debug menu is something other than 6 or 7.

      r0: window_id
      return: bool
  check_debug_menu_field0x1_a4:
    value: 0x2e238
    doc: |-
      Checks if debug_menu::field_0x1a4 is 0.

      r0: window_id
      return: bool
  update_debug_menu:
    value: 0x2e28c
    doc: |-
      Window update function for debug menus.

      r0: window pointer
  create_scroll_box_single:
    value: 0x2e6c0
    doc: |-
      Creates window containing text that pages vertically on overflow, with a single pair of strings. Also see struct scroll_box.

      This includes things like descriptions for items and moves.

      If window_params is NULL, SCROLL_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: string ID 1
      stack[0]: preprocessor args 1
      stack[1]: string ID 2
      stack[2]: preprocessor args 2
      return: window_id
  create_scroll_box_multi:
    value: 0x2e80c
    doc: |-
      Creates window containing text that pages vertically on overflow, with an array of string pairs. Also see struct scroll_box.

      This includes things like descriptions for items and moves.

      If window_params is NULL, SCROLL_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: number of string pairs
      stack[0]: string ID 1 array
      stack[1]: preprocessor args 1 array
      stack[2]: string ID 2 array
      stack[3]: preprocessor args 2 array
      return: window_id
  set_scroll_box_state7:
    value: 0x2e9a4
    doc: |-
      Sets the state of a scroll box to 7.

      r0: window_id
  close_scroll_box:
    value: 0x2e9bc
    doc: |-
      Closes a window created with CreateScrollBoxSingle or CreateScrollBoxMulti.

      r0: window_id
  is_scroll_box_active:
    value: 0x2e9d8
    doc: |-
      This is a guess.

      Checks if the state of a scroll box is not 8.

      r0: window_id
      return: bool
  update_scroll_box:
    value: 0x2e9fc
    doc: |-
      Window update function for scroll boxes.

      r0: window pointer
  create_dialogue_box:
    value: 0x2f3a4
    doc: |-
      Creates a window containing text that is gradually revealed via scrolling, and pages on overflow. Also see struct dialogue_box.

      This is primarily used for character dialogue, hence the name. However, it can also be used for other types of messages. The defining feature of this window type is the scrolling/paging behavior.

      If window_params is NULL, DIALOGUE_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      r0: window_params
      return: window_id
  close_dialogue_box:
    value: 0x2f43c
    doc: |-
      Closes a window created with CreateDialogueBox.

      r0: window_id
  is_dialogue_box_active:
    value: 0x2f474
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: window_id
      return: bool
  show_string_id_in_dialogue_box:
    value: 0x2f4a8
    doc: |-
      Preprocesses the corresponding string_id message in the text file and puts it into the dialogue box.

      r0: window_id
      r1: preprocessor flags (see PreprocessString)
      r2: string_id
      r3: pointer to preprocessor args (see PreprocessString)
  show_string_in_dialogue_box:
    value: 0x2f530
    doc: |-
      Preprocesses the passed string and puts it into the dialogue box.

      r0: window_id
      r1: preprocessor flags (see PreprocessString)
      r2: string
      r3: pointer to preprocessor args (see PreprocessString)
  show_dialogue_box:
    value: 0x2f698
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: window_id
  read_string_from_dialogue_box:
    value: 0x2f740
    doc: |-
      Copies data from the dialogue box's string buffer into an output buffer.

      r0: window_id
      r1: [output] string buffer
      r2: number of bytes to read
  update_dialogue_box:
    value: 0x2f77c
    doc: |-
      Window update function for dialogue boxes.

      r0: window pointer
  create_portrait_box:
    value: 0x2f8a0
    doc: |-
      Creates a window containing a character portrait. Also see struct portrait_box.

      This is commonly paired with a dialogue box, but can also be used standalone.

      If framed, the window box type will be 0xFC, otherwise it will be 0xF9.

      The new window will always default to PORTRAIT_BOX_DEFAULT_WINDOW_PARAMS.

      r0: screen index
      r1: palette_idx
      r2: framed
      return: window_id
  close_portrait_box:
    value: 0x2f944
    doc: |-
      Closes a window created with CreatePortraitBox.

      r0: window_id
  portrait_box_needs_update:
    value: 0x2f960
    doc: |-
      Checks if a portrait box has a state of PORTRAIT_BOX_TRY_UPDATE or PORTRAIT_BOX_UPDATE.

      r0: window_id
      return: bool
  show_portrait_in_portrait_box:
    value: 0x2f984
    doc: |-
      Stages a portrait to be rendered in a portrait box at next update (sets portrait_box::buffer_state).

      If portrait is NULL, the default portrait will be shown (see InitPortraitParams).

      r0: window_id
      r1: portrait params pointer
  hide_portrait_box:
    value: 0x2f9d0
    doc: |-
      Flags a portrait box to be hidden at next update (sets portrait_box::hide) if it's not already in the PORTRAIT_BOX_HIDDEN state, and resets its buffer state.

      r0: window_id
  update_portrait_box:
    value: 0x2fa00
    doc: |-
      Window update function for portrait boxes.

      r0: window pointer
  create_text_box:
    value: 0x2fbb8
    doc: |-
      Calls CreateTextBoxInternal, sets the callback without an argument, and returns the window_id.

      r0: window_params
      r1: text box callback function
      return: window_id
  create_text_box_with_arg:
    value: 0x2fbd0
    doc: |-
      Calls CreateTextBoxInternal, sets the callback with an argument, and returns the window_id.

      r0: window_params
      r1: text box callback with arg function
      r2: callback argument
      return: window_id
  close_text_box:
    value: 0x2fbf0
    doc: |-
      Closes a window created with CreateTextBox or CreateTextBoxWithArg.

      r0: window_id
  close_text_box2:
    value: 0x2fc0c
    doc: |-
      Seems to do some things with the text box, before doing the same things that CloseTextBox does.

      r0: window_id
  create_text_box_internal:
    value: 0x2fcd0
    doc: |-
      Creates a window containing simple text, without much advanced functionality. Also see struct text_box.

      If window_params is NULL, TEXT_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      r0: window_params
      return: text_box pointer
  update_text_box:
    value: 0x2fd50
    doc: |-
      Window update function for text boxes.

      r0: window pointer
  is_text_box_active:
    value: 0x2fe90
    doc: |-
      This is a guess.

      Checks if the state of a text box is not 7.

      r0: window_id
      return: bool
  create_area_name_box:
    value: 0x2feb0
    doc: |-
      Creates a window containing the area name, as resolved from the "[area:0]" tag.

      This only seems to be used for the "area name" text box in the top-level menu in ground mode (not dungeon mode), and the analogous text box on the world map transition screen before entering a dungeon.

      If window_params is NULL, AREA_NAME_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width is 0, it will be computed based on the contained text. If window_params::height is 0, it will default to 2.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: ID (for preprocessor_args)
      return: window_id
  set_area_name_box_state3:
    value: 0x30030
    doc: |-
      Sets the state of an area name box to 3.

      r0: window_id
  close_area_name_box:
    value: 0x30044
    doc: |-
      Closes a window created with CreateAreaNameBox.

      r0: window_id
  is_area_name_box_active:
    value: 0x30060
    doc: |-
      This is a guess.

      Checks if the state of an area name box is something other than 2 or 4.

      r0: window_id
      return: bool
  update_area_name_box:
    value: 0x30080
    doc: |-
      Window update function for area name boxes.

      r0: window pointer
  create_controls_chart:
    value: 0x30120
    doc: |-
      Creates a window containing a chart of player controls for some context. Also see struct controls_chart.

      This is usually used for static top-screen control reference charts.

      If window_params is NULL, CONTROLS_CHART_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: string ID
      return: window_id
  close_controls_chart:
    value: 0x301c8
    doc: |-
      Closes a window created with CreateControlsChart.

      r0: window_id
  is_controls_chart_active:
    value: 0x301e4
    doc: |-
      This is a guess.

      Checks if the state of a controls chart is something other than 2 or 4.

      r0: window_id
      return: bool
  update_controls_chart:
    value: 0x30204
    doc: |-
      Window update function for controls charts.

      r0: window pointer
  create_alert_box:
    value: 0x302a4
    doc: |-
      Creates a window containing text that will disappear after a certain amount of time. Also see struct alert_box.

      This is only used in dungeon mode, for the "popup alert" messages about things happening in the dungeon (which will also be accessible in the message logs).

      If window_params is NULL, ALERT_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      r0: window_params
      return: window_id
  close_alert_box:
    value: 0x30338
    doc: |-
      Closes a window created with CreateAlertBox.

      r0: window_id
  is_alert_box_active:
    value: 0x304e8
    doc: |-
      This is a guess.

      Checks if the state of an alert box is 3.

      r0: window_id
      return: bool
  update_alert_box:
    value: 0x30568
    doc: |-
      Window update function for alert boxes.

      r0: window pointer
  create_advanced_text_box:
    value: 0x308a8
    doc: |-
      Calls CreateAdvancedTextBoxInternal with all the selectable items on one page (n_items_per_page = n_items), sets the callback without an argument, and returns the window_id.

      If window_params is NULL, ADVANCED_TEXT_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.

      If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: text box callback function
      stack[0]: number of selectable items
      return: window_id
  create_advanced_text_box_with_arg:
    value: 0x308d8
    doc: |-
      Calls CreateAdvancedTextBoxInternal with all the selectable items on one page (n_items_per_page = n_items), sets the callback with an argument, and returns the window_id.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: text box callback with arg function
      stack[0]: callback argument
      stack[1]: number of selectable items
      return: window_id
  create_advanced_text_box_internal:
    value: 0x30910
    doc: |-
      Creates a window containing text formatted in complex, potentially sectioned layouts. Also see struct advanced_text_box.

      This is usually used to display text with "pretty" formatting in certain contexts, such as the message log, the move selection menu, team member summaries, etc.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: total number of selectable items
      stack[0]: number of selectable items per page
      return: advanced_text_box pointer
  set_advanced_text_box_partial_menu:
    value: 0x30a70
    doc: |-
      Seems to set advanced_text_box::flags::partial_menu to the given value?

      r0: window_id
      r1: partial_menu flag value
  set_advanced_text_box_field0x1_c4:
    value: 0x30a98
    doc: |-
      Sets the value of advanced_text_box::field_0x1c4 to the given value.

      r0: window_id
      r1: value
  set_advanced_text_box_field0x1_c2:
    value: 0x30b30
    doc: |-
      Sets advanced_text_box::field_0x1c2 to 1.

      r0: window_id
  close_advanced_text_box2:
    value: 0x30b44
    doc: |-
      Seems to do some things with the text box, before doing the same things that CloseAdvancedTextBox does.

      r0: window_id
  set_advanced_text_box_state5:
    value: 0x30b80
    doc: |-
      Sets the state of an advanced text box to 5.

      r0: window_id
  close_advanced_text_box:
    value: 0x30b94
    doc: |-
      Closes a window created with CreateAdvancedTextBox or CreateAdvancedTextBoxWithArg.

      r0: window_id
  is_advanced_text_box_active:
    value: 0x30bb8
    doc: |-
      This is a guess.

      Checks if the state of an advanced text box is something other than 6 or 7.

      r0: window_id
      return: bool
  get_advanced_text_box_flags2:
    value: 0x30d34
    doc: |-
      Gets the value of advanced_text_box::flags2.

      r0: window_id
      return: flags2
  set_unk_advanced_text_box_fn:
    value: 0x30db4
    doc: |-
      Sets the value of advanced_text_box::field_0x1b4 to the given function pointer.

      r0: window_id
      r1: some function pointer?
  set_unk_advanced_text_box_window_fn:
    value: 0x30dc8
    doc: |-
      Sets the value of advanced_text_box::field_0x1b8 to the given function pointer.

      r0: window_id
      r1: some function pointer?
  update_advanced_text_box:
    value: 0x30ddc
    doc: |-
      Window update function for advanced text boxes.

      r0: window pointer
  play_advanced_text_box_input_sound:
    value: 0x3121c
    doc: |-
      Calls PlayWindowInputSound for an advanced text box.

      r0: window_id
      r1: index for PlayWindowInputSound
  create_team_selection_menu:
    value: 0x31238
    doc: |-
      Creates a window containing a menu for selecting a single team member. Also see struct team_selection_menu.

      If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.

      This appears to be used for various shop (and shop-like) interfaces when a single team member needs to be selected. For example, the Electivire Link Shop, the Chimecho Assembly, the Croagunk Swap Shop, and Luminous Spring. It's unknown if this is used for other contexts besides team member selection.

      r0: window_params
      r1: window_flags
      r2: window_extra_info pointer
      r3: function to get the menu item text for a given team member
      stack[0]: total number of options
      stack[1]: number of options per page
      return: window_id
  close_team_selection_menu:
    value: 0x3148c
    doc: |-
      Closes a window created with CreateTeamSelectionMenu.

      r0: window_id
  is_team_selection_menu_active:
    value: 0x314a8
    doc: |-
      This is a guess.

      Checks if the state of a team selection menu is something other than 6 or 7.

      r0: window_id
      return: bool
  update_team_selection_menu:
    value: 0x31530
    doc: |-
      Window update function for team selection menus.

      r0: window pointer
  is_team_selection_menu_state3:
    value: 0x31ba4
    doc: |-
      Checks if the state of a team selection menu is 3.

      r0: window_id
  init_window_input:
    value: 0x31dec
    doc: |-
      This seems to be called when creating most interactive windows that respond to user input, like menus (but also other interactive windows like scroll boxes and advanced text boxes). It presumably sets up the state necessary for detecting and responding to user input.

      r0: window_input_ctx pointer
      r1: window_flags
      r2: window_extra_info pointer
      r3: window rectangle
      stack[0]: total number of selectable items
      stack[1]: number of selectable items per page
  is_menu_option_active:
    value: 0x32768
    doc: |-
      Called whenever a menu option is selected. Returns whether the option is active or not.

      r0: ?
      return: True if the menu option is enabled, false otherwise.
  play_window_input_sound:
    value: 0x32c54
    doc: |-
      Plays a "beep" sound when giving an input to an interactive window (typically, when choosing a menu option).

      r0: window_input_ctx pointer
      r1: Some kind of index used to determine the ID of the sound to play
  init_inventory_menu_input:
    value: 0x32d2c
    doc: |-
      Almost exactly the same as InitWindowInput, except two differences in field assignments on the window input context, one of which uses an extra parameter.

      r0: inventory_menu_input_ctx pointer
      r1: window_flags
      r2: window_extra_info pointer
      r3: window rectangle
      stack[0]: total number of selectable items
      stack[1]: number of selectable items per page
      stack[2]: ?
  setup_and_show_keyboard:
    value: 0x36aa8
    doc: |-
      Calls a function that seems to set up info for the keyboard menu before ending with a call to ShowKeyboard.

      r0: menu type
      r1: buffer1
      r2: buffer2
      return: ?
  show_keyboard:
    value: 0x36ae4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: menu type
      r1: buffer1
      r2: ???
      r3: buffer2
      return: ?
  get_keyboard_status:
    value: 0x36fd0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: ?
  get_keyboard_string_result:
    value: 0x37858
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: ?
  team_selection_menu_get_item:
    value: 0x3aa58
    doc: |-
      Gets the menu item text (member name) for a given team member for a team selection menu.

      r0: buffer
      r1: team member index
      return: menu item text (points into buffer)
  print_move_option_menu:
    value: 0x405bc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  print_iq_skills_menu:
    value: 0x41d3c
    doc: |-
      Draws the IQ skills menu for a certain monster.

      r0: Monster species
      r1: Pointer to bitarray where the enabled skills will be written when enabling or disabling them in the menu
      r2: Monster IQ
      r3: True if the monster is blinded
  get_notify_note:
    value: 0x487bc
    doc: |-
      Returns the current value of NOTIFY_NOTE.

      return: bool
  set_notify_note:
    value: 0x487cc
    doc: |-
      Sets NOTIFY_NOTE to the given value.

      r0: bool
  init_special_episode_hero:
    value: 0x48804
    doc: |-
      Removes/invalidates the special episode member slots, zero inits the special episode treasure bag, zero inits the
      special episode Kecleon shops, zero inits VAR_WORLD_MAP_MARK_LIST_SPECIAL, sets VAR_SPECIAL_EPISODE_OPEN_OLD for
      the corresponding special episode, and initializes the hero for the special episode.

      No params.
  event_flag_backup_veneer:
    value: 0x48a74
    doc: |-
      Likely a linker-generated veneer for EventFlagBackup.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      No params.
  init_main_team_after_quiz:
    value: 0x48ae0
    doc: |-
      Implements SPECIAL_PROC_INIT_MAIN_TEAM_AFTER_QUIZ (see ScriptSpecialProcessCall).

      No params.
  init_special_episode_partners:
    value: 0x48d28
    doc: |-
      Initializes the partners for the current special episode and sets the team to be the hero and partner only.
      Implements SPECIAL_PROC_0x3 (see ScriptSpecialProcessCall). 

      No params.
  init_special_episode_extra_partner:
    value: 0x48da0
    doc: |-
      Initializes any partners/special episode members that join the team later in a special episode. This is used to add
      Celebi in the In the Future of Darkness special episode.
      Implements SPECIAL_PROC_0x4 (see ScriptSpecialProcessCall).

      No params.
  read_string_save:
    value: 0x48ed0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: buffer
  check_string_save:
    value: 0x48eec
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: buffer
      return: bool
  write_save_file:
    value: 0x49190
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: save_info
      r1: buffer
      r2: size
      return: status code
  read_save_file:
    value: 0x491ec
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: save_info
      r1: buffer
      r2: size
      return: status code
  calc_checksum:
    value: 0x49240
    doc: |-
      Calculates the checksum of the save file and stores it at the start of the data.

      r0: Pointer to a buffer containing the save data
      r1: Size in bytes
  check_checksum_invalid:
    value: 0x49268
    doc: |-
      Calculates the checksum of the save file and compares it with the one stored in it.

      r0: Pointer to a buffer containing the save data
      r1: Size in bytes
      return: True if the calculated and stored checksums don't match, false if they do.
  note_save_base:
    value: 0x492a0
    doc: |-
      Probably related to saving or quicksaving?

      This function prints the debug message "NoteSave Base %d %d" with some values. It's also the only place where GetRngSeed is called.

      r0: Irdkwia's notes: state ID
      others: ?
      return: status code
  write_quick_save_info:
    value: 0x49564
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: buffer
      r1: size
  read_save_header:
    value: 0x49588
    doc: "Note: unverified, ported from Irdkwia's notes"
  note_load_base:
    value: 0x496a8
    doc: |-
      Probably related to loading a save file or quicksave?

      This function prints the debug message "NoteLoad Base %d" with some value. It's also the only place where SetRngSeed is called.

      return: status code
  read_quick_save_info:
    value: 0x49960
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: buffer
      r1: size
      return: status code
  get_game_mode:
    value: 0x4b2f8
    doc: |-
      Gets the value of GAME_MODE.

      return: game mode
  is_game_mode_rescue:
    value: 0x4b330
    doc: |-
      Returns true if the value of GAME_MODE is GAME_MODE_RESCUE.

      return: True if GAME_MODE is GAME_MODE_RESCUE.
  init_script_variable_values:
    value: 0x4b384
    doc: |-
      Initialize the script variable values table (SCRIPT_VARS_VALUES).

      The whole table is first zero-initialized. Then, all script variable values are first initialized to their defaults, after which some of them are overwritten with other hard-coded values.

      No params.
  init_event_flag_script_vars:
    value: 0x4b63c
    doc: |-
      Initializes an assortment of event flag script variables (see the code for an exhaustive list).

      No params.
  zinit_script_variable:
    value: 0x4b76c
    doc: |-
      Zero-initialize the values of the given script variable.

      r0: pointer to the local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID
  load_script_variable_raw:
    value: 0x4b7d4
    doc: |-
      Loads a script variable descriptor for a given ID.

      r0: [output] script variable descriptor pointer
      r1: pointer to the local variable table (doesn't need to be valid; just controls the output value pointer)
      r2: script variable ID
  load_script_variable_value:
    value: 0x4b824
    doc: |-
      Loads the value of a script variable.

      r0: pointer to the local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID
      return: value
  load_script_variable_value_at_index:
    value: 0x4b9b0
    doc: |-
      Loads the value of a script variable at some index (for script variables that are arrays).

      r0: pointer to the local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID
      r2: value index for the given script var
      return: value
  save_script_variable_value:
    value: 0x4bb58
    doc: |-
      Saves the given value to a script variable.

      r0: pointer to local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID
      r2: value to save
  save_script_variable_value_at_index:
    value: 0x4bcc0
    doc: |-
      Saves the given value to a script variable at some index (for script variables that are arrays).

      r0: pointer to local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID
      r2: value index for the given script var
      r3: value to save
  load_script_variable_value_sum:
    value: 0x4be38
    doc: |-
      Loads the sum of all values of a given script variable (for script variables that are arrays).

      r0: pointer to the local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID
      return: sum of values
  load_script_variable_value_bytes:
    value: 0x4be9c
    doc: |-
      Loads some number of bytes from the value of a given script variable.

      r0: script variable ID
      r1: [output] script variable value bytes
      r2: number of bytes to load
  save_script_variable_value_bytes:
    value: 0x4bf04
    doc: |-
      Saves some number of bytes to the given script variable.

      r0: script variable ID
      r1: bytes to save
      r2: number of bytes
  script_variables_equal:
    value: 0x4bf50
    doc: |-
      Checks if two script variables have equal values. For arrays, compares elementwise for the length of the first variable.

      r0: pointer to the local variable table (only needed if id >= VAR_LOCAL0)
      r1: script variable ID 1
      r2: script variable ID 2
      return: true if values are equal, false otherwise
  event_flag_resume:
    value: 0x4c2f8
    doc: |-
      Restores BACKUP event flag script variables (see the code for an exhaustive list) to their
      respective script variables, but only in certain game modes.

      This function prints the debug string "EventFlag BackupGameMode %d" with the game mode.

      No params.
  event_flag_backup:
    value: 0x4c51c
    doc: |-
      Saves event flag script variables (see the code for an exhaustive list) to their respective BACKUP script variables, but only in certain game modes.

      This function prints the debug string "EventFlag BackupGameMode %d" with the game mode.

      No params.
  dump_script_variable_values:
    value: 0x4c740
    doc: |-
      Runs EventFlagBackup, then copies the script variable values table (SCRIPT_VARS_VALUES) to the given pointer.

      r0: destination pointer for the data dump
      return: always 1
  restore_script_variable_values:
    value: 0x4c768
    doc: |-
      Restores the script variable values table (SCRIPT_VARS_VALUES) with the given data. The source data is assumed to be exactly 1024 bytes in length.

      Irdkwia's notes: CheckCorrectVersion

      r0: raw data to copy to the values table
      return: whether the restored value for VAR_VERSION is equal to its default value
  init_scenario_script_vars:
    value: 0x4c7c0
    doc: |-
      Initializes most of the SCENARIO_* script variables (except SCENARIO_TALK_BIT_FLAG for some reason). Also initializes the PLAY_OLD_GAME variable.

      No params.
  set_scenario_script_var:
    value: 0x4c950
    doc: |-
      Sets the given SCENARIO_* script variable with a given pair of values [val0, val1].

      In the special case when the ID is VAR_SCENARIO_MAIN, and the set value is different from the old one, the REQUEST_CLEAR_COUNT script variable will be set to 0.

      r0: script variable ID
      r1: val0
      r2: val1
  get_special_episode_type:
    value: 0x4cc24
    doc: |-
      Gets the special episode type from the SPECIAL_EPISODE_TYPE script variable.

      return: special episode type
  set_special_episode_type:
    value: 0x4cc38
    doc: |-
      Sets the special episode type by changing the SPECIAL_EPISODE_TYPE script variable.

      r0: special episode type
  get_execute_special_episode_type:
    value: 0x4cc70
    doc: |-
      Gets the special episode type from the EXECUTE_SPECIAL_EPISODE_TYPE script variable.

      return: special episode type
  is_special_episode_open:
    value: 0x4cc84
    doc: |-
      Checks if a special episode is unlocked from the SPECIAL_EPISODE_OPEN script variable.

      r0: special episode type
      return: bool
  has_played_old_game:
    value: 0x4cda8
    doc: |-
      Returns the value of the VAR_PLAY_OLD_GAME script variable.

      return: bool
  get_performance_flag_with_checks:
    value: 0x4cdcc
    doc: |-
      Returns the value of one of the flags in VAR_PERFORMANCE_PROGRESS_LIST, with some edge cases.

      List of cases where the function behaves differently:
      - If the requested flag is 0, returns true if and only if SCENARIO_MAIN == 0x35
      - If the requested flag is 1 or 2 and GAME_MODE == GAME_MODE_SPECIAL_EPISODE, returns true
      - If the requested flag is between 3 and 7 (both included) and GAME_MODE == GAME_MODE_SPECIAL_EPISODE, returns false

      r0: ID of the flag to get
      return: Value of the flag
  get_scenario_balance:
    value: 0x4cecc
    doc: |-
      Returns the current SCENARIO_BALANCE value.

      The exact value returned depends on multiple factors:
      - If the first special episode is active, returns 1
      - If a different special episode is active, returns 3
      - If the SCENARIO_BALANCE_DEBUG variable is >= 0, returns its value
      - In all other cases, the value of the SCENARIO_BALANCE_FLAG variable is returned

      return: Current SCENARIO_BALANCE value.
  scenario_flag_backup:
    value: 0x4cff0
    doc: |-
      Saves scenario flag script variables (SCENARIO_SELECT, SCENARIO_MAIN_BIT_FLAG) to their respective BACKUP script variables, but only in certain game modes.

      This function prints the debug string "ScenarioFlag BackupGameMode %d" with the game mode.

      No params.
  init_world_map_script_vars:
    value: 0x4d0c0
    doc: |-
      Initializes the WORLD_MAP_* script variable values (IDs 0x55-0x57).

      No params.
  init_dungeon_list_script_vars:
    value: 0x4d1c8
    doc: |-
      Initializes the DUNGEON_*_LIST script variable values (IDs 0x4f-0x54).

      No params.
  set_dungeon_conquest:
    value: 0x4d270
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      r1: bit_value
  get_dungeon_mode:
    value: 0x4d2d4
    doc: |-
      Returns the mode of the specified dungeon

      r0: Dungeon ID
      return: Dungeon mode
  global_progress_alloc:
    value: 0x4d440
    doc: |-
      Allocates a new global progress struct.

      This updates the global pointer and returns a copy of that pointer.

      return: pointer to a newly allocated global progress struct
  reset_global_progress:
    value: 0x4d468
    doc: |-
      Zero-initializes the global progress struct.

      No params.
  set_monster_flag1:
    value: 0x4d484
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
  get_monster_flag1:
    value: 0x4d4c0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: ?
  set_monster_flag2:
    value: 0x4d4fc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
  has_monster_been_attacked_in_dungeons:
    value: 0x4d540
    doc: |-
      Checks whether the specified monster has been attacked by the player at some point in their adventure during an exploration.

      The check is performed using the result of passing the ID to FemaleToMaleForm.

      r0: Monster ID
      return: True if the specified mosnter (after converting its ID through FemaleToMaleForm) has been attacked by the player before, false otherwise.
  set_dungeon_tip_shown:
    value: 0x4d588
    doc: |-
      Marks a dungeon tip as already shown to the player

      r0: Dungeon tip ID
  get_dungeon_tip_shown:
    value: 0x4d5c8
    doc: |-
      Checks if a dungeon tip has already been shown before or not.

      r0: Dungeon tip ID
      return: True if the tip has been shown before, false otherwise.
  set_max_reached_floor:
    value: 0x4d614
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      r1: max floor
  get_max_reached_floor:
    value: 0x4d630
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: max floor
  increment_nb_adventures:
    value: 0x4d650
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  get_nb_adventures:
    value: 0x4d684
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: # adventures
  can_monster_spawn:
    value: 0x4d698
    doc: |-
      Always returns true.

      This function seems to be a debug switch that the developers may have used to disable the random enemy spawn. 
      If it returned false, the call to SpawnMonster inside TrySpawnMonsterAndTickSpawnCounter would not be executed.

      r0: monster ID
      return: bool (always true)
  increment_exclusive_monster_counts:
    value: 0x4d6a0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
  copy_progress_info_to:
    value: 0x4d6f8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: write_info
      others: ?
  copy_progress_info_from_scratch_to:
    value: 0x4d880
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: start_address
      r1: total_length
      return: ?
  copy_progress_info_from:
    value: 0x4d8b8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
  copy_progress_info_from_scratch_from:
    value: 0x4da80
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: start_address
      r1: total_length
  init_kaomado_stream:
    value: 0x4dab8
    doc: |-
      Initializes the stream used to load all Kaomado portraits, called once on game start!

      No params.
  init_portrait_params:
    value: 0x4dad4
    doc: |-
      Initializes a struct portrait_params.

      The emote is set to PORTRAIT_NONE and the layout to the default. Everything else is initialized to 0.

      r0: portrait params pointer
  init_portrait_params_with_monster_id:
    value: 0x4db0c
    doc: |-
      Calls InitPortraitParams, and also initializes emote to PORTRAIT_NORMAL and monster ID to the passed argument.

      r0: portrait params pointer
      r1: monster ID
  set_portrait_emotion:
    value: 0x4db2c
    doc: |-
      Sets the emote in the passed portrait params, only if the monster ID isn't MONSTER_NONE.

      r0: portrait params pointer
      r1: emotion ID
  set_portrait_layout:
    value: 0x4db3c
    doc: |-
      Sets the layout in the passed portrait from the array of possible layouts.

      If the layout is 32 or if the monster ID is MONSTER_NONE, then it does nothing.

      r0: portrait params pointer
      r1: layout index
  set_portrait_offset:
    value: 0x4db80
    doc: |-
      Offsets the portrait from the original offset determined by the layout, by the vector passed as argument.

      If the monster ID is MONSTER_NONE, then it does nothing.

      r0: portrait params pointer
      r1: (x, y) offset in tiles from the original offset, derived from the layout
  allow_portrait_default:
    value: 0x4dbcc
    doc: |-
      Allows the portrait to try and load the default emote (PORTRAIT_NORMAL) if it can't find the specified emote.

      r0: portrait params pointer
      r1: allow default
  is_valid_portrait:
    value: 0x4dbd4
    doc: |-
      Returns whether this portrait params represents a valid portrait.

      r0: portrait params pointer
      return: bool
  load_portrait:
    value: 0x4dbf4
    doc: |-
      Tries to load the portrait data associated with the passed portrait params.

      Returns whether the operation was successful (the portrait could be found). If the passed buffer is null, the check if performed without loading any data.

      This function also modifies the flip fields in the passed portrait params.

      r0: portrait params pointer
      r1: kaomado_buffer pointer
      return: portrait exists
  wonder_mail_password_to_mission:
    value: 0x4e0b8
    doc: |-
      Tries to convert a Wonder Mail S password to a mission struct.

      Returns whether the conversion was successful. This function does not include any checks if the mission itself is valid, only if the code is valid.

      r0: string
      r1: [output] Pointer to the struct where the data of the converted mission will be written to
      return: successful conversion
  mission_to_wonder_mail_password:
    value: 0x4e1b4
    doc: |-
      Converts a mission struct to a Wonder Mail S password.

      r0: [output] Pointer to the buffer where the string will be written
      r1: mission struct pointer
  set_enter_dungeon:
    value: 0x4ec84
    doc: |-
      Used to set the dungeon that will be accessed when switching from ground to dungeon mode.

      r0: Dungeon ID
  init_dungeon_init:
    value: 0x4ed94
    doc: |-
      Initializes the dungeon_init struct before entering a dungeon.

      r0: [output] Pointer to the struct to init
      r1: Dungeon ID
  is_no_loss_penalty_dungeon:
    value: 0x4f318
    doc: |-
      Returns true if the specified dungeon shouldn't have a loss penalty.

      If true you won't lose your money and items upon fainting. Also used to initialize dungeon_init::skip_faint_animation_flag.

      Returns: True for DUNGEON_CRYSTAL_LAKE and DUNGEON_5TH_STATION_CLEARING, as well as for DUNGEON_DEEP_STAR_CAVE_TEAM_ROGUE if the ground variable SIDE01_BOSS2ND is 0; false otherwise.
  check_mission_restrictions:
    value: 0x4f6fc
    doc: |-
      Seems to be used to check if you have any missions that have unmet restrictions when trying to access a dungeon.

      r0: ?
      return: (?) Seems to be composed of multiple bitflags.
  get_nb_floors:
    value: 0x4f8b4
    doc: |-
      Returns the number of floors of the given dungeon.

      The result is hardcoded for certain dungeons, such as dojo mazes.

      r0: Dungeon ID
      return: Number of floors
  get_nb_floors_plus_one:
    value: 0x4f8ec
    doc: |-
      Returns the number of floors of the given dungeon + 1.

      r0: Dungeon ID
      return: Number of floors + 1
  get_dungeon_group:
    value: 0x4f900
    doc: |-
      Returns the dungeon group associated to the given dungeon.

      For IDs greater or equal to dungeon_id::DUNGEON_NORMAL_FLY_MAZE, returns dungeon_group_id::DGROUP_MAROWAK_DOJO.

      r0: Dungeon ID
      return: Group ID
  get_nb_preceding_floors:
    value: 0x4f918
    doc: |-
      Given a dungeon ID, returns the total amount of floors summed by all the previous dungeons in its group.

      The value is normally pulled from dungeon_data_list_entry::n_preceding_floors_group, except for dungeons with an ID >= dungeon_id::DUNGEON_NORMAL_FLY_MAZE, for which this function always returns 0.

      r0: Dungeon ID
      return: Number of preceding floors of the dungeon
  get_nb_floors_dungeon_group:
    value: 0x4f930
    doc: |-
      Returns the total amount of floors among all the dungeons in the dungeon group of the specified dungeon.

      r0: Dungeon ID
      return: Total number of floors in the group of the specified dungeon
  dungeon_floor_to_group_floor:
    value: 0x4f984
    doc: |-
      Given a dungeon ID and a floor number, returns a struct with the corresponding dungeon group and floor number in that group.

      The function normally uses the data in mappa_s.bin to calculate the result, but there's some dungeons (such as dojo mazes) that have hardcoded return values.

      Irdkwia's notes:
        [r1]: dungeon_id
        [r1+1]: dungeon_floor_id
        [r0]: group_id
        [r0+1]: group_floor_id

      r0: [output] Struct containing the dungeon group and floor group
      r1: Struct containing the dungeon ID and floor number
  get_mission_rank:
    value: 0x4fb4c
    doc: |-
      Gets the mission rank for the given dungeon and floor.

      If the dungeon ID is >= DUNGEON_NORMAL_FLY_MAZE or the group of the dungeon is > DGROUP_DUMMY_0x63, returns MISSION_RANK_E.

      r0: Dungeon and floor
      return: Mission rank
  get_outlaw_level:
    value: 0x4fbc4
    doc: |-
      Gets the level that should be used for outlaws for the given dungeon and floor

      r0: Dungeon and floor
      return: Outlaw level
  get_outlaw_leader_level:
    value: 0x4fbe0
    doc: |-
      Gets the level that should be used for team leader outlaws for the given dungeon and floor. Identical to GetOutlawLevel.

      r0: Dungeon and floor
      return: Outlaw leader level
  get_outlaw_minion_level:
    value: 0x4fbfc
    doc: |-
      Gets the level that should be used for minion outlaws for the given dungeon and floor.

      r0: Dungeon and floor
      return: Outlaw minion level
  add_guest_monster:
    value: 0x4fc18
    doc: |-
      Adds a guest monster to the active team

      r0: dungeon_init struct for the dungeon that is about to be entered
      r1: Number of the guest monster to add. Used when more than one monster is added.
      r2: Pointer to the guest monster entry to add to the team (usually located within GUEST_MONSTER_DATA)
  get_ground_name_id:
    value: 0x4fc90
    doc: "Note: unverified, ported from Irdkwia's notes"
  set_adventure_log_struct_location:
    value: 0x4fd5c
    doc: |-
      Sets the location of the adventure log struct in memory.

      Sets it in a static memory location (At 0x22AB69C [US], 0x22ABFDC [EU], 0x22ACE58 [JP])

      No params.
  set_adventure_log_dungeon_floor:
    value: 0x4fd74
    doc: |-
      Sets the current dungeon floor pair.

      r0: struct dungeon_floor_pair
  get_adventure_log_dungeon_floor:
    value: 0x4fd94
    doc: |-
      Gets the current dungeon floor pair.

      return: struct dungeon_floor_pair
  clear_adventure_log_struct:
    value: 0x4fda8
    doc: |-
      Clears the adventure log structure.

      No params.
  set_adventure_log_completed:
    value: 0x4fed4
    doc: |-
      Marks one of the adventure log entry as completed.

      r0: entry ID
  is_adventure_log_not_empty:
    value: 0x4fefc
    doc: |-
      Checks if at least one of the adventure log entries is completed.

      return: bool
  get_adventure_log_completed:
    value: 0x4ff34
    doc: |-
      Checks if one adventure log entry is completed.

      r0: entry ID
      return: bool
  increment_nb_dungeons_cleared:
    value: 0x4ff60
    doc: |-
      Increments by 1 the number of dungeons cleared.

      Implements SPECIAL_PROC_INCREMENT_DUNGEONS_CLEARED (see ScriptSpecialProcessCall).

      No params.
  get_nb_dungeons_cleared:
    value: 0x4ffa4
    doc: |-
      Gets the number of dungeons cleared.

      return: the number of dungeons cleared
  increment_nb_friend_rescues:
    value: 0x4ffb8
    doc: |-
      Increments by 1 the number of successful friend rescues.

      No params.
  get_nb_friend_rescues:
    value: 0x50000
    doc: |-
      Gets the number of successful friend rescues.

      return: the number of successful friend rescues
  increment_nb_evolutions:
    value: 0x50014
    doc: |-
      Increments by 1 the number of evolutions.

      No params.
  get_nb_evolutions:
    value: 0x5005c
    doc: |-
      Gets the number of evolutions.

      return: the number of evolutions
  increment_nb_steals:
    value: 0x50070
    doc: |-
      Leftover from Time & Darkness. Does not do anything.

      Calls to this matches the ones for incrementing the number of successful steals in Time & Darkness.

      No params.
  increment_nb_eggs_hatched:
    value: 0x50074
    doc: |-
      Increments by 1 the number of eggs hatched.

      No params.
  get_nb_eggs_hatched:
    value: 0x500b0
    doc: |-
      Gets the number of eggs hatched.

      return: the number of eggs hatched
  get_nb_pokemon_joined:
    value: 0x500c4
    doc: |-
      Gets the number of different pokémon that joined.

      return: the number of different pokémon that joined
  get_nb_moves_learned:
    value: 0x500d8
    doc: |-
      Gets the number of different moves learned.

      return: the number of different moves learned
  set_victories_on_one_floor:
    value: 0x500ec
    doc: |-
      Sets the record of victories on one floor.

      r0: the new record of victories
  get_victories_on_one_floor:
    value: 0x50120
    doc: |-
      Gets the record of victories on one floor.

      return: the record of victories
  set_pokemon_joined:
    value: 0x50134
    doc: |-
      Marks one pokémon as joined.

      r0: monster ID
  set_pokemon_battled:
    value: 0x50190
    doc: |-
      Marks one pokémon as battled.

      r0: monster ID
  get_nb_pokemon_battled:
    value: 0x501ec
    doc: |-
      Gets the number of different pokémon that battled against you.

      return: the number of different pokémon that battled against you
  increment_nb_big_treasure_wins:
    value: 0x50200
    doc: |-
      Increments by 1 the number of big treasure wins.

      Implements SPECIAL_PROC_INCREMENT_BIG_TREASURE_WINS (see ScriptSpecialProcessCall).

      No params.
  set_nb_big_treasure_wins:
    value: 0x50220
    doc: |-
      Sets the number of big treasure wins.

      r0: the new number of big treasure wins
  get_nb_big_treasure_wins:
    value: 0x50258
    doc: |-
      Gets the number of big treasure wins.

      return: the number of big treasure wins
  set_nb_recycled:
    value: 0x5026c
    doc: |-
      Sets the number of items recycled.

      r0: the new number of items recycled
  get_nb_recycled:
    value: 0x502a4
    doc: |-
      Gets the number of items recycled.

      return: the number of items recycled
  increment_nb_sky_gifts_sent:
    value: 0x502b8
    doc: |-
      Increments by 1 the number of sky gifts sent.

      Implements SPECIAL_PROC_SEND_SKY_GIFT_TO_GUILDMASTER (see ScriptSpecialProcessCall).

      No params.
  set_nb_sky_gifts_sent:
    value: 0x502d8
    doc: |-
      Sets the number of Sky Gifts sent.

      return: the number of Sky Gifts sent
  get_nb_sky_gifts_sent:
    value: 0x50310
    doc: |-
      Gets the number of Sky Gifts sent.

      return: the number of Sky Gifts sent
  compute_special_counters:
    value: 0x50324
    doc: |-
      Computes the counters from the bit fields in the adventure log, as they are not updated automatically when bit fields are altered.

      Affects GetNbPokemonJoined, GetNbMovesLearned, GetNbPokemonBattled and GetNbItemAcquired.

      No params.
  recruit_special_pokemon_log:
    value: 0x5057c
    doc: |-
      Marks a specified special pokémon as recruited in the adventure log.

      Irdkwia's notes: Useless in Sky

      r0: monster ID
  increment_nb_fainted:
    value: 0x505e8
    doc: |-
      Increments by 1 the number of times you fainted.

      No params.
  get_nb_fainted:
    value: 0x50624
    doc: |-
      Gets the number of times you fainted.

      return: the number of times you fainted
  set_item_acquired:
    value: 0x50638
    doc: |-
      Marks one specific item as acquired.

      r0: item
  get_nb_item_acquired:
    value: 0x50704
    doc: |-
      Gets the number of items acquired.

      return: the number of items acquired
  set_challenge_letter_cleared:
    value: 0x50758
    doc: |-
      Sets a challenge letter as cleared.

      r0: challenge ID
  get_sentry_duty_game_points:
    value: 0x507dc
    doc: |-
      Gets the points for the associated rank in the footprints minigame.

      r0: the rank (range 0-4, 1st to 5th)
      return: points
  set_sentry_duty_game_points:
    value: 0x507f4
    doc: |-
      Sets a new record in the footprints minigame.

      r0: points
      return: the rank (range 0-4, 1st to 5th; -1 if out of ranking)
  copy_log_to:
    value: 0x50884
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: write_info
  copy_log_from:
    value: 0x50a70
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
  get_ability_string:
    value: 0x50c54
    doc: |-
      Copies the string for the ability id into the buffer.

      r0: [output] buffer
      r1: ability ID
  get_ability_desc_string_id:
    value: 0x50c74
    doc: |-
      Gets the ability description string ID for the corresponding ability.

      r0: ability ID
      return: string ID
  get_type_string_id:
    value: 0x50c88
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: type ID
      return: string ID
  get_conversion2_convert_to_type:
    value: 0x50c9c
    doc: |-
      Determines which type a monster with Conversion2 should turn into after being hit by a certain
      type of move.

      r0: type ID
      return: type ID
  copy_bits_to:
    value: 0x50cf8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: write_info
      r1: buffer_write
      r2: nb_bits
  copy_bits_from:
    value: 0x50d78
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
      r1: buffer_read
      r2: nb_bits
  store_default_team_data:
    value: 0x50e04
    doc: |-
      Sets the name of the team for the main story to the default team name Poképals. Also initializes
      the team to Normal Rank and possibly set Secret Rank unlocked to false?

      No params.
  get_main_team_name_with_check:
    value: 0x50e48
    doc: |-
      Gets the name of the team for the main story with an additional check if the team name should be
      "???" because the story has not progressed enough.

      r0: [output] buffer
  get_main_team_name:
    value: 0x50eb4
    doc: |-
      Gets the name of the team for the main story.

      r0: [output] buffer
  set_main_team_name:
    value: 0x50ecc
    doc: |-
      Sets the main team name to the name in the passed buffer.

      r0: buffer
  get_rankup_points:
    value: 0x50ef0
    doc: |-
      Returns the number of points required to reach the next rank.

      If PERFORMANCE_PROGRESS_LIST[8] is 0 and the current rank is RANK_MASTER, or if the current rank is RANK_GUILDMASTER, returns 0.

      return: Points required to reach the next rank
  get_rank:
    value: 0x50fac
    doc: |-
      Returns the team's rank

      If PERFORMANCE_PROGRESS_LIST[8] is 0, the maximum rank that can be returned is RANK_MASTER.

      return: Rank
  get_rank_storage_size:
    value: 0x5101c
    doc: |-
      Gets the size of storage for the current rank.

      return: storage size
  reset_play_timer:
    value: 0x51140
    doc: |-
      Reset the file timer.

      r0: play_time
  play_timer_tick:
    value: 0x51150
    doc: |-
      Advance the file timer by 1 frame.

      r0: play_time
  get_play_time_seconds:
    value: 0x5118c
    doc: |-
      Returns the current play time in seconds.

      return: play time in seconds
  sub_fixed_point:
    value: 0x51248
    doc: |-
      Compute the subtraction of two decimal fixed-point numbers (16 fraction bits).

      Numbers are in the format {16-bit integer part, 16-bit thousandths}, where the integer part is the lower word. Probably used primarily for belly.

      r0: number
      r1: decrement
      return: max(number - decrement, 0)
  bin_to_dec_fixed_point:
    value: 0x51358
    doc: |-
      Convert a binary fixed-point number (16 fraction bits) to the decimal fixed-point number (16 fraction bits) used for belly calculations. Thousandths are floored.

      If <data> holds the raw binary data, a binary fixed-point number (16 fraction bits) has the value ((unsigned)data) * 2^-16), and the decimal fixed-point number (16 fraction bits) used for belly has the value (data & 0xffff) + (data >> 16)/1000.

      r0: pointer p, where ((const unsigned *)p)[1] is the fractional number in binary fixed-point format to convert
      return: fractional number in decimal fixed-point format
  ceil_fixed_point:
    value: 0x5139c
    doc: |-
      Compute the ceiling of a decimal fixed-point number (16 fraction bits).

      Numbers are in the format {16-bit integer part, 16-bit thousandths}, where the integer part is the lower word. Probably used primarily for belly.

      r0: number
      return: ceil(number)
  dungeon_goes_up:
    value: 0x515c0
    doc: |-
      Returns whether the specified dungeon is considered as going upward or not

      r0: dungeon id
      return: bool
  get_turn_limit:
    value: 0x515e8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: turn limit
  does_not_save_when_entering:
    value: 0x51600
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  treasure_box_drops_enabled:
    value: 0x51628
    doc: |-
      Checks if enemy Treasure Box drops are enabled in the dungeon.

      r0: dungeon ID
      return: bool
  is_level_reset_dungeon:
    value: 0x51650
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  get_max_items_allowed:
    value: 0x51678
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: max items allowed
  is_money_allowed:
    value: 0x51690
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  get_max_rescue_attempts:
    value: 0x516b8
    doc: |-
      Returns the maximum rescue attempts allowed in the specified dungeon.

      r0: dungeon id
      return: Max rescue attempts, or -1 if rescues are disabled.
  is_recruiting_allowed:
    value: 0x516d0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  get_leader_change_flag:
    value: 0x516f8
    doc: |-
      Returns true if the flag that allows changing leaders is set in the restrictions of the specified dungeon

      r0: dungeon id
      return: True if the restrictions of the current dungeon allow changing leaders, false otherwise.
  get_random_movement_chance:
    value: 0x51720
    doc: |-
      Returns dungeon_restriction::random_movement_chance for the specified dungeon ID.

      r0: dungeon ID
      return: Random movement chance
  can_enemy_evolve:
    value: 0x51738
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  get_max_members_allowed:
    value: 0x51760
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: max members allowed
  is_iq_enabled:
    value: 0x51778
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  is_trap_invisible_when_attacking:
    value: 0x517a0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
      return: bool
  joined_at_range_check:
    value: 0x517c8
    doc: |-
      Returns whether a certain joined_at field value is between dungeon_id::DUNGEON_JOINED_AT_BIDOOF and dungeon_id::DUNGEON_DUMMY_0xE3.

      Irdkwia's notes: IsSupportPokemon

      r0: joined_at id
      return: bool
  is_dojo_dungeon:
    value: 0x517e8
    doc: |-
      Checks if the given dungeon is a Marowak Dojo dungeon.

      r0: dungeon ID
      return: bool
  is_future_dungeon:
    value: 0x51804
    doc: |-
      Checks if the given dungeon is a dungeon in the future arc of the main story.

      r0: dungeon ID
      return: bool
  is_special_episode_dungeon:
    value: 0x51820
    doc: |-
      Checks if the given dungeon is a special episode dungeon.

      r0: dungeon ID
      return: bool
  retrieve_from_item_list1:
    value: 0x5183c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon_info
      r1: ?
      return: ?
  is_forbidden_floor:
    value: 0x518a0
    doc: |-
      Related to missions floors forbidden

      Note: unverified, ported from Irdkwia's notes

      r0: dungeon_info
      others: ?
      return: bool
  copy16_bits_from:
    value: 0x51924
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
      r1: buffer_read
  retrieve_from_item_list2:
    value: 0x519b4
    doc: |-
      Same as RetrieveFromItemList1, except there is one more comparison

      Note: unverified, ported from Irdkwia's notes

      r0: dungeon_info
  is_invalid_for_mission:
    value: 0x51a14
    doc: |-
      It's a guess

      Note: unverified, ported from Irdkwia's notes

      r0: dungeon_id
      return: bool
  is_exp_enabled_in_dungeon:
    value: 0x51a54
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon_id
      return: bool
  is_sky_exclusive_dungeon:
    value: 0x51a7c
    doc: |-
      Also the dungeons where Giratina has its Origin Form

      Note: unverified, ported from Irdkwia's notes

      r0: dungeon_id
      return: bool
  joined_at_range_check2:
    value: 0x51a98
    doc: |-
      Returns whether a certain joined_at field value is equal to dungeon_id::DUNGEON_BEACH or is between dungeon_id::DUNGEON_DUMMY_0xEC and dungeon_id::DUNGEON_DUMMY_0xF0.

      Irdkwia's notes: IsSEPokemon

      r0: joined_at id
      return: bool
  get_bag_capacity:
    value: 0x51b0c
    doc: |-
      Returns the player's bag capacity for a given point in the game.

      r0: scenario_balance
      return: bag capacity
  get_bag_capacity_special_episode:
    value: 0x51b1c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: se_type
      return: bag capacity
  get_rank_up_entry:
    value: 0x51b2c
    doc: |-
      Gets the rank up data for the specified rank.

      r0: rank index
      return: struct rankup_table_entry*
  get_bg_region_area:
    value: 0x521c4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: offset
      r1: subregion_id
      r2: region_id
      return: ?
  load_monster_md:
    value: 0x52690
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  get_name_raw:
    value: 0x526cc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dst_ptr
      r1: id
  get_name:
    value: 0x52708
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dst_ptr
      r1: id
      r2: color_id
  get_name_with_gender:
    value: 0x52778
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dst_ptr
      r1: id
      r2: color_id
  get_species_string:
    value: 0x52838
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dst_ptr
      r1: id
  get_name_string:
    value: 0x52a00
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: name
  get_dex_number:
    value: 0x52a78
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: dex number
  get_category_string:
    value: 0x52a94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: category
  get_monster_gender:
    value: 0x52ae0
    doc: |-
      Returns the gender field of a monster given its ID.

      r0: monster id
      return: monster gender
  get_body_size:
    value: 0x52afc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: body size
  get_sprite_size:
    value: 0x52b18
    doc: |-
      Returns the sprite size of the specified monster. If the size is between 1 and 6, 6 will be returned.

      r0: monster id
      return: sprite size
  get_sprite_file_size:
    value: 0x52b54
    doc: |-
      Returns the sprite file size of the specified monster.

      r0: monster id
      return: sprite file size
  get_shadow_size:
    value: 0x52b74
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: shadow size
  get_speed_status:
    value: 0x52b90
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: speed status
  get_mobility_type:
    value: 0x52bac
    doc: |-
      Gets the mobility type for a given monster species.

      r0: species ID
      return: mobility type
  get_regen_speed:
    value: 0x52bc8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: regen speed
  get_can_move_flag:
    value: 0x52bec
    doc: |-
      Returns the flag that determines if a monster can move in dungeons.

      r0: Monster ID
      return: "Can move" flag
  get_chance_asleep:
    value: 0x52c18
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: chance asleep
  get_weight_multiplier:
    value: 0x52c34
    doc: |-
      Gets the weight multiplier value for the given species. This value is passed as the damage_mult_fp parameter to DealDamage when calculating the damage dealt by Low Kick and Grass Knot.

      r0: monster ID
      return: Monster weight multiplier, as a binary fixed-point number with 8 fraction bits.
  get_size:
    value: 0x52c50
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: size
  get_base_hp:
    value: 0x52c6c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: base HP
  can_throw_items:
    value: 0x52c88
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: bool
  can_evolve:
    value: 0x52cb4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: bool
  get_monster_pre_evolution:
    value: 0x52ce0
    doc: |-
      Returns the pre-evolution id of a monster given its ID.

      r0: monster id
      return: ID of the monster that evolves into the one specified in r0
  get_base_offensive_stat:
    value: 0x52cfc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: stat index
      return: base attack/special attack stat
  get_base_defensive_stat:
    value: 0x52d1c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: stat index
      return: base defense/special defense stat
  get_type_func:
    value: 0x52d3c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: type index (0 for primary type or 1 for secondary type)
      return: type
  get_ability:
    value: 0x52d5c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: ability index (0 for primary ability or 1 for secondary ability)
      return: ability
  get_recruit_rate2:
    value: 0x52d7c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: recruit rate 2
  get_recruit_rate1:
    value: 0x52d98
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: recruit rate 1
  get_exp:
    value: 0x52db4
    doc: |-
      Base Formula = ((Level-1)*ExpYield)//10+ExpYield
      Note: Defeating an enemy without using a move will divide this amount by 2

      r0: id
      r1: level
      return: exp
  get_evo_parameters:
    value: 0x52de8
    doc: |-
      Bx
      Has something to do with evolution

      Note: unverified, ported from Irdkwia's notes

      r0: [output] struct_evo_param
      r1: id
  get_treasure_box_chances:
    value: 0x52e18
    doc: |-
      Has something to do with bytes 3C-3E

      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: [output] struct_chances
  get_iq_group:
    value: 0x52e60
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: IQ group
  get_spawn_threshold:
    value: 0x52e7c
    doc: |-
      Returns the spawn threshold of the given monster ID

      The spawn threshold determines the minimum SCENARIO_BALANCE_FLAG value required by a monster to spawn in dungeons.

      r0: monster id
      return: Spawn threshold
  needs_item_to_spawn:
    value: 0x52e98
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: bool
  get_exclusive_item:
    value: 0x52ec4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      r1: determines which exclusive item
      return: exclusive item
  get_family_index:
    value: 0x52ef0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: family index
  load_m2n_and_n2m:
    value: 0x52f0c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  guest_monster_to_ground_monster:
    value: 0x531cc
    doc: |-
      Inits a ground_monster entry with the given guest_monster struct.

      r0: [output] ground_monster struct to init
      r1: guest_monster struct to use
  set_base_stats_moves_ground_monster:
    value: 0x53278
    doc: |-
      Sets a ground monster to have the base stats and Level 1 moves of its species, along with 1 IQ.

      r0: ground monster pointer
  strcmp_monster_name:
    value: 0x5332c
    doc: |-
      Checks if the string_buffer matches the name of the species

      Note: unverified, ported from Irdkwia's notes

      r0: string_buffer
      r1: monster ID
      return: bool
  get_lvl_up_entry:
    value: 0x53b18
    doc: |-
      Gets the level-up entry of the given monster ID at the specified level.

      The monster's entire level up data is also decompressed to LEVEL_UP_DATA_DECOMPRESS_BUFFER, and its ID is stored in LEVEL_UP_DATA_MONSTER_ID.

      r0: [output] Level-up entry
      r1: monster ID
      r2: level
  get_encoded_halfword:
    value: 0x53bc8
    doc: |-
      Decodes a 2-byte value that may be encoded using 1 or 2 bytes and writes it to the specified buffer.

      The encoding system uses the most significant bit of the first byte to signal if the value is encoded as a single byte or as a halfword. If the bit is unset, the value is read as (encoded byte) & 0x7F. If it's set, the value is read as ((first encoded byte) & 0x7F << 7) | (second encoded byte) & 0x7F.

      r0: Pointer to encoded value
      r1: [output] Buffer where the resulting 2-byte value will be stored.
      return: Pointer to the next byte to decode
  get_evo_family:
    value: 0x5414c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster_str
      r1: evo_family_str
      return: nb_family
  get_evolutions:
    value: 0x54204
    doc: |-
      Returns a list of all the possible evolutions for a given monster id.

      r0: Monster id
      r1: [Output] Array that will hold the list of monster ids the specified monster can evolve into
      r2: True to skip the check that prevents returning monsters with a different sprite size than the current one
      r3: True to skip the check that prevents Shedinja from being counted as a potential evolution
      return: Number of possible evolutions for the specified monster id
  shuffle_hidden_power:
    value: 0x54344
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dmons_addr
  get_base_form:
    value: 0x543a0
    doc: |-
      Checks if the specified monster ID corresponds to any of the pokémon that have multiple forms and returns the ID of the base form if so. If it doesn't, the same ID is returned.

      Some of the pokémon included in the check are Castform, Unown, Deoxys, Cherrim, Shaymin, and Giratina

      r0: Monster ID
      return: ID of the base form of the specified monster, or the same if the specified monster doesn't have a base form.
  get_base_form_burmy_wormadam_shellos_gastrodon_cherrim:
    value: 0x545cc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: base form
  get_base_form_castform_cherrim_deoxys:
    value: 0x54714
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: base form
  get_all_base_forms:
    value: 0x547e0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: base form
  get_dex_number_veneer:
    value: 0x547f0
    doc: |-
      Likely a linker-generated veneer for GetDexNumber.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: id
      return: dex number
  get_monster_id_from_spawn_entry:
    value: 0x547fc
    doc: |-
      Returns the monster ID of the specified monster spawn entry

      r0: Pointer to the monster spawn entry
      return: monster_spawn_entry::id
  set_monster_id:
    value: 0x5481c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: mons_spawn_str
      r1: monster ID
  set_monster_level_and_id:
    value: 0x54824
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: mons_spawn_str
      r1: level
      r2: monster ID
  get_monster_level_from_spawn_entry:
    value: 0x54834
    doc: |-
      Returns the level of the specified monster spawn entry.

      r0: pointer to the monster spawn entry
      return: uint8_t
  apply_level_up_boosts_to_ground_monster:
    value: 0x54844
    doc: |-
      Applies the level up boosts to stats and moves (until moveset is full) to a target monster.

      r0: ground monster pointer
      r1: level
      r2: flag that enables further editing of the monster
  get_monster_gender_veneer:
    value: 0x54adc
    doc: |-
      Likely a linker-generated veneer for GetMonsterGender.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: monster id
      return: monster gender
  is_monster_valid:
    value: 0x54ae8
    doc: |-
      Checks if an monster ID is valid.

      r0: monster ID
      return: bool
  is_unown:
    value: 0x54e04
    doc: |-
      Checks if a monster ID is an Unown.

      r0: monster ID
      return: bool
  is_shaymin:
    value: 0x54e20
    doc: |-
      Checks if a monster ID is a Shaymin form.

      r0: monster ID
      return: bool
  is_castform:
    value: 0x54e50
    doc: |-
      Checks if a monster ID is a Castform form.

      r0: monster ID
      return: bool
  is_cherrim:
    value: 0x54ea8
    doc: |-
      Checks if a monster ID is a Cherrim form.

      r0: monster ID
      return: bool
  is_deoxys:
    value: 0x54ef0
    doc: |-
      Checks if a monster ID is a Deoxys form.

      r0: monster ID
      return: bool
  get_second_form_if_valid:
    value: 0x54f20
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: second form
  female_to_male_form:
    value: 0x54f5c
    doc: |-
      Returns the ID of the first form of the specified monster if the specified ID corresponds to a secondary form with female gender and the first form has male gender. If those conditions don't meet, returns the same ID unchanged.

      r0: Monster ID
      return: ID of the male form of the monster if the requirements meet, same ID otherwise.
  get_base_form_castform_deoxys_cherrim:
    value: 0x54fa0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id
      return: base form
  base_forms_equal:
    value: 0x55054
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: id1
      r1: id2
      return: if the base forms are the same
  dex_numbers_equal:
    value: 0x55140
    doc: |-
      Each Unown is considered as different

      Note: unverified, ported from Irdkwia's notes

      r0: id1
      r1: id2
      return: bool
  genders_equal:
    value: 0x551c8
    doc: |-
      Checks if the genders for two monster IDs are equal.

      r0: id1
      r1: id2
      return: bool
  genders_equal_not_genderless:
    value: 0x551f4
    doc: |-
      Checks if the genders for two monster IDs are equal. Always returns false if either gender is GENDER_GENDERLESS.

      r0: id1
      r1: id2
      return: bool
  genders_not_equal_not_genderless:
    value: 0x55244
    doc: |-
      Checks if the genders for two monster IDs are not equal. Always returns false
      if either gender is GENDER_GENDERLESS.

      r0: id1
      r1: id2
      return: bool
  is_monster_on_team:
    value: 0x554c4
    doc: |-
      Checks if a given monster is on the exploration team (not necessarily the active party)?

      Irdkwia's notes:
        recruit_strategy=0: strict equality
        recruit_strategy=1: relative equality

      r0: monster ID
      r1: recruit_strategy
      return: bool
  get_nb_recruited:
    value: 0x555f0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: recruit_str
  is_valid_team_member:
    value: 0x5570c
    doc: |-
      Returns whether or not the team member at the given index is valid for the current game mode.

      During normal play, this will only be false for the special-episode-reserved indexes (2, 3, 4). During special episodes, this will be false for the hero and partner (0, 1).

      r0: team member index
      return: bool
  is_main_character:
    value: 0x558a4
    doc: |-
      Returns whether or not the team member at the given index is a "main character".

      During normal play, this will only be true for the hero and partner (0, 1). During special episodes, this will be true for the special-episode-reserved indexes (2, 3, 4).

      r0: team member index
      return: bool
  get_team_member:
    value: 0x55924
    doc: |-
      Gets the team member at the given index.

      r0: team member index
      return: ground monster pointer
  get_hero_member_idx:
    value: 0x559cc
    doc: |-
      Returns the team member index of the hero (0) if the hero is valid, otherwise return -1.

      return: team member index
  get_partner_member_idx:
    value: 0x559f8
    doc: |-
      Returns the team member index of the partner (1) if the partner is valid, otherwise return -1.

      return: team member index
  get_main_character1_member_idx:
    value: 0x55a24
    doc: |-
      Returns the team member index of the first main character for the given game mode, if valid, otherwise return -1.

      In normal play, this will be the hero (0). During special episodes, this will be 2.

      return: team member index
  get_main_character2_member_idx:
    value: 0x55a68
    doc: |-
      Returns the team member index of the second main character for the given game mode, if valid, otherwise return -1.

      In normal play, this will be the partner (1). During special episodes, this will be 3 if there's a second main character.

      return: team member index
  get_main_character3_member_idx:
    value: 0x55aac
    doc: |-
      Returns the team member index of the third main character for the given game mode, if valid, otherwise return -1.

      In normal play, this will be invalid (-1). During special episodes, this will be 4 if there's a third main character.

      return: team member index
  get_hero:
    value: 0x55aec
    doc: |-
      Returns the ground monster data of the hero.

      return: ground monster pointer
  get_partner:
    value: 0x55b14
    doc: |-
      Returns the ground monster data of the partner.

      return: ground monster pointer
  get_main_character1:
    value: 0x55b40
    doc: |-
      Returns the ground monster data of the first main character for the given game mode.

      In normal play, this will be the hero. During special episodes, this will be the first special episode main character (index 2).

      return: ground monster pointer
  get_main_character2:
    value: 0x55b88
    doc: |-
      Returns the ground monster data of the second main character for the given game mode, or null if invalid.

      In normal play, this will be the partner. During special episodes, this will be the second special episode main character (index 3) if one is present.

      return: ground monster pointer
  get_main_character3:
    value: 0x55bd0
    doc: |-
      Returns the ground monster data of the third main character for the given game mode, or null if invalid.

      In normal play, this will be null. During special episodes, this will be the third special episode main character (index 4) if one is present.

      return: ground monster pointer
  get_first_matching_member_idx:
    value: 0x55c70
    doc: |-
      Gets the first team member index (in the Chimecho Assembly) that has a specific monster ID, or -1 if there is none.

      If valid, this will always be 5 or greater, since indexes 0-4 are reserved for main characters.

      r0: monster ID
      return: team member index of the first matching slot
  get_first_empty_member_idx:
    value: 0x55ce0
    doc: |-
      Gets the first unoccupied team member index (in the Chimecho Assembly), or -1 if there is none.

      If valid, this will always be 5 or greater, since indexes 0-4 are reserved for main characters.

      r0: ?
      return: team member index of the first available slot
  is_monster_not_nicknamed:
    value: 0x563ec
    doc: |-
      Checks if the string_buffer matches the name of the species

      r0: ground monster pointer
      return: bool
  remove_active_members_from_all_teams:
    value: 0x56444
    doc: |-
      Removes all of the active monsters on every type of team from the team member table.

      No params.
  remove_active_members_from_special_episode_team:
    value: 0x564d4
    doc: |-
      Removes the active monsters on the Special Episode Team from the team member table.

      No params.
  remove_active_members_from_rescue_team:
    value: 0x5653c
    doc: |-
      Removes the active monsters on the Rescue Team from the team member table.

      No params.
  check_team_member_idx:
    value: 0x565e0
    doc: |-
      Checks if a team member's member index (team_member::member_idx) is equal to certain values.

      This is known to return true for some or all of the guest monsters.

      r0: member index
      return: True if the value is equal to 0x55AA or 0x5AA5
  is_monster_id_in_normal_range:
    value: 0x56610
    doc: |-
      Checks if a monster ID is in the range [0, 554], meaning it's before the special story monster IDs and secondary gender IDs.

      r0: monster ID
      return: bool
  set_active_team:
    value: 0x56648
    doc: |-
      Sets the specified team to active in TEAM_MEMBER_TABLE.

      r0: team ID
  get_active_team_member:
    value: 0x56708
    doc: |-
      Returns a struct containing information about the active team member in the given slot index.

      r0: roster index
      return: team member pointer, or null if index is -1
  get_active_roster_index:
    value: 0x56738
    doc: |-
      Searches for the roster index for the given team member within the current active roster.

      r0: team member index
      return: roster index if the team member is active, -1 otherwise
  try_add_monster_to_active_team:
    value: 0x56ad0
    doc: |-
      Attempts to add a monster from the team member table to the active team.

      Returns the team index of the newly added monster. If the monster was already on the team, returns its current team index. If the monster is not on the team and there's no space left, returns -1.

      r0: member index
      return: Team index
  remove_active_members_from_main_team:
    value: 0x56cdc
    doc: |-
      Removes the active monsters on the Main Team from the team member table.

      No params.
  set_team_setup_hero_and_partner_only:
    value: 0x56d48
    doc: |-
      Implements SPECIAL_PROC_SET_TEAM_SETUP_HERO_AND_PARTNER_ONLY (see ScriptSpecialProcessCall).

      No params.
  set_team_setup_hero_only:
    value: 0x56e2c
    doc: |-
      Implements SPECIAL_PROC_SET_TEAM_SETUP_HERO_ONLY (see ScriptSpecialProcessCall).

      No params.
  get_party_members:
    value: 0x56f9c
    doc: |-
      Appears to get the team's active party members. Implements most of SPECIAL_PROC_IS_TEAM_SETUP_SOLO (see ScriptSpecialProcessCall).

      r0: [output] Array of 4 2-byte values (they seem to be indexes of some sort) describing each party member, which will be filled in by the function. The input can be a null pointer if the party members aren't needed
      return: Number of party members
  refill_team:
    value: 0x580d4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  clear_item:
    value: 0x5856c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: team_id
      r1: check
  change_giratina_form_if_sky_dungeon:
    value: 0x58954
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: dungeon ID
  revert_giratina_and_shaymin:
    value: 0x589f0
    doc: |-
      Reverts Giratina and Shaymin party members to their standard forms.

      r0: team member index in party
      r1: ?
  get_iq_skill_string_id:
    value: 0x58f98
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: iq skill id
      return: iq skill string id
  does_tactic_follow_leader:
    value: 0x58fb8
    doc: |-
      Returns whether or not the tactic involves following the team leader.

      r0: tactic_id
      return: bool
  get_unlocked_tactics:
    value: 0x58fc8
    doc: |-
      Returns an array with all the enabled tactics. TACTIC_NONE is used to fill the empty/unused entries
      in the array.

      r0: [output] Array of tactic_ids that are enabled
      r1: Monster level
  get_unlocked_tactic_flags:
    value: 0x59018
    doc: |-
      Returns an array with an entry for each tactic and if they're unlocked at the passed level.

      r0: [output] bool Array where the unlocked status of each tactic is stored
      r1: Monster level
  can_learn_iq_skill:
    value: 0x59054
    doc: |-
      Returns whether an IQ skill can be learned with a given IQ amount or not.

      If the specified amount is 0, it always returns false.

      r0: IQ amount
      r1: IQ skill
      return: True if the specified skill can be learned with the specified IQ amount.
  get_learnable_iq_skills:
    value: 0x59080
    doc: |-
      Determines the list of IQ skills that a given monster can learn given its IQ value.

      The list of skills is written in the array specified in r0. The array has 69 slots in total. Unused slots are set to 0.

      r0: [output] Array where the list of skills will be written
      r1: Monster species
      r2: Monster IQ
      return: Amount of skills written to the output array
  disable_iq_skill:
    value: 0x59120
    doc: |-
      Disables an IQ skill.

      r0: Pointer to the bitarray containing the list of enabled IQ skills
      r1: ID of the skill to disable
  enable_iq_skill:
    value: 0x59170
    doc: |-
      Enables an IQ skill and disables any other skills that are incompatible with it.

      r0: Pointer to the bitarray containing the list of enabled IQ skills
      r1: ID of the skill to enable
  get_species_iq_skill:
    value: 0x591e4
    doc: |-
      Gets the <index>th skill on the list of IQ skills that a given monster species can learn.

      r0: Species ID
      r1: Index (starting at 0)
      return: IQ skill ID
  disable_all_iq_skills:
    value: 0x59208
    doc: |-
      Disables all IQ skills in the bitarray.

      r0: Pointer to the bitarray containing the list of enabled IQ skills
  enable_all_learnable_iq_skills:
    value: 0x5922c
    doc: |-
      Attempts to enable all the IQ skills available to the monster. If there are incompatible IQ skils,
      the one with the highest ID will be activated while the others will be inactivated.

      r0: [output] Array where the list of skills will be written
      r1: Monster species
      r2: Monster IQ
  iq_skill_flag_test:
    value: 0x59280
    doc: |-
      Tests whether an IQ skill with a given ID is active.

      r0: IQ skill bitvector to test
      r1: IQ skill ID
      return: bool
  get_next_iq_skill:
    value: 0x592a0
    doc: |-
      Returns the next IQ skill that a given monster will learn given its current IQ value, or IQ_NONE if the monster won't learn any more skills.

      r0: Monster ID
      r1: Monster IQ
      return: ID of the next skill learned by the monster, or IQ_NONE if the monster won't learn any more skills.
  get_explorer_maze_team_name:
    value: 0x593dc
    doc: |-
      Returns the name of the explorer maze team. If the language of the team name is different from the
      language of selected in this game a default team name is written to the buffer instead.

      r0: [output] Buffer
  get_explorer_maze_monster:
    value: 0x59474
    doc: |-
      Returns the data of a monster sent into the Explorer Dojo using the "exchange teams" option.

      r0: Entry number (0-3)
      return: Ground monster data of the specified entry
  write_monster_info_to_save:
    value: 0x59494
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: start_address
      r1: total_length
      return: ?
  read_monster_info_from_save:
    value: 0x595a0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: start_address
      r1: total_length
  write_monster_to_save:
    value: 0x596b0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: write_info
      r1: ground_monster
  read_monster_from_save:
    value: 0x597c0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: read_info
      r1: ground_monster
  get_evolution_possibilities:
    value: 0x59e94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: ground_monster
      r1: evo_struct_addr
  get_monster_evo_status:
    value: 0x5a58c
    doc: |-
      evo_status = 0: Not possible now
      evo_status = 1: Possible now
      evo_status = 2: No further

      Note: unverified, ported from Irdkwia's notes

      r0: ground_monster
      return: evo_status
  copy_tactic_string:
    value: 0x5a7ac
    doc: |-
      Gets the string corresponding to a given string ID and copies it to the buffer specified in r0.

      This function won't write more than 64 bytes.

      r0: [output] buffer
      r1: tactic_id
  get_stat_boosts_for_monster_summary:
    value: 0x5a7cc
    doc: |-
      Gets the stat boosts from held items, exclusive items, and iq skills and stores them into the
      monster_summary struct.

      r0: monster_summary
      r1: enum monster_id monster_id
      r2: pointer to held item
      r3: iq
      stack[0]: bool if Klutz is active
  create_monster_summary_from_team_member:
    value: 0x5b1a4
    doc: |-
      Creates a snapshot of the condition of a team_member struct in a monster_summary struct.

      r0: [output] monster_summary
      r1: team_member
      r2: bool is leader
  get_sos_mail_count:
    value: 0x5bcf8
    doc: |-
      Implements SPECIAL_PROC_GET_SOS_MAIL_COUNT (see ScriptSpecialProcessCall).

      r0: ?
      r1: some flag?
      return: SOS mail count
  is_mission_suspended_and_valid:
    value: 0x5cbd0
    doc: |-
      Checks if a mission is currently suspended and contains valid fields. Calls IsMissionValid for the validity check.

      r0: mission to check
      return: bool
  are_missions_equivalent:
    value: 0x5ccb0
    doc: |-
      Checks if two missions are equivalent.

      r0: mission1
      r1: mission2
      return: bool
  is_mission_valid:
    value: 0x5cdbc
    doc: |-
      Checks if a mission contains valid fields.

      For example, a mission will be considered invalid if the ID of the monsters or items involved are out of bounds, if their entries are marked as invalid, if the destination floor does not exist, etc.
      If the mission fails one of the checks, the game will print an error message explaining what is wrong using DebugPrint0.

      r0: mission to check
      return: True if the mission is valid, false if it's not.
  generate_mission:
    value: 0x5d5a0
    doc: |-
      Attempts to generate a random mission.

      r0: Pointer to something
      r1: Pointer to the struct where the data of the generated mission will be written to
      return: MISSION_GENERATION_SUCCESS if the mission was successfully generated, MISSION_GENERATION_FAILURE if it failed and MISSION_GENERATION_GLOBAL_FAILURE if it failed and the game shouldn't try to generate more.
  is_mission_type_special_episode:
    value: 0x5e5b4
    doc: |-
      Checks if a mission is for a Special Episode Transmission, which unlocks Special Episode 3. This specifically checks for a mission of type MISSION_SPECIAL_EPISODE and subtype 0x2.

      r0: mission pointer
      return: bool
  generate_daily_missions:
    value: 0x5e94c
    doc: |-
      Generates the missions displayed on the Job Bulletin Board and the Outlaw Notice Board.

      No params.
  already_have_mission:
    value: 0x5f014
    doc: |-
      Checks if a specified mission already exists in the Job List.

      r0: mission to check
      return: bool
  count_job_list_missions:
    value: 0x5f100
    doc: |-
      Gets the number of missions currently in the Job List.

      return: number of missions
  dungeon_requests_done:
    value: 0x5f120
    doc: |-
      Seems to return the number of missions completed.

      Part of the implementation for SPECIAL_PROC_DUNGEON_HAD_REQUEST_DONE (see ScriptSpecialProcessCall).

      r0: ?
      r1: some flag?
      return: number of missions completed
  dungeon_requests_done_wrapper:
    value: 0x5f18c
    doc: |-
      Calls DungeonRequestsDone with the second argument set to false.

      r0: ?
      return: number of mission completed
  any_dungeon_requests_done:
    value: 0x5f19c
    doc: |-
      Calls DungeonRequestsDone with the second argument set to true, and converts the integer output to a boolean.

      r0: ?
      return: bool: whether the number of missions completed is greater than 0
  add_mission_to_job_list:
    value: 0x5f434
    doc: |-
      Adds a mission to the Job List.

      r0: mission to add
  get_accepted_mission:
    value: 0x5f454
    doc: |-
      Gets the mission struct corresponding to a certain mission number in the player's job list.

      r0: mission id in player's job list
      return: mission struct pointer
  get_mission_by_type_and_dungeon:
    value: 0x5f728
    doc: |-
      Returns the position on the mission list of the first mission of the specified type that takes place in the specified dungeon.

      If the type of the mission has a subtype, the subtype of the checked mission must match the one in [r2] too for it to be returned.

      r0: Position on the mission list where the search should start. Missions before this position on the list will be ignored.
      r1: Mission type
      r2: Pointer to some struct that contains the subtype of the mission to check on its first byte
      r3: Dungeon ID
      return: Index of the first mission that meets the specified requirements, or -1 if there aren't any missions that do so.
  check_accepted_mission_by_type_and_dungeon:
    value: 0x5f820
    doc: |-
      Returns true if there are any accepted missions on the mission list that are of the specified type and take place in the specified dungeon.

      If the type of the mission has a subtype, the subtype of the checked mission must match the one in [r2] too for it to be returned.

      r0: Mission type
      r1: Pointer to some struct that contains the subtype of the mission to check on its first byte
      r2: Dungeon ID
      return: True if at least one mission meets the specified requirements, false otherwise.
  get_all_possible_monsters:
    value: 0x5fab4
    doc: |-
      Stores MISSION_MONSTER_LIST_PTR into the passed buffer and retrieves the number of monsters that can be used in a mission.

      r0: buffer
      return: Number of monsters usable for a mission
  generate_all_possible_monsters_list:
    value: 0x5fad4
    doc: |-
      Attempts to add monster IDs 1 (Bulbasaur) through 535 (Shaymin Sky) as entries to a heap-allocated list.

      If no monsters are valid mission targets, the heap-allocated list is freed. Otherwise, sets MISSION_MONSTER_LIST_PTR and MISSION_MONSTER_COUNT.

      return: Number of monsters usable for a mission
  delete_all_possible_monsters_list:
    value: 0x5fb40
    doc: |-
      If MISSION_MONSTER_LIST_PTR is not null, frees its heap-allocated list and nulls MISSION_MONSTER_LIST_PTR and MISSION_MONSTER_COUNT.

      No params.
  generate_all_possible_dungeons_list:
    value: 0x5fb70
    doc: |-
      Attempts to add dungeon IDs 1 (DUNGEON_TEST_DUNGEON) through 179 (DUNGEON_RESCUE) as entries to a heap-allocated list.

      If no dungeons are valid mission targets, the heap-allocated list is freed. Otherwise, sets MISSION_DUNGEON_LIST_PTR and MISSION_DUNGEON_COUNT.

      return: Number of dungeons usable for a mission
  delete_all_possible_dungeons_list:
    value: 0x5fc1c
    doc: |-
      If MISSION_DUNGEON_LIST_PTR is not null, frees its heap-allocated list and nulls MISSION_DUNGEON_LIST_PTR and MISSION_DUNGEON_COUNT.

      No params.
  generate_all_possible_deliver_list:
    value: 0x5fc4c
    doc: |-
      Attempts to add all items in ITEM_DELIVERY_TABLE as entries to a heap-allocated list.

      If no items are valid for a delivery mission, the heap-allocated list is freed. Otherwise, sets MISSION_DELIVER_LIST_PTR and MISSION_DELIVER_COUNT.

      return: Number of deliverable items for a mission
  delete_all_possible_deliver_list:
    value: 0x5fc88
    doc: |-
      If MISSION_DELIVER_LIST_PTR is not null, frees its heap-allocated list and nulls MISSION_DELIVER_LIST_PTR and MISSION_DELIVER_COUNT.

      No params.
  clear_mission_data:
    value: 0x5fd34
    doc: |-
      Given a mission struct, clears some of its fields.

      In particular, mission::status is set to mission_status::MISSION_STATUS_INVALID, mission::dungeon_id is set to -1, mission::floor is set to 0 and mission::reward_type is set to mission_reward_type::MISSION_REWARD_MONEY.

      r0: Pointer to the mission to clear
  generate_mission_details_struct:
    value: 0x604cc
    doc: |-
      Generates a mission_details struct, to be used for printing mission details such as the title, summary, and objective.

      r0: mission struct pointer
      r1: [output] mission_details struct pointer
      r2: ?
      r3: ?
  validate_normal_challenge_mission:
    value: 0x60b80
    doc: |-
      Validates a normal (non-legendary) challenge letter mission by checking whether its client (leader), target (second member), and outlaw_backup_species (third member) match those of some mission_rescue_bin struct (alongside some other conditions).

      r0: mission_template struct pointer
      r1: mission struct pointer
      return: bool
  validate_legendary_challenge_mission:
    value: 0x60c80
    doc: |-
      Validates a legendary challenge letter mission by checking whether its dungeon matches the restricted dungeon of some mission_rescue_bin struct (alongside some other conditions).

      r0: mission_template struct pointer
      r1: mission struct pointer
      return: bool
  append_mission_title:
    value: 0x60d8c
    doc: |-
      Generates the mission title of a mission, and appends it to the string location.

      r0: [output] output buffer
      r1: intermediate buffer, filled then concatenated to output buffer
      r2: pointer to preprocessor args
      r3: pointer to mission_details struct
  append_mission_summary:
    value: 0x61230
    doc: |-
      Generates the mission title of a mission, and appends it to the string location.

      r0: [output] main string location
      r1: temporary string buffer, concatenated to main string
      r2: window_id for DrawTextInWindow
      r3: y offset for DrawTextInWindow
      stack[0]: pointer to preprocessor args
      stack[1]: pointer to mission_details struct
  is_monster_mission_allowed:
    value: 0x62d90
    doc: |-
      Checks if the specified monster is contained in the MISSION_BANNED_MONSTERS array.

      The function converts the ID by calling GetBaseForm and FemaleToMaleForm first.

      r0: Monster ID
      return: False if the monster ID (after converting it) is contained in MISSION_BANNED_MONSTERS, true if it isn't.
  can_monster_be_used_for_mission_wrapper:
    value: 0x62dd4
    doc: |-
      Calls CanMonsterBeUsedForMission with r1 = 1.

      r0: Monster ID
      return: Result of CanMonsterBeUsedForMission
  can_monster_be_used_for_mission:
    value: 0x62de4
    doc: |-
      Returns whether a certain monster can be used (probably as the client or as the target) when generating a mission.

      Excluded monsters include those that haven't been fought in dungeons yet, the second form of certain monsters and, if PERFOMANCE_PROGRESS_FLAG[9] is 0, monsters in MISSION_BANNED_STORY_MONSTERS, the species of the player and the species of the partner.

      r0: Monster ID
      r1: True to exclude monsters in the MISSION_BANNED_MONSTERS array, false to allow them
      return: True if the specified monster can be part of a mission
  is_monster_mission_allowed_story:
    value: 0x62e60
    doc: |-
      Checks if the specified monster should be allowed to be part of a mission (probably as the client or the target), accounting for the progress on the story.

      If PERFOMANCE_PROGRESS_FLAG[9] is true, the function returns true.
      If it isn't, the function checks if the specified monster is contained in the MISSION_BANNED_STORY_MONSTERS array, or if it corresponds to the ID of the player or the partner.

      The function converts the ID by calling GetBaseForm and FemaleToMaleForm first.

      r0: Monster ID
      return: True if PERFOMANCE_PROGRESS_FLAG[9] is true, false if it isn't and the monster ID (after converting it) is contained in MISSION_BANNED_STORY_MONSTERS or if it's the ID of the player or the partner, true otherwise.
  is_monster_illegal_for_missions:
    value: 0x62ee0
    doc: |-
      Checks if the monster index is illegal to be used for any mission.

      Illegal indexes include Shaymin-Sky, Giratina-Origin, Purple Kecleon, Shiny Celebi, Primal Dialga, and all the unused Arceus forms.

      r0: Monster ID
      return: True if the specified monster is illegal for missions
  can_dungeon_be_used_for_mission:
    value: 0x62f34
    doc: |-
      Returns whether a certain dungeon can be used when generating a mission.

      Excluded dungeons include DUNGEON_ICE_AEGIS_CAVE, DUNGEON_DESTINY_TOWER, all Special Episode dungeons, dungeons with IDs greater than 174 (DUNGEON_STAR_CAVE), DUNGEON_CRYSTAL_CAVE and DUNGEON_CRYSTAL_CROSSING if PERFORMANCE_PROGRESS_LIST[9] is false, and any dungeon that does not have a dungeon mode of DMODE_OPEN_AND_REQUEST.

      r0: Dungeon ID
      return: True if the specified dungeon can be part of a mission
  can_send_item:
    value: 0x63158
    doc: |-
      Returns whether a certain item can be sent to another player via Wonder Mail.

      r0: item ID
      r1: to_sky
      return: bool
  is_available_item:
    value: 0x637d8
    doc: |-
      Checks if a certain item is valid to be used in delivery missions. 

      Validity entails a loop throughout all dungeons, checking if they have been visited before (via a call to GetMaxReachedFloor), and checking if the item is available within a dungeon's group (via a call to IsItemAvailableInDungeonGroup).

      r0: item ID
      return: bool
  get_available_item_delivery_list:
    value: 0x63824
    doc: |-
      Iterates through ITEM_DELIVERY_TABLE and checks if each entry is valid to be used in delivery missions.

      r0: item_buffer
      return: Number of deliverable items for a mission
  get_actor_matching_storage_id:
    value: 0x65d14
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: actor_id
      return: storage ID
  set_actor_talk_main_and_actor_talk_sub:
    value: 0x65eb8
    doc: |-
      Sets ACTOR_TALK_MAIN and ACTOR_TALK_SUB to given actor IDs.

      r0: actor_id for ACTOR_TALK_MAIN
      r1: actor_id for ACTOR_TALK_SUB
  set_actor_talk_main:
    value: 0x65ecc
    doc: |-
      Sets ACTOR_TALK_MAIN to be actor_id.
      Implements SPECIAL_PROC_SET_ACTOR_TALK_MAIN (see ScriptSpecialProcessCall).

      r0: actor_id
  set_actor_talk_sub:
    value: 0x65edc
    doc: |-
      Sets ACTOR_TALK_SUB to be actor_id.
      Implements SPECIAL_PROC_SET_ACTOR_TALK_SUB (see ScriptSpecialProcessCall).

      r0: actor_id
  randomize_demo_actors:
    value: 0x65fc4
    doc: |-
      Randomly picks one of the 18 teams from DEMO_TEAMS and sets ENTITY_NPC_DEMO_HERO and ENTITY_NPC_DEMO_PARTNER
      to the randomly selected hero and partner.
      Implements SPECIAL_PROC_RANDOMIZE_DEMO_ACTORS (see ScriptSpecialProcessCall).

      No params.
  item_at_table_idx:
    value: 0x66074
    doc: |-
      Gets info about the item at a given item table (not sure what this table is...) index.

      Used by SPECIAL_PROC_COUNT_TABLE_ITEM_TYPE_IN_BAG and friends (see ScriptSpecialProcessCall).

      r0: table index
      r1: [output] pointer to an owned_item
  main_loop:
    value: 0x66098
    doc: |-
      This function gets called shortly after the game is started. Contains a single infinite loop and has no return statement.

      No params.
  create_job_summary:
    value: 0x69b98
    doc: |-
      Creates a window containing a summary of a specific mission on the Top Screen.

      r0: mission pointer
      r1: ?
  dungeon_swap_id_to_idx:
    value: 0x6aaac
    doc: |-
      Converts a dungeon ID to its corresponding index in DUNGEON_SWAP_ID_TABLE, or -1 if not found.

      r0: dungeon ID
      return: index
  dungeon_swap_idx_to_id:
    value: 0x6aae8
    doc: |-
      Converts an index in DUNGEON_SWAP_ID_TABLE to the corresponding dungeon ID, or DUNGEON_DUMMY_0xFF if the index is -1.

      r0: index
      return: dungeon ID
  get_dungeon_mode_special:
    value: 0x6ab04
    doc: |-
      Returns the status of the given dungeon, with some modifications.

      If the dungeon ID is DUNGEON_BEACH, returns DMODE_REQUEST.
      If it's DUNGEON_JOINED_AT_UNKNOWN, returns DMODE_OPEN_AND_REQUEST.
      If it's >= DUNGEON_NORMAL_FLY_MAZE and <= DUNGEON_DOJO_0xD3, returns DMODE_OPEN_AND_REQUEST.
      Else, calls GetDungeonMode and returns DMODE_REQUEST if the dungeon has been cleared, or DMODE_OPEN if it's not.

      r0: Dungeon ID
      return: Dungeon mode
