doc: List of functions within ARM7 with relative address locations as their values.
meta:
  id: arm7_functions
  endian: le
instances:
  start_arm7:
    value: 0x0
    doc: |-
      The entrypoint for the ARM7 CPU.

      Handles mapping the ARM7 binary into the various memory areas that the program will be using.

      Once the memory mapping has been completed, a constant containing the address to NitroSpMain is loaded into a register (r1), and a `bx` branch will jump to NitroSpMain.

      No params.
  do_autoload_arm7:
    value: 0x118
  start_autoload_done_callback_arm7:
    value: 0x188
  nitro_sp_main:
    value: 0x1e8
    doc: |-
      This main function for the ARM7 subsystem. Contains the main event loop.

      No params.
  hardware_interrupt:
    value: 0x3670
    doc: |-
      Called whenever a hardware interrupt takes place.

      Returns immediately if the IME flag is 0 or if none of the devices that requested an interrupt has the corresponding Interrupt Enable flag set.
      It searches for the first device that requested an interrupt, clears its Interrupt Request flag, then jumps to the start of the corresponding interrupt function. The return address is manually set to ReturnFromInterrupt.
      This function does not return.

      No params.
  return_from_interrupt:
    value: 0x36dc
    doc: |-
      The execution returns to this function after a hardware interrupt function is run.

      No params.
  audio_interrupt:
    value: 0x3824
    doc: |-
      Called when handling a hardware interrupt from the audio system.

      Its parameter is used to index a list of function pointers. The game then jumps to the read pointer.

      r0: Index of the function to jump to
  clear_ime_flag:
    value: 0x3ac0
    doc: |-
      Clears the Interrupt Master Enable flag, which disables all hardware interrupts.

      return: Previous IME value
  clear_ie_flag:
    value: 0x3b10
    doc: |-
      Clears the specified Interrupt Enable flag, which disables interrupts for the specified hardware component.

      r0: Flag to clear
      return: Previous value of the Interrupt Enable flags
  get_current_playback_time:
    value: 0x5404
    doc: |-
      Returns the time that the current song has been playing for. Might have a more generic purpose.

      The time is obtained using a couple of RAM counters and the hardware timers for additional precision.
      The game uses this value to know when a given note should stop being played. It doesn't seem to be used to keep track of the
      current time instant within the song.

      return: Playback time. Units unknown.
  clear_irq_flag:
    value: 0x5ed4
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      return: Old value of cpsr & 0x80 (0x80 if interrupts were disabled, 0x0 if they were already enabled)
  enable_irq_flag:
    value: 0x5ee8
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      return: Old value of cpsr & 0x80 (0x80 if interrupts were already disabled, 0x0 if they were enabled)
  set_irq_flag:
    value: 0x5efc
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      r0: Value to set the flag to (0x80 to set it, which disables interrupts; 0x0 to unset it, which enables interrupts)
      return: Old value of cpsr & 0x80 (0x80 if interrupts were disabled, 0x0 if they were enabled)
  enable_irq_fiq_flags:
    value: 0x5f14
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      return: Old value of cpsr & 0xC0 (contains the previous values of the i and f flags)
  set_irq_fiq_flags:
    value: 0x5f28
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      r0: Value to set the flags to (0xC0 to set both flags, 0x80 to set the i flag and clear the f flag, 0x40 to set the f flag and clear the i flag and 0x0 to clear both flags)
      return: Old value of cpsr & 0xC0 (contains the previous values of the i and f flags)
  get_processor_mode:
    value: 0x5f40
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      return: cpsr & 0x1f (the cpsr mode bits M4-M0)
  s32_div_f:
    value: 0xedb0
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      r0: dividend
      r1: divisor
      return: (quotient) | (remainder << 32)
  u32_div_f:
    value: 0xefbc
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      r0: dividend
      r1: divisor
      return: (quotient) | (remainder << 32)
  u32_div_not_0_f:
    value: 0xefc4
    doc: |-
      Copy of the ARM9 function. See arm9.yml for more information.

      r0: dividend
      r1: divisor
      return: (quotient) | (remainder << 32)
