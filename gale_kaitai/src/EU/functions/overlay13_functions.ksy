doc: List of functions within OVERLAY13 with relative address locations as their values.
meta:
  id: overlay13_functions
  endian: le
instances:
  entry_overlay13:
    value: 0x0
    doc: |-
      Main function of this overlay.

      Note: unverified, ported from Irdkwia's notes

      No params.
  exit_overlay13:
    value: 0x50
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  overlay13_switch_function_na238_a1_c8:
    value: 0x88
    doc: |-
      Handles the 'return' value from MENU_PERSONALITY_TEST called by scripts. 

      return: int?
  overlay13_switch_function_na238_a574:
    value: 0x434
    doc: |-
      Handles the menus and dialogue boxes associated with the personality quiz.

      No params.
  get_personality:
    value: 0x1c68
    doc: |-
      Returns the personality obtained after answering all the questions.

      The value to return is determined by checking the points obtained for each the personalities and returning the one with the highest amount of points.

      return: Personality (0-15)
  get_option_string_from_id:
    value: 0x1cb0
    doc: |-
      Note: unverified, ported from Irdkwia's notes. The first parameter and the return value point to the same string (which is passed directly into PreprocessString as the first argument), so I'm not sure why they're named differently... Seems like a mistake?

      r0: menu_id
      r1: option_id
      return: process
  wait_for_next_step:
    value: 0x1d0c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: switch_case
