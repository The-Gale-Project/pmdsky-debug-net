doc: List of functions within OVERLAY11 with relative address locations as their values.
meta:
  id: overlay11_functions
  endian: le
instances:
  init_script_routine_state:
    value: 0x5f0
    doc: |-
      Initializes the various fields of script_routine_state, a struct that seems relevant when handling script opcode operations.

      r0: script_routine_state pointer
  init_script_routine:
    value: 0x6a8
    doc: |-
      Initializes the various fields of script_routine.

      r0: routine pointer
      r1: ground entity function table pointer
      r2: live entity pointer
  lock_routine:
    value: 0xcac
    doc: |-
      Sets a routine to be locked via the Lock opcode.

      r0: script routine pointer
      r1: lock id
      return: Always 1, but this does seem to get checked in RunNextOpcode for some reason
  unlock_routine:
    value: 0xeac
    doc: |-
      Attempts to unlock a script routine via the Unlock opcode.

      r0: script routine pointer
      r1: lock id
      return: True if the script routine was successfully unlocked
  unlock_scripting_lock:
    value: 0xef0
    doc: |-
      Unlocks a scripting lock.

      Sets the corresponding byte to 1 on LOCK_NOTIFY_ARRAY to signal that the scripting engine should handle the unlock. Also sets a global unlock flag, used to tell the scripting engine that the state of locks have changed and they should be checked again.

      r0: ID of the lock to unlock
  func_that_calls_run_next_opcode:
    value: 0xf24
    doc: |-
      Called up to 16 times per frame. Exact purpose unknown.

      r0: script routine pointer
  run_next_opcode:
    value: 0x1b24
    doc: |-
      Runs the next scripting opcode.

      Contains a switch statement based on the routine's next opcode to run.

      r0: script routine pointer
      return: status
  get_ssb_string:
    value: 0x8008
    doc: |-
      Returns a string from a given SSB runtime struct.

      r0: ssb runtime info pointer
      r1: idx
  handle_unlocks:
    value: 0x8110
    doc: |-
      Checks if a script unlock happened by reading entries from LOCK_NOTIFY_ARRAY and handles the ones that were set.

      If the global unlock flag is not set, returns immediately. If it is, the function loops LOCK_NOTIFY_ARRAY, checking for true values. If it finds one, resets it back to 0 and handles the unlock.

      No params.
  script_case_process:
    value: 0x81a8
    doc: |-
      Calculates the next opcode address for a script routine as the result of a switch-statement.

      r0: script routine pointer
      r1: case id
      return: Next opcode address for the routine to execute
  load_file_from_rom_veneer:
    value: 0x849c
    doc: |-
      Likely a linker-generated veneer for LoadFileFromRom.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: [output] pointer to an IO struct {ptr, len}
      r1: file path string pointer
      r2: flags
  ssb_load2:
    value: 0x84bc
  script_param_to_int:
    value: 0x866c
    doc: |-
      Converts the given opcode parameter to a signed integer.

      The parameter will be returned unchanged unless one of its two most significant bits (0x8000 and 0x4000) are set, in which case both bits will be cleared and the original value will be modified according to the following two rules:
      - If the 0x4000 bit is set (sign bit), the value will be set to -16384 + value.
      - If the 0x8000 bit is set (fixed-point flag), the value will be set to value / 256, rounded down.
      Both rules can be applied, in the same order as listed, if both conditions are met.

      r0: Parameter to convert
      return: The input parameter, as a signed integer
  script_param_to_fixed_point16:
    value: 0x86a0
    doc: |-
      Converts the given opcode parameter to a 16-bit signed fixed-point number with 8 fraction bits.

      The resulting number is encoded as (value) * 256, with the last byte acting as a fraction byte capable of representing multiples of 1/256.

      The parameter will either be returned unchanged or modified depending on which of its two most significant bits (0x8000 and 0x4000) are set. Both bits are unset before running the operations listed below:
      - If the 0x4000 bit is set (sign bit), the value will be set to -16384 + value.
      - If the 0x8000 bit is set (fixed-point flag), the raw value is interpreted as being fixed-point already, and nothing else happens. Otherwise, it's assumed to be a normal integer and is converted to fixed-point by left-shifting it by 8 (moving the integer part to its proper place).
      Both rules can be applied, in the same order as listed, if both conditions are met.

      r0: Parameter to convert
      return: The input parameter, as a 16-bit signed fixed-point number with 8 fraction bits
  station_load_hanger:
    value: 0x8994
  script_station_load_talk:
    value: 0x91a4
  ssb_load1:
    value: 0x9b10
  script_special_process_call:
    value: 0xaed8
    doc: |-
      Processes calls to the OPCODE_PROCESS_SPECIAL script opcode.

      r0: some struct containing a callback of some sort, only used for special process ID 18
      r1: special process ID
      r2: first argument, if relevant? Probably corresponds to the second parameter of OPCODE_PROCESS_SPECIAL
      r3: second argument, if relevant? Probably corresponds to the third parameter of OPCODE_PROCESS_SPECIAL
      return: return value of the special process if it has one, otherwise 0
  get_coroutine_info:
    value: 0xbd78
    doc: |-
      Returns information about a coroutine in unionall

      It's used by the CallCommon code to pull the data required to call the coroutine, so maybe the function returns data required to call a coroutine instead of info about the coroutine itself.

      r0: [output] Coroutine info
      r1: Coroutine ID
      return: True if the coroutine is valid? It's false only if the coroutine's offset is 0.
  get_special_recruitment_species:
    value: 0xbdfc
    doc: |-
      Returns an entry from RECRUITMENT_TABLE_SPECIES.

      Note: This indexes without doing bounds checking.

      r0: index into RECRUITMENT_TABLE_SPECIES
      return: enum monster_id
  prepare_menu_accept_team_member:
    value: 0xbe40
    doc: |-
      Implements SPECIAL_PROC_PREPARE_MENU_ACCEPT_TEAM_MEMBER (see ScriptSpecialProcessCall).

      r0: index into RECRUITMENT_TABLE_SPECIES
  init_random_npc_jobs:
    value: 0xbee4
    doc: |-
      Implements SPECIAL_PROC_INIT_RANDOM_NPC_JOBS (see ScriptSpecialProcessCall).

      r0: job type? 0 is a random NPC job, 1 is a bottle mission
      r1: ?
  get_random_npc_job_type:
    value: 0xbf7c
    doc: |-
      Implements SPECIAL_PROC_GET_RANDOM_NPC_JOB_TYPE (see ScriptSpecialProcessCall).

      return: job type?
  get_random_npc_job_subtype:
    value: 0xbf94
    doc: |-
      Implements SPECIAL_PROC_GET_RANDOM_NPC_JOB_SUBTYPE (see ScriptSpecialProcessCall).

      return: job subtype?
  get_random_npc_job_still_available:
    value: 0xbfb0
    doc: |-
      Implements SPECIAL_PROC_GET_RANDOM_NPC_JOB_STILL_AVAILABLE (see ScriptSpecialProcessCall).

      return: bool
  accept_random_npc_job:
    value: 0xc018
    doc: |-
      Implements SPECIAL_PROC_ACCEPT_RANDOM_NPC_JOB (see ScriptSpecialProcessCall).

      return: bool
  ground_main_loop:
    value: 0xc534
    doc: |-
      Appears to be the main loop for ground mode.

      Based on debug print statements and general code structure, it seems contain a core loop, and dispatches to various functions in response to different events.

      r0: mode, which is stored globally and used in switch statements for dispatch
      return: return code
  get_alloc_arena_ground:
    value: 0xd11c
    doc: |-
      The GetAllocArena function used for ground mode. See SetMemAllocatorParams for more information.

      For (flags & 0xFF):
        8, 15, 16: GROUND_MEMORY_ARENA_1
        14: GROUND_MEMORY_ARENA_2
        other: null (default arena)

      r0: initial memory arena pointer, or null
      r1: flags (see MemAlloc)
      return: memory arena pointer, or null
  get_free_arena_ground:
    value: 0xd180
    doc: |-
      The GetFreeArena function used for ground mode. See SetMemAllocatorParams for more information.

      r0: initial memory arena pointer, or null
      r1: pointer to free
      return: memory arena pointer, or null
  ground_main_return_dungeon:
    value: 0xd1d4
    doc: |-
      Implements SPECIAL_PROC_RETURN_DUNGEON (see ScriptSpecialProcessCall).

      No params.
  ground_main_next_day:
    value: 0xd1f8
    doc: |-
      Implements SPECIAL_PROC_NEXT_DAY (see ScriptSpecialProcessCall).

      No params.
  jump_to_title_screen:
    value: 0xd39c
    doc: |-
      Implements SPECIAL_PROC_JUMP_TO_TITLE_SCREEN and SPECIAL_PROC_0x1A (see ScriptSpecialProcessCall).

      r0: int, argument value for SPECIAL_PROC_JUMP_TO_TITLE_SCREEN and -1 for SPECIAL_PROC_0x1A
      return: bool (but note that the special process ignores this and always returns 0)
  return_to_title_screen:
    value: 0xd454
    doc: |-
      Implements SPECIAL_PROC_RETURN_TO_TITLE_SCREEN (see ScriptSpecialProcessCall).

      r0: fade duration
      return: bool (but note that the special process ignores this and always returns 0)
  script_special_process0x16:
    value: 0xd4b4
    doc: |-
      Implements SPECIAL_PROC_0x16 (see ScriptSpecialProcessCall).

      r0: bool
  is_screen_fade_in_progress:
    value: 0xdd38
    doc: |-
      Used for example in the handler functions of the top screen types in ground mode to check whether the top screen fade is complete or not.

      return: True if the top screen is still fading, false if it's done fading.
  load_background_attributes:
    value: 0xf900
    doc: |-
      Open and read an entry from the MAP_BG/bg_list.dat

      Documentation on this format can be found here:
      https://github.com/SkyTemple/skytemple-files/tree/55b3017631a8a1b0f106111ef91a901dc394c6df/skytemple_files/graphics/bg_list_dat

      r0: [output] The entry
      r1: background ID
  load_map_type10:
    value: 0x10ae4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: [output] buffer_ptr
      r1: map_id
      r2: dungeon_info_str
      r3: additional_info
  load_map_type11:
    value: 0x11004
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: [output] buffer_ptr
      r1: map_id
      r2: dungeon_info_str
      r3: additional_info
  get_special_layout_background:
    value: 0x15380
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: bg_id
      r1: dungeon_info_str
      r2: additional_info
      r3: copy_fixed_room_layout
  set_anim_data_fields:
    value: 0x1863c
    doc: |-
      Sets some fields on the animation struct?

      r0: animation pointer
      r1: ?
  set_anim_data_fields_wrapper:
    value: 0x1877c
    doc: Calls SetAnimDataFields with the second argument right-shifted by 16.
  init_anim_data_from_other_anim_data:
    value: 0x18a84
    doc: |-
      Appears to partially copy some animation data into another animation struct, plus doing extra initialization on the destination struct.

      r0: dst
      r1: src
  set_anim_data_fields2:
    value: 0x19108
    doc: |-
      Sets some fields on the animation struct, based on the params?

      r0: animation pointer
      r1: flags
      r2: ?
  get_idle_animation_type:
    value: 0x19b70
    doc: |-
      Given a monster species, returns the type of idle animation it should have.

      Possible values are "freeze animation #0" (0x300), "loop animation #7" (0x807) and "freeze animation #7" (0x307).

      r0: Monster ID
      r1: (?) Could contain data about the animation the monster is currently playing
      return: Animation data
  load_object_anim_data:
    value: 0x1ac80
    doc: |-
      Loads the animation (WAN) data for a given object index?

      r0: animation pointer
      r1: object index
      r2: flags
  init_anim_data_from_other_anim_data_veneer:
    value: 0x1ad28
    doc: |-
      Likely a linker-generated veneer for InitAnimDataFromOtherAnimData.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: dst
      r1: src
  unlock_main_routine:
    value: 0x1b470
    doc: |-
      Unlocks the main routine of the current script, as specified in GROUND_STATE_PTRS::main_routine.

      r0: lock id
      return: True if the script routine was successfully unlocked
  alloc_and_init_partner_follow_data_and_live_actor_list:
    value: 0x1badc
    doc: |-
      Allocate and initialize the partner follow data and the live actor list (in GROUND_STATE_PTRS)

      No params.
  init_partner_follow_data_and_live_actor_list:
    value: 0x1bb38
    doc: |-
      Initialize the partner follow data and the live actor list (in GROUND_STATE_PTRS, doesn't perform the allocation of the structures)

      No params.
  get_live_actor_idx_from_script_entity_id:
    value: 0x1bc30
    doc: |-
      Searches through the live actor list to find the first matching actor who has an ID matching that of a script_entity_id.

      r0: script_entity_id
      return: index of the live actor, or -1 if the specified actor could not be found
  delete_live_actor:
    value: 0x1c398
    doc: |-
      Remove the actor from the actor list (in GROUND_STATE_PTRS)

      r0: the index of the actor in the live actor list
  set_attribute_bitfield_live_actor:
    value: 0x1c54c
    doc: |-
      Sets bits of the attribute bitfield of a currently loaded actor.

      r0: live actor id
      r1: attribute bitfield
  reset_attribute_bitfield_live_actor:
    value: 0x1c5d8
    doc: |-
      Clears bits of the attribute bitfield of a currently loaded actor.

      r0: live actor id
      r1: attribute bitfield
  unlock_actor_routines:
    value: 0x1ce38
    doc: |-
      Attempts to unlock all live actor routines of the current script.

      r0: lock id
      return: True if any script routine was successfully unlocked
  get_colliding_actor_id:
    value: 0x1cfa0
    doc: |-
      Returns the first colliding actor given a series of vector coordinates.

      r0: live actor id (used only to ignore an actor colliding with itself)
      r1: attribute bitfield to test actors against
      r2: pointer to coord_min
      r3: pointer to coord_max
      return: The first colliding actor's id, or -1 if no is collision detected
  change_actor_animation:
    value: 0x1d1e8
    doc: |-
      Used by the SetAnimation opcode to change the animation of an actor.

      It's responsible for breaking down the SetAnimation parameter and determining which animation to play and which flags to set.

      r0: live actor
      r1: SetAnimation parameter
  set_position_live_actor:
    value: 0x1d348
    doc: |-
      Sets the position for a currently loaded actor.

      r0: live actor
      r1: pointer to a position vector
  get_id_live_actor:
    value: 0x1e824
    doc: |-
      Returns the ID of a currently loaded actor. This ID can then be used to index GROUND_STATE_PTRS::actors.

      r0: live actor
      return: id
  get_collision_box_live_actor:
    value: 0x1e82c
    doc: |-
      Gets the collision box of a currently loaded actor.

      r0: live actor
      r1: [output] collision box buffer
  set_position_initial_live_actor:
    value: 0x1e840
    doc: |-
      Sets a currently loaded actor to return to its initial position.

      r0: live actor
      r1: pointer to an position vector; if null, actor will return to its initial position
  set_movement_range_live_actor:
    value: 0x1e8fc
    doc: |-
      Sets a currently loaded actor's random movement range.

      r0: live actor
      r1: pointer to limit_min_pos
      r2: pointer to limit_max_pos
  get_collision_box_center_live_actor:
    value: 0x1e920
    doc: |-
      Gets the center of a collision box of a currently loaded actor.

      This simply adds the actor's minimum coordinates by half the size of the actor's collision box.

      r0: live actor
      r1: [output] collision box center buffer
  set_position_live_actor_veneer:
    value: 0x1e944
    doc: |-
      Likely a linker-generated veneer for SetPositionLiveActor.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: live actor
      r1: pointer to a position vector
  get_height_live_actor:
    value: 0x1e950
    doc: |-
      Gets the two height values of a currently loaded actor.

      r0: live actor
      r1: [output] pointer to first height value
      r2: [output] pointer to second height value, which is curiously not referenced by SetHeightLiveActor
  set_height_live_actor:
    value: 0x1e964
    doc: |-
      Sets the height of a currently loaded actor.

      r0: live actor
      r1: height
  get_direction_live_actor:
    value: 0x1e96c
    doc: |-
      Gets the direction of a currently loaded actor.

      r0: live actor
      r1: [output] pointer to direction
  set_direction_live_actor:
    value: 0x1e97c
    doc: |-
      Sets the direction of a currently loaded actor. Does nothing if the direction value passed is -1.

      r0: live actor
      r1: direction
  set_animation_live_actor:
    value: 0x1e9a4
    doc: |-
      Sets the animation of a currently loaded actor. Leads up to a final ChangeActorAnimation call.

      Includes a check for if live_actor::id is less than 3 and if live_actor::field_0xa is equal to 0x119, which ultimately may perform ((SetAnimation parameter) & 0x1f00 | 0x53).

      r0: live actor
      r1: SetAnimation parameter
  set_effect_live_actor:
    value: 0x1e9f0
    doc: |-
      Sets the effect of a currently loaded actor.

      r0: live actor
      r1: flag (true if effect id is 0?)
      r2: effect id
      r3: effect position marker
  get_animation_status_live_actor:
    value: 0x1ea04
    doc: |-
      Gets the animation status of a currently loaded actor.

      Used to determine if the animation has finished via script opcodes like WaitAnimation and WaitEndAnimation.

      r0: live actor
      return: status
  get_effect_status_live_actor:
    value: 0x1ea24
    doc: |-
      Gets the effect status of a currently loaded actor.

      Used to determine if an effect has finished via the script opcode WaitEffect.

      r0: live actor
      return: status
  get_attribute_bitfield_live_actor:
    value: 0x1ea48
    doc: |-
      Gets the attribute bitfield of a currently loaded actor.

      r0: live actor
      r1: [output] pointer to attribute bitfield
  set_attribute_bitfield_live_actor_wrapper:
    value: 0x1ea54
    doc: |-
      Sets bits of the attribute bitfield of a currently loaded actor.

      Is a wrapper around SetAttributeBitfieldLiveActor, meaning this calls SetAttributeBitfieldLiveActor with a first parameter of live_actor::id.

      r0: live actor
      r1: attribute bitfield
  reset_attribute_bitfield_live_actor_wrapper:
    value: 0x1ea64
    doc: |-
      Clears bits of the attribute bitfield of a currently loaded actor.

      Is a wrapper around ResetAttributeBitfieldLiveActor, meaning this calls ResetAttributeBitfieldLiveActor with a first parameter of live_actor::id.

      r0: live actor
      r1: attribute bitfield
  set_blink_live_actor:
    value: 0x1ea74
    doc: |-
      Sets the actor to blink in and out of sight at certain intervals.

      r0: live actor
      r1: frame interval for blinking in
      r2: frame interval for blinking out
  set_position_offset_live_actor:
    value: 0x1ea84
    doc: |-
      Offsets a currently loaded actor's position.

      r0: live actor
      r1: pointer to an position offset vector
  init_partner_follow_data:
    value: 0x1f848
    doc: |-
      Initialize the partner follow data structure, without allocating it (in GROUND_STATE_PTRS)

      No params.
  delete_live_object:
    value: 0x2026c
    doc: |-
      Remove the object from the object list (in GROUND_STATE_PTRS)

      r0: the index of the object in the live object list
  set_attribute_bitfield_live_object:
    value: 0x20418
    doc: |-
      Sets bits of the attribute bitfield of a currently loaded object.

      r0: live object id
      r1: attribute bitfield
  reset_attribute_bitfield_live_object:
    value: 0x20458
    doc: |-
      Clears bits of the attribute bitfield of a currently loaded object.

      r0: live object id
      r1: attribute bitfield
  unlock_object_routines:
    value: 0x20a64
    doc: |-
      Attempts to unlock all live object routines of the current script.

      r0: lock id
      return: True if any script routine was successfully unlocked
  get_colliding_object_id:
    value: 0x20b38
    doc: |-
      Returns the first colliding object given a series of vector coordinates.

      r0: attribute bitfield to test objects against
      r1: pointer to coord_min
      r2: pointer to coord_max
      return: The first colliding object's id, or -1 if no is collision detected
  set_position_live_object:
    value: 0x20d90
    doc: |-
      Sets the position for a currently loaded object.

      r0: live object
      r1: pointer to a position vector
  get_id_live_object:
    value: 0x20e80
    doc: |-
      Returns the ID of a currently loaded object. This ID can then be used to index GROUND_STATE_PTRS::objects.

      r0: live object
      return: id
  get_collision_box_live_object:
    value: 0x20e88
    doc: |-
      Gets the collision box of a currently loaded object.

      r0: live object
      r1: [output] collision box buffer
  set_position_initial_live_object:
    value: 0x20e9c
    doc: |-
      Sets a currently loaded object to return to its initial position.

      r0: live object
      r1: pointer to an position vector; if null, object will return to its initial position
  set_movement_range_live_object:
    value: 0x20f58
    doc: |-
      Sets a currently loaded object's random movement range.

      r0: live object
      r1: pointer to limit_min_pos
      r2: pointer to limit_max_pos
  get_collision_box_center_live_object:
    value: 0x20f7c
    doc: |-
      Gets the center of a collision box of a currently loaded object.

      This simply adds the object's minimum coordinates by half the size of the object's collision box.

      r0: live object
      r1: [output] collision box center buffer
  set_position_live_object_veneer:
    value: 0x20fa0
    doc: |-
      Likely a linker-generated veneer for SetPositionLiveObject.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: live object
      r1: pointer to a position vector
  get_height_live_object:
    value: 0x20fac
    doc: |-
      Gets the two height values of a currently loaded object.

      r0: live object
      r1: [output] pointer to first height value
      r2: [output] pointer to second height value, which is curiously not referenced by SetHeightLiveObject
  set_height_live_object:
    value: 0x20fc0
    doc: |-
      Sets the height of a currently loaded object.

      r0: live object
      r1: height
  get_direction_live_object:
    value: 0x20fc8
    doc: |-
      Gets the direction of a currently loaded object.

      r0: live object
      r1: [output] pointer to direction
  set_direction_live_object:
    value: 0x20fd8
    doc: |-
      Sets the direction of a currently loaded object. Does nothing if the direction value passed is -1.

      r0: live object
      r1: direction
  set_animation_live_object:
    value: 0x20fe8
    doc: |-
      Sets the animation of a currently loaded object.

      r0: live object
      r1: SetAnimation parameter
  set_effect_live_object:
    value: 0x210a8
    doc: |-
      Sets the effect of a currently loaded object.

      r0: live object
      r1: flag (true if effect id is 0?)
      r2: effect id
  get_animation_status_live_object:
    value: 0x210b8
    doc: |-
      Gets the animation status of a currently loaded object.

      Used to determine if the animation has finished via script opcodes like WaitAnimation and WaitEndAnimation.

      r0: live object
      return: status
  get_effect_status_live_object:
    value: 0x210d8
    doc: |-
      Gets the effect status of a currently loaded object.

      Used to determine if an effect has finished via the script opcode WaitEffect.

      r0: live object
      return: status
  get_attribute_bitfield_live_object:
    value: 0x210fc
    doc: |-
      Gets the attribute bitfield of a currently loaded object.

      r0: live object
      r1: [output] pointer to attribute bitfield
  set_attribute_bitfield_live_object_wrapper:
    value: 0x21108
    doc: |-
      Sets bits of the attribute bitfield of a currently loaded object.

      Is a wrapper around SetAttributeBitfieldLiveObject, meaning this calls SetAttributeBitfieldLiveObject with a first parameter of live_object::id.

      r0: live object
      r1: attribute bitfield
  reset_attribute_bitfield_live_object_wrapper:
    value: 0x21118
    doc: |-
      Clears bits of the attribute bitfield of a currently loaded object.

      Is a wrapper around ResetAttributeBitfieldLiveObject, meaning this calls ResetAttributeBitfieldLiveObject with a first parameter of live_object::id.

      r0: live object
      r1: attribute bitfield
  set_blink_live_object:
    value: 0x21128
    doc: |-
      Sets the object to blink in and out of sight at certain intervals.

      r0: live object
      r1: frame interval for blinking in
      r2: frame interval for blinking out
  set_position_offset_live_object:
    value: 0x21138
    doc: |-
      Offsets a currently loaded object's position.

      r0: live object
      r1: pointer to an position offset vector
  delete_live_performer:
    value: 0x21a0c
    doc: |-
      Remove the performer from the performer list (in GROUND_STATE_PTRS)

      r0: the index of the performer in the live performer list
  set_attribute_bitfield_live_performer:
    value: 0x21bb8
    doc: |-
      Sets bits of the attribute bitfield of a currently loaded performer.

      r0: live performer id
      r1: attribute bitfield
  reset_attribute_bitfield_live_performer:
    value: 0x21bf8
    doc: |-
      Clears bits of the attribute bitfield of a currently loaded performer.

      r0: live performer id
      r1: attribute bitfield
  unlock_performer_routines:
    value: 0x22174
    doc: |-
      Attempts to unlock all live performer routines of the current script.

      r0: lock id
      return: True if any script routine was successfully unlocked
  set_position_live_performer:
    value: 0x22224
    doc: |-
      Sets the position for a currently loaded performer.

      r0: live performer
      r1: pointer to a position vector
  get_id_live_performer:
    value: 0x222b0
    doc: |-
      Returns the ID of a currently loaded performer. This ID can then be used to index GROUND_STATE_PTRS::performers.

      r0: live performer
      return: id
  get_collision_box_live_performer:
    value: 0x222b8
    doc: |-
      Gets the collision box of a currently loaded performer.

      r0: live performer
      r1: [output] collision box buffer
  set_position_initial_live_performer:
    value: 0x222cc
    doc: |-
      Sets a currently loaded performer to return to its initial position.

      r0: live performer
      r1: pointer to an position vector; if null, performer will return to its initial position
  set_movement_range_live_performer:
    value: 0x22388
    doc: |-
      Sets a currently loaded performer's random movement range.

      r0: live performer
      r1: pointer to limit_min_pos
      r2: pointer to limit_max_pos
  get_collision_box_center_live_performer:
    value: 0x223ac
    doc: |-
      Gets the center of a collision box of a currently loaded performer.

      This simply adds the performer's minimum coordinates by half the size of the performer's collision box.

      r0: live performer
      r1: [output] collision box center buffer
  set_position_live_performer_veneer:
    value: 0x223d0
    doc: |-
      Likely a linker-generated veneer for SetPositionLivePerformer.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: live performer
      r1: pointer to a position vector
  get_height_live_performer:
    value: 0x223dc
    doc: |-
      Gets the two height values of a currently loaded performer.

      r0: live performer
      r1: [output] pointer to first height value
      r2: [output] pointer to second height value, which is curiously not referenced by SetHeightLivePerformer
  set_height_live_performer:
    value: 0x223f0
    doc: |-
      Sets the height of a currently loaded performer.

      r0: live performer
      r1: height
  get_direction_live_performer:
    value: 0x223f8
    doc: |-
      Gets the direction of a currently loaded performer.

      r0: live performer
      r1: [output] pointer to direction
  set_direction_live_performer:
    value: 0x22408
    doc: |-
      Sets the direction of a currently loaded performer. Does nothing if the direction value passed is -1.

      r0: live performer
      r1: direction
  set_animation_live_performer:
    value: 0x22418
    doc: |-
      Sets the animation of a currently loaded performer.

      r0: live performer
      r1: SetAnimation parameter
  set_effect_live_performer:
    value: 0x224d8
    doc: |-
      Sets the effect of a currently loaded performer.

      r0: live performer
      r1: flag (true if effect id is 0?)
      r2: effect id
  get_animation_status_live_performer:
    value: 0x224e8
    doc: |-
      Gets the animation status of a currently loaded performer.

      Used to determine if the animation has finished via script opcodes like WaitAnimation and WaitEndAnimation.

      r0: live performer
      return: status
  get_effect_status_live_performer:
    value: 0x22508
    doc: |-
      Gets the effect status of a currently loaded performer.

      Used to determine if an effect has finished via the script opcode WaitEffect.

      r0: live performer
      return: status
  get_attribute_bitfield_live_performer:
    value: 0x22540
    doc: |-
      Gets the attribute bitfield of a currently loaded performer.

      r0: live performer
      r1: [output] pointer to attribute bitfield
  set_attribute_bitfield_live_performer_wrapper:
    value: 0x2254c
    doc: |-
      Sets bits of the attribute bitfield of a currently loaded performer.

      Is a wrapper around SetAttributeBitfieldLivePerformer, meaning this calls SetAttributeBitfieldLivePerformer with a first parameter of live_performer::id.

      r0: live performer
      r1: attribute bitfield
  reset_attribute_bitfield_live_performer_wrapper:
    value: 0x2255c
    doc: |-
      Clears bits of the attribute bitfield of a currently loaded performer.

      Is a wrapper around ResetAttributeBitfieldLivePerformer, meaning this calls ResetAttributeBitfieldLivePerformer with a first parameter of live_performer::id.

      r0: live performer
      r1: attribute bitfield
  set_blink_live_performer:
    value: 0x2256c
    doc: |-
      Sets the performer to blink in and out of sight at certain intervals.

      r0: live performer
      r1: frame interval for blinking in
      r2: frame interval for blinking out
  set_position_offset_live_performer:
    value: 0x2257c
    doc: |-
      Offsets a currently loaded performer's position.

      r0: live performer
      r1: pointer to an position offset vector
  delete_live_event:
    value: 0x22a88
    doc: |-
      Remove the event from the event list (in GROUND_STATE_PTRS)

      r0: the index of the event in the live event list
  get_colliding_event_id:
    value: 0x22c18
    doc: |-
      Returns the first colliding event given a series of vector coordinates.

      r0: attribute bitfield to test events against
      r1: pointer to coord_min
      r2: pointer to coord_max
      return: The first colliding event's id, or -1 if no is collision detected
  create_team_info_box:
    value: 0x22cb4
    doc: |-
      Creates a window containing team information (rank and money carried) for the top-level menu in ground mode. Also see struct team_info_box.

      The new window will always default to TEAM_INFO_BOX_DEFAULT_WINDOW_PARAMS.

      return: window_id
  close_team_info_box:
    value: 0x22d6c
    doc: |-
      Closes a window created with CreateTeamInfoBox.

      r0: window_id
  is_team_info_box_active:
    value: 0x22da4
    doc: |-
      This is a guess.

      Checks if the state of a team info box is not 5.

      r0: window_id
      return: bool
  update_team_info_box:
    value: 0x22dc4
    doc: |-
      Window update function for team info boxes.

      r0: window pointer
  create_top_ground_menu:
    value: 0x24ba4
    doc: |-
      Creates a parent menu (containing Items, Team, etc.) and two other windows upon pressing X in the overworld.

      return: always 1
  close_top_ground_menu:
    value: 0x24d10
    doc: |-
      Closes the three windows created by CreateOverworldMenu.

      No params.
  update_top_ground_menu:
    value: 0x24d6c
    doc: |-
      Window update function for the top-level ground mode menu.

      return: status code
  is_bag_not_empty:
    value: 0x288e0
    doc: |-
      Checks if the bag has at least one valid item. Notably used in CreateTopGroundMenu to decide if the "Items" option should be enabled.

      return: bool
  sprintf_static:
    value: 0x2cce8
    doc: |-
      Statically defined copy of sprintf(3) in overlay 11. See arm9.yml for more information.

      r0: str
      r1: format
      ...: variadic
      return: number of characters printed, excluding the null-terminator
  get_exclusive_item_requirements:
    value: 0x2ed54
    doc: |-
      Used to calculate the items required to get a certain exclusive item in the swap shop.

      r0: ?
      r1: ?
  handle_controls_top_screen_ground:
    value: 0x32434
    doc: |-
      Handles the controls top screen display in the overworld.

      For some reason the implementation seems considerably jankier in ground mode. In dungeon mode there's this structure for the top screen that has handlers for creating, updating and closing the various top screen layouts in a sort of polymorphic way. Here there's just a separate function for every layout that gets called every frame and seems to have a switch-case to handle everything about it.

      No params.
  get_dungeon_map_pos:
    value: 0x32b64
    doc: |-
      Checks if a dungeon should be displayed on the map and the position where it should be displayed if so.

      r0: [Output] Buffer where the coordinates of the map marker will be stored. The coordinates are shifted 8 bits to the left, so they are probably fixed-point numbers instead of integers.
      r1: Dungeon ID
      return: True if the dungeon should be displayed on the map, false otherwise.
  world_map_set_mode:
    value: 0x32e20
    doc: |-
      Function called by the script function "worldmap_SetMode"
      Define the mode of the world map, which can among other things be used to decide if the player character should appear on the world map
      The mode is set even if no world map is set

      r0: world map mode
  world_map_set_camera:
    value: 0x32ee0
    doc: |-
      Function called with the script function "worldmap_SetCamera".
      Set the map marker the world map should try to center on (while still ensuring it doesn't go over the background border)
      Has no effect if no map is currently set

      r0: map marker id
  status_update:
    value: 0x378f8
    doc: |-
      Implements SPECIAL_PROC_STATUS_UPDATE (see ScriptSpecialProcessCall).

      No params.
  handle_team_stats_ground:
    value: 0x3793c
    doc: |-
      Handles the team stats top screen display in the overworld.

      For some reason the implementation seems considerably jankier in ground mode. In dungeon mode there's this structure for the top screen that has handlers for creating, updating and closing the various top screen layouts in a sort of polymorphic way. Here there's just a separate function for every layout that gets called every frame and seems to have a switch-case to handle everything about it.

      No params.
