doc: List of functions within OVERLAY29 with relative address locations as their values.
meta:
  id: overlay29_functions
  endian: le
instances:
  get_weather_color_table:
    value: 0x23e0
    doc: |-
      Gets a pointer to the floor's color table given the current weather.

      The returned table contains 1024 color entries.

      r0: Weather ID
      return: color table pointer
  dungeon_alloc:
    value: 0x281c
    doc: |-
      Allocates a new dungeon struct.

      This updates the master dungeon pointer and returns a copy of that pointer.

      return: pointer to a newly allocated dungeon struct
  get_dungeon_ptr_master:
    value: 0x2840
    doc: |-
      Returns the master dungeon pointer (a global, see DUNGEON_PTR_MASTER).

      return: pointer to a newly allocated dungeon struct
  dungeon_z_init:
    value: 0x2850
    doc: |-
      Zero-initializes the dungeon struct pointed to by the master dungeon pointer.

      No params.
  dungeon_free:
    value: 0x2870
    doc: |-
      Frees the dungeons struct pointer to by the master dungeon pointer, and nullifies the pointer.

      No params.
  run_dungeon:
    value: 0x2cf8
    doc: |-
      Called at the start of a dungeon. Initializes the dungeon struct from specified dungeon data. Includes a loop that does not break until the dungeon is cleared, and another one inside it that runs until the current floor ends.

      r0: Pointer to the struct containing info used to initialize the dungeon. See type dungeon_init for details.
      r1: Pointer to the dungeon data struct that will be used during the dungeon.
  get_floor_type:
    value: 0x4170
    doc: |-
      Get the current floor type.

      Floor types:
        0 appears to mean the current floor is "normal"
        1 means the current floor is a fixed floor with warp zones enabled
        2 means the current floor has a rescue point

      return: floor type
  try_forced_loss:
    value: 0x43e0
    doc: |-
      Attempts to trigger a forced loss of the type specified in dungeon::forced_loss_reason.

      r0: if true, the function will not check for the end of the floor condition and will skip other (unknown) actions in case of forced loss.
      return: true if the forced loss happens, false otherwise
  is_boss_fight:
    value: 0x4624
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: fixed_room_id
      return: bool
  is_current_fixed_room_boss_fight:
    value: 0x4640
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: bool
  is_marowak_training_maze:
    value: 0x4660
    doc: |-
      Check if the current dungeon is one of the training mazes in Marowak Dojo (this excludes Final Maze).

      return: bool
  fixed_room_is_substitute_room:
    value: 0x468c
    doc: |-
      Checks if the current fixed room is the "substitute room" (ID 0x6E).

      return: bool
  story_restrictions_enabled:
    value: 0x46e8
    doc: |-
      Returns true if certain special restrictions are enabled.

      If true, you will get kicked out of the dungeon if a team member that passes the arm9::JoinedAtRangeCheck2 check faints.

      return: !dungeon::nonstory_flag || dungeon::hidden_land_flag
  get_scenario_balance_veneer:
    value: 0x471c
    doc: |-
      Likely a linker-generated veneer for GetScenarioBalance.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
  fade_to_black:
    value: 0x4728
    doc: |-
      Fades the screen to black across several frames.

      No params.
  check_touchscreen_area:
    value: 0x4a78
    doc: |-
      Checks if the currently pressed touchscreen position is within the specified area.

      r0: Area lower X coordinate
      r1: Area lower Y coordinate
      r2: Area upper X coordinate
      r3: Area upper Y coordinate
      return: True if the specified area contains the currently pressed touchscreen position, false otherwise.
  get_trap_info:
    value: 0x53c8
    doc: |-
      Given a trap entity, returns the pointer to the trap info struct it contains.

      r0: Entity pointer
      return: Trap data pointer
  get_item_info:
    value: 0x53d0
    doc: |-
      Given an item entity, returns the pointer to the item info struct it contains.

      r0: Entity pointer
      return: Item data pointer
  get_tile_at_entity:
    value: 0x53e8
    doc: |-
      Returns a pointer to the tile where an entity is located.

      r0: pointer to entity
      return: pointer to tile
  update_entity_pixel_pos:
    value: 0x5800
    doc: |-
      Updates an entity's pixel_pos field using the specified pixel_position struct, or its own pos field if it's null.

      r0: Entity pointer
      r1: Pixel position to use, or null to use the entity's own position
  set_entity_pixel_pos_xy:
    value: 0x5844
    doc: |-
      r0: Entity pointer
      r1: x
      r2: y
  increment_entity_pixel_pos_xy:
    value: 0x5850
    doc: |-
      r0: Entity pointer
      r1: x
      r2: y
  create_enemy_entity:
    value: 0x5e80
    doc: |-
      Creates and initializes the entity struct of a newly spawned enemy monster. Fails if there's 16 enemies on the floor already.

      It could also be used to spawn fixed room allies, since those share their slots on the entity list.

      r0: Monster ID
      return: Pointer to the newly initialized entity, or null if the entity couldn't be initialized
  spawn_trap:
    value: 0x6020
    doc: |-
      Spawns a trap on the floor. Fails if there are more than 64 traps already on the floor.

      This modifies the appropriate fields on the dungeon struct, initializing new entries in the entity table and the trap info list.

      r0: trap ID
      r1: position
      r2: team (see struct trap::team)
      r3: flags (see struct trap::team)
      return: entity pointer for the newly added trap, or null on failure
  spawn_item_entity:
    value: 0x60d4
    doc: |-
      Spawns a blank item entity on the floor. Fails if there are more than 64 items already on the floor.

      This initializes a new entry in the entity table and points it to the corresponding slot in the item info list.

      r0: position
      return: entity pointer for the newly added item, or null on failure
  should_minimap_display_entity:
    value: 0x6258
    doc: |-
      Checks if a given entity should be displayed on the minimap

      r0: Entity pointer
      return: True if the entity should be displayed on the minimap
  should_display_entity:
    value: 0x6334
    doc: |-
      Checks if an entity should be displayed or not.

      For example, it returns false if the entity is an invisible enemy.
      Also used to determine if messages that involve a certain entity should be displayed or suppressed.

      r0: Entity pointer
      r1: (?) Seems to be 1 for monsters and 0 for items.
      return: True if the entity and its associated messages should be displayed, false if they shouldn't.
  should_display_entity_wrapper:
    value: 0x64ec
    doc: |-
      Calls ShouldDisplayEntity with r1 = 0

      r0: Entity pointer
      return: True if the entity and its associated messages should be displayed, false if they shouldn't.
  can_see_target:
    value: 0x650c
    doc: |-
      Checks if a given monster can see another monster.

      Calls IsPositionActuallyInSight. Also checks if the user is blinded, if the target is invisible, etc.
      This function is almost the same as CanTargetEntity, the only difference is that the latter calls IsPositionInSight instead.

      r0: User entity pointer
      r1: Target entity pointer
      return: True if the user can see the target, false otherwise
  can_target_entity:
    value: 0x65d0
    doc: |-
      Checks if a monster can target another entity when controlled by the AI.
      More specifically, it checks if the target is invisible, if the user can see invisible monsters, if the user is blinded and if the target position is in sight from the position of the user (this last check is done by calling IsPositionInSight with the user's and the target's position).
      This function is almost the same as CanSeeTarget, the only difference is that the latter calls IsPositionActuallyInSight instead.

      r0: User entity pointer
      r1: Target entity pointer
      return: True if the user can target the target, false otherwise
  can_target_position:
    value: 0x6714
    doc: |-
      Checks if a monster can target a position. This function just calls IsPositionInSight using the position of the user as the origin.

      r0: Entity pointer
      r1: Target position
      return: True if the specified monster can target the target position, false otherwise.
  populate_active_monster_ptrs:
    value: 0x6738
    doc: |-
      Populates active_monster_ptrs with all valid monsters in the monster_slot_headers array.

      No params.
  get_team_member_index:
    value: 0x67f8
    doc: |-
      Given a pointer to an entity, returns its index on the entity list, or null if the entity can't be found on the first 4 slots of the list.

      r0: Pointer to the entity to find
      return: Index of the specified entity on the entity list, or null if it's not on the first 4 slots.
  substitute_placeholder_string_tags:
    value: 0x6898
    doc: |-
      Replaces instances of a given placeholder tag by the string representation of the given entity.

      From the eos-move-effects docs (which are somewhat nebulous): "Replaces the string at StringID [r0] by the string representation of the target [r1] (aka its name). Any message with the string manipulator '[string:StringID]' will use that string".

      The game uses various placeholder tags in its strings, which you can read about here: https://textbox.skytemple.org/.

      r0: string ID (unclear what this means)
      r1: entity pointer
      r2: ?
  update_map_surveyor_flag:
    value: 0x6bdc
    doc: |-
      Sets the Map Surveyor flag in the dungeon struct to true if a team member has Map Surveyor, sets it to false otherwise.

      This function has two variants: in the EU ROM, it will return true if the flag was changed. The NA version will return the new value of the flag instead.

      return: bool
  point_camera_to_monster:
    value: 0x6c84
    doc: |-
      Points the camera to the specified monster.

      r0: Entity pointer
      r1: ?
  update_camera:
    value: 0x6cf4
    doc: |-
      Called every frame. Sets the camera to the right coordinates depending on the monster it points to.

      It also takes care of updating the minimap, checking which elements should be shown on it, as well as whether the screen should be black due to the blinker status.

      r0: ?
  get_visibility_range:
    value: 0x716c
    doc: |-
      Returns dungeon::display_data::visibility_range. If the visibility range is 0, returns 2 instead.

      return: Visibility range of the current floor, or 2 if the visibility is 0.
  reveal_whole_floor:
    value: 0x7260
    doc: |-
      Sets the luminous state for the floor and marks all the tiles on the floor as revealed.

      More specifically, sets dungeon::display_data::luminous to 1, sets visibility_flags::f_revealed for all tiles on the floor, calls UpdateCamera, UpdateTrapsVisibility, UpdateMinimap and logs the message "It became brighter on the floor!".

      r0: Pointer to the entity who revealed the floor
  play_effect_animation_entity:
    value: 0x7414
    doc: |-
      Just a guess. This appears to be paired often with GetEffectAnimationField0x19, and also has calls AnimationHasMoreFrames in a loop alongside AdvanceFrame(66) calls.

      The third parameter skips the loop entirely. It seems like in this case the function might just preload some animation frames for later use??

      r0: entity pointer
      r1: Effect ID
      r2: appears to be a flag for actually running the animation now? If this is 0, the AdvanceFrame loop is skipped entirely.
      others: ?
      return: status code, or maybe the number of frames or something? Either way, -1 seems to indicate the animation being finished or something?
  play_effect_animation_pos:
    value: 0x760c
    doc: |-
      Takes a position struct in r0 and converts it to a pixel position struct before calling PlayEffectAnimationPixelPos

      r0: Position where the effect should be played
      r1: Effect ID
      r2: Unknown flag (same as the one in PlayEffectAnimationEntity)
      return: Result of call to PlayEffectAnimationPixelPos
  play_effect_animation_pixel_pos:
    value: 0x7650
    doc: |-
      Seems like a variant of PlayEffectAnimationEntity that uses pixel coordinates as its first parameter instead of an entity pointer.

      r0: Pixel position where the effect should be played
      r1: Effect ID
      r2: Unknown flag (same as the one in PlayEffectAnimationEntity)
      return: Same as PlayEffectAnimationEntity
  animation_delay_or_something:
    value: 0x7710
    doc: |-
      Called whenever most (all?) animations are played. Does not return until the animation is over.

      Might wait until the animation is done? Contains several loops that call AdvanceFrame.

      r0: ?
  update_status_icon_flags:
    value: 0x78e4
    doc: |-
      Sets a monster's status_icon_flags bitfield according to its current status effects. Does not affect a Sudowoodo in the "permanent sleep" state (statuses::sleep == 0x7F).

      Some of the status effect in monster::statuses are used as an index to access an array, where every group of 8 bytes represents a bitmask. All masks are added in a bitwise OR and then stored in monster::status_icon.

      Also sets icon flags for statuses::exposed, statuses::grudge, critical HP and lowered stats with explicit checks, and applies the effect of the Identifier Orb (see dungeon::identify_orb_flag).

      r0: entity pointer
  play_effect_animation0x171_full:
    value: 0x7e48
    doc: |-
      Just a guess. Calls PlayEffectAnimation with data from animation ID 0x171, with the third parameter of PlayEffectAnimation set to true.

      r0: entity pointer
  play_effect_animation0x171:
    value: 0x7e9c
    doc: |-
      Just a guess. Calls PlayEffectAnimation with data from animation ID 0x171.

      r0: entity pointer
  show_pp_restore_effect:
    value: 0x8794
    doc: |-
      Displays the graphical effect on a monster that just recovered PP.

      r0: entity pointer
  should_display_entity_advanced:
    value: 0x9d00
    doc: |-
      Returns whether or not the entity should be displayed, using the same checks as ShouldDisplayEntity except also checking whether it is visible and whether the camera entity is blinded.

      r0: entity pointer
      return: bool
  play_effect_animation0x18_e:
    value: 0xa208
    doc: |-
      Just a guess. Calls PlayEffectAnimation with data from animation ID 0x18E.

      r0: entity pointer
  load_mappa_file_attributes:
    value: 0xadec
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      This function processes the monster spawn list of the current floor, checking which species can spawn, capping the amount of spawnable species on the floor to 14, randomly choosing which 14 species will spawn and ensuring that the sprite size of all the species combined does not exceed the maximum of 0x58000 bytes (352 KB). Kecleon and the Decoy are always included in the random selection.
      The function also processes the floor's item spawn lists. When loading fixed rooms from the hidden staircase, the game forces the number of spawnable species to 0.

      r0: quick_saved
      r1: disable_monsters
      r2: special_process
  get_item_id_to_spawn:
    value: 0xb8f4
    doc: |-
      Randomly picks an item to spawn using one of the floor's item spawn lists and returns its ID.

      If the function fails to properly choose an item (due to, for example, a corrupted item list), ITEM_POKE is returned.

      r0: Which item list to use
      return: Item ID
  copy_spawn_entries_master:
    value: 0xba18
    doc: |-
      Copies the array at spawn_entries_master, starting from offset, to spawn_entries and returns the number of elements copied.

      r0: [output] Size 16 monster_spawn_entry array
      r1: Offset (always 0 in practice)
      return: int
  monster_spawn_list_partial_copy:
    value: 0xba90
    doc: |-
      Copies all entries in the floor's monster spawn list that have a sprite size >= 6 to the specified buffer.

      The parameter in r1 can be used to specify how many entries are already present in the buffer. Entries added by this function will be placed after those, and the total returned in r1 will account for existing entries as well.

      r0: [output] Buffer where the result will be stored
      r1: Current amount of entries in the buffer
      return: New amount of entries in the buffer
  is_on_monster_spawn_list:
    value: 0xbb7c
    doc: |-
      Returns true if the specified monster is included in the floor's monster spawn list (the modified list after a maximum of 14 different species were chosen, not the raw list read from the mappa file).

      r0: Monster ID
      return: bool
  get_monster_id_to_spawn:
    value: 0xbbd0
    doc: |-
      Randomly picks a monster to spawn using the floor's monster spawn list and returns its ID.

      r0: the spawn weight to use (0 for normal, 1 for monster house)
      return: monster ID
  get_monster_level_to_spawn:
    value: 0xbc88
    doc: |-
      Get the level of the monster to be spawned, given its id.

      r0: monster ID
      return: Level of the monster to be spawned, or 1 if the specified ID can't be found on the floor's spawn table.
  alloc_top_screen_status:
    value: 0xbcf4
    doc: |-
      Allocates and initializes the top_screen_status struct when entering dungeon mode.

      No params.
  free_top_screen_status:
    value: 0xbd74
    doc: |-
      Gets called when leaving dungeon mode, calls FreeTopScreen and then also frees the allocated memory to the top_screen_status struct.

      No params.
  initialize_team_stats:
    value: 0xbf60
    doc: |-
      Initializes the team stats top screen.

      return: always 1, seems unused
  update_team_stats_wrapper:
    value: 0xbfc0
    doc: |-
      Contains a check and calls UpdateTeamStats in overlay10.

      return: always 1, seems unused
  free_team_stats_wrapper:
    value: 0xc018
    doc: |-
      Calls a function that calls FreeTeamStats in overlay10.

      return: always 1, seems unused
  assign_top_screen_handlers:
    value: 0xc4f8
    doc: |-
      Sets the handler functions of the top screen type.

      r0: Array where the handler function pointers get written to.
      r1: init_func
      r2: update_func
      r3: ?
      stack[0]: free_func
  handle_top_screen_fades:
    value: 0xc69c
    doc: |-
      Used to initialize and uninitialize the top screen in dungeon mode in conjunction with handling the fade status of the screen.

      For example, when a fade out is done, it calls the necessary functions to close the top screen windows. When it starts fading in again, it re-creates all the necessary windows corresponding to the top screen type setting.

      No params.
  free_top_screen:
    value: 0xca7c
    doc: |-
      Gets called twice when fading out the top screen. First it calls the free_func of the top screen type and sets the handlers to null and on the second pass it just returns.

      return: always 1, seems unused
  get_direction_towards_position:
    value: 0xce50
    doc: |-
      Gets the direction in which a monster should move to go from the origin position to the target position

      r0: Origin position
      r1: Target position
      return: Direction in which to move to reach the target position from the origin position
  get_chebyshev_distance:
    value: 0xcebc
    doc: |-
      Returns the Chebyshev distance between two positions. Calculated as max(abs(x0-x1), abs(y0-y1)).

      r0: Position A
      r1: Position B
      return: Chebyshev Distance between position A and position B
  is_position_actually_in_sight:
    value: 0xcefc
    doc: |-
      Checks if a given target position is in sight from a given origin position.
      If the origin position is on a hallway or r2 is true, checks if both positions are within <dungeon::display_data::visibility_range> tiles of each other.
      If the origin position is on a room, checks that the target position is within the boundaries of said room.

      r0: Origin position
      r1: Target position
      r2: True to assume the entity standing on the origin position has the dropeye status
      return: True if the target position is in sight from the origin position
  is_position_in_sight:
    value: 0xcfd4
    doc: |-
      Checks if a given target position is in sight from a given origin position.
      There's multiple factors that affect this check, but generally, it's true if both positions are in the same room (by checking if the target position is within the boundaries of the room where the origin position is) or within 2 tiles of each other.

      r0: Origin position
      r1: Target position
      r2: True to assume the entity standing on the origin position has the dropeye status
      return: True if the target position is in sight from the origin position
  get_leader:
    value: 0xd3b0
    doc: |-
      Gets the pointer to the entity that is currently leading the team, or null if none of the first 4 entities is a valid monster with its is_team_leader flag set. It also sets LEADER_PTR to the result before returning it.

      return: Pointer to the current leader of the team or null if there's no valid leader.
  get_leader_monster:
    value: 0xd448
    doc: |-
      Returns a pointer to the monster data of the current leader.

      No params.
  get_random_tile:
    value: 0xd458
    doc: |-
      Gets a random valid tile. Used for warping as well as several other things.

      The selection algorithm is as follows:
      First, try to randomly select a valid tile that is not a hallway and is at least 6 tiles away from the leader in either direction.
      If none are found, try to randomly select a valid tile that is not a hallway.
      If none are found, try to randomly select a valid tile.
      If none are found, return 0.

      A valid tile is defined as a floor tile that has no object or monster on it and also does not have a key door (if r1 is true).

      r0: [output] position
      r1: boolean indicating whether or not to exclude key doors
      return: whether a tile was successfully found
  find_nearby_unoccupied_tile:
    value: 0xd674
    doc: |-
      Searches for an unoccupied tile near some origin.

      A tile is considered "unoccupied" if it's not a key door, and has no object or monster on it. In "random room" mode, the tile must also not be in a hallway, and must not have the stairs.

      The first unoccupied tile found is returned. The search order is randomized in "random room" mode, otherwise the search order is fixed based on the input displacement array.

      r0: [output] position
      r1: origin position
      r2: array of displacements from the origin position to consider
      r3: number of elements in displacements array
      stack[0]: random room mode flag
      return: whether a tile was successfully found
  find_closest_unoccupied_tile_within2:
    value: 0xd820
    doc: |-
      Searches for the closest unoccupied tile within 2 steps of the given origin.

      Calls FindNearbyUnoccupiedTile with DISPLACEMENTS_WITHIN_2_SMALLEST_FIRST.

      r0: [output] position
      r1: origin position
      r2: random room mode flag
      return: whether a tile was successfully found
  find_farthest_unoccupied_tile_within2:
    value: 0xd83c
    doc: |-
      Searches for the farthest unoccupied tile within 2 steps of the given origin.

      Calls FindNearbyUnoccupiedTile with DISPLACEMENTS_WITHIN_2_LARGEST_FIRST.

      r0: [output] position
      r1: origin position
      r2: random room mode flag
      return: whether a tile was successfully found
  find_unoccupied_tile_within3:
    value: 0xd858
    doc: |-
      Searches for an unoccupied tile within 3 steps of the given origin.

      Calls FindNearbyUnoccupiedTile with DISPLACEMENTS_WITHIN_3.

      r0: [output] position
      r1: origin position
      r2: random room mode flag
      return: whether a tile was successfully found
  tick_status_turn_counter:
    value: 0xd874
    doc: |-
      Ticks down a turn counter for a status condition. If the counter equals 0x7F, it will not be decreased.

      r0: pointer to the status turn counter
      return: new counter value
  advance_frame:
    value: 0xde10
    doc: |-
      Advances one frame. Does not return until the next frame starts.

      r0: ? - Unused by the function
  display_animated_numbers:
    value: 0xe548
    doc: |-
      Displays numbers or the "MISS" text above a monster. Normally used to display damage amounts, although it also has other uses (such as showing the stockpile count).

      r0: Amount to display. Can be negative. 9999 displays "MISS" instead.
      r1: Entity above which the numbers will be displayed
      r2: True to display a plus or minus sign before the numbers, false to hide it
      r3: Color of the numbers. NUMBER_COLOR_AUTO to determine it automatically.
  set_dungeon_rng_preseed23_bit:
    value: 0xe798
    doc: |-
      Sets the preseed in the global dungeon PRNG state, using 23 bits from the input. See GenerateDungeonRngSeed for more information.

      Given the input preseed23, the actual global preseed is set to (preseed23 & 0xFFFFFF | 1), so only bits 1-23 of the input are used.

      r0: preseed23
  generate_dungeon_rng_seed:
    value: 0xe7b0
    doc: |-
      Generates a seed with which to initialize the dungeon PRNG.

      The seed is calculated by starting with a different seed, the "preseed" x0 (defaults to 1, but can be set by other functions). The preseed is iterated twice with the same recurrence relation used in the primary LCG to generate two pseudorandom 32-bit numbers x1 and x2. The output seed is then computed as
        seed = (x1 & 0xFF0000) | (x2 >> 0x10) | 1
      The value x1 is then saved as the new preseed.

      This method of seeding the dungeon PRNG appears to be used only sometimes, depending on certain flags in the data for a given dungeon.

      return: RNG seed
  get_dungeon_rng_preseed:
    value: 0xe7fc
    doc: |-
      Gets the current preseed stored in the global dungeon PRNG state. See GenerateDungeonRngSeed for more information.

      return: current dungeon RNG preseed
  set_dungeon_rng_preseed:
    value: 0xe80c
    doc: |-
      Sets the preseed in the global dungeon PRNG state. See GenerateDungeonRngSeed for more information.

      r0: preseed
  init_dungeon_rng:
    value: 0xe81c
    doc: |-
      Initialize (or reinitialize) the dungeon PRNG with a given seed. The primary LCG and the five secondary LCGs are initialized jointly, and with the same seed.

      r0: seed
  dungeon_rand16_bit:
    value: 0xe850
    doc: |-
      Computes a pseudorandom 16-bit integer using the dungeon PRNG.

      Note that the dungeon PRNG is only used in dungeon mode (as evidenced by these functions being in overlay 29). The game uses another lower-quality PRNG (see arm9.yml) for other needs.

      Random numbers are generated with a linear congruential generator (LCG). The game actually maintains 6 separate sequences that can be used for generation: a primary LCG and 5 secondary LCGs. The generator used depends on parameters set on the global PRNG state.

      All dungeon LCGs have a modulus of 2^32 and a multiplier of 1566083941 (see DUNGEON_PRNG_LCG_MULTIPLIER). The primary LCG uses an increment of 1, while the secondary LCGs use an increment of 2531011 (see DUNGEON_PRNG_LCG_INCREMENT_SECONDARY). So, for example, the primary LCG uses the recurrence relation:
        x = (1566083941*x_prev + 1) % 2^32

      Since the dungeon LCGs generate 32-bit integers rather than 16-bit, the primary LCG yields 16-bit values by taking the upper 16 bits of the computed 32-bit value. The secondary LCGs yield 16-bit values by taking the lower 16 bits of the computed 32-bit value.

      All of the dungeon LCGs have a hard-coded default seed of 1, but in practice the seed is set with a call to InitDungeonRng during dungeon initialization.

      return: pseudorandom int on the interval [0, 65535]
  dungeon_rand_int:
    value: 0xe8c8
    doc: |-
      Compute a pseudorandom integer under a given maximum value using the dungeon PRNG.

      r0: high
      return: pseudorandom integer on the interval [0, high - 1]
  dungeon_rand_range:
    value: 0xe8f0
    doc: |-
      Compute a pseudorandom value between two integers using the dungeon PRNG.

      If both input integers are the same, the first is returned.

      r0: x
      r1: y
      return: pseudorandom integer on the interval [min(x, y), max(x, y) - 1], or x if x == y.
  calc_status_duration:
    value: 0xe9b0
    doc: |-
      Seems to calculate the duration of a volatile status on a monster.

      r0: entity pointer
      r1: pointer to a turn range (an array of two shorts {lower, higher})
      r2: flag for whether or not to factor in the Self Curer IQ skill and the Natural Cure ability
      return: number of turns for the status condition
  dungeon_rng_unset_secondary:
    value: 0xea64
    doc: |-
      Sets the dungeon PRNG to use the primary LCG for subsequent random number generation, and also resets the secondary LCG index back to 0.

      Similar to DungeonRngSetPrimary, but DungeonRngSetPrimary doesn't modify the secondary LCG index if it was already set to something other than 0.

      No params.
  dungeon_rng_set_secondary:
    value: 0xea7c
    doc: |-
      Sets the dungeon PRNG to use one of the 5 secondary LCGs for subsequent random number generation.

      r0: secondary LCG index
  dungeon_rng_set_primary:
    value: 0xea94
    doc: |-
      Sets the dungeon PRNG to use the primary LCG for subsequent random number generation.

      No params.
  music_table_idx_to_music_id:
    value: 0xeb30
    doc: |-
      Used to convert an index that refers to a MUSIC_ID_TABLE entry to a regular music ID.

      r0: Music table index
      return: Music ID
  change_dungeon_music:
    value: 0xec44
    doc: |-
      Replace the currently playing music with the provided music

      r0: music ID
  try_switch_place:
    value: 0xefa8
    doc: |-
      The user entity attempts to switch places with the target entity (i.e. by the effect of the Switcher Orb). 

      The function checks for the Suction Cups ability for both the user and the target, and for the Mold Breaker ability on the user.

      r0: pointer to user entity
      r1: pointer to target entity
  set_leader_action_fields:
    value: 0xf1f8
    doc: |-
      Sets the leader's monster::action::action_id to the specified value.

      Also sets monster::action::action_use_idx and monster::action::field_0xA to 0, as well as monster::action::field_0x10 and monster::action::field_0x12 to -1.

      r0: ID of the action to set
  clear_monster_action_fields:
    value: 0xf224
    doc: |-
      Clears the fields related to AI in the monster's data struct, setting them all to 0.
      Specifically, monster::action::action_id, monster::action::action_use_idx and monster::action::field_0xA are cleared.

      r0: Pointer to the monster's action field
  set_monster_action_fields:
    value: 0xf238
    doc: |-
      Sets some the fields related to AI in the monster's data struct.
      Specifically, monster::action::action_id, monster::action::action_use_idx and monster::action::field_0xA. The last 2 are always set to 0.

      r0: Pointer to the monster's action field
      r1: Value to set monster::action::action_id to.
  set_action_pass_turn_or_walk:
    value: 0xf24c
    doc: |-
      Sets a monster's action to action::ACTION_PASS_TURN or action::ACTION_WALK, depending on the result of GetCanMoveFlag for the monster's ID.

      r0: Pointer to the monster's action field
      r1: Monster ID
  get_item_to_use_by_index:
    value: 0xf27c
    doc: |-
      Returns a pointer to the item that is about to be used by a monster given its index.

      r0: Entity pointer
      r1: Item index
      return: Pointer to the item
  get_item_to_use:
    value: 0xf37c
    doc: |-
      Returns a pointer to the item that is about to be used by a monster.

      r0: Entity pointer
      r1: Parameter index in monster::action_data::action_parameters. Will be used to use to determine the index of the used item.
      r2: Unused
      return: Pointer to the item
  get_item_action:
    value: 0xf408
    doc: |-
      Returns the action ID that corresponds to an item given its ID.

      The action is based on the category of the item (see ITEM_CATEGORY_ACTIONS), unless the specified ID is 0x16B, in which case ACTION_UNK_35 is returned.
      Some items can have unexpected actions, such as thrown items, which have ACTION_NOTHING. This is done to prevent duplicate actions from being listed in the menu (since items always have a "throw" option), since a return value of ACTION_NOTHING prevents the option from showing up in the menu.

      r0: Item ID
      return: Action ID associated with the specified item
  remove_used_item:
    value: 0xf43c
    doc: |-
      Removes an item from the bag or from the floor after using it

      r0: Pointer to the entity that used the item
      r1: Parameter index in monster::action_data::action_parameters. Will be used to use to determine the index of the used item.
  add_dungeon_sub_menu_option:
    value: 0xf64c
    doc: |-
      Adds an option to the list of actions that can be taken on a pokémon, item or move to the currently active sub-menu on dungeon mode (team, moves, items, etc.).

      r0: Action ID
      r1: True if the option should be enabled, false otherwise
  disable_dungeon_sub_menu_option:
    value: 0xf724
    doc: |-
      Disables an option that was addeed to a dungeon sub-menu.

      r0: Action ID of the option that should be disabled
  set_action_regular_attack:
    value: 0xfa80
    doc: |-
      Sets a monster's action to action::ACTION_REGULAR_ATTACK, with a specified direction.

      r0: Pointer to the monster's action field
      r1: Direction in which to use the move. Gets stored in monster::action::direction.
  set_action_use_move_player:
    value: 0xfac8
    doc: |-
      Sets a monster's action to action::ACTION_USE_MOVE_PLAYER, with a specified monster and move index.

      r0: Pointer to the monster's action field
      r1: Index of the monster that is using the move on the entity list. Gets stored in monster::action::action_use_idx.
      r2: Index of the move to use (0-3). Gets stored in monster::action::field_0xA.
  set_action_use_move_ai:
    value: 0xfaec
    doc: |-
      Sets a monster's action to action::ACTION_USE_MOVE_AI, with a specified direction and move index.

      r0: Pointer to the monster's action field
      r1: Index of the move to use (0-3). Gets stored in monster::action::action_use_idx.
      r2: Direction in which to use the move. Gets stored in monster::action::direction.
  run_fractional_turn:
    value: 0xfb38
    doc: |-
      The main function which executes the actions that take place in a fractional turn. Called in a loop by RunDungeon while IsFloorOver returns false.

      r0: first loop flag (true when the function is first called during a floor)
  run_leader_turn:
    value: 0x10138
    doc: |-
      Handles the leader's turn. Includes a movement speed check that might cause it to return early if the leader isn't fast enough to act in this fractional turn. If that check (and some others) pass, the function does not return until the leader performs an action.

      r0: ?
      return: true if the leader has performed an action
  try_spawn_monster_and_activate_plus_minus:
    value: 0x1050c
    doc: |-
      Called at the beginning of RunFractionalTurn. Executed only if FRACTIONAL_TURN_SEQUENCE[fractional_turn * 2] is not 0.

      First it calls TrySpawnMonsterAndTickSpawnCounter, then tries to activate the Plus and Minus abilities for both allies and enemies, and finally calls TryForcedLoss.

      No params.
  is_floor_over:
    value: 0x10618
    doc: |-
      Checks if the current floor should end, and updates dungeon::floor_loop_status if required.
      If the player has been defeated, sets dungeon::floor_loop_status to floor_loop_status::FLOOR_LOOP_LEADER_FAINTED.
      If dungeon::end_floor_flag is 1 or 2, sets dungeon::floor_loop_status to floor_loop_status::FLOOR_LOOP_NEXT_FLOOR.

      return: true if the current floor should end
  decrement_wind_counter:
    value: 0x10978
    doc: |-
      Decrements dungeon::wind_turns and displays a wind warning message if required.

      No params.
  is_dungeon_end_reason_failure:
    value: 0x10d74
    doc: |-
      Checks if the damage_source of the dungeon ending is because of a failure to complete the dungeon.
      Specifically checks fainted_monster_dungeon_end_reason to be less than DAMAGE_SOURCE_ESCAPE.

      return: bool
  set_forced_loss_reason:
    value: 0x10e38
    doc: |-
      Sets dungeon::forced_loss_reason to the specified value

      r0: Forced loss reason
  get_forced_loss_reason:
    value: 0x10e4c
    doc: |-
      Returns dungeon::forced_loss_reason

      return: forced_loss_reason
  bind_trap_to_tile:
    value: 0x11688
    doc: |-
      Sets the given tile's associated object to be the given trap, and sets the visibility of the trap.

      r0: tile pointer
      r1: entity pointer
      r2: visibility flag
  are_late_game_traps_enabled_wrapper:
    value: 0x11698
    doc: |-
      A wrapper around AreLateGameTrapsEnabled that passes the fixed room for the floor.

      return: bool
  spawn_enemy_trap_at_pos:
    value: 0x117a0
    doc: |-
      A convenience wrapper around SpawnTrap and BindTrapToTile. Always passes 0 for the team parameter (making it an enemy trap).

      r0: trap ID
      r1: x position
      r2: y position
      r3: flags
      stack[0]: visibility flag
  prepare_trapper_trap:
    value: 0x11a04
    doc: |-
      Saves the relevant information in the dungeon struct to later place a trap at the
      location of the entity. (Only called with trap ID 0x19 (TRAP_NONE), but could be used 
      with others).

      r0: entity pointer
      r1: trap ID
      r2: team (see struct trap::team)
  try_spawn_trap:
    value: 0x11aec
    doc: |-
      Checks if the a trap can be placed on the tile. If the trap ID is >= TRAP_NONE (the
      last value for a trap), randomly select another trap (except for wonder tile). After
      30 failed attempts to select a non-wonder tile trap ID, default to chestnut trap.
      If the checks pass, spawn the trap.

      r0: position
      r1: trap ID
      r2: team (see struct trap::team)
      r3: visibility flag
      return: true if a trap was spawned succesfully
  try_spawn_trapper_trap:
    value: 0x11c04
    doc: |-
      If the flag for a trapper trap is set, handles spawning a trap based upon the
      information inside the dungeon struct. Uses the entity for logging a message
      depending on success or failure.

      r0: entity pointer
      return: true if a trap was spawned succesfully
  try_remove_trap:
    value: 0x11cac
    doc: |-
      Tries to remove a trap from the tile at the passed position. It does nothing
      if there is no trap on the tile at that position.

      r0: position
      r1: bool update trap visibility
      return: whether a trap was succesfully removed or not
  try_trigger_trap:
    value: 0x11dd0
    doc: |-
      Called whenever a monster steps on a trap.

      The function will try to trigger it. Nothing will happen if the pokémon has the same team as the trap. The attempt to trigger the trap can also fail due to IQ skills, due to the trap failing to work (random chance), etc.

      r0: Entity who stepped on the trap
      r1: Trap position
      r2: ?
      r3: ?
  apply_mud_trap_effect:
    value: 0x1219c
    doc: |-
      Randomly lowers attack, special attack, defense, or special defense of the defender by 3 stages.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_sticky_trap_effect:
    value: 0x12264
    doc: |-
      If the defender is the leader, randomly try to make something in the bag sticky. Otherwise, try to make the item the monster is holding sticky.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_grimy_trap_effect:
    value: 0x12460
    doc: |-
      If the defender is the leader, randomly try to turn food items in the toolbox into
      grimy food. Otherwise, try to make the food item the monster is holding grimy food.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_pitfall_trap_effect:
    value: 0x12654
    doc: |-
      If the defender is the leader, end the current floor unless it has a rescue point.
      Otherwise, make the entity faint and ignore reviver seeds. If not called by a random
      trap, break the grate on the pitfall trap.

      r0: attacker entity pointer
      r1: defender entity pointer
      r2: tile pointer
      r3: bool caused by random trap
  apply_summon_trap_effect:
    value: 0x127c8
    doc: |-
      Randomly spawns 2-4 enemy monsters around the position. The entity is only used for
      logging messages.

      r0: entity pointer
      r1: position
  apply_pp_zero_trap_effect:
    value: 0x12864
    doc: |-
      Tries to reduce the PP of one of the defender's moves to 0.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_pokemon_trap_effect:
    value: 0x1294c
    doc: |-
      Turns item in the same room as the tile at the position (usually just the entities's
      position) into monsters. If the position is in a hallway, convert items in a 3x3 area
      centered on the position into monsters.

      r0: entity pointer
      r1: position
  apply_trip_trap_effect:
    value: 0x12b60
    doc: |-
      Tries to drop the defender's item and places it on the floor.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_stealth_rock_trap_effect:
    value: 0x12c84
    doc: |-
      Tries to apply the damage from the stealth rock trap but does nothing if the defender is a rock type.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_toxic_spikes_trap_effect:
    value: 0x12d20
    doc: |-
      Tries to inflict 10 damage on the defender and then tries to poison them.

      r0: attacker entity pointer
      r1: defender entity pointer
  apply_random_trap_effect:
    value: 0x12d74
    doc: |-
      Selects a random trap that isn't a wonder tile and isn't a random trap and calls
      ApplyTrapEffect on all monsters that is different from the trap's team.

      r0: Triggered trap
      r1: User
      r2: Target, normally same as user
      r3: Tile that contains the trap
      stack[0]: position
  apply_grudge_trap_effect:
    value: 0x12ea8
    doc: |-
      Spawns several monsters around the position and gives all monsters on the floor the
      grudge status condition.

      r0: entity pointer
      r1: position
  apply_trap_effect:
    value: 0x12f88
    doc: |-
      Performs the effect of a triggered trap.

      The trap's animation happens before this function is called.

      r0: Triggered trap
      r1: User
      r2: Target, normally same as user
      r3: Tile that contains the trap
      stack[0]: position
      stack[1]: trap ID
      stack[2]: bool caused by random trap
      return: True if the trap should be destroyed after the effect is applied
  reveal_traps_nearby:
    value: 0x1340c
    doc: |-
      Reveals traps within the monster's viewing range.

      r0: entity pointer
  should_run_monster_ai:
    value: 0x13820
    doc: |-
      Checks a monster's monster_behavior to see whether or not the monster should use AI. Only called on monsters with
      a monster_behavior greater than or equal to BEHAVIOR_FIXED_ENEMY. Returns false for BEHAVIOR_FIXED_ENEMY, 
      BEHAVIOR_WANDERING_ENEMY_0x8, BEHAVIOR_SECRET_BAZAAR_KIRLIA, BEHAVIOR_SECRET_BAZAAR_MIME_JR,
      BEHAVIOR_SECRET_BAZAAR_SWALOT, BEHAVIOR_SECRET_BAZAAR_LICKILICKY, and BEHAVIOR_SECRET_BAZAAR_SHEDINJA.

      r0: monster entity pointer
      return: bool
  debug_recruiting_enabled:
    value: 0x138a0
    doc: |-
      Always returns true. Called by SpecificRecruitCheck.

      Seems to be a function used during development to disable recruiting. If it returns false, SpecificRecruitCheck will also return false.

      return: true
  try_activate_iq_booster:
    value: 0x138a8
    doc: |-
      Increases the IQ of all team members holding the IQ Booster by floor_properties::iq_booster_value amount unless the
      value is 0.

      No params.
  is_secret_bazaar_npc_behavior:
    value: 0x13938
    doc: |-
      Checks if a behavior ID corresponds to one of the Secret Bazaar NPCs.

      r0: monster behavior ID
      return: bool
  get_leader_action:
    value: 0x149c0
    doc: |-
      Returns a pointer to the action data of the current leader (field 0x4A on its monster struct).

      No params.
  get_entity_touchscreen_area:
    value: 0x149e0
    doc: |-
      Returns the area on the touchscreen that contains the sprite of the specified entity

      r0: Entity pointer
      r1: [output] struct where the result should be written
  set_leader_action:
    value: 0x14d10
    doc: |-
      Sets the leader's action field depending on the inputs given by the player.

      This function also accounts for other special situations that can force a certain action, such as when the leader is running. The function also takes care of opening the main menu when X is pressed.
      The function generally doesn't return until the player has an action set.

      No params.
  should_leader_keep_running:
    value: 0x16ec4
    doc: |-
      Determines if the leader should keep running. Returns false if the leader bumps into something, or if an action that should stop the leader takes place.

      return: True if the leader should keep running, false if it should stop.
  check_leader_tile:
    value: 0x1746c
    doc: |-
      Checks the tile the leader just stepped on and performs any required actions, such as picking up items, triggering traps, etc.

      Contains a switch that checks the type of the tile the leader just stepped on.

      No params.
  change_leader:
    value: 0x17770
    doc: |-
      Tries to change the current leader to the monster specified by dungeon::new_leader.

      Accounts for situations that can prevent changing leaders, such as having stolen from a Kecleon shop. If one of those situations prevents changing leaders, prints the corresponding message to the message log.

      No params.
  get_player_gender:
    value: 0x18114
    doc: |-
      Gets the gender of the player.

      return: monster_gender
  use_single_use_item_wrapper:
    value: 0x19108
    doc: |-
      Same as UseSingleUseItem, but the second parameter is determined automatically from monster::action_data::action_parameter[1]::action_use_idx.

      r0: User
  use_single_use_item:
    value: 0x19134
    doc: |-
      Makes a monster use a single-use item. The item is deleted afterwards.

      The item to use is determined by the user's monster::action_data::action_parameter[0].

      r0: User (monster who used the item)
      r1: Target (monster that consumes the item)
  use_throwable_item:
    value: 0x192f8
    doc: |-
      Makes a monster use a throwable item.

      The item to use is determined by monster::action_data::action_parameter[0].
      If the item's category is CATEGORY_THROWN_LINE or CATEGORY_THROWN_ARC, the game will attempt to decrement the count of the used item by 1. If it's not or there's only 1 item left, it is destroyed instead.

      r0: User (monster who used the item)
  reset_damage_data:
    value: 0x1ac50
    doc: |-
      Zeroes the damage data struct, which is output by the damage calculation function.

      r0: damage data pointer
  free_loaded_attack_sprite_and_more:
    value: 0x1ad48
    doc: |-
      Among other things, free another data structure in the attack sprite storage area/data

      No params.
  set_and_load_current_attack_animation:
    value: 0x1ada0
    doc: |-
      Load given sprite into the currently loaded attack sprite structure, replacing the previous one if already loaded.

      r0: pack id
      r1: file index
      return: sprite id in the loaded wan list
  clear_loaded_attack_sprite:
    value: 0x1ae40
    doc: |-
      Delete the data of the currently loaded attack sprite, if any.
      Doesn’t free the structure, which can continue to be used.

      No params.
  get_loaded_attack_sprite_id:
    value: 0x1ae88
    doc: |-
      Get the sprite ID (in the loaded WAN list) of the currently loaded attack sprite, or 0 if none.

      return: sprite ID
  dungeon_get_total_sprite_file_size:
    value: 0x1aea0
    doc: |-
      Checks Castform and Cherrim

      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: sprite file size
  dungeon_get_sprite_index:
    value: 0x1b1c0
    doc: |-
      Gets the sprite index of the specified monster on this floor

      r0: Monster ID
      return: Sprite index of the specified monster ID
  joined_at_range_check2_veneer:
    value: 0x1b1e0
    doc: |-
      Likely a linker-generated veneer for arm9::JoinedAtRangeCheck2.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      No params.
  floor_number_is_even:
    value: 0x1b1ec
    doc: |-
      Checks if the current dungeon floor number is even (probably to determine whether an enemy spawn should be female).

      Has a special check to return false for Labyrinth Cave B10F (the Gabite boss fight).

      return: bool
  get_kecleon_id_to_spawn_by_floor:
    value: 0x1b224
    doc: |-
      If the current floor number is even, returns female Kecleon's id (0x3D7), otherwise returns male Kecleon's id (0x17F).

      return: monster ID
  store_sprite_file_index_both_genders:
    value: 0x1b244
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      r1: file ID
  load_monster_sprite_inner:
    value: 0x1b30c
    doc: |-
      This is called by LoadMonsterSprite a bunch of times.

      r0: monster ID
  swap_monster_wan_file_index:
    value: 0x1b40c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: src_id
      r1: dst_id
  load_monster_sprite:
    value: 0x1b48c
    doc: |-
      Loads the sprite of the specified monster to use it in a dungeon.

      Irdkwia's notes: Handles Castform/Cherrim/Deoxys

      r0: monster ID
      r1: ?
  delete_monster_sprite_file:
    value: 0x1b5a0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
  delete_all_monster_sprite_files:
    value: 0x1b63c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  eu_faint_check:
    value: 0x1bd68
    doc: |-
      This function is exclusive to the EU ROM. Seems to perform a check to see if the monster who just fainted was a team member who should cause the minimap to be updated (or something like that, maybe related to the Map Surveyor IQ skill) and if it passes, updates the minimap.
      The function ends by calling another 2 functions. In US ROMs, calls to EUFaintCheck are replaced by calls to those two functions. This seems to indicate that this function fixes some edge case glitch that can happen when a team member faints.

      r0: False if the fainted entity was a team member
      r1: True to set an unknown byte in the RAM to 1
  handle_faint:
    value: 0x1bdb8
    doc: |-
      Handles a fainted pokémon (reviving does not count as fainting).

      r0: Fainted entity
      r1: Damage source (move ID or greater than the max move id for other causes)
      r2: Entity responsible of the fainting
  move_monster_to_pos:
    value: 0x1c47c
    doc: |-
      Moves a monster to the target position. Used both for regular movement and special movement (like teleportation).

      r0: Entity pointer
      r1: X target position
      r2: Y target position
      r3: ?
  create_monster_summary_from_monster:
    value: 0x1c858
    doc: |-
      Creates a snapshot of the condition of a monster struct in a monster_summary struct.

      r0: [output] monster_summary
      r1: monster
  update_ai_target_pos:
    value: 0x1cfd0
    doc: |-
      Given a monster, updates its target_pos field based on its current position and the direction in which it plans to attack.

      r0: Entity pointer
  set_monster_type_and_ability:
    value: 0x1d020
    doc: |-
      Checks Forecast ability

      Note: unverified, ported from Irdkwia's notes

      r0: target entity pointer
  try_activate_slow_start:
    value: 0x1d0c8
    doc: |-
      Runs a check over all monsters on the field for the ability Slow Start, and lowers the speed of those who have it.

      No params
  try_activate_artificial_weather_abilities:
    value: 0x1d164
    doc: |-
      Runs a check over all monsters on the field for abilities that affect the weather and changes the floor's weather accordingly.

      No params
  get_monster_apparent_id:
    value: 0x1d294
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: target entity pointer
      r1: current_id
      return: ?
  try_activate_trace_and_color_change:
    value: 0x1d37c
    doc: |-
      Tries to activate the abilities trace and color change if possible. Called after using
      a move.

      r0: attacker entity pointer
      r1: defender entity pointer
      r2: move pointer
  try_activate_conversion2:
    value: 0x1d5d0
    doc: |-
      Checks for the conversion2 status and applies the type change if applicable. Called
      after using a move.

      r0: attacker entity pointer
      r1: defender entity pointer
      r2: move pointer
  try_activate_truant:
    value: 0x1d67c
    doc: |-
      Checks if an entity has the ability Truant, and if so tries to apply the pause status to it.

      r0: pointer to entity
  try_point_camera_to_monster:
    value: 0x1d740
    doc: |-
      Attempts to place the camera on top of the specified monster.

      If the camera is already on top of the specified entity, the function does nothing.

      r0: Entity pointer. Must be a monster, otherwise the function does nothing.
      r1: ?
      r2: ?
  reevaluate_snatch_monster:
    value: 0x1d7fc
    doc: |-
      Checks if any monster on the floor has the snatch status and stores the corresponding info
      onto the dungeon struct. This is only called when reinitalizing a dungeon from a quicksave.
      Normally, the game will try to prevent multiple monsters from having snatch, but will pick
      the first one in the list if multiple have the status.

      No params.
  get_random_explorer_maze_monster:
    value: 0x1d878
    doc: |-
      Checks if any enemy monsters on the floor have the behavior BEHAVIOR_EXPLORER_MAZE_1, 
      BEHAVIOR_EXPLORER_MAZE_2, BEHAVIOR_EXPLORER_MAZE_3 or BEHAVIOR_EXPLORER_MAZE_4 and returns
      one at random. If none can be found, it returns NULL.

      return: monster entity pointer
  restore_pp_all_moves_set_flags:
    value: 0x1d900
    doc: |-
      Restores PP for all moves, clears flags move::f_consume_2_pp, move::flags2_unk5 and move::flags2_unk7, and sets flag move::f_consume_pp.
      Called when a monster is revived.

      r0: pointer to entity whose moves will be restored
  check_team_member_idx_veneer:
    value: 0x1dacc
    doc: |-
      Likely a linker-generated veneer for CheckTeamMemberIdx.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: member index
      return: True if the value is equal to 0x55AA or 0x5AA5
  is_monster_id_in_normal_range_veneer:
    value: 0x1daf4
    doc: |-
      Likely a linker-generated veneer for IsMonsterIdInNormalRange.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: monster ID
      return: bool
  boost_iq:
    value: 0x1dfd0
    doc: |-
      Tries to boost the target's IQ.

      r0: monster entity pointer
      r1: iq boost
      r2: bool suppress logs
  should_monster_head_to_stairs:
    value: 0x1e2bc
    doc: |-
      Checks if a given monster should try to reach the stairs when controlled by the AI

      r0: Entity pointer
      return: True if the monster should try to reach the stairs, false otherwise
  mew_spawn_check:
    value: 0x1e47c
    doc: |-
      If the monster id parameter is 0x97 (Mew), returns false if either dungeon::mew_cannot_spawn or the second parameter are true.

      Called before spawning an enemy, appears to be checking if Mew can spawn on the current floor.

      r0: monster id
      r1: return false if the monster id is Mew
      return: bool
  try_end_status_with_ability:
    value: 0x1e668
    doc: |-
      Checks if any of the defender's active abilities would end one of their current status
      conditions. For example, if the ability Own Tempo will stop confusion.

      Called after changing a monster's ability with skill swap, role play, or trace to
      remove statuses the monster should no longer be affected by.

      r0: attacker entity pointer
      r1: defender entity pointer
  get_team_member_with_iq_skill:
    value: 0x1ee84
    doc: |-
      Returns an entity pointer to the first team member which has the specified iq skill.

      r0: iq skill id
      return: pointer to entity
  team_member_has_enabled_iq_skill:
    value: 0x1eef0
    doc: |-
      Returns true if any team member has the specified iq skill.

      r0: iq skill id
      return: bool
  team_leader_iq_skill_is_enabled:
    value: 0x1ef0c
    doc: |-
      Returns true the leader has the specified iq skill.

      r0: iq skill id
      return: bool
  count_moves_out_of_pp:
    value: 0x1ef34
    doc: |-
      Returns how many of a monster's move are out of PP.

      r0: entity pointer
      return: number of moves out of PP
  has_super_effective_move_against_user:
    value: 0x1ef98
    doc: |-
      Checks if the target has at least one super effective move against the user.

      r0: User
      r1: Target
      r2: If true, moves with a max Ginseng boost != 99 will be ignored
      return: True if the target has at least one super effective move against the user, false otherwise.
  try_eat_item:
    value: 0x1f0a0
    doc: |-
      The user attempts to eat an item from the target.

      The function tries to eat the target's held item first. If that's not possible and the target is part of the team, it attempts to eat a random edible item from the bag instead.
      Fun fact: The code used to select the random bag item that will be eaten is poorly coded. As a result, there's a small chance of the first edible item in the bag being picked instead of a random one. The exact chance of this happening is (N/B)^B, where N is the amount of non-edible items in the bag and B is the total amount of items in the bag.

      r0: User
      r1: Target
      return: True if the attempt was successful
  set_decoy_ai_tracker:
    value: 0x1f3c4
    doc: |-
      If there is a decoy on the floor that the entity can see, sets the entity's decoy_ai_tracker to 1 or 2,
      depending on whether the attacker who caused the decoy status is on the team or not, respectively.

      r0: Entity pointer
  check_spawn_threshold:
    value: 0x1f478
    doc: |-
      Checks if a given monster ID can spawn in dungeons.

      The function returns true if the monster's spawn threshold value is <= SCENARIO_BALANCE_FLAG

      r0: monster ID
      return: True if the monster can spawn, false otherwise
  has_low_health:
    value: 0x1f49c
    doc: |-
      Checks if the entity passed is a valid monster, and if it's at low health (below 25% rounded down)

      r0: entity pointer
      return: bool
  are_entities_adjacent:
    value: 0x1f504
    doc: |-
      Checks whether two entities are adjacent or not.

      The function checks all 8 possible directions.

      r0: First entity
      r1: Second entity
      return: True if both entities are adjacent, false otherwise.
  is_special_story_ally:
    value: 0x1f94c
    doc: |-
      Checks if a monster is a special story ally.

      This is a hard-coded check that looks at the monster's "Joined At" field. If the value is in the range [DUNGEON_JOINED_AT_BIDOOF, DUNGEON_DUMMY_0xE3], this check will return true.

      r0: monster pointer
      return: bool
  is_experience_locked:
    value: 0x1f96c
    doc: |-
      Checks if a monster does not gain experience.

      This basically just inverts IsSpecialStoryAlly, with the exception of also checking for the "Joined At" field being DUNGEON_CLIENT (set for mission clients).

      r0: monster pointer
      return: bool
  init_other_monster_data:
    value: 0x1fcd4
    doc: |-
      Initializes stats, IQ skills and moves for a given monster

      Might only be used when spawning fixed room monsters.

      r0: Entity pointer
      r1: Fixed room monster stats index
      r2: Spawn direction? (when calling this function while spawning a fixed room monster, this is the parameter value associated to the spawn action, after converting it to a direction.)
  init_enemy_spawn_stats:
    value: 0x1fdd4
    doc: |-
      Initializes dungeon::enemy_spawn_stats. Might do something else too.

      No params.
  init_enemy_stats_and_moves:
    value: 0x200b0
    doc: |-
      Initializes the HP, Atk, Sp. Atk, Def, Sp. Def and moveset of a newly spawned enemy. Might do something else too.

      r0: Pointer to the monster's move list
      r1: Pointer to the monster's current HP
      r2: Pointer to the monster's offensive stats
      r3: Pointer to the monster's defensive stats
  spawn_team:
    value: 0x20388
    doc: |-
      Seems to initialize and spawn the team when entering a dungeon.

      r0: ?
  spawn_initial_monsters:
    value: 0x20bf4
    doc: |-
      Tries to spawn monsters on all the tiles marked for monster spawns. This includes normal enemies and mission targets (rescue targets, outlaws, etc.).

      A random initial position is selected as a starting point. Tiles are then swept over left-to-right, top-to-bottom, wrapping around when the map boundary is reached, until all tiles have been checked. The first marked tile encountered in the sweep is reserved for the mission target, but the actual spawning of the target is done last.

      No params.
  spawn_monster:
    value: 0x20f00
    doc: |-
      Spawns the given monster on a tile.

      r0: pointer to struct spawned_monster_data
      r1: if true, the monster cannot spawn asleep, otherwise it will randomly be asleep
      return: pointer to entity
  init_team_member:
    value: 0x21230
    doc: |-
      Initializes a team member. Run at the start of each floor in a dungeon.

      r0: Monster ID
      r1: X position
      r2: Y position
      r3: Pointer to the struct containing the data of the team member to initialize
      stack[0]: ?
      stack[1]: ?
      stack[2]: ?
      stack[3]: ?
      stack[4]: ?
  init_monster:
    value: 0x21850
    doc: |-
      Initializes the monster struct within the provided entity struct.

      r0: ?
      r1: Pointer to the entity whose monster struct should be initialized
      r2: pointer to the entity's spawned_monster_data struct
      r3: (?) Pointer to something
  sub_init_monster:
    value: 0x21c3c
    doc: |-
      Called by InitMonster. Initializes some fields on the monster struct.

      r0: pointer to monster to initialize
      r1: some flag
  mark_shopkeeper_spawn:
    value: 0x22014
    doc: |-
      Add a shopkeeper spawn to the list on the dungeon struct. Actual spawning is done later by SpawnShopkeepers.

      If an existing entry in dungeon::shopkeeper_spawns exists with the same position, that entry is reused for the new spawn data. Otherwise, a new entry is appended to the array.

      r0: x position
      r1: y position
      r2: monster ID
      r3: monster behavior
  spawn_shopkeepers:
    value: 0x220c8
    doc: |-
      Spawns all the shopkeepers in the dungeon struct's shopkeeper_spawns array.

      No params.
  get_max_hp_at_level:
    value: 0x22178
    doc: |-
      Returns the max HP of a monster given its level.

      r0: Monster ID
      r1: Monster level
      return: Max HP at the given level
  get_offensive_stat_at_level:
    value: 0x221cc
    doc: |-
      Returns the Atk / Sp. Atk of a monster given its level, capped to 255.

      r0: Monster ID
      r1: Monster level
      r2: Stat index (0: Atk, 1: Sp. Atk)
      return: Atk / Sp. Atk at the given level
  get_defensive_stat_at_level:
    value: 0x22234
    doc: |-
      Returns the Def / Sp. Def of a monster given its level, capped to 255.

      r0: Monster ID
      r1: Monster level
      r2: Stat index (0: Def, 1: Sp. Def)
      return: Def / Sp. Def at the given level
  get_outlaw_spawn_data:
    value: 0x2229c
    doc: |-
      Gets outlaw spawn data for the current floor.

      r0: [output] Outlaw spawn data
  execute_monster_action:
    value: 0x2235c
    doc: |-
      Executes the set action for the specified monster. Used for both AI actions and player-inputted actions. If the action is not ACTION_NOTHING, ACTION_PASS_TURN, ACTION_WALK or ACTION_UNK_4, the monster's already_acted field is set to true. Includes a switch based on the action ID that performs the action, although some of them aren't handled by said swtich.

      r0: Pointer to monster entity
      return: If the result is true, the AI is run again for the current ally, and it performs another action. This can happen up to three times.
  try_activate_flash_fire_on_all_monsters:
    value: 0x23014
    doc: |-
      Checks every monster for apply_flash_fire_boost. If it's true, activates Flash Fire for the monster and sets
      apply_flash_fire_boost back to false.

      No params.
  has_status_that_prevents_acting:
    value: 0x23074
    doc: |-
      Returns true if the monster has any status problem that prevents it from acting

      r0: Entity pointer
      return: True if the specified monster can't act because of a status problem, false otherwise.
  get_mobility_type_check_slip:
    value: 0x234d8
    doc: |-
      Returns the mobility type of a monster species, accounting for STATUS_SLIP.

      The function also converts MOBILITY_LAVA and MOBILITY_WATER to other values if required.

      r0: Monster species
      r1: True if the monster can walk on water
      return: Mobility type
  get_mobility_type_check_slip_and_floating:
    value: 0x23520
    doc: |-
      Returns the mobility type of a monster, accounting for STATUS_SLIP and the result of a call to IsFloating.

      r0: Entity pointer
      r1: Monster species
      return: Mobility type
  is_invalid_spawn_tile:
    value: 0x23570
    doc: |-
      Checks if a monster cannot spawn on the given tile for some reason.

      Reasons include:
      - There's another monster on the tile
      - The tile is an impassable wall
      - The monster does not have the required mobility to stand on the tile

      r0: monster ID
      r1: tile pointer
      return: true means the monster CANNOT spawn on this tile
  get_mobility_type_after_iq_skills:
    value: 0x23774
    doc: |-
      Modifies the given mobility type to account for All-Terrain Hiker and Absolute Mover, if the user has them.

      r0: Entity pointer
      r1: Mobility type
      return: New mobility type, after accounting for the IQ skills mentioned above
  cannot_stand_on_tile:
    value: 0x23b48
    doc: |-
      Checks if a given monster cannot stand on a given tile.

      Reasons include:
      - The coordinates of the tile are out of bounds
      - There's another monster on the tile
      - The monster does not have the required mobility to stand on the tile

      r0: Entity pointer
      r1: Tile pointer
      return: True if the monster cannot stand on the specified tile, false if it can
  calc_speed_stage:
    value: 0x23ca0
    doc: |-
      Calculates the speed stage of a monster from its speed up/down counters. The second parameter is the weight of each counter (how many stages it will add/remove), but appears to be always 1. 
      Takes modifiers into account (paralysis, snowy weather, Time Tripper). Deoxys-speed, Shaymin-sky and enemy Kecleon during a thief alert get a flat +1 always.

      The calculated speed stage is both returned and saved in the monster's statuses struct.

      r0: pointer to entity
      r1: speed counter weight
      return: speed stage
  calc_speed_stage_wrapper:
    value: 0x23df8
    doc: |-
      Calls CalcSpeedStage with a speed counter weight of 1.

      r0: pointer to entity
      return: speed stage
  get_number_of_attacks:
    value: 0x23e08
    doc: |-
      Returns the number of attacks that a monster can do in one turn (1 or 2).

      Checks for the abilities Swift Swim, Chlorophyll, Unburden, and for exclusive items.

      r0: pointer to entity
      return: int
  get_monster_display_name_type:
    value: 0x23fb4
    doc: |-
      Determines how the name of a monster should be displayed.

      r0: Entity pointer
      return: Display name type
  get_monster_name:
    value: 0x24010
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: buffer
      r1: TargetInfo
  sprintf_static:
    value: 0x24174
    doc: |-
      Statically defined copy of sprintf(3) in overlay 29. See arm9.yml for more information.

      r0: str
      r1: format
      ...: variadic
      return: number of characters printed, excluding the null-terminator
  is_monster_drowsy:
    value: 0x2435c
    doc: |-
      Checks if a monster has the sleep, nightmare, or yawning status. Note that this excludes the napping status.

      r0: entity pointer
      return: bool
  monster_has_nonvolatile_nonsleep_status:
    value: 0x24390
    doc: |-
      Checks if a monster has one of the statuses in the "burn" group, which includes the traditionally non-volatile status conditions (except sleep) in the main series: STATUS_BURN, STATUS_POISONED, STATUS_BADLY_POISONED, STATUS_PARALYSIS, and STATUS_IDENTIFYING.

      STATUS_IDENTIFYING is probably included based on enum status_id? Unless it's handled differently somehow.

      r0: entity pointer
      return: bool
  monster_has_immobilizing_status:
    value: 0x243ac
    doc: |-
      Checks if a monster has one of the non-self-inflicted statuses in the "freeze" group, which includes status conditions that immobilize the monster: STATUS_FROZEN, STATUS_SHADOW_HOLD, STATUS_WRAPPED, STATUS_PETRIFIED, STATUS_CONSTRICTION, and STATUS_FAMISHED.

      r0: entity pointer
      return: bool
  monster_has_attack_interfering_status:
    value: 0x243cc
    doc: |-
      Checks if a monster has one of the statuses in the "cringe" group, which includes status conditions that interfere with the monster's ability to attack: STATUS_CRINGE, STATUS_CONFUSED, STATUS_PAUSED, STATUS_COWERING, STATUS_TAUNTED, STATUS_ENCORE, STATUS_INFATUATED, and STATUS_DOUBLE_SPEED.

      STATUS_DOUBLE_SPEED is probably included based on enum status_id? Unless it's handled differently somehow.

      r0: entity pointer
      return: bool
  monster_has_skill_interfering_status:
    value: 0x243e8
    doc: |-
      Checks if a monster has one of the non-self-inflicted statuses in the "curse" group, which loosely includes status conditions that interfere with the monster's skills or ability to do things: STATUS_CURSED, STATUS_DECOY, STATUS_GASTRO_ACID, STATUS_HEAL_BLOCK, STATUS_EMBARGO.

      r0: entity pointer
      return: bool
  monster_has_leech_seed_status:
    value: 0x24434
    doc: |-
      Checks if a monster is afflicted with Leech Seed.

      r0: entity pointer
      return: bool
  monster_has_whiffer_status:
    value: 0x24450
    doc: |-
      Checks if a monster has the whiffer status.

      r0: entity pointer
      return: bool
  is_monster_visually_impaired:
    value: 0x2446c
    doc: |-
      Checks if a monster's vision is impaired somehow. This includes the checks in IsBlinded, as well as STATUS_CROSS_EYED and STATUS_DROPEYE.

      r0: entity pointer
      r1: flag for whether to check for the held item
      return: bool
  is_monster_muzzled:
    value: 0x244a8
    doc: |-
      Checks if a monster has the muzzled status.

      r0: entity pointer
      return: bool
  monster_has_miracle_eye_status:
    value: 0x244c4
    doc: |-
      Checks if a monster has the Miracle Eye status.

      r0: entity pointer
      return: bool
  monster_has_negative_status:
    value: 0x244e0
    doc: |-
      Checks if a monster has any "negative" status conditions. This includes a wide variety of non-self-inflicted statuses that could traditionally be viewed as actual "status conditions", as well as speed being lowered and moves being sealed.

      r0: entity pointer
      r1: flag for whether to check for the held item (see IsMonsterVisuallyImpaired)
      return: bool
  is_monster_sleeping:
    value: 0x24654
    doc: |-
      Checks if a monster has the sleep, nightmare, or napping status.

      r0: entity pointer
      return: bool
  check_various_statuses2:
    value: 0x246c4
    doc: |-
      Returns 0 if none of these conditions holds for the given entity:
      blinded (checked only if blind_check == 1),
      asleep, frozen, paused, infatuated, wrapping, wrapped, biding, petrified, or terrified.

      r0: Entity pointer
      r1: If true, return 1 if entity is blinded
      return: bool
  check_various_conditions:
    value: 0x249ec
    doc: |-
      Returns 0 if none of these conditions holds for the given entity: is a rescue client,
      doesn’t gain experience (a mission client/story teammate?), is a terrified non-team-leader,
      meets any of the conditions in CheckVariousStatuses2 (with blind_check = 0), is charging a two-turn move.

      r0: Entity pointer
      return: bool
  check_various_statuses:
    value: 0x24b5c
    doc: |-
      Returns 0 if none of these conditions holds for the given entity: asleep, frozen, petrified, biding.

      r0: Entity pointer
      return: bool
  can_monster_move_in_direction:
    value: 0x24d24
    doc: |-
      Checks if the given monster can move in the specified direction

      Returns false if any monster is standing on the target tile

      r0: Monster entity pointer
      r1: Direction to check
      return: bool
  get_directional_mobility_type:
    value: 0x24ddc
    doc: |-
      Returns the mobility type of a monster, after accounting for things that could affect it.

      List of checks: Mobile status, Mobile Scarf, All-Terrain Hiker and Absolute Mover.

      If the specified direction is DIR_NONE, direction checks are skipped. If it's not, MOBILITY_INTANGIBLE is only returned if the direction is not diagonal.

      r0: Monster entity pointer
      r1: Base mobility type
      r2: Direction of mobility
      return: Final mobility type
  is_monster_cornered:
    value: 0x24fc4
    doc: |-
      True if the given monster is cornered (it can't move in any direction)

      r0: Entity pointer
      return: True if the monster can't move in any direction, false otherwise.
  can_attack_in_direction:
    value: 0x250e0
    doc: |-
      Returns whether a monster can attack in a given direction.
      The check fails if the destination tile is impassable, contains a monster that isn't of type entity_type::ENTITY_MONSTER or if the monster can't directly move from the current tile into the destination tile.

      r0: Entity pointer
      r1: Direction
      return: True if the monster can attack into the tile adjacent to them in the specified direction, false otherwise.
  can_ai_monster_move_in_direction:
    value: 0x251a4
    doc: |-
      Checks whether an AI-controlled monster can move in the specified direction.
      Accounts for walls, other monsters on the target position and IQ skills that might prevent a monster from moving into a specific location, such as House Avoider, Trap Avoider or Lava Evader.

      r0: Entity pointer
      r1: Direction
      r2: [output] True if movement was not possible because there was another monster on the target tile, false otherwise.
      return: True if the monster can move in the specified direction, false otherwise.
  should_monster_run_away:
    value: 0x25464
    doc: |-
      Checks if a monster should run away from other monsters

      r0: Entity pointer
      return: True if the monster should run away, false otherwise
  should_monster_run_away_variation:
    value: 0x25554
    doc: |-
      Calls ShouldMonsterRunAway and returns its result. It also calls another function if the result was true.

      r0: Entity pointer
      r1: ?
      return: Result of the call to ShouldMonsterRunAway
  get_treatment_between_monsters:
    value: 0x25608
    doc: |-
      Called to check if a monster should treat another as an ally, enemy, or ignore it.
      (Examples of the "ignore" case: target is a shopkeeper, there is a decoy on the floor, etc.)

      r0: Pointer to entity 1
      r1: Pointer to entity 2
      r2: If false, return TREATMENT_IGNORE if entity 2 is invisible and entity 1 cannot see invisible monsters
      r3: If true, return TREATMENT_IGNORE if entity 1 is a team member and entity 2 has the STATUS_PETRIFIED status
      return: Treatment that monster 1 should apply to monster 2
  safeguard_is_active:
    value: 0x257ec
    doc: |-
      Checks if the monster is under the effect of Safeguard.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message
      return: bool
  leaf_guard_is_active:
    value: 0x25840
    doc: |-
      Checks if the monster is protected by the ability Leaf Guard.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message
      return: bool
  is_protected_from_stat_drops:
    value: 0x259d8
    doc: |-
      Checks if the target monster is protected from getting their stats dropped by the user.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message
      return: bool
  no_gastro_acid_status:
    value: 0x25b88
    doc: |-
      Checks if a monster does not have the Gastro Acid status.

      r0: entity pointer
      r1: ability ID (unused)
      return: bool
  ability_is_active:
    value: 0x25bbc
    doc: |-
      Checks if a monster has a certain ability that isn't disabled by Gastro Acid.

      r0: entity pointer
      r1: ability ID
      return: bool
  ability_is_active_veneer:
    value: 0x25c24
    doc: |-
      Likely a linker-generated veneer for AbilityIsActive.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: entity pointer
      r1: ability ID
      return: bool
  other_monster_ability_is_active:
    value: 0x25c30
    doc: |-
      Checks if there are any other monsters on the floor besides the user that have the specified ability active, subject to the user being on the floor.

      It also seems like there might be some other range or validity check, so this might not actually check ALL other monsters?

      r0: user entity pointer
      r1: ability ID
      return: bool
  levitate_is_active:
    value: 0x25cc4
    doc: |-
      Checks if a monster is levitating (has the effect of Levitate and Gravity is not active).

      r0: pointer to entity
      return: bool
  monster_is_type:
    value: 0x25cfc
    doc: |-
      Checks if a monster is a given type.

      r0: entity pointer
      r1: type ID
      return: bool
  is_type_affected_by_gravity:
    value: 0x25d34
    doc: |-
      Checks if Gravity is active and that the given type is affected (i.e., Flying type).

      r0: target entity pointer (unused)
      r1: type ID
      return: bool
  has_type_affected_by_gravity:
    value: 0x25d58
    doc: |-
      Checks if Gravity is active and that the given monster is of an affected type (i.e., Flying type).

      r0: target entity pointer
      r1: type ID
      return: bool
  can_see_invisible_monsters:
    value: 0x25d98
    doc: |-
      Returns whether a certain monster can see other invisible monsters.
      To be precise, this function returns true if the monster is holding Goggle Specs or if it has the status status::STATUS_EYEDROPS.

      r0: Entity pointer
      return: True if the monster can see invisible monsters.
  is_tactic_set:
    value: 0x25dcc
    doc: |-
      Returns whether a monster is set to use a specific tactic.

      r0: Entity pointer
      r1: Enum tactic_id
      return: True if the monster is set to the given tactic.
  has_dropeye_status:
    value: 0x25dfc
    doc: |-
      Returns whether a certain monster is under the effect of status::STATUS_DROPEYE.

      r0: Entity pointer
      return: True if the monster has dropeye status.
  iq_skill_is_enabled:
    value: 0x25e2c
    doc: |-
      Checks if a monster has a certain IQ skill enabled.

      r0: entity pointer
      r1: IQ skill ID
      return: bool
  update_iq_skills:
    value: 0x25e68
    doc: |-
      Updates the IQ skill flags of a monster.

      If the monster is a team member, copies monster::iq_skill_menu_flags to monster::iq_skill_flags. If the monster is an enemy, enables all the IQ skills it can learn (except a few that are only enabled in enemies that have a certain amount of IQ).
      If the monster is an enemy, it also sets its tactic to TACTIC_GO_AFTER_FOES.
      Called after exiting the IQ skills menu or after an enemy spawns.

      r0: monster pointer
  get_move_type_for_monster:
    value: 0x26128
    doc: |-
      Check the type of a move when used by a certain monster. Accounts for special cases such as Hidden Power, Weather Ball, the regular attack...

      r0: Entity pointer
      r1: Pointer to move data
      return: Type of the move
  get_move_power:
    value: 0x261c8
    doc: |-
      Gets the power of a move, factoring in Ginseng/Space Globe boosts.

      r0: user pointer
      r1: move pointer
      return: move power
  monster_can_throw_items:
    value: 0x26214
    doc: |-
      Returns a boolean indicating whether or not the given monster can throw items based on its monster id.

      r0: Monster pointer
      return: bool
  update_state_flags:
    value: 0x2626c
    doc: |-
      Updates monster::state_flags and monster::prev_state_flags with new values.

      r0: monster pointer
      r1: bitmask for bits to update
      r2: whether to set the bits indicated by the mask to 1 or 0
      return: whether or not any of the masked bits changed from the previous state
  is_protected_from_negative_status:
    value: 0x262dc
    doc: |-
      Checks if the target monster is protected from getting a negative status condition.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message
      return: bool
  add_exp_special:
    value: 0x263e8
    doc: |-
      Adds to a monster's experience points, subject to experience boosting effects.

      This function appears to be called only under special circumstances. Possibly when granting experience from damage (e.g., Joy Ribbon)?

      Interestingly, the parameter in r0 isn't actually used. This might be a compiler optimization to avoid shuffling registers, since this function might be called alongside lots of other functions that have both the attacker and defender as the first two arguments.

      r0: attacker pointer
      r1: defender pointer
      r2: base experience gain, before boosts
  enemy_evolution:
    value: 0x265a8
    doc: |-
      Checks if any enemies on the floor should evolve and attempts to evolve it. The
      entity pointer passed seems to get replaced by a generic placeholder entity if the
      entity pointer passed is invalid.

      r0: entity pointer
  level_up_item_effect:
    value: 0x26908
    doc: |-
      Attempts to level up the target. Calls LevelUp with a few extra checks and messages
      for using as an item. Used for the Joy Seed and Golden Seed.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of levels
      r3: bool message flag?
      stack[0]: bool show level up dialogue (for example "Hey, I leveled up!" with a portrait)?
  try_decrease_level:
    value: 0x26e34
    doc: |-
      Decrease the target monster's level if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of levels to decrease
      return: success flag
  level_up:
    value: 0x26ee8
    doc: |-
      Attempts to level up the target. Fails if the target's level can't be raised. The show level up dialogue bool does nothing for monsters not on the team.

      r0: user entity pointer
      r1: target entity pointer
      r2: bool message flag?
      r3: bool show level up dialogue (for example "Hey, I leveled up!" with a portrait)?
      return: success flag
  get_monster_moves:
    value: 0x279c4
    doc: |-
      Determines the moveset of a newly spawned monster given its species and level.

      The function loops the monster's learnset, adding moves to the list in level-up order. Once all four slots are filled up, a random existing move gets replaced to make room for the new one. This means that the monster will always have the latest move it can learn given its level.

      r0: [output] Pointer to move ID list (4 entries, 2 bytes each)
      r1: Monster ID
      r2: Monster level
  evolve_monster:
    value: 0x27b28
    doc: |-
      Makes the specified monster evolve into the specified species. Has a special case when
      a monster evolves into Ninjask and tries to spawn a Shedinja as well.

      r0: user entity pointer?
      r1: target pointer to the entity to evolve
      r2: Species to evolve into
  change_monster_animation:
    value: 0x28854
    doc: |-
      Changes the animation a monster is currently playing. Optionally changes their direction as well.

      Does nothing if the provided entity is not a monster.

      r0: Entity pointer
      r1: ID of the animation to set
      r2: Direction to turn the monster in, or DIR_NONE to keep the current direction
  get_idle_animation_id:
    value: 0x28960
    doc: |-
      Returns the animation id to be applied to a monster that is currently idling.

      Returns a different animation for monsters with the sleep, napping, nightmare or bide status, as well as for sudowoodo and for monsters with infinite sleep turns (0x7F).

      r0: pointer to entity
      return: animation ID
  determine_all_monster_shadow:
    value: 0x28a10
    doc: |-
      Change all monsters' shadows to be appropriate for their sizes and the tile they're
      standing on. It simply calls DetermineMontersShadow for all monsters in the dungeon.

      No params.
  determine_monster_shadow:
    value: 0x28a58
    doc: |-
      Changes the monster's shadow to be appropriate for its size and the tile it's standing on.
      If the tile is a floor and it's a water tileset, it changes the monster to use the water
      shadows. If the tile is secondary terrain and secondary terrain is water, it also uses the
      water shadows. If the tile is a chasm, it changes nothing and returns 6. Otherwise, use
      the default land shadow.

      r0: monster entity pointer
      return: the type of shadow used?
  display_actions:
    value: 0x28e8c
    doc: |-
      Graphically displays any pending actions that have happened but haven't been shown on screen yet. All actions are displayed at the same time. For example, this delayed display system is used to display multiple monsters moving at once even though they take turns sequentially.

      r0: Pointer to an entity. Can be null.
      return: Seems to be true if there were any pending actions to display.
  check_non_leader_tile:
    value: 0x29540
    doc: |-
      Similar to CheckLeaderTile, but for other monsters.

      Used both for enemies and team members.

      r0: Entity pointer
  end_negative_status_condition:
    value: 0x29770
    doc: |-
      Cures the target's negative status conditions. The game rarely (if not never) calls
      this function with the bool to remove the wrapping status false.

      r0: pointer to user
      r1: pointer to target
      r2: bool play animation
      r3: bool log failure message
      stack[0]: bool remove wrapping status
      return: bool succesfully removed negative status
  end_negative_status_condition_wrapper:
    value: 0x29ad4
    doc: |-
      Calls EndNegativeStatusCondition with remove wrapping status false.

      r0: pointer to user
      r1: pointer to target
      r2: bool play animation
      r3: bool log failure message
      return: bool succesfully removed negative status
  transfer_negative_status_condition:
    value: 0x29ae8
    doc: |-
      Transfers all negative status conditions the user has and gives then to the target.

      r0: user entity pointer
      r1: target entity pointer
  end_sleep_class_status:
    value: 0x29e88
    doc: |-
      Cures the target's sleep, sleepless, nightmare, yawn or napping status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_burn_class_status:
    value: 0x2a054
    doc: |-
      Cures the target's burned, poisoned, badly poisoned or paralysis status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_frozen_class_status:
    value: 0x2a104
    doc: |-
      Cures the target's freeze, shadow hold, ingrain, petrified, constriction or wrap (both as user and as target) status due to the action of the user.

      r0: pointer to user
      r1: pointer to target
      r2: if true, the event will be printed to the log
  end_cringe_class_status:
    value: 0x2a280
    doc: |-
      Cures the target's cringe, confusion, cowering, pause, taunt, encore or infatuated status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_reflect_class_status:
    value: 0x2a3a0
    doc: |-
      Removes the target's reflect, safeguard, light screen, counter, magic coat, wish, protect, mirror coat, endure, mini counter?, mirror move, conversion 2, vital throw, mist, metal burst, aqua ring or lucky chant status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  try_remove_snatched_monster_from_dungeon_struct:
    value: 0x2a584
    doc: |-
      If the target is afflicted with snatch, change dungeon::snatch_monster and dungeon::snatch_status_unique_id back
      to NULL and 0 respectively. This function does not actually remove the status and visual flags for snatch from
      the monster, it simply removes it from the dungeon struct. After calling, the user should ensure the monster
      does not still have the snatch status.

      r0: pointer to user
      r1: pointer to target
  end_curse_class_status:
    value: 0x2a5d4
    doc: |-
      Removes the target's curse (1), decoy (2), snatch (3), gastro acid (4), heal block (5), or embargo (6) status
      due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
      r2: curse class status being afflicted after (0 is the status is only being removed)
      r3: flag to log a message
  end_leech_seed_class_status:
    value: 0x2a770
    doc: |-
      Cures the target's leech seed or destiny bond status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_sure_shot_class_status:
    value: 0x2a7fc
    doc: |-
      Removes the target's sure shot, whiffer, set damage or focus energy status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_invisible_class_status:
    value: 0x2a8ac
    doc: |-
      Removes the target's invisible, transformed, mobile, or slip status due to the action of the user, and prints
      the event to the log.

      r0: pointer to user
      r1: pointer to target
      r2: flag to not log a message when removing slip status
  end_blinker_class_status:
    value: 0x2a9d4
    doc: |-
      Removes the target's blinker, cross-eyed, eyedrops, or dropeye status due to the action of the user, and
      prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_muzzled_status:
    value: 0x2aaa4
    doc: |-
      Removes the target's muzzled status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_miracle_eye_status:
    value: 0x2ab10
    doc: |-
      Removes the target's miracle eye status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  end_magnet_rise_status:
    value: 0x2ab7c
    doc: |-
      Removes the target's magnet rise status due to the action of the user, and prints the event to the log.

      r0: pointer to user
      r1: pointer to target
  transfer_negative_blinker_class_status:
    value: 0x2b798
    doc: |-
      Tries to transfer the negative blinker class status conditions from the user to
      the target.

      r0: user entity pointer
      r1: target entity pointer
      return: Whether or not the status could be transferred
  end_frozen_status:
    value: 0x2bb24
    doc: |-
      Cures the target's freeze status due to the action of the user.

      r0: user entity pointer
      r1: target entity pointer
  end_protect_status:
    value: 0x2bbc4
    doc: |-
      Ends the target's protect status due to the action of the user.

      r0: user entity pointer
      r1: target entity pointer
  try_restore_roost_typing:
    value: 0x2bc00
    doc: |-
      Tries to restore the target's original typings before the Roost effect took place. Does nothing if the target
      is not affected by Roost.

      r0: user entity pointer
      r1: target entity pointer
  try_trigger_monster_house:
    value: 0x2bdf8
    doc: |-
      Triggers a Monster House for an entity, if the right conditions are met.

      Conditions: entity is valid and on the team, the tile is a Monster House tile, and the Monster House hasn't already been triggered.

      This function sets the monster_house_triggered flag on the dungeon struct, spawns a bunch of enemies around the triggering entity (within a 4 tile radius), and handles the "dropping down" animation for these enemies. If the allow outside enemies flag is set, the enemy spawns can be on any free tile (no monster) with open terrain, including in hallways. Otherwise, spawns are confined within the room boundaries.

      r0: entity for which the Monster House should be triggered
      r1: allow outside enemies flag (in practice this is always set to dungeon_generation_info::force_create_monster_house)
  should_monster_follow_leader:
    value: 0x2c14c
    doc: |-
      Checks if the monster should follow the leader. Always returns false for enemy monsters.
      This function may actually be should monster target leader position.

      r0: Pointer to monster
      return: bool
  run_monster_ai:
    value: 0x2c1ec
    doc: |-
      Runs the AI for a single monster to determine whether the monster can act and which action it should perform if so

      r0: Pointer to monster
      r1: Unused
  apply_damage_and_effects:
    value: 0x2c4e8
    doc: |-
      Calls ApplyDamage, then performs various "post-damage" effects such as counter damage, statuses from abilities that activate on contact, and probably some other stuff.

      Note that this doesn't include the effect of Illuminate, which is specifically handled elsewhere.

      r0: attacker pointer
      r1: defender pointer
      r2: damage_data pointer
      r3: False Swipe flag (see ApplyDamage)
      stack[0]: experience flag (see ApplyDamage)
      stack[1]: Damage source (see HandleFaint)
      stack[2]: defender response flag. If true, the defender can respond to the attack with various effects. If false, the only post-damage effect that can happen is the Rage attack boost.
  apply_damage:
    value: 0x2ce8c
    doc: |-
      Applies damage to a monster. Displays the damage animation, lowers its health and handles reviving if applicable.
      The EU version has some additional checks related to printing fainting messages under specific circumstances.

      r0: Attacker pointer
      r1: Defender pointer
      r2: Pointer to the damage_data struct that contains info about the damage to deal
      r3: False Swipe flag, causes the defender's HP to be set to 1 if it would otherwise have been 0
      stack[0]: experience flag, controls whether or not experience will be granted upon a monster fainting, and whether enemy evolution might be triggered
      stack[1]: Damage source (see HandleFaint)
      return: True if the target fainted (reviving does not count as fainting)
  aftermath_check:
    value: 0x2e900
    doc: |-
      Checks if the defender has the Aftermath ability and tries to activate it if so (50% chance).

      The ability won't trigger if the damage source is DAMAGE_SOURCE_EXPLOSION.

      r0: Attacker pointer
      r1: Defender pointer
      r2: Damage source
      return: True if Aftermath was activated, false if it wasn't
  get_type_matchup_both_types:
    value: 0x2e980
    doc: |-
      Gets the type matchup for a given combat interaction, accounting for both of the user's types.

      Calls GetTypeMatchup twice and combines the result.

      r0: attacker pointer
      r1: defender pointer
      r2: attack type
      return: enum type_matchup
  scrappy_should_activate:
    value: 0x2ea4c
    doc: |-
      Checks whether Scrappy should activate.

      Scrappy activates when the ability is active on the attacker, the move type is Normal or Fighting, and the defender is a Ghost type.

      r0: attacker pointer
      r1: defender pointer
      r2: move type ID
      return: bool
  is_type_ineffective_against_ghost:
    value: 0x2eae4
    doc: |-
      Checks whether a type is normally ineffective against Ghost, i.e., it's Normal or Fighting.

      r0: type ID
      return: bool
  ghost_immunity_is_active:
    value: 0x2eaf8
    doc: |-
      Checks whether the defender's typing would give it Ghost immunities.

      This only checks one of the defender's types at a time. It checks whether the defender has the exposed status and whether the attacker has the Scrappy-like exclusive item effect, but does NOT check whether the attacker has the Scrappy ability.

      r0: attacker pointer
      r1: defender pointer
      r2: defender type index (0 the defender's first type, 1 for the defender's second type)
      return: bool
  get_type_matchup:
    value: 0x2eb4c
    doc: |-
      Gets the type matchup for a given combat interaction.

      Note that the actual monster's types on the attacker and defender pointers are not used; the pointers are only used to check conditions. The actual type matchup table lookup is done solely using the attack and target type parameters.

      This factors in some conditional effects like exclusive items, statuses, etc. There's some weirdness with the Ghost type; see the comment for struct type_matchup_table.

      r0: attacker pointer
      r1: defender pointer
      r2: target type index (0 the target's first type, 1 for the target's second type)
      r3: attack type
      return: enum type_matchup
  calc_type_based_damage_effects:
    value: 0x2ebf8
    doc: |-
      Calculates type-based effects on damage.

      Loosely, this includes type matchup effects (including modifications due to abilities, IQ skills, and exclusive items), STAB, pinch abilities like Overgrow, weather/floor condition effects on certain types, and miscellaneous effects like Charge.

      r0: [output] damage multiplier due to type effects.
      r1: attacker pointer
      r2: defender pointer
      r3: attack power
      stack[0]: attack type
      stack[1]: [output] struct containing info about the damage calculation (only the critical_hit, type_matchup, and field_0xF fields are modified)
      stack[2]: flag for whether Erratic Player and Technician effects should be excluded. CalcDamage only passes in true if the move is the regular attack or a projectile.
      return: whether or not the Type-Advantage Master IQ skill should activate if the attacker has it. In practice, this corresponds to when the attack is super-effective, but technically true is also returned when the defender is an invalid entity.
  calc_damage:
    value: 0x2faa0
    doc: |-
      The damage calculation function.

      At a high level, the damage formula is:
        M * [(153/256)*(A + P) - 0.5*D + 50*ln(10*[L + (A - D)/8 + 50]) - 311]
      where:
        - A is the offensive stat (attack or special attack) with relevant modifiers applied (stat stages, certain items, certain abilities, etc.)
        - D is the defensive stat (defense or special defense) with relevant modifiers applied (stat stages, certain items, certain abilities, etc.)
        - L is the attacker's level
        - P is the move power with relevant modifiers applied
        - M is an aggregate damage multiplier from a variety of things, such as type-effectiveness, STAB, critical hits (which are also rolled in this function), certain items, certain abilities, certain statuses, etc.

      The calculations are done primarily with 64-bit fixed point arithmetic, and a bit of 32-bit fixed point arithmetic. There's also rounding/truncation/clamping at various steps in the process.

      r0: attacker pointer
      r1: defender pointer
      r2: attack type
      r3: attack power
      stack[0]: crit chance
      stack[1]: [output] struct containing info about the damage calculation
      stack[2]: damage multiplier (as a binary fixed-point number with 8 fraction bits)
      stack[3]: move ID
      stack[4]: flag to account for certain effects (Flash Fire, Reflect, Light Screen, aura bows, Def. Scarf, Zinc Band). Only ever set to false when computing recoil damage for Jump Kick/Hi Jump Kick missing, which is based on the damage that would have been done if the move didn't miss.
  apply_damage_and_effects_wrapper:
    value: 0x31010
    doc: |-
      A wrapper for ApplyDamageAndEffects used for applying damage from sources such as statuses, traps, liquid ooze,
      hunger, and possibly more.

      r0: monster entity pointer
      r1: damage amount
      r2: damage message
      r3: damage source
  calc_recoil_damage_fixed:
    value: 0x31080
    doc: |-
      Appears to calculate recoil damage to a monster.

      This function wraps CalcDamageFixed using the monster as both the attacker and the defender, after doing some basic checks (like if the monster is already at 0 HP) and applying a boost from the Reckless ability if applicable.

      r0: entity pointer
      r1: fixed damage
      r2: ?
      r3: [output] struct containing info about the damage calculation
      stack[0]: move ID (interestingly, this doesn't seem to be used by the function)
      stack[1]: attack type
      stack[2]: damage source
      stack[3]: damage message
      others: ?
  calc_damage_fixed:
    value: 0x31134
    doc: |-
      Appears to calculate damage from a fixed-damage effect.

      r0: attacker pointer
      r1: defender pointer
      r2: fixed damage
      r3: experience flag (see ApplyDamage)
      stack[0]: [output] struct containing info about the damage calculation
      stack[1]: attack type
      stack[2]: move category
      stack[3]: damage source
      stack[4]: damage message
      others: ?
  calc_damage_fixed_no_category:
    value: 0x3129c
    doc: |-
      A wrapper around CalcDamageFixed with the move category set to none.

      r0: attacker pointer
      r1: defender pointer
      r2: fixed damage
      r3: experience flag (see ApplyDamage)
      stack[0]: [output] struct containing info about the damage calculation
      stack[1]: attack type
      stack[2]: damage source
      stack[3]: damage message
      others: ?
  calc_damage_fixed_wrapper:
    value: 0x312e8
    doc: |-
      A wrapper around CalcDamageFixed.

      r0: attacker pointer
      r1: defender pointer
      r2: fixed damage
      r3: experience flag (see ApplyDamage)
      stack[0]: [output] struct containing info about the damage calculation
      stack[1]: attack type
      stack[2]: move category
      stack[3]: damage source
      stack[4]: damage message
      others: ?
  update_shopkeeper_mode_after_attack:
    value: 0x31334
    doc: |-
      Updates the shopkeeper mode of a monster in response to being struck by an attack.

      If the defender is in normal shopkeeper mode (not aggressive), nothing happens. Otherwise, the mode is set to SHOPKEEPER_MODE_ATTACK_TEAM if the attacker is a team member, or SHOPKEEPER_MODE_ATTACK_ENEMIES otherwise.

      r0: attacker pointer
      r1: defender pointer
  update_shopkeeper_mode_after_trap:
    value: 0x31370
    doc: |-
      Updates the shopkeeper mode of a monster in response to stepping on a trap.

      If in the normal shopkeeper mode (not aggressive), nothing happens. Otherwise, the mode is set to SHOPKEEPER_MODE_ATTACK_TEAM if the trap is from a team member or SHOPKEEPER_MODE_ATTACK_ENEMIES otherwise.

      r0: shopkeeper pointer
      r1: bool non team member trap
  reset_damage_calc_diagnostics:
    value: 0x3141c
    doc: |-
      Resets the damage calculation diagnostic info stored on the dungeon struct. Called unconditionally at the start of CalcDamage.

      No params.
  specific_recruit_check:
    value: 0x31a08
    doc: |-
      Checks if a specific monster can be recruited. Called by RecruitCheck.

      Will return false if dungeon::recruiting_enabled is false, if the monster is Mew and dungeon::dungeon_objective is OBJECTIVE_RESCUE or if the monster is any of the special Deoxys forms or any of the 3 regis.
      If this function returns false, RecruitCheck will return false as well.

      r0: Monster ID
      return: True if the monster can be recruited
  recruit_check:
    value: 0x31ac4
    doc: |-
      Determines if a defeated enemy will attempt to join the team

      r0: user entity pointer
      r1: target entity pointer
      return: True if the target will attempt to join the team
  try_recruit:
    value: 0x31f58
    doc: |-
      Asks the player if they would like to recruit the enemy that was just defeated and handles the recruitment if they accept.

      r0: user entity pointer
      r1: monster to recruit entity pointer
      return: True if the monster was recruited, false if it wasn't
  try_spawn_monster_and_tick_spawn_counter:
    value: 0x325b0
    doc: |-
      First ticks up the spawn counter, and if it's equal or greater than the spawn cooldown, it will try to spawn an enemy if the number of enemies is below the spawn cap.

      If the spawn counter is greater than 900, it will instead perform the special spawn caused by the ability Illuminate.

      No params.
  ai_decide_use_item:
    value: 0x32808
    doc: |-
      Decides whether or not an AI should use its held item and updates its action_data fields accordingly.

      r0: Entity pointer
  get_possible_ai_thrown_item_directions:
    value: 0x32ca4
    doc: |-
      If the entity can throw an item at a target in a certain direction,
      adds that direction to AI_THROWN_ITEM_DIRECTIONS and the probability of throwing it to AI_THROWN_ITEM_PROBABILITIES (if it is not already present).
      The size of the arrays will be stored in AI_THROWN_ITEM_ACTION_CHOICE_COUNT.
      The caller function will select the direction to throw the item by iterating through the array(s), rolling the probability, and then throwing in that direction if the roll succeeds.
      Nothing will be thrown if all rolls fail.

      r0: Entity pointer
      r1: Integer in {1, 2}. If 1, target allies; if 2, target enemies.
      r2: Item struct pointer
      r3: If false, will call GetAiUseItemProbability to get the probability of throwing in a certain direction.
      If true, the added probability will always be 100.
  get_possible_ai_arc_item_targets:
    value: 0x32f20
    doc: |-
      Gets the positions of all targets that an AI can hit with an item thrown in an arc, such as a Gravelerock.
      The number of positions in the array will be stored in AI_THROWN_ITEM_ACTION_CHOICE_COUNT.

      r0: Entity pointer
      r1: Item struct pointer
      r2: [output] Array of size 20 for storing position structs
      r3: If false, will roll GetAiUseItemProbability every time a position is checked and not add it if it rolls false.
  try_non_leader_item_pick_up:
    value: 0x33058
    doc: |-
      Similar to TryLeaderItemPickUp, but for other monsters.

      Used both for enemies and team members.

      r0: entity pointer
  get_exclusive_item_with_effect_from_bag:
    value: 0x33548
    doc: |-
      If an exclusive item with a certain effect is present in the bag and works for the entity, returns true and copies the item struct to the address at item. Otherwise, returns false.

      r0: Entity pointer
      r1: exclusive_item_effect_id enum
      r2: [output] Item pointer
      return: bool
  aura_bow_is_active:
    value: 0x335bc
    doc: |-
      Checks if a monster is holding an aura bow that isn't disabled by Klutz.

      r0: entity pointer
      return: bool
  exclusive_item_offense_boost:
    value: 0x3366c
    doc: |-
      Gets the exclusive item boost for attack/special attack for a monster

      r0: entity pointer
      r1: move category index (0 for physical, 1 for special)
      return: boost
  exclusive_item_defense_boost:
    value: 0x3367c
    doc: |-
      Gets the exclusive item boost for defense/special defense for a monster

      r0: entity pointer
      r1: move category index (0 for physical, 1 for special)
      return: boost
  team_member_has_item_active:
    value: 0x3368c
    doc: |-
      Checks if any team member is holding a certain item and puts them into the array given.

      r0: [output] pointer to array of monsters (expected to have space for at least 4 pointers)
      r1: item ID
      return: number of team members with the item active
  team_member_has_exclusive_item_effect_active:
    value: 0x33734
    doc: |-
      Checks if any team member is under the effects of a certain exclusive item effect.

      r0: exclusive item effect ID
      return: bool
  try_spawn_enemy_item_drop:
    value: 0x338cc
    doc: |-
      Determine what item a defeated enemy should drop, if any, then (probably?) spawn that item underneath them.

      This function is called at the time when an enemy is defeated from ApplyDamage.

      r0: attacker entity (who defeated the enemy)
      r1: defender entity (who was defeated)
  tick_no_slip_cap:
    value: 0x33a84
    doc: |-
      Checks if the entity is a team member and holds the No-Slip Cap, and if so attempts to make one item in the bag sticky.

      r0: pointer to entity
  tick_status_and_health_regen:
    value: 0x34f68
    doc: |-
      Applies the natural HP regen effect by taking modifiers into account (Poison Heal, Heal Ribbon, weather-related regen). Then it ticks down counters for volatile status effects, and heals them if the counter reached zero.

      r0: pointer to entity
  inflict_sleep_status_single:
    value: 0x35704
    doc: |-
      This is called by TryInflictSleepStatus.

      r0: entity pointer
      r1: number of turns
  try_inflict_sleep_status:
    value: 0x357b8
    doc: |-
      Inflicts the Sleep status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of turns
      r3: flag to log a message on failure
  is_protected_from_sleep_class_status:
    value: 0x358c4
    doc: |-
      Checks if the monster is immune to sleep class status conditions.

      r0: user entity pointer
      r1: target entity pointer
      r2: ignore safeguard
      r3: ignore other protections (exclusive items + leaf guard)
      stack[0]: flag to log a message on failure
      return: bool
  try_inflict_nightmare_status:
    value: 0x35b2c
    doc: |-
      Inflicts the Nightmare status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of turns
  try_inflict_napping_status:
    value: 0x35c40
    doc: |-
      Inflicts the Napping status condition (from Rest) on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of turns
  try_inflict_yawning_status:
    value: 0x35d50
    doc: |-
      Inflicts the Yawning status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of turns
  try_inflict_sleepless_status:
    value: 0x35e60
    doc: |-
      Inflicts the Sleepless status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_paused_status:
    value: 0x35f4c
    doc: |-
      Inflicts the Paused status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: ?
      r3: number of turns
      stack[0]: flag to log a message on failure
      stack[1]: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_infatuated_status:
    value: 0x3608c
    doc: |-
      Inflicts the Infatuated status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_burn_status:
    value: 0x36218
    doc: |-
      Inflicts the Burn status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to apply some special effect alongside the burn?
      r3: flag to log a message on failure
      stack[0]: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_burn_status_whole_team:
    value: 0x364f8
    doc: |-
      Inflicts the Burn status condition on all team members if possible.

      No params.
  try_inflict_poisoned_status:
    value: 0x36544
    doc: |-
      Inflicts the Poisoned status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_badly_poisoned_status:
    value: 0x3681c
    doc: |-
      Inflicts the Badly Poisoned status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_frozen_status:
    value: 0x36ad8
    doc: |-
      Inflicts the Frozen status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
  try_inflict_constriction_status:
    value: 0x36d00
    doc: |-
      Inflicts the Constriction status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: animation ID
      r3: flag to log a message on failure
  try_inflict_shadow_hold_status:
    value: 0x36e58
    doc: |-
      Inflicts the Shadow Hold (AKA Immobilized) status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
  try_inflict_ingrain_status:
    value: 0x37010
    doc: |-
      Inflicts the Ingrain status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_wrapped_status:
    value: 0x370d4
    doc: |-
      Inflicts the Wrapped status condition on a target monster if possible.

      This also gives the user the Wrap status (Wrapped around foe).

      r0: user entity pointer
      r1: target entity pointer
  free_other_wrapped_monsters:
    value: 0x372d0
    doc: |-
      Frees from the wrap status all monsters which are wrapped by/around the monster passed as parameter.

      r0: pointer to entity
  try_inflict_petrified_status:
    value: 0x3734c
    doc: |-
      Inflicts the Petrified status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  lower_offensive_stat:
    value: 0x374dc
    doc: |-
      Lowers the specified offensive stat on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: number of stages
      stack[0]: flag to check for being protected from stat drops
      stack[1]: flag to log a message on failure for IsProtectedFromStatDrops
  lower_defensive_stat:
    value: 0x376f4
    doc: |-
      Lowers the specified defensive stat on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: number of stages
      stack[0]: flag to check for being protected from stat drops
      stack[1]: flag to log a message on failure for IsProtectedFromStatDrops
  boost_offensive_stat:
    value: 0x3787c
    doc: |-
      Boosts the specified offensive stat on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: number of stages
  boost_defensive_stat:
    value: 0x379e8
    doc: |-
      Boosts the specified defensive stat on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: number of stages
  flash_fire_should_activate:
    value: 0x37b54
    doc: |-
      Checks whether Flash Fire should activate, assuming the defender is being hit by a Fire-type move.

      This checks that the defender is valid and Flash Fire is active, and that Normalize isn't active on the attacker.

      r0: attacker pointer
      r1: defender pointer
      return: 2 if Flash Fire should activate and raise the defender's boost level, 1 if Flash Fire should activate but the defender's boost level is maxed out, 0 otherwise.
  activate_flash_fire:
    value: 0x37bc4
    doc: |-
      Actually applies the Flash Fire boost with a message log and animation. Passes the same monster for attacker and
      defender, but the attacker goes unused.

      r0: attacker pointer?
      r1: defender pointer
  apply_offensive_stat_multiplier:
    value: 0x37c20
    doc: |-
      Applies a multiplier to the specified offensive stat on the target monster.

      This affects struct monster_stat_modifiers::offensive_multipliers, for moves like Charm and Memento.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: multiplier
      stack[0]: ?
  apply_defensive_stat_multiplier:
    value: 0x37e44
    doc: |-
      Applies a multiplier to the specified defensive stat on the target monster.

      This affects struct monster_stat_modifiers::defensive_multipliers, for moves like Screech.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: multiplier
      stack[0]: ?
  boost_hit_chance_stat:
    value: 0x37fc4
    doc: |-
      Boosts the specified hit chance stat (accuracy or evasion) on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
  lower_hit_chance_stat:
    value: 0x3810c
    doc: |-
      Lowers the specified hit chance stat (accuracy or evasion) on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: flag to log a message on failure
  try_inflict_cringe_status:
    value: 0x382c8
    doc: |-
      Inflicts the Cringe status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_paralysis_status:
    value: 0x38424
    doc: |-
      Inflicts the Paralysis status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  boost_speed:
    value: 0x386f0
    doc: |-
      Boosts the speed of the target monster.

      If the number of turns specified is 0, a random turn count will be selected using the default SPEED_BOOST_TURN_RANGE.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of stages
      r3: number of turns
      stack[0]: flag to log a message on failure
  boost_speed_one_stage:
    value: 0x3881c
    doc: |-
      A wrapper around BoostSpeed with the number of stages set to 1.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of turns
      r3: flag to log a message on failure
  lower_speed:
    value: 0x38834
    doc: |-
      Lowers the speed of the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: number of stages
      r3: flag to log a message on failure
  try_seal_move:
    value: 0x3899c
    doc: |-
      Seals one of the target monster's moves. The move to be sealed is randomly selected.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      return: Whether or not a move was sealed
  boost_or_lower_speed:
    value: 0x38b0c
    doc: |-
      Randomly boosts or lowers the speed of the target monster by one stage with equal probability.

      r0: user entity pointer
      r1: target entity pointer
  reset_hit_chance_stat:
    value: 0x38b6c
    doc: |-
      Resets the specified hit chance stat (accuracy or evasion) back to normal on the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: stat index
      r3: ?
  exclusive_item_effect_is_active_with_logging:
    value: 0x38c20
    doc: |-
      Calls ExclusiveItemEffectIsActive, then logs the specified message if indicated.

      r0: user entity pointer
      r1: target entity pointer
      r2: whether a message should be logged if the effect is active
      r3: message ID to be logged if the effect is active
      stack[0]: exclusive item effect ID
      return: bool, same as ExclusiveItemEffectIsActive
  try_activate_quick_feet:
    value: 0x38cfc
    doc: |-
      Activate the Quick Feet ability on the defender, if the monster has it and it's active.

      r0: attacker pointer
      r1: defender pointer
      return: bool, whether or not the ability was activated
  try_inflict_terrified_status:
    value: 0x38d40
    doc: |-
      Inflicts the Terrified status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_grudge_status:
    value: 0x38d98
    doc: |-
      Inflicts the Grudge status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message
      return: Whether or not the status could be inflicted
  try_inflict_confused_status:
    value: 0x38e18
    doc: |-
      Inflicts the Confused status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_cowering_status:
    value: 0x3904c
    doc: |-
      Inflicts the Cowering status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_restore_hp:
    value: 0x3914c
    doc: |-
      Restore HP of the target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: HP to restore
      return: success flag
  try_increase_hp:
    value: 0x391c4
    doc: |-
      Restore HP and possibly boost max HP of the target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: HP to restore
      r3: max HP boost
      stack[0]: flag to log a message on failure
      return: Success flag
  reveal_items:
    value: 0x394f0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: user entity pointer
      r1: target entity pointer
  reveal_stairs:
    value: 0x39580
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: user entity pointer
      r1: target entity pointer
  reveal_enemies:
    value: 0x3963c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_leech_seed_status:
    value: 0x396cc
    doc: |-
      Inflicts the Leech Seed status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log a message on failure
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_destiny_bond_status:
    value: 0x39930
    doc: |-
      Inflicts the Destiny Bond status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_sure_shot_status:
    value: 0x39a50
    doc: |-
      Inflicts the Sure Shot status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_whiffer_status:
    value: 0x39ae0
    doc: |-
      Inflicts the Whiffer status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_set_damage_status:
    value: 0x39bc8
    doc: |-
      Inflicts the Set Damage status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_focus_energy_status:
    value: 0x39c64
    doc: |-
      Inflicts the Focus Energy status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_decoy_status:
    value: 0x39d04
    doc: |-
      Inflicts the Decoy status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      return: Whether or not the status could be inflicted
  try_inflict_curse_status:
    value: 0x39fbc
    doc: |-
      Inflicts the Curse status condition on a target monster if possible and if the user is
      a ghost type. Otherwise, just boost the user's defense and attack then lower the user's
      speed.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_snatch_status:
    value: 0x3a160
    doc: |-
      Inflicts the Snatch status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_taunt_status:
    value: 0x3a288
    doc: |-
      Inflicts the Taunt status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      return: Whether or not the status could be inflicted
  try_inflict_stockpile_status:
    value: 0x3a3b8
    doc: |-
      Inflicts the Stockpile condition on a target monster if possible. Won't boost the level
      of stockpiling above 3.

      r0: user entity pointer
      r1: target entity pointer
      return: Whether or not the status could be inflicted or boosted
  try_inflict_invisible_status:
    value: 0x3a45c
    doc: |-
      Attempts to turn the target invisible.

      The user pointer is only used when calling LogMessage functions.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_perish_song_status:
    value: 0x3a50c
    doc: |-
      Inflicts the Perish Song status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_encore_status:
    value: 0x3a600
    doc: |-
      Inflicts the Encore status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_decrease_belly:
    value: 0x3a7b8
    doc: |-
      Tries to reduce the belly size of the target. Only when max belly shrink is 0, the
      current belly is reduced by belly to lose. If both are non-zero, only the max belly
      shrink is applied.

      r0: user entity pointer
      r1: target entity pointer
      r2: belly to lose
      r3: max belly shrink
  try_increase_belly:
    value: 0x3aa90
    doc: |-
      Restore belly and possibly boost max belly of the target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: belly to restore
      r3: max belly boost (if belly is full)
      stack[0]: flag to log a message
  try_inflict_muzzled_status:
    value: 0x3b004
    doc: |-
      Inflicts the Muzzled status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_transform:
    value: 0x3b0fc
    doc: |-
      Attempts to transform the target into the species of a random monster contained in the list returned by MonsterSpawnListPartialCopy.

      The user pointer is only used when calling LogMessage functions.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_mobile_status:
    value: 0x3b2ec
    doc: |-
      Inflicts the Mobile status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_exposed_status:
    value: 0x3b3a8
    doc: |-
      Inflicts the Exposed status condition on a target monster if possible. Only applies to
      Ghost types and monsters with raised evasion. If the animation effect ID is 0,
      defaults to animation ID 0xE (this fallback animation likely can't be seen in normal
      play).

      r0: user entity pointer
      r1: target entity pointer
      r2: animation effect ID
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_activate_identify_condition:
    value: 0x3b528
    doc: |-
      Sets the flag for the identify orb which causes monsters holding items to be shown with
      a blue exclamation mark status icon.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_blinker_status:
    value: 0x3b5ac
    doc: |-
      Inflicts the Blinker status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
      r3: flag to log a message on failure
      return: Whether or not the status could be inflicted
  is_blinded:
    value: 0x3b6c4
    doc: |-
      Returns true if the monster has the blinded status (see statuses::blinded), or if it is not the leader and is holding Y-Ray Specs.

      r0: pointer to entity
      r1: flag for whether to check for the held item
      return: bool
  try_inflict_cross_eyed_status:
    value: 0x3b724
    doc: |-
      Inflicts the Cross-Eyed status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_eyedrop_status:
    value: 0x3b83c
    doc: |-
      Inflicts the Eyedrop status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_slip_status:
    value: 0x3b8ec
    doc: |-
      Inflicts the Slip status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      return: Whether or not the status could be inflicted
  try_inflict_dropeye_status:
    value: 0x3b9d4
    doc: |-
      Inflicts the Dropeye status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      return: Whether or not the status could be inflicted
  restore_all_move_pp:
    value: 0x3bb00
    doc: |-
      Restores the PP of all the target's moves by the specified amount.

      r0: user entity pointer
      r1: target entity pointer
      r2: PP to restore
      r3: flag to suppress message logging
  restore_one_move_pp:
    value: 0x3bc38
    doc: |-
      Restores the PP the target's move in the specified move slot by the specified amount.

      r0: user entity pointer
      r1: target entity pointer
      r2: move index
      r3: PP to restore
      stack[0]: flag to log message
  restore_random_move_pp:
    value: 0x3bd68
    doc: |-
      Restores the PP of a random one of the target's moves by the specified amount.

      r0: user entity pointer
      r1: target entity pointer
      r2: PP to restore
      r3: flag to log message
  apply_protein_effect:
    value: 0x3be30
    doc: |-
      Tries to boost the target's attack stat.

      r0: user entity pointer
      r1: target entity pointer
      r2: attack boost
  apply_calcium_effect:
    value: 0x3bec4
    doc: |-
      Tries to boost the target's special attack stat.

      r0: user entity pointer
      r1: target entity pointer
      r2: special attack boost
  apply_iron_effect:
    value: 0x3bf58
    doc: |-
      Tries to boost the target's defense stat.

      r0: user entity pointer
      r1: target entity pointer
      r2: defense boost
  apply_zinc_effect:
    value: 0x3bfec
    doc: |-
      Tries to boost the target's special defense stat.

      r0: user entity pointer
      r1: target entity pointer
      r2: special defense boost
  try_inflict_long_toss_status:
    value: 0x3c080
    doc: |-
      Inflicts the Long Toss status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_pierce_status:
    value: 0x3c0f0
    doc: |-
      Inflicts the Pierce status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_gastro_acid_status:
    value: 0x3c15c
    doc: |-
      Inflicts the Gastro Acid status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log message
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  set_aqua_ring_healing_countdown_to4:
    value: 0x3c2a0
    doc: |-
      Sets the countdown for Aqua Ring healing countdown to a global value (0x4).

      r0: pointer to entity
  apply_aqua_ring_healing:
    value: 0x3c2c8
    doc: |-
      Applies the passive healing gained from the Aqua Ring status.

      r0: pointer to entity
  try_inflict_aqua_ring_status:
    value: 0x3c33c
    doc: |-
      Inflicts the Aqua Ring status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_lucky_chant_status:
    value: 0x3c3e8
    doc: |-
      Inflicts the Lucky Chant status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_heal_block_status:
    value: 0x3c488
    doc: |-
      Inflicts the Heal Block status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log message
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  monster_has_embargo_status:
    value: 0x3c5ac
    doc: |-
      Returns true if the monster has the Embargo status condition.

      r0: pointer to entity
      return: bool
  log_item_blocked_by_embargo:
    value: 0x3c5e0
    doc: |-
      Logs the error message when the usage of an item is blocked by Embargo.

      r0: pointer to entity
  try_inflict_embargo_status:
    value: 0x3c60c
    doc: |-
      Inflicts the Embargo status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to log message
      r3: flag to only perform the check for inflicting without actually inflicting
      return: Whether or not the status could be inflicted
  try_inflict_miracle_eye_status:
    value: 0x3c730
    doc: |-
      Inflicts the Miracle Eye status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: flag to only perform the check for inflicting without actually inflicting
  try_inflict_magnet_rise_status:
    value: 0x3c864
    doc: |-
      Inflicts the Magnet Rise status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  is_floating:
    value: 0x3c92c
    doc: |-
      Checks if a monster is currently floating for reasons other than its typing or ability.

      In particular, this checks for Gravity and Magnet Rise.

      r0: entity pointer
      return: bool
  try_inflict_safeguard_status:
    value: 0x3cd50
    doc: |-
      Inflicts the Safeguard status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_mist_status:
    value: 0x3cdf0
    doc: |-
      Inflicts the Mist status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_wish_status:
    value: 0x3ce8c
    doc: |-
      Inflicts the Wish status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_magic_coat_status:
    value: 0x3cf2c
    doc: |-
      Inflicts the Magic Coat status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_light_screen_status:
    value: 0x3cfcc
    doc: |-
      Inflicts the Light Screen status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_reflect_status:
    value: 0x3d06c
    doc: |-
      Inflicts the Reflect status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_protect_status:
    value: 0x3d10c
    doc: |-
      Inflicts the Protect status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_mirror_coat_status:
    value: 0x3d1bc
    doc: |-
      Inflicts the Mirror Coat status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_endure_status:
    value: 0x3d258
    doc: |-
      Inflicts the Endure status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_mirror_move_status:
    value: 0x3d2f8
    doc: |-
      Inflicts the Mirror Move status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_conversion2_status:
    value: 0x3d398
    doc: |-
      Inflicts the Conversion2 status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_inflict_vital_throw_status:
    value: 0x3d464
    doc: |-
      Inflicts the Vital Throw status condition on a target monster if possible.

      r0: user entity pointer
      r1: target entity pointer
  try_reset_stat_changes:
    value: 0x3d504
    doc: |-
      Tries to reset the stat changes of the defender.

      r0: attacker entity pointer
      r1: defender entity pointer
      r3: bool to force animation
  mirror_move_is_active:
    value: 0x3d628
    doc: |-
      Checks if the monster is under the effect of Mirror Move.

      Returns 1 if the effects is a status, 2 if it comes from an exclusive item, 0 otherwise.

      r0: pointer to entity
      return: int
  mist_is_active:
    value: 0x3d6ac
    doc: |-
      Checks if the monster is under the effect of Mist.

      Returns 1 if the effects is a status, 2 if it comes from an exclusive item, 0 otherwise.

      r0: pointer to entity
      return: int
  conversion2_is_active:
    value: 0x3d6f4
    doc: |-
      Checks if the monster is under the effect of Conversion 2 (its type was changed).

      Returns 1 if the effects is a status, 2 if it comes from an exclusive item, 0 otherwise.

      r0: pointer to entity
      return: int
  ai_consider_move:
    value: 0x3d760
    doc: |-
      The AI uses this function to check if a move has any potential targets, to calculate the list of potential targets and to calculate the move's special weight.
      This weight will be higher if the pokémon has weak-type picker and the target is weak to the move (allies only, enemies always get a result of 1 even if the move is super effective). More things could affect the result.
      This function also sets the flag can_be_used on the ai_possible_move struct if it makes sense to use it.
      More research is needed. There's more documentation about this special weight. Does all the documented behavior happen in this function?

      r0: ai_possible_move struct for this move
      r1: Entity pointer
      r2: Move pointer
      return: Move's calculated special weight
  try_add_target_to_ai_target_list:
    value: 0x3de90
    doc: |-
      Checks if the specified target is eligible to be targeted by the AI and if so adds it to the list of targets. This function also fills an array that seems to contain the directions in which the user should turn to look at each of the targets in the list, as well as a third unknown array.

      r0: Number of existing targets in the list
      r1: Move's AI range field
      r2: User entity pointer
      r3: Target entity pointer
      stack[0]: Move pointer
      stack[1]: check_all_conditions parameter to pass to IsAiTargetEligible
      return: New number of targets in the target list
  is_ai_target_eligible:
    value: 0x3df84
    doc: |-
      Checks if a given target is eligible to be targeted by the AI with a certain move

      r0: Move's AI range field
      r1: User entity pointer
      r2: Target entity pointer
      r3: Move pointer
      stack[0]: True to check all the possible move_ai_condition values, false to only check for move_ai_condition::AI_CONDITION_RANDOM (if the move has a different ai condition, the result will be false).
      return: True if the target is eligible, false otherwise
  is_target_in_range:
    value: 0x3e574
    doc: |-
      Returns true if the target is within range of the user's move, false otherwise.

      If the user does not have Course Checker, it simply checks if the distance between user and target is less or equal than the move range.
      Otherwise, it will iterate through all tiles in the direction specified, checking for walls or other monsters in the way, and return false if they are found.

      r0: user pointer
      r1: target pointer
      r2: direction ID
      r3: move range (in number of tiles)
  should_use_pp:
    value: 0x3e680
    doc: |-
      Checks if a monster should use PP when using a move. It also displays the corresponding animation if PP Saver triggers and prints the required messages to the message log.

      r0: entity pointer
      return: True if the monster should not use PP, false if it should.
  get_entity_move_target_and_range:
    value: 0x3eb8c
    doc: |-
      Gets the move target-and-range field when used by a given entity. See struct move_target_and_range in the C headers.

      r0: entity pointer
      r1: move pointer
      r2: AI flag (same as GetMoveTargetAndRange)
      return: move target and range
  get_entity_natural_gift_info:
    value: 0x3ed70
    doc: |-
      Gets the relevant entry in NATURAL_GIFT_ITEM_TABLE based on the entity's held item, if possible.

      r0: entity pointer
      return: pointer to a struct natural_gift_item_info, or null if none was found
  get_entity_weather_ball_type:
    value: 0x3edec
    doc: |-
      Gets the current Weather Ball type for the given entity, based on the apparent weather.

      r0: entity pointer
      return: type ID
  activate_motor_drive:
    value: 0x3ef40
    doc: |-
      Displays the message and applies the speed boost for the ability Motor Drive.

      r0: monster pointer
  try_activate_frisk:
    value: 0x3ef84
    doc: |-
      Tries to activate the Frisk ability on the defender. The attacker has to be on the team and the defender has to be
      holding an item or be able to drop a treasure box.

      r0: attacker pointer
      r1: defender pointer
  try_activate_bad_dreams:
    value: 0x3f098
    doc: |-
      Tries to apply the damage from Bad Dreams to all sleeping monsters in the room.

      r0: monster pointer
  activate_stench:
    value: 0x3f21c
    doc: |-
      Activate the Stench ability on the monster.

      r0: monster pointer
  try_activate_steadfast:
    value: 0x3f244
    doc: |-
      Activate the Steadfast ability on the defender, if the monster has it and it's active.

      r0: attacker pointer
      r1: defender pointer
  is_in_spawn_list:
    value: 0x3f2dc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: spawn_list_ptr
      r1: monster ID
      return: bool
  change_shaymin_forme:
    value: 0x3f3cc
    doc: |-
      forme:
        1: change from Land to Sky
        2: change from Sky to Land
      result:
        0: not Shaymin
        1: not correct Forme
        2: frozen
        3: ok

      Note: unverified, ported from Irdkwia's notes

      r0: Target
      r1: forme
      return: result
  apply_item_effect:
    value: 0x3f56c
    doc: |-
      Seems to apply an item's effect via a giant switch statement?

      r3: attacker pointer
      stack[0]: defender pointer
      stack[1]: thrown item pointer
      others: ?
  apply_cheri_berry_effect:
    value: 0x40ad4
    doc: |-
      Tries to heal the paralysis status condition. Prints a message on failure.

      r0: user entity pointer
      r1: target entity pointer
  apply_pecha_berry_effect:
    value: 0x40b00
    doc: |-
      Tries to heal the poisoned and badly poisoned status condition. Prints a message on
      failure.

      r0: user entity pointer
      r1: target entity pointer
  apply_rawst_berry_effect:
    value: 0x40b34
    doc: |-
      Tries to heal the burn status condition. Prints a message on failure.

      r0: user entity pointer
      r1: target entity pointer
  apply_hunger_seed_effect:
    value: 0x40b7c
    doc: |-
      Empties the targets belly to cause Hungry Pal status in non-leader monsters and
      Famished in the leader monster.

      r0: user entity pointer
      r1: target entity pointer
  apply_vile_seed_effect:
    value: 0x40c68
    doc: |-
      Reduces the targets defense and special defense stages to the lowest level.

      r0: attacker pointer
      r1: defender pointer
  apply_violent_seed_effect:
    value: 0x40d04
    doc: |-
      Boosts the target's offensive stats stages to the max.

      r0: user entity pointer
      r1: target entity pointer
  apply_ginseng_effect:
    value: 0x40d50
    doc: |-
      Boosts the power of the move at the top of the target's Move List. Appears to have a
      leftover check to boost the power of a move by 3 instead of 1 that always fails because
      the chance is 0.

      r0: user entity pointer
      r1: target entity pointer
  apply_blast_seed_effect:
    value: 0x40e6c
    doc: |-
      If thrown, unfreeze and deal fixed damage to the defender. If not thrown, try to find 
      a monster in front of the attacker. If a monster is found unfreeze and dedal fixed 
      damage to the defender. Appears to have a leftover check for if the current fixed room is a boss fight and loads a different pointer for the damage when used in a boss room.
      However, this isn't noticeable because both the normal and boss damage is the same.

      r0: user entity pointer
      r1: target entity pointer
      r2: bool thrown
  apply_gummi_boosts_dungeon_mode:
    value: 0x40fa8
    doc: |-
      Applies the IQ and possible stat boosts from eating a Gummi to the target monster.

      r0: user entity pointer
      r1: target entity pointer
      r2: Gummi type ID
      r3: Stat boost amount, if a random stat boost occurs
  can_monster_use_item:
    value: 0x4138c
    doc: |-
      Checks whether a monster can use a certain item.

      Returns false if the item is sticky, or if the monster is under the STATUS_MUZZLED status and the item is edible.
      Also prints failure messages if required.

      r0: Monster entity pointer
      r1: Item pointer
      return: True if the monster can use the item, false otherwise
  apply_grimy_food_effect:
    value: 0x4141c
    doc: |-
      Randomly inflicts poison, shadow hold, burn, paralysis, or an offensive stat debuff
      to the target. If the survivalist iq skill or gluttony ability is active, the target
      has a 50% chance not to be affected.

      r0: user entity pointer
      r1: target entity pointer
  apply_mix_elixir_effect:
    value: 0x41568
    doc: |-
      If the target monster is a Linoone, restores all the PP of all the target's moves.

      r0: user entity pointer
      r1: target entity pointer
  apply_dough_seed_effect:
    value: 0x415c8
    doc: |-
      If the target monster is a team member, set dough_seed_extra_poke_flag to true to 
      make extra poke spawn on the next floor. Otherwise, do nothing.

      r0: user entity pointer
      r1: target entity pointer
  apply_via_seed_effect:
    value: 0x41634
    doc: |-
      Tries to randomly teleport the target with a message for eating the seed.

      r0: user entity pointer
      r1: target entity pointer
  apply_gravelyrock_effect:
    value: 0x416a8
    doc: |-
      Restores 10 hunger to the target and will raise the target's IQ if they are a bonsly
      or sudowoodo.

      r0: user entity pointer
      r1: target entity pointer
  apply_gone_pebble_effect:
    value: 0x41720
    doc: |-
      Causes a few visual effects, temporarily changes the dungeon music to the Goodnight
      track, and gives the target the enduring status.

      r0: user entity pointer
      r1: target entity pointer
  apply_gracidea_effect:
    value: 0x418a8
    doc: |-
      If the target is Shaymin, attempt to change the target's form to Shaymin Sky Forme. Otherwise, do nothing.

      r0: user entity pointer
      r1: target entity pointer
  get_ai_use_item_probability:
    value: 0x41f44
    doc: |-
      Called to get the probability of an item being used or thrown by an AI on the current turn.

      r0: Pointer to either the user if it is an item used by the AI or the target if it is an item thrown by the AI
      r1: Pointer to item
      r2: Size-2 bitvector: if bit 0 is set, the AI is throwing the item. If bit 1 is set, it is targeting an ally with the item.
      return: Integer in range [0, 100]
  is_adjacent_to_enemy:
    value: 0x427d8
    doc: |-
      Called to check if a hostile entity is present in any of the tiles adjacent to an entity.

      r0: Pointer to entity
      return: True if yes, false if no
  should_try_eat_item:
    value: 0x42878
    doc: |-
      Checks if a given item should be eaten by the TryEatItem effect.

      Returns false if the ID is lower than 0x45, greater than 0x8A or if it's listed in the EAT_ITEM_EFFECT_IGNORE_LIST array.

      r0: Item ID
      return: True if the item should be eaten by TryEatItem.
  get_max_pp_wrapper:
    value: 0x428d8
    doc: |-
      Gets the maximum PP for a given move. A wrapper around the function in the ARM 9 binary.

      r0: move pointer
      return: max PP for the given move, capped at 99
  move_is_not_physical:
    value: 0x42900
    doc: |-
      Checks if a move isn't a physical move.

      r0: move ID
      return: bool
  category_is_not_physical:
    value: 0x42918
    doc: |-
      Checks that a move category is not CATEGORY_PHYSICAL.

      r0: move category ID
      return: bool
  try_drought:
    value: 0x4347c
    doc: |-
      Attempts to drain all water from the current floor.

      Fails if orbs are disabled on the floor or if the current tileset has the is_water_tileset flag set.

      r0: user pointer
  try_pounce:
    value: 0x43b08
    doc: |-
      Makes the target monster execute the Pounce action in a given direction if possible.

      If the direction ID is 8, the target will pounce in the direction it's currently facing.

      r0: user entity pointer
      r1: target entity pointer
      r2: direction ID
  try_blow_away:
    value: 0x43cc8
    doc: |-
      Blows away the target monster in a given direction if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: direction ID
  try_explosion:
    value: 0x44330
    doc: |-
      Creates an explosion if possible.

      The target monster is considered the source of the explosion.

      r0: user entity pointer
      r1: target entity pointer
      r2: coordinates where the explosion should take place (center)
      r3: explosion radius (only works correctly with 1 and 2)
      stack[0]: damage type
      stack[1]: damage source
  try_aftermath_explosion:
    value: 0x44670
    doc: |-
      Creates the explosion for the ability aftermath if possible.

      The target monster is considered the source of the explosion.

      r0: user entity pointer
      r1: target entity pointer
      r2: coordinates where the explosion should take place (center)
      r3: explosion radius (only works correctly with 1 and 2)
      stack[0]: damage type
      stack[1]: damage source (normally DAMAGE_SOURCE_EXPLOSION)
  try_warp:
    value: 0x44bf0
    doc: |-
      Makes the target monster warp if possible.

      r0: user entity pointer
      r1: target entity pointer
      r2: warp type
      r3: position (if warp type is position-based)
  ensure_can_stand_current_tile:
    value: 0x44fec
    doc: |-
      Checks that the given monster is standing on a tile it can stand on given its
      movement type and warps it if not. If the monster is a non-leader ally, they
      will be warped to the leader. Otherwise, the monster is warped randomly.

      r0: Entity pointer
  try_activate_nondamaging_defender_ability:
    value: 0x45960
    doc: |-
      Applies the effects of a defender's ability on an attacker. After a move is used,
      this function is called to see if any of the bitflags for an ability were set and
      applies the corresponding effect. (The way leech seed removes certain statuses is
      also handled here.)

      r0: entity pointer
  try_activate_nondamaging_defender_exclusive_item:
    value: 0x45bd8
    doc: |-
      Applies the effects of a defender's item on an attacker. After a move is used,
      this function is called to see if any of the bitflags for an item were set and
      applies the corresponding effect.

      r0: attacker entity pointer
      r1: defender entity pointer
  get_move_range_distance:
    value: 0x4618c
    doc: |-
      Returns the maximum reach distance of a move, based on its AI range value.

      If the move doesn't have an AI range value of RANGE_FRONT_10, RANGE_FRONT_WITH_CORNER_CUTTING or RANGE_FRONT_2_WITH_CORNER_CUTTING, returns 0.
      If r2 is true, the move is a two-turn move and the user isn't charging said move, returns 0.

      r0: User entity pointer
      r1: Move pointer
      r2: True to perform the two-turn move check
      return: Maximum reach distance of the move, in tiles.
  move_hit_check:
    value: 0x47b30
    doc: |-
      Determines if a move used hits or misses the target. It gets called twice per target, once with r3 = false and a second time with r3 = true.

      r0: Attacker
      r1: Defender
      r2: Pointer to move data
      r3: False if the move's first accuracy (accuracy1) should be used, true if its second accuracy (accuracy2) should be used instead.
      stack[0]: If true, always hit if the attacker and defender are the same. Otherwise, moves can miss no matter what the attacker and defender are.
      return: True if the move hits, false if it misses.
  build_move_target_list:
    value: 0x47f18
    doc: |-
      Builds the list of targets of a given move for a given user

      r0: [output] Buffer where the resulting list should be stored
      r1: Pointer to entity using the move
      r2: Pointer to move data
  is_hyper_beam_variant:
    value: 0x4841c
    doc: |-
      Checks if a move is a Hyper Beam variant that requires a a turn to recharge.

      Include moves: Frenzy Plant, Hydro Cannon, Hyper Beam, Blast Burn, Rock Wrecker, Giga Impact, Roar of Time

      r0: move
      return: bool
  is_charging_two_turn_move:
    value: 0x4848c
    doc: |-
      Checks if a monster is currently charging the specified two-turn move.

      r0: User entity pointer
      r1: Move pointer
      return: True if the user is charging the specified two-turn move, false otherwise.
  is_charging_any_two_turn_move:
    value: 0x48504
    doc: |-
      Returns a boolean indicating whether or not the given entity is charging any two-turn move.

      r0: Entity pointer
      r1: Unused boolean which was supposed to make function return true if the entity is under the effect of Charge (the Electric-type move).
          However, the conditional which uses this boolean will never be activated, as the loop will always terminate before getting to it.
      return: bool
  has_max_ginseng_boost99:
    value: 0x48680
    doc: |-
      Checks if a move has a max Ginseng boost value of 99

      r0: Move
      return: True if the move's max Ginseng boost is 99, false otherwise.
  two_turn_move_forced_miss:
    value: 0x4873c
    doc: |-
      Checks if a move should miss a monster due to the monster being in the middle of Fly, Bounce, Dive, Dig, Shadow Force, or some other two-turn move that grants pseudo-invincibility.

      r0: entity pointer
      r1: move
      return: true if the move should miss
  dungeon_rand_outcome_user_target_interaction:
    value: 0x4881c
    doc: |-
      Like DungeonRandOutcome, but specifically for user-target interactions.

      This modifies the underlying random process depending on factors like Serene Grace, and whether or not either entity has fainted.

      r0: user entity pointer
      r1: target entity pointer
      r2: base success percentage (100*p). 0 is treated specially and guarantees success.
      return: True if the random check passed, false otherwise.
  dungeon_rand_outcome_user_action:
    value: 0x48908
    doc: |-
      Like DungeonRandOutcome, but specifically for user actions.

      This modifies the underlying random process to factor in Serene Grace (and checks whether the user is a valid entity).

      r0: entity pointer
      r1: base success percentage (100*p). 0 is treated specially and guarantees success.
      return: True if the random check passed, false otherwise.
  can_ai_use_move:
    value: 0x4895c
    doc: |-
      Checks if an AI-controlled monster can use a move.
      Will return false if the any of the flags move::f_exists, move::f_subsequent_in_link_chain or move::f_disabled is true. The function does not check if the flag move::f_enabled_for_ai is set. This function also returns true if the call to CanMonsterUseMove is true.
      The function contains a loop that is supposed to check other moves after the specified one, but the loop breaks after it finds a move that isn't linked, which is always true given the checks in place at the start of the function.

      r0: Entity pointer
      r1: Move index
      r2: extra_checks parameter when calling CanMonsterUseMove
      return: True if the AI can use the move (not accounting for move::f_enabled_for_ai)
  can_monster_use_move:
    value: 0x48a0c
    doc: |-
      Checks if a monster can use the given move.
      Will always return true for the regular attack. Will return false if the move if the flag move::f_disabled is true, if the flag move::f_sealed is true. More things will be checked if the extra_checks parameter is true.

      r0: Entity pointer
      r1: Move pointer
      r2: True to check whether the move is out of PP, whether it can be used under the taunted status and whether the encore status prevents using the move
      return: True if the monster can use the move, false otherwise.
  update_move_pp:
    value: 0x48c74
    doc: |-
      Updates the PP of any moves that were used by a monster, if PP should be consumed.

      r0: entity pointer
      r1: flag for whether or not PP should be consumed
  get_damage_source_wrapper:
    value: 0x48d2c
    doc: |-
      Wraps GetDamageSource (in arm9) for a move info struct rather than a move ID.

      r0: move info pointer
      r1: item ID
      return: damage source
  lower_sshort:
    value: 0x48d4c
    doc: |-
      Gets the lower 2 bytes of a 4-byte number and interprets it as a signed short.

      r0: 4-byte number x
      return: (short) x
  play_move_animation:
    value: 0x4959c
    doc: |-
      Handles the process of getting and playing all the animations for a move. Waits
      until the animation has no more frames before returning.

      r0: Pointer to the entity that used the move
      r1: Pointer to the entity that is the target
      r2: Move pointer
      r3: position
  get_move_animation_id:
    value: 0x499f8
    doc: |-
      Returns the move animation ID that should be played for a move.
      It contains a check for weather ball. After that, if the parameter should_play_alternative_animation is false, the move ID is returned. If it's true, there's a bunch of manual ID checks that result on a certain hardcoded return value.

      r0: Move ID
      r1: Apparent weather for the monster who used the move
      r2: Result of ShouldMovePlayADifferentAnimation
      return: Move animation ID
  should_move_play_alternative_animation:
    value: 0x49b60
    doc: |-
      Checks whether a moved used by a monster should play its alternative animation. Includes checks for Curse, Snore, Sleep Talk, Solar Beam and 2-turn moves.

      r0: Pointer to the entity that used the move
      r1: Move pointer
      return: True if the move should play its alternative animation
  execute_move_effect:
    value: 0x52724
    doc: |-
      Handles the effects that happen after a move is used. Includes a loop that is run for each target, mutiple ability checks and the giant switch statement that executes the effect of the move used given its ID.

      r0: pointer to list of targets
      r1: attacker pointer
      r2: pointer to move data
      r3: ?
      stack[0]: ?
  do_move_damage_inlined:
    value: 0x56930
    doc: |-
      Exactly the same as DoMoveDamage, except it appears DealDamage was inlined.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: item ID
      return: whether or not damage was dealt
  deal_damage:
    value: 0x569e0
    doc: |-
      Deals damage from a move or item used by an attacking monster on a defending monster.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: damage multiplier (as a binary fixed-point number with 8 fraction bits)
      stack[0]: item ID
      return: amount of damage dealt
  deal_damage_with_type_and_power_boost:
    value: 0x56a78
    doc: |-
      Same as DealDamage, except with an explicit move type and a base power boost.

      r0: attacker pointer
      r1: defender pointer
      r2: move
      r3: damage multiplier (as a binary fixed-point number with 8 fraction bits)
      stack[0]: item ID
      stack[1]: move type
      stack[2]: base power boost
      return: amount of damage dealt
  deal_damage_projectile:
    value: 0x56b0c
    doc: |-
      Deals damage from a variable-damage projectile.

      r0: entity pointer 1?
      r1: entity pointer 2?
      r2: move pointer
      r3: move power
      stack[0]: damage multiplier (as a binary fixed-point number with 8 fraction bits)
      stack[1]: item ID of the projectile
      return: Calculated damage
  deal_damage_with_type:
    value: 0x56b9c
    doc: |-
      Same as DealDamage, except with an explicit move type.

      r0: attacker pointer
      r1: defender pointer
      r2: move type
      r3: move
      stack[0]: damage multiplier (as a binary fixed-point number with 8 fraction bits)
      stack[1]: item ID
      return: amount of damage dealt
  perform_damage_sequence:
    value: 0x56c2c
    doc: |-
      Performs the "damage sequence" given the results of the damage calculation. This includes running the accuracy roll with MoveHitCheck, calling ApplyDamageAndEffects, and some other miscellaneous bits of state bookkeeping (including handling the effects of Illuminate).

      This is the last function called by DealDamage. The result of this call is the return value of DealDamage and its relatives.

      r0: Attacker pointer
      r1: Defender pointer
      r2: Move pointer
      r3: [output] struct containing info about the damage calculation
      stack[0]: Damage source
      return: Calculated damage
  can_hit_with_regular_attack:
    value: 0x56e88
    doc: |-
      Returns true if the defender is adjacent to the attacker and can hit them with a regular attack.
      Notably, this check is what prevents ranged moves, moves that cut corners, etc. from being reflected by Magic Coat and Mirror Move.

      r0: Entity pointer (attacker)
      r1: Entity pointer (defender)
      return: bool
  status_checker_check:
    value: 0x56f34
    doc: |-
      Determines if using a given move against its intended targets would be redundant because all of them already have the effect caused by said move.

      r0: Pointer to the entity that is considering using the move
      r1: Move pointer
      return: True if it makes sense to use the move, false if it would be redundant given the effects it causes and the effects that all the targets already have.
  get_apparent_weather:
    value: 0x58bc8
    doc: |-
      Get the weather, as experienced by a specific entity.

      r0: entity pointer
      return: weather ID
  try_weather_form_change:
    value: 0x59030
    doc: |-
      Tries to change a monster into one of its weather-related alternative forms. Applies to Castform and Cherrim, and checks for their unique abilities.

      r0: pointer to entity
  activate_sport_condition:
    value: 0x5930c
    doc: |-
      Activates the Mud Sport or Water Sport condition on the dungeon floor for some number of turns.

      r0: water sport flag (false for Mud Sport, true for Water Sport)
  try_activate_weather:
    value: 0x59384
    doc: |-
      Tries to change the weather based upon the information for each weather type in the
      dungeon struct. Returns whether the weather was succesfully changed or not.

      r0: bool to log message and play animation?
      r1: bool to force weather change and animation?
      return: True if the weather changed
  digit_count:
    value: 0x59530
    doc: |-
      Counts the number of digits in a nonnegative integer.

      If the number is negative, it is cast to a uint16_t before counting digits.

      r0: int
      return: number of digits in int
  load_texture_ui:
    value: 0x59580
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  display_number_texture_ui:
    value: 0x5974c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: x position
      r1: y position
      r2: number
      r3: ally_mode
      return: xsize
  display_char_texture_ui:
    value: 0x59854
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: render_3d_element_64
      r1: x position
      r2: y position
      r3: char_id
      stack[0]: ?
      return: ?
  display_ui:
    value: 0x598dc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  get_tile:
    value: 0x5a14c
    doc: |-
      Get the tile at some position. If the coordinates are out of bounds, returns a default tile.

      r0: x position
      r1: y position
      return: tile pointer
  get_tile_safe:
    value: 0x5a1b4
    doc: |-
      Get the tile at some position. If the coordinates are out of bounds, returns a pointer to a copy of the default tile.

      r0: x position
      r1: y position
      return: tile pointer
  is_full_floor_fixed_room:
    value: 0x5a224
    doc: |-
      Checks if the current fixed room on the dungeon generation info corresponds to a fixed, full-floor layout.

      The first non-full-floor fixed room is 0xA5, which is for Sealed Chambers.

      return: bool
  is_current_tileset_background:
    value: 0x5a254
    doc: |-
      Calls IsBackgroundTileset with the current tileset ID

      return: True if the current dungeon tileset is a background, false if it's a regular tileset.
  try_spawn_golden_chamber:
    value: 0x5a274
    doc: |-
      Changes the tileset and fixed room id of the floor for the Golden Chamber if the floor should be a
      Golden Chamber.

      No params.
  count_items_on_floor_for_acute_sniffer:
    value: 0x5a2b0
    doc: |-
      Counts the number of items on the floor by checking every tile for an item and stores it into
      dungeon::item_sniffer_item_count

      No params.
  get_stairs_spawn_position:
    value: 0x5a410
    doc: |-
      Gets the spawn position for the stairs and stores it at the passed pointers.

      r0: [output] pointer to x coordinate
      r1: [output] pointer to y coordinate
  position_is_on_stairs:
    value: 0x5a43c
    doc: |-
      Checks if this location is on top of the staircase. In the game it is only used to check if an outlaw has reached
      the staircase.

      r0: x coordinate
      r1: y coordinate
      return: bool
  get_stairs_room:
    value: 0x5a478
    doc: |-
      Returns the index of the room that contains the stairs

      return: Room index
  get_default_tile_texture_id:
    value: 0x5a4a0
    doc: |-
      Returns the texture_id of the default tile?

      return: texture_id
  determine_all_tiles_walkable_neighbors:
    value: 0x5aa9c
    doc: |-
      Evaluates the walkable_neighbor_flags for all tiles.

      No params.
  determine_tile_walkable_neighbors:
    value: 0x5aad4
    doc: |-
      Evaluates the walkable_neighbor_flags for the this tile by checking the 8 adjacent tiles.

      r0: x coordinate
      r1: y coordinate
  update_traps_visibility:
    value: 0x5af9c
    doc: |-
      Exact purpose unknown. Gets called whenever a trap tile is shown or hidden.

      No params.
  draw_tile_grid:
    value: 0x5b478
    doc: |-
      Draws a grid on the nearby walkable tiles. Triggered by pressing Y.

      r0: Coordinates of the entity around which the grid will be drawn
      r1: ?
      r2: ?
      r3: ?
  hide_tile_grid:
    value: 0x5b7ec
    doc: |-
      Hides the grid on the nearby walkable tiles. Triggered by releasing Y.

      No params.
  discover_minimap:
    value: 0x5ba8c
    doc: |-
      Discovers the tiles around the specified position on the minimap.

      The discovery radius depends on the visibility range of the floor. If display_data::blinded is true, the function returns early without doing anything.

      r0: Position around which the map should be discovered
  position_has_item:
    value: 0x5bb7c
    doc: |-
      Checks if the tile at the position has an item on it.

      r0: Position to check
      return: bool
  position_has_monster:
    value: 0x5bbb8
    doc: |-
      Checks if the tile at the position has a monster on it.

      r0: Position to check
      return: bool
  try_smash_wall:
    value: 0x5bbec
    doc: |-
      Checks if the tile at the position is a wall. If so, smash it (turn it into a floor tile), play an animation

      r0: Wall position to smash
      return: bool
  is_water_tileset:
    value: 0x5bee4
    doc: |-
      Returns flag tileset_property::is_water_tileset for the current tileset

      return: True if the current tileset is a water tileset
  get_random_spawn_monster_id:
    value: 0x5bfe8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: monster ID?
  nearby_ally_iq_skill_is_enabled:
    value: 0x5c2d8
    doc: |-
      Appears to check whether or not the given monster has any allies nearby (within 1 tile) that have the given IQ skill active.

      r0: entity pointer
      r1: IQ skill ID
      return: bool
  reset_gravity:
    value: 0x5c3bc
    doc: |-
      Resets gravity (and the byte after it?) in the dungeon struct back to 0.

      No params.
  gravity_is_active:
    value: 0x5c3e0
    doc: |-
      Checks if gravity is active on the floor.

      return: bool
  try_activate_gravity:
    value: 0x5c40c
    doc: |-
      Attempts to activate Gravity for this dungeon floor.

      return: whether or not gravity was activated
  should_boost_kecleon_shop_spawn_chance:
    value: 0x5c510
    doc: |-
      Gets the boost_kecleon_shop_spawn_chance field on the dungeon struct.

      return: bool
  set_should_boost_kecleon_shop_spawn_chance:
    value: 0x5c528
    doc: |-
      Sets the boost_kecleon_shop_spawn_chance field on the dungeon struct to the given value.

      r0: bool to set the flag to
  update_should_boost_kecleon_shop_spawn_chance:
    value: 0x5c540
    doc: |-
      Sets the boost_kecleon_shop_spawn_chance field on the dungeon struct depending on if a team member has the exclusive item effect for more kecleon shops.

      No params.
  get_dough_seed_flag:
    value: 0x5c580
    doc: |-
      Gets the dough_seed_extra_money_flag field on the dungeon struct.

      return: bool
  set_dough_seed_flag:
    value: 0x5c598
    doc: |-
      Sets the dough_seed_extra_money_flag field on the dungeon struct to the given value.

      r0: bool to set the flag to
  try_spawn_dough_seed_poke:
    value: 0x5c5b0
    doc: |-
      Checks the dough_seed_extra_money_flag field on the dungeon struct and tries to spawn
      extra poke if it is set.

      No params.
  is_secret_bazaar:
    value: 0x5c614
    doc: |-
      Checks if the current floor is the Secret Bazaar.

      return: bool
  should_boost_hidden_stairs_spawn_chance:
    value: 0x5c63c
    doc: |-
      Gets the boost_hidden_stairs_spawn_chance field on the dungeon struct.

      return: bool
  set_should_boost_hidden_stairs_spawn_chance:
    value: 0x5c654
    doc: |-
      Sets the boost_hidden_stairs_spawn_chance field on the dungeon struct to the given value.

      r0: bool to set the flag to
  update_should_boost_hidden_stairs_spawn_chance:
    value: 0x5c66c
    doc: |-
      Sets the boost_hidden_stairs_spawn_chance field on the dungeon struct depending on if a team member has the exclusive item effect for more hidden stairs.

      No params.
  is_secret_room:
    value: 0x5c6ac
    doc: |-
      Checks if the current floor is the Secret Room fixed floor (from hidden stairs).

      return: bool
  is_secret_floor:
    value: 0x5c6d4
    doc: |-
      Checks if the current floor is a secret bazaar or a secret room.

      return: bool
  get_current_hidden_stairs_type:
    value: 0x5c700
    doc: |-
      Checks if the current floor is a secret bazaar or a secret room and returns which one it is.

      return: enum hidden_stairs_type
  hidden_stairs_present:
    value: 0x5c728
    doc: |-
      Checks if the hidden stairs are present on this floor.

      The function checks that dungeon_generation_info::hidden_stairs_pos isn't (-1, -1)

      return: True if the hidden stairs are present on this floor, false otherwise.
  position_is_on_hidden_stairs:
    value: 0x5c758
    doc: |-
      Checks if this location is on top of the hidden stairs.

      r0: position pointer
      return: bool
  hidden_stairs_trigger:
    value: 0x5c7e4
    doc: |-
      Called whenever the leader steps on the hidden stairs.

      If the stairs hadn't been revealed yet, plays the corresponding animation.

      r0: True to display a message if the stairs are revealed, false to omit it.
  get_hidden_stairs_field:
    value: 0x5c8a0
    doc: |-
      Gets the hidden_stairs_type variable from dungeon::dungeon_generation_info.

      return: enum hidden_stairs_type
  set_hidden_stairs_field:
    value: 0x5c8b8
    doc: |-
      Sets the hidden_stairs_type variable from dungeon::dungeon_generation_info to a certain value.

      r0: New value
  get_hidden_floor_field:
    value: 0x5c8d0
    doc: |-
      Gets the hidden_floor_type variable from dungeon::dungeon_generation_info.

      return: enum hidden_stairs_type
  set_hidden_floor_field:
    value: 0x5c8e8
    doc: |-
      Sets the hidden_floor_type variable from dungeon::dungeon_generation_info to a certain value.

      r0: New value
  load_weather3_d_files:
    value: 0x5c900
    doc: |-
      Loads the 1001.wte, 1005.wte, and 1031.wte files in dungeon.bin, which are used for the 3D effects for the tileset weather as well as the Sandstorm/Fog weather conditions.

      No params.
  render_weather3_d:
    value: 0x5cb14
    doc: |-
      Renders the 3D effects for the tileset weather as well as the Sandstorm/Fog weather conditions.

      No params.
  get_minimap_data:
    value: 0x5d168
    doc: |-
      Returns a pointer to the minimap_display_data struct in the dungeon struct.

      return: minimap_display_data*
  draw_minimap_tile:
    value: 0x5d23c
    doc: |-
      Draws a single tile on the minimap.

      r0: X position
      r1: Y position
  flash_leader_icon:
    value: 0x5da74
    doc: |-
      Seems to control flashing the leader's icon on the minimap when r0 = 0? Doesn't seem to ever be called when r0 = 1.

      r0: ?
  update_minimap:
    value: 0x5dd38
    doc: |-
      Graphically updates the minimap

      No params.
  set_minimap_data_e447:
    value: 0x5e268
    doc: |-
      Sets minimap_display_data::field_0xE447 to the specified value

      r0: Value to set the field to
  get_minimap_data_e447:
    value: 0x5e280
    doc: |-
      Exclusive to the EU ROM. Returns minimap_display_data::field_0xE447.

      return: minimap_display_data::field_0xE447
  set_minimap_data_e448:
    value: 0x5e294
    doc: |-
      Sets minimap_display_data::field_0xE448 to the specified value

      r0: Value to set the field to
  init_weird_minimap_matrix:
    value: 0x5e2f4
    doc: |-
      Initializes the matrix at minimap_display_data+0xE000. Seems to overflow said matrix when doing so.

      No params.
  init_minimap_display_tile:
    value: 0x5e354
    doc: |-
      Used to initialize an instance of struct minimap_display_tile

      r0: Pointer to struct to init
      r1: Seems to be a pointer to the file that stores minimap icons or something like that
  load_fixed_room_data_veneer:
    value: 0x5e688
    doc: |-
      Likely a linker-generated veneer for LoadFixedRoomData.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      No params.
  unload_fixed_room_data:
    value: 0x5e694
    doc: |-
      Unloads fixed room data from the buffer pointed to by FIXED_ROOM_DATA_PTR, then clears the pointer.

      Also clears dungeon::unk_fixed_room_pointer.

      No params.
  is_normal_floor:
    value: 0x5e6b8
    doc: |-
      Checks if the current floor is a normal layout.

      "Normal" means any layout that is NOT one of the following:
      - Hidden stairs floors
      - Golden Chamber
      - Challenge Request floor
      - Outlaw hideout
      - Treasure Memo floor
      - Full-room fixed floors (ID < 0xA5) [0xA5 == Sealed Chamber]

      return: bool
  generate_floor:
    value: 0x5e73c
    doc: |-
      This is the master function that generates the dungeon floor.

      Very loosely speaking, this function first tries to generate a valid floor layout. Then it tries to spawn entities in a valid configuration. Finally, it performs cleanup and post-processing depending on the dungeon.

      If a spawn configuration is invalid, the entire floor layout is scrapped and regenerated. If the generated floor layout is invalid 10 times in a row, or a valid spawn configuration isn't generated within 10 attempts, the generation algorithm aborts and the default one-room Monster House floor is generated as a fallback.

      No params.
  get_tile_terrain:
    value: 0x5eedc
    doc: |-
      Gets the terrain type of a tile.

      r0: tile pointer
      return: terrain ID
  dungeon_rand100:
    value: 0x5eee8
    doc: |-
      Compute a pseudorandom integer on the interval [0, 100) using the dungeon PRNG.

      return: pseudorandom integer
  clear_hidden_stairs:
    value: 0x5eef8
    doc: |-
      Clears the tile (terrain and spawns) on which Hidden Stairs are spawned, if applicable.

      No params.
  flag_hallway_junctions:
    value: 0x5ef70
    doc: |-
      Sets the junction flag (bit 3 of the terrain flags) on any hallway junction tiles in some range [x0, x1), [y0, y1). This leaves tiles within rooms untouched.

      A hallway tile is considered a junction if it has at least 3 cardinal neighbors with open terrain.

      r0: x0
      r1: y0
      r2: x1
      r3: y1
  generate_standard_floor:
    value: 0x5f08c
    doc: |-
      Generate a standard floor with the given parameters.

      Broadly speaking, a standard floor is generated as follows:
      1. Generating the grid
      2. Creating a room or hallway anchor in each grid cell
      3. Creating hallways between grid cells
      4. Generating special features (maze room, Kecleon shop, Monster House, extra hallways, room imperfections, secondary structures)

      r0: grid size x
      r1: grid size y
      r2: floor properties
  generate_outer_ring_floor:
    value: 0x5f1f4
    doc: |-
      Generates a floor layout with a 4x2 grid of rooms, surrounded by an outer ring of hallways.

      r0: floor properties
  generate_crossroads_floor:
    value: 0x5f680
    doc: |-
      Generates a floor layout with a mesh of hallways on the interior 3x2 grid, surrounded by a boundary of rooms protruding from the interior like spikes, excluding the corner cells.

      r0: floor properties
  generate_line_floor:
    value: 0x5fae0
    doc: |-
      Generates a floor layout with 5 grid cells in a horizontal line.

      r0: floor properties
  generate_cross_floor:
    value: 0x5fc40
    doc: |-
      Generates a floor layout with 5 rooms arranged in a cross ("plus sign") formation.

      r0: floor properties
  generate_beetle_floor:
    value: 0x5fdd8
    doc: |-
      Generates a floor layout in a "beetle" formation, which is created by taking a 3x3 grid of rooms, connecting the rooms within each row, and merging the central column into one big room.

      r0: floor properties
  merge_rooms_vertically:
    value: 0x5ff94
    doc: |-
      Merges two vertically stacked rooms into one larger room.

      r0: x grid coordinate of the rooms to merge
      r1: y grid coordinate of the upper room
      r2: dy, where the lower room has a y grid coordinate of y+dy
      r3: grid to update
  generate_outer_rooms_floor:
    value: 0x600e0
    doc: |-
      Generates a floor layout with a ring of rooms on the grid boundary and nothing in the interior.

      Note that this function is bugged, and won't properly connect all the rooms together for grid_size_x < 4.

      r0: grid size x
      r1: grid size y
      r2: floor properties
  is_not_full_floor_fixed_room:
    value: 0x60374
    doc: |-
      Checks if a fixed room ID does not correspond to a fixed, full-floor layout.

      The first non-full-floor fixed room is 0xA5, which is for Sealed Chambers.

      r0: fixed room ID
      return: bool
  generate_fixed_room:
    value: 0x60390
    doc: |-
      Handles fixed room generation if the floor contains a fixed room.

      r0: fixed room ID
      r1: floor properties
      return: bool
  generate_one_room_monster_house_floor:
    value: 0x607d8
    doc: |-
      Generates a floor layout with just a large, one-room Monster House.

      This is the default layout if dungeon generation fails.

      No params.
  generate_two_rooms_with_monster_house_floor:
    value: 0x608a8
    doc: |-
      Generate a floor layout with two rooms (left and right), one of which is a Monster House.

      No params.
  generate_extra_hallways:
    value: 0x60a4c
    doc: |-
      Generate extra hallways on the floor via a series of random walks.

      Each random walk starts from a random tile in a random room, leaves the room in a random cardinal direction, and from there tunnels through obstacles through a series of random turns, leaving open terrain in its wake. The random walk stops when it reaches open terrain, goes out of bounds, or reaches an impassable obstruction.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: number of extra hallways to generate
  get_grid_positions:
    value: 0x60fe8
    doc: |-
      Get the grid cell positions for a given set of floor grid dimensions.

      r0: [output] pointer to array of the starting x coordinates of each grid column
      r1: [output] pointer to array of the starting y coordinates of each grid row
      r2: grid size x
      r3: grid size y
  init_dungeon_grid:
    value: 0x61068
    doc: |-
      Initialize a dungeon grid with defaults.

      The grid is an array of grid cells stored in column-major order (such that grid cells with the same x value are stored contiguously), with a fixed column size of 15. If the grid size in the y direction is less than this, the last (15 - grid_size_y) entries of each column will be uninitialized.

      Note that the grid size arguments define the maximum size of the grid from a programmatic standpoint. However, grid cells can be invalidated if they exceed the configured floor size in the dungeon generation status struct. Thus, the dimensions of the ACTIVE grid can be smaller.

      r0: [output] grid (expected to have space for at least (15*(grid_size_x-1) + grid_size_y) dungeon grid cells)
      r1: grid size x
      r2: grid size y
  assign_rooms:
    value: 0x61168
    doc: |-
      Randomly selects a subset of grid cells to become rooms.

      The given number of grid cells will become rooms. If any of the selected grid cells are invalid, fewer rooms will be generated. The number of rooms assigned will always be at least 2 and never exceed 36.

      Cells not marked as rooms will become hallway anchors. A hallway anchor is a single tile in a non-room grid cell to which hallways will be connected later, thus "anchoring" hallway generation.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: number of rooms; if positive, a random value between [n_rooms, n_rooms+2] will be used. If negative, |n_rooms| will be used exactly.
  create_rooms_and_anchors:
    value: 0x6137c
    doc: |-
      Creates rooms and hallway anchors in each grid cell as designated by AssignRooms.

      This function creates a rectangle of open terrain for each room (with some margin relative to the grid cell border). A single open tile is created in hallway anchor cells, and a hallway anchor indicator is set for later reference.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: array of the starting x coordinates of each grid column
      stack[0]: array of the starting y coordinates of each grid row
      stack[1]: room bitflags; only uses bit 2 (mask: 0b100), which enables room imperfections
  generate_secondary_structures:
    value: 0x616d8
    doc: |-
      Try to generate secondary structures in flagged rooms.

      If a valid room with no special features is flagged to have a secondary structure, try to generate a random one in the room, based on the result of a dice roll:
        0: no secondary structure
        1: maze, or a central water/lava "plus sign" as fallback, or a single water/lava tile in the center as a second fallback
        2: checkerboard pattern of water/lava
        3: central pool of water/lava
        4: central "island" with items and a Warp Tile, surrounded by a "moat" of water/lava
        5: horizontal or vertical divider of water/lava splitting the room in two

      If the room isn't the right shape, dimension, or otherwise doesn't support the selected secondary structure, it is left untouched.

      r0: grid to update
      r1: grid size x
      r2: grid size y
  assign_grid_cell_connections:
    value: 0x620c0
    doc: |-
      Randomly assigns connections between adjacent grid cells.

      Connections are created via a random walk with momentum, starting from the grid cell at (cursor x, cursor y). A connection is drawn in a random direction from the current cursor, and this process is repeated a certain number of times (the "floor connectivity" specified in the floor properties). The direction of the random walk has "momentum"; there's a 50% chance it will be the same as the previous step (or rotated counterclockwise if on the boundary). This helps to reduce the number of dead ends and forks in the road caused by the random walk "doubling back" on itself.

      If dead ends are disabled in the floor properties, there is an additional phase to remove dead end hallway anchors (only hallway anchors, not rooms) by drawing additional connections. Note that the actual implementation contains a bug: the grid cell validity checks use the wrong index, so connections may be drawn to invalid cells.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: cursor x
      stack[0]: cursor y
      stack[1]: floor properties
  create_grid_cell_connections:
    value: 0x624a0
    doc: |-
      Create grid cell connections either by creating hallways or merging rooms.

      When creating a hallway connecting a hallway anchor, the exact anchor coordinates are used as the endpoint. When creating a hallway connecting a room, a random point on the room edge facing the hallway is used as the endpoint. The grid cell boundaries are used as the middle coordinates for kinks (see CreateHallway).

      If room merging is enabled, there is a 9.75% chance that two connected rooms will be merged into a single larger room (9.75% comes from two 5% rolls, one for each of the two rooms being merged). A room can only participate in a merge once.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: array of the starting x coordinates of each grid column
      stack[0]: array of the starting y coordinates of each grid row
      stack[1]: disable room merging flag
  generate_room_imperfections:
    value: 0x62d98
    doc: |-
      Attempt to generate room imperfections for each room in the floor layout, if enabled.

      Each room has a 40% chance of having imperfections if its grid cell is flagged to allow room imperfections. Imperfections are generated by randomly growing the walls of the room inwards for a certain number of iterations, starting from the corners.

      r0: grid to update
      r1: grid size x
      r2: grid size y
  create_hallway:
    value: 0x63184
    doc: |-
      Create a hallway between two points.

      If the two points share no coordinates in common (meaning the line connecting them is diagonal), a "kinked" hallway is created, with the kink at a specified "middle" coordinate (in practice the grid cell boundary). For example, with a kinked horizontal hallway, there are two horizontal lines extending out from the endpoints, connected by a vertical line on the middle x coordinate.

      If a hallway would intersect with an existing open tile (like an existing hallway), the hallway will only be created up to the point where it intersects with the open tile.

      r0: x0
      r1: y0
      r2: x1
      r3: y1
      stack[0]: vertical flag (true for vertical hallway, false for horizontal)
      stack[1]: middle x coordinate for kinked horizontal hallways
      stack[2]: middle y coordinate for kinked vertical hallways
  ensure_connected_grid:
    value: 0x63488
    doc: |-
      Ensure the grid forms a connected graph (all valid cells are reachable) by adding hallways to unreachable grid cells.

      If a grid cell cannot be connected for some reason, remove it entirely.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: array of the starting x coordinates of each grid column
      stack[0]: array of the starting y coordinates of each grid row
  set_terrain_obstacle_checked:
    value: 0x63964
    doc: |-
      Set the terrain of a specific tile to be an obstacle (wall or secondary terrain).

      Secondary terrain (water/lava) can only be placed in the specified room. If the tile room index does not match, a wall will be placed instead.

      r0: tile pointer
      r1: use secondary terrain flag (true for water/lava, false for wall)
      r2: room index
  finalize_junctions:
    value: 0x639a0
    doc: |-
      Finalizes junction tiles by setting the junction flag (bit 3 of the terrain flags) and ensuring open terrain.

      Note that this implementation is slightly buggy. This function scans tiles left-to-right, top-to-bottom, and identifies junctions as any open, non-hallway tile (room_index != 0xFF) adjacent to an open, hallway tile (room_index == 0xFF). This interacts poorly with hallway anchors (room_index == 0xFE). This function sets the room index of any hallway anchors to 0xFF within the same loop, so a hallway anchor may or may not be identified as a junction depending on the orientation of connected hallways.

      For example, in the following configuration, the "o" tile would be marked as a junction because the neighboring hallway tile to its left comes earlier in iteration, while the "o" tile still has the room index 0xFE, causing the algorithm to mistake it for a room tile:
        xxxxx
        ---ox
        xxx|x
        xxx|x
      However, in the following configuration, the "o" tile would NOT be marked as a junction because it comes earlier in iteration than any of its neighboring hallway tiles, so its room index is set to 0xFF before it can be marked as a junction. This is actually the ONLY possible configuration where a hallway anchor will not be marked as a junction.
        xxxxx
        xo---
        x|xxx
        x|xxx

      No params.
  generate_kecleon_shop:
    value: 0x63c4c
    doc: |-
      Possibly generate a Kecleon shop on the floor.

      A Kecleon shop will be generated with a probability determined by the Kecleon shop spawn chance parameter. A Kecleon shop will be generated in a random room that is valid, connected, has no other special features, and has dimensions of at least 5x4. Kecleon shops will occupy the entire room interior, leaving a one tile margin from the room walls.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: Kecleon shop spawn chance (percentage from 0-100)
  generate_monster_house:
    value: 0x64000
    doc: |-
      Possibly generate a Monster House on the floor.

      A Monster House will be generated with a probability determined by the Monster House spawn chance parameter, and only if the current floor can support one (no non-Monster-House outlaw missions or special floor types). A Monster House will be generated in a random room that is valid, connected, and is not a merged or maze room.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: Monster House spawn chance (percentage from 0-100)
  generate_maze_room:
    value: 0x64288
    doc: |-
      Possibly generate a maze room on the floor.

      A maze room will be generated with a probability determined by the maze room chance parameter. A maze will be generated in a random room that is valid, connected, has odd dimensions, and has no other features.

      r0: grid to update
      r1: grid size x
      r2: grid size y
      r3: maze room chance (percentage from 0-100)
  generate_maze:
    value: 0x644bc
    doc: |-
      Generate a maze room within a given grid cell.

      A "maze" is generated within the room using a series of random walks to place obstacle terrain (walls or secondary terrain) in a maze-like arrangement. "Maze lines" (see GenerateMazeLine) are generated using every other tile around the room's border, as well as every other interior tile, as a starting point. This ensures that there are stripes of walkable open terrain surrounded by stripes of obstacles (the maze walls).

      r0: grid cell pointer
      r1: use secondary terrain flag (true for water/lava, false for walls)
  generate_maze_line:
    value: 0x64738
    doc: |-
      Generate a "maze line" from a given starting point, within the given bounds.

      A "maze line" is a random walk starting from (x0, y0). The random walk proceeds with a stride of 2 in a random direction, laying down obstacles as it goes. The random walk terminates when it gets trapped and there are no more neighboring tiles that are open and in-bounds.

      r0: x0
      r1: y0
      r2: xmin
      r3: ymin
      stack[0]: xmax
      stack[1]: ymax
      stack[2]: use secondary terrain flag (true for water/lava, false for walls)
      stack[3]: room index
  set_spawn_flag5:
    value: 0x648e0
    doc: |-
      Set spawn flag 5 (0b100000 or 0x20) on all tiles in a room.

      r0: grid cell
  is_next_to_hallway:
    value: 0x64934
    doc: |-
      Checks if a tile position is either in a hallway or next to one.

      r0: x
      r1: y
      return: bool
  resolve_invalid_spawns:
    value: 0x649d8
    doc: |-
      Resolve invalid spawn flags on tiles.

      Spawn flags can be invalid due to terrain. For example, traps can't spawn on obstacles. Spawn flags can also be invalid due to multiple being set on a single tile, in which case one will take precedence. For example, stair spawns trump trap spawns.

      No params.
  convert_secondary_terrain_to_chasms:
    value: 0x64a70
    doc: |-
      Converts all secondary terrain tiles (water/lava) to chasms.

      No params.
  ensure_impassable_tiles_are_walls:
    value: 0x64adc
    doc: |-
      Ensures all tiles with the impassable flag are walls.

      No params.
  initialize_tile:
    value: 0x64b38
    doc: |-
      Initialize a tile struct.

      r0: tile pointer
  reset_floor:
    value: 0x64b70
    doc: |-
      Resets the floor in preparation for a floor generation attempt.

      Resets all tiles, resets the border to be impassable, and clears entity spawns.

      No params.
  pos_is_out_of_bounds:
    value: 0x64d10
    doc: |-
      Checks if a position (x, y) is out of bounds on the map: !((0 <= x <= 55) && (0 <= y <= 31)).

      r0: x
      r1: y
      return: bool
  shuffle_spawn_positions:
    value: 0x64d48
    doc: |-
      Randomly shuffle an array of spawn positions.

      r0: spawn position array containing bytes {x1, y1, x2, y2, ...}
      r1: number of (x, y) pairs in the spawn position array
  mark_non_enemy_spawns:
    value: 0x64db0
    doc: |-
      Mark tiles for all non-enemy entities, which includes stairs, items, traps, and the player. Note that this only marks tiles; actual spawning is handled later.

      Most entities are spawned randomly on a subset of permissible tiles.

      Stairs are spawned if they don't already exist on the floor, and hidden stairs of the specified type are also spawned if configured as long as there are at least 2 floors left in the dungeon. Stairs can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop, doesn't already have an enemy spawn, isn't a hallway junction, and isn't a special tile like a Key door.

      Items are spawned both normally in rooms, as well as in walls and Monster Houses. Normal items can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop or Monster House, isn't a hallway junction, and isn't a special tile like a Key door. Buried items can spawn on any wall tile. Monster House items can spawn on any Monster House tile that isn't in a Kecleon shop and isn't a hallway junction.

      Traps are similarly spawned both normally in rooms, as well as in Monster Houses. Normal traps can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop, doesn't already have an item or enemy spawn, and isn't a special tile like a Key door. Monster House traps follow the same conditions as Monster House items.

      The player can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop, isn't a hallway junction, doesn't already have an item, enemy, or trap spawn, and isn't a special tile like a Key door.

      r0: floor properties
      r1: empty Monster House flag. An empty Monster House is one with no items or traps, and only a small number of enemies.
  mark_enemy_spawns:
    value: 0x654d4
    doc: |-
      Mark tiles for all enemies, which includes normal enemies and those in Monster Houses. Note that this only marks tiles; actual spawning is handled later in SpawnInitialMonsters.

      Normal enemies can spawn on any tile that has open terrain, isn't in a Kecleon shop, doesn't already have another entity spawn, and isn't a special tile like a Key door.

      Monster House enemies can spawn on any Monster House tile that isn't in a Kecleon shop, isn't where the player spawns, and isn't a special tile like a Key door.

      r0: floor properties
      r1: empty Monster House flag. An empty Monster House is one with no items or traps, and only a small number of enemies.
  set_secondary_terrain_on_wall:
    value: 0x657d0
    doc: |-
      Set a specific tile to have secondary terrain (water/lava), but only if it's a passable wall.

      r0: tile pointer
  generate_secondary_terrain_formations:
    value: 0x65810
    doc: |-
      Generate secondary terrain (water/lava) formations.

      This includes "rivers" that flow from top-to-bottom (or bottom-to-top), as well as "lakes" both standalone and after rivers. Water/lava formations will never cut through rooms, but they can pass through rooms to the opposite side.

      Rivers are generated by a top-down or bottom-up random walk that ends when existing secondary terrain is reached or the walk goes out of bounds. Some rivers also end prematurely in a lake. Lakes are a large collection of secondary terrain generated around a central point.

      r0: bit index to test in the floor properties room flag bitvector (formations are only generated if the bit is set)
      r1: floor properties
  stairs_always_reachable:
    value: 0x65ed0
    doc: |-
      Checks that the stairs are reachable from every walkable tile on the floor.

      This runs a graph traversal algorithm that is very similar to breadth-first search (the order in which nodes are visited is slightly different), starting from the stairs. If any tile is walkable but wasn't reached by the traversal algorithm, then the stairs must not be reachable from that tile.

      r0: x coordinate of the stairs
      r1: y coordinate of the stairs
      r2: flag to always return true, but set a special bit on all walkable tiles that aren't reachable from the stairs
      return: bool
  get_next_fixed_room_action:
    value: 0x66534
    doc: |-
      Returns the next action that needs to be performed when spawning a fixed room tile.

      return: Next action ID
  convert_walls_to_chasms:
    value: 0x665ac
    doc: |-
      Converts all wall tiles to chasms.

      No params.
  reset_inner_boundary_tile_rows:
    value: 0x66be0
    doc: |-
      Reset the inner boundary tile rows (y == 1 and y == 30) to their initial state of all wall tiles, with impassable walls at the edges (x == 0 and x == 55).

      No params.
  reset_important_spawn_positions:
    value: 0x66ccc
    doc: |-
      Resets important spawn positions (the player, stairs, and hidden stairs) back to their default values.

      r0: dungeon generation info pointer (a field on the dungeon struct)
  spawn_stairs:
    value: 0x66cf0
    doc: |-
      Spawn stairs at the given location.

      If the hidden stairs type is something other than HIDDEN_STAIRS_NONE, hidden stairs of the specified type will be spawned instead of normal stairs.

      If spawning normal stairs and the current floor is a rescue floor, the room containing the stairs will be converted into a Monster House.

      If attempting to spawn hidden stairs but the spawn is blocked, the floor generation status's hidden stairs spawn position will be updated, but it won't be transferred to the dungeon generation info struct.

      r0: position (two-byte array for {x, y})
      r1: dungeon generation info pointer (a field on the dungeon struct)
      r2: hidden stairs type
  get_hidden_stairs_type:
    value: 0x66e00
    doc: |-
      Gets the hidden stairs type for a given floor.

      This function reads the floor properties and resolves any randomness (such as HIDDEN_STAIRS_RANDOM_SECRET_BAZAAR_OR_SECRET_ROOM and the floor_properties::hidden_stairs_spawn_chance) into a concrete hidden stairs type.

      r0: dungeon generation info pointer
      r1: floor properties pointer
      return: enum hidden_stairs_type
  get_final_kecleon_shop_spawn_chance:
    value: 0x66f20
    doc: |-
      Gets the kecleon shop spawn chance for the floor.

      When dungeon::boost_kecleon_shop_spawn_chance is false, returns the same value as the input. When it's true, returns the input (chance * 1.2).

      r0: base kecleon shop spawn chance, floor_properties::kecleon_shop_spawn_chance
      return: int
  reset_hidden_stairs_spawn:
    value: 0x66f6c
    doc: |-
      Resets hidden stairs spawn information for the floor. This includes the position on the floor generation status as well as the flag indicating whether the spawn was blocked.

      No params.
  place_fixed_room_tile:
    value: 0x66f94
    doc: |-
      Used to spawn a single tile when generating a fixed room. The tile might contain an item or a monster.

      r0: Pointer to the tile to spawn
      r1: Fixed room action to perform. Controls what exactly will be spawned. The action is actually 12 bits long, the highest 4 bits are used as a parameter that represents a direction (for example, when spawning a monster).
      r2: Tile X position
      r3: Tile Y position
  fixed_room_action_param_to_direction:
    value: 0x679d0
    doc: |-
      Converts the parameter stored in a fixed room action value to a direction ID.

      The conversion is performed by subtracting 1 to the value. If the parameter had a value of 0, DIR_NONE is returned.

      r0: Parameter value
      return: Direction
  apply_key_effect:
    value: 0x67d3c
    doc: |-
      Attempts to open a locked door in front of the target if a locked door has not already
      been open on the floor.

      r0: user entity pointer
      r1: target entity pointer
  load_fixed_room_data:
    value: 0x67df4
    doc: |-
      Loads fixed room data from BALANCE/fixed.bin into the buffer pointed to by FIXED_ROOM_DATA_PTR.

      No params.
  load_fixed_room:
    value: 0x67e84
    doc: "Note: unverified, ported from Irdkwia's notes"
  open_fixed_bin:
    value: 0x680b8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  close_fixed_bin:
    value: 0x680ec
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      No params.
  are_orbs_allowed:
    value: 0x68110
    doc: |-
      Checks if orbs are usable in the given fixed room.

      Always true if not a full-floor fixed room.

      r0: fixed room ID
      return: bool
  are_tile_jumps_allowed:
    value: 0x68140
    doc: |-
      Checks if tile jumps (warping, being blown away, and leaping) are allowed in the given fixed room.

      Always true if not a full-floor fixed room.

      r0: fixed room ID
      return: bool
  are_trawl_orbs_allowed:
    value: 0x68170
    doc: |-
      Checks if Trawl Orbs work in the given fixed room.

      Always true if not a full-floor fixed room.

      r0: fixed room ID
      return: bool
  are_orbs_allowed_veneer:
    value: 0x681a0
    doc: |-
      Likely a linker-generated veneer for InitMemAllocTable.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      r0: fixed room ID
      return: bool
  are_late_game_traps_enabled:
    value: 0x681ac
    doc: |-
      Check if late-game traps (Summon, Pitfall, and Pokémon traps) work in the given fixed room.

      Or disabled? This function, which Irdkwia's notes label as a disable check, check the struct field labeled in End's notes as an enable flag.

      r0: fixed room ID
      return: bool
  are_moves_enabled:
    value: 0x681c4
    doc: |-
      Checks if moves (excluding the regular attack) are usable in the given fixed room.

      r0: fixed room ID
      return: bool
  is_room_illuminated:
    value: 0x681dc
    doc: |-
      Checks if the given fixed room is fully illuminated.

      r0: fixed room ID
      return: bool
  get_matching_monster_id:
    value: 0x681f4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      r1: ?
      r2: ?
      return: monster ID
  generate_item_explicit:
    value: 0x68418
    doc: |-
      Initializes an item struct with the given information.

      This calls InitStandardItem, then explicitly sets the quantity and stickiness. If quantity == 0 for Poké, GenerateCleanItem is used instead.

      r0: pointer to item to initialize
      r1: item ID
      r2: quantity
      r3: sticky flag
  generate_and_spawn_item:
    value: 0x68494
    doc: |-
      A convenience function that generates an item with GenerateItemExplicit, then spawns it with SpawnItem.

      If the check-in-bag flag is set and the player's bag already contains an item with the given ID, a Reviver Seed will be spawned instead.

      It seems like this function is only ever called in one place, with an item ID of 0x49 (Reviver Seed).

      r0: item ID
      r1: x position
      r2: y position
      r3: quantity
      stack[0]: sticky flag
      stack[1]: check-in-bag flag
  is_hidden_stairs_floor:
    value: 0x68570
    doc: |-
      Checks if the current floor is either the Secret Bazaar or a Secret Room.

      return: bool
  is_secret_bazaar_veneer:
    value: 0x6859c
    doc: |-
      Likely a linker-generated veneer for IsSecretBazaar.

      See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-

      return: bool
  generate_standard_item:
    value: 0x68c34
    doc: |-
      Wrapper around GenerateItem with quantity set to 0

      r0: pointer to item to initialize
      r1: item ID
      r2: stickiness type
  generate_clean_item:
    value: 0x68c48
    doc: |-
      Wrapper around GenerateItem with quantity set to 0 and stickiness type set to SPAWN_STICKY_NEVER.

      r0: pointer to item to initialize
      r1: item ID
  try_leader_item_pick_up:
    value: 0x690c0
    doc: |-
      Checks the tile at the specified position and determines if the leader should pick up an item.

      r0: position
      r1: flag for whether or not a message should be logged upon the leader failing to obtain the item
  spawn_item:
    value: 0x695a0
    doc: |-
      Spawns an item on the floor. Fails if there are more than 64 items already on the floor.

      This calls SpawnItemEntity, fills in the item info struct, sets the entity to be visible, binds the entity to the tile it occupies, updates the n_items counter on the dungeon struct, and various other bits of bookkeeping.

      r0: position
      r1: item pointer
      r2: some flag?
      return: success flag
  remove_ground_item:
    value: 0x69728
    doc: |-
      Removes an item lying on the ground.

      Also updates dungeon::n_items.

      r0: Position where the item is located
      r1: If true, update dungeon::poke_buy_kecleon_shop and dungeon::poke_sold_kecleon_shop
  spawn_dropped_item_wrapper:
    value: 0x69aa8
    doc: |-
      Wraps SpawnDroppedItem in a more convenient interface.

      r0: entity
      r1: position
      r2: item
      r3: ?
  spawn_dropped_item:
    value: 0x69b44
    doc: |-
      Used to spawn an item that was thrown or dropped, with a log message.

      Determines where exactly the item will land, if it bounces on a trap, etc.
      Used for thrown items that hit a wall, for certain enemy drops (such as Unown stones or Treasure Boxes), for certain moves (like Pay Day and Knock Off), and possibly other things.

      r0: entity that dropped or threw the item
      r1: item entity. Contains the coordinates where the item should try to land first.
      r2: item info
      r3: ?
      stack[0]: pointer to int16_t[2] for x/y direction (corresponding to DIRECTIONS_XY)
      stack[1]: ?
  try_generate_unown_stone_drop:
    value: 0x6a0cc
    doc: |-
      Determine if a defeated monster should drop a Unown Stone, and generate the item if so.

      Checks that the current dungeon isn't a Marowak Dojo training maze, and that the monster is an Unown. If so, there's a 21% chance that an Unown Stone will be generated.

      r0: [output] item
      r1: monster ID
      return: whether or not an Unown Stone was generated
  has_held_item:
    value: 0x6a850
    doc: |-
      Checks if a monster has a certain held item.

      r0: entity pointer
      r1: item ID
      return: bool
  generate_money_quantity:
    value: 0x6a8a0
    doc: |-
      Set the quantity code on an item (assuming it's Poké), given some maximum acceptable money amount.

      r0: item pointer
      r1: max money amount (inclusive)
  check_team_items_flags:
    value: 0x6ac4c
    doc: |-
      Checks whether any of the items in the bag or any of the items carried by team members has any of the specified flags set in its flags field.

      r0: Flag(s) to check (0 = f_exists, 1 = f_in_shop, 2 = f_unpaid, etc.)
      return: True if any of the items of the team has the specified flags set, false otherwise.
  add_held_item_to_bag:
    value: 0x6af90
    doc: |-
      Adds the monster's held item to the bag. This is only called on monsters on the exploration team.
      monster::is_not_team_member should be checked to be false before calling.

      r0: monster pointer
  remove_empty_items_in_bag_wrapper:
    value: 0x6b0ac
    doc: |-
      Calls RemoveEmptyItemsInBag, then some other function that seems to update the minimap, the map surveyor flag, and other stuff.

      No params.
  generate_item:
    value: 0x6b344
    doc: |-
      Initializes an item struct with the given information.

      This wraps InitItem, but with extra logic to resolve the item's stickiness. It also calls GenerateMoneyQuantity for Poké.

      r0: pointer to item to initialize
      r1: item ID
      r2: quantity
      r3: stickiness type (enum gen_item_stickiness)
  does_projectile_hit_target:
    value: 0x6c0a0
    doc: |-
      Determines if a hurled projectile will impact on a target or if the target will dodge it instead.

      Contains a random chance using THROWN_ITEM_HIT_CHANCE, as well as some additional checks involving certain items (Whiff Specs, Lockon Specs and Dodge Scarf), exclusive item effects (EXCLUSIVE_EFF_THROWN_ITEM_PROTECTION) or pokémon (Kecleon, clients, secret bazaar NPCs).

      r0: Monster that throws the item
      r1: Target monster
      return: True if the item impacts on the target, false if the target dodges the item.
  display_floor_card:
    value: 0x6c354
    doc: |-
      Dispatches the splash screen between floors showing the dungeon name and the current floor.

      First it checks whether the current floor is a secret bazaar or secret room, then it calls HandleFloorCard.

      r0: Duration in frames
  handle_floor_card:
    value: 0x6c38c
    doc: |-
      Handles the display of the splash screen between floors showing the dungeon name and the current floor.

      Seems to enter a loop where it calls AdvanceFrame until the desired number of frames is waited or A is pressed.

      r0: dungeon_id
      r1: floor
      r2: duration
      r3: enum hidden_stairs_type
  fill_mission_destination_info:
    value: 0x6c520
    doc: |-
      Fills the dungeon::mission_destination_info field with information from the currently active mission on the floor, if one is present.

      No params.
  check_active_challenge_request:
    value: 0x6d1cc
    doc: |-
      Checks if there's an active challenge request on the current dungeon.

      return: True if there's an active challenge request on the current dungeon in the list of missions.
  get_mission_destination:
    value: 0x6d224
    doc: |-
      Returns the current mission destination on the dungeon struct.

      return: &dungeon::mission_destination
  is_outlaw_or_challenge_request_floor:
    value: 0x6d244
    doc: |-
      Checks if the current floor is an active mission destination of type MISSION_TAKE_ITEM_FROM_OUTLAW, MISSION_ARREST_OUTLAW or MISSION_CHALLENGE_REQUEST.

      return: bool
  is_destination_floor:
    value: 0x6d288
    doc: |-
      Checks if the current floor is a mission destination floor.

      return: bool
  is_current_mission_type:
    value: 0x6d29c
    doc: |-
      Checks if the current floor is an active mission destination of a given type (and any subtype).

      r0: mission type
      return: bool
  is_current_mission_type_exact:
    value: 0x6d2d0
    doc: |-
      Checks if the current floor is an active mission destination of a given type and subtype.

      r0: mission type
      r1: mission subtype
      return: bool
  is_outlaw_monster_house_floor:
    value: 0x6d30c
    doc: |-
      Checks if the current floor is a mission destination for a Monster House outlaw mission.

      return: bool
  is_golden_chamber:
    value: 0x6d330
    doc: |-
      Checks if the current floor is a Golden Chamber floor.

      return: bool
  is_legendary_challenge_floor:
    value: 0x6d354
    doc: |-
      Checks if the current floor is a boss floor for a Legendary Challenge Letter mission.

      return: bool
  is_jirachi_challenge_floor:
    value: 0x6d394
    doc: |-
      Checks if the current floor is the boss floor in Star Cave Pit for Jirachi's Challenge Letter mission.

      return: bool
  is_destination_floor_with_monster:
    value: 0x6d3cc
    doc: |-
      Checks if the current floor is a mission destination floor with a special monster.

      See FloorHasMissionMonster for details.

      return: bool
  load_mission_monster_sprites:
    value: 0x6d478
    doc: |-
      Loads the sprites of monsters that appear on the current floor because of a mission, if applicable.

      This includes monsters to be rescued, outlaws and its minions.

      No params.
  mission_target_enemy_is_defeated:
    value: 0x6d4f0
    doc: |-
      Checks if the target enemy of the mission on the current floor has been defeated.

      return: bool
  set_mission_target_enemy_defeated:
    value: 0x6d510
    doc: |-
      Set the flag for whether or not the target enemy of the current mission has been defeated.

      r0: new flag value
  is_destination_floor_with_fixed_room:
    value: 0x6d524
    doc: |-
      Checks if the current floor is a mission destination floor with a fixed room.

      The entire floor can be a fixed room layout, or it can just contain a Sealed Chamber.

      return: bool
  get_item_to_retrieve:
    value: 0x6d54c
    doc: |-
      Get the ID of the item that needs to be retrieve on the current floor for a mission, if one exists.

      return: item ID
  get_item_to_deliver:
    value: 0x6d570
    doc: |-
      Get the ID of the item that needs to be delivered to a mission client on the current floor, if one exists.

      return: item ID
  get_special_target_item:
    value: 0x6d59c
    doc: |-
      Get the ID of the special target item for a Sealed Chamber or Treasure Memo mission on the current floor.

      return: item ID
  is_destination_floor_with_item:
    value: 0x6d5e4
    doc: |-
      Checks if the current floor is a mission destination floor with a special item.

      This excludes missions involving taking an item from an outlaw.

      return: bool
  is_destination_floor_with_hidden_outlaw:
    value: 0x6d644
    doc: |-
      Checks if the current floor is a mission destination floor with a "hidden outlaw" that behaves like a normal enemy.

      return: bool
  is_destination_floor_with_fleeing_outlaw:
    value: 0x6d668
    doc: |-
      Checks if the current floor is a mission destination floor with a "fleeing outlaw" that runs away.

      return: bool
  get_mission_target_enemy:
    value: 0x6d6a0
    doc: |-
      Get the monster ID of the target enemy to be defeated on the current floor for a mission, if one exists.

      return: monster ID
  get_mission_enemy_minion_group:
    value: 0x6d6b8
    doc: |-
      Get the monster ID of the specified minion group on the current floor for a mission, if it exists.

      Note that a single minion group can correspond to multiple actual minions of the same species. There can be up to 2 minion groups.

      r0: minion group index (0-indexed)
      return: monster ID
  set_target_monster_not_found_flag:
    value: 0x6d744
    doc: |-
      Sets dungeon::target_monster_not_found_flag to the specified value.

      r0: Value to set the flag to
  get_target_monster_not_found_flag:
    value: 0x6d758
    doc: |-
      Gets the value of dungeon::target_monster_not_found_flag.

      return: dungeon::target_monster_not_found_flag
  floor_has_mission_monster:
    value: 0x6d7c8
    doc: |-
      Checks if a given floor is a mission destination with a special monster, either a target to rescue or an enemy to defeat.

      Mission types with a monster on the destination floor:
      - Rescue client
      - Rescue target
      - Escort to target
      - Deliver item
      - Search for target
      - Take item from outlaw
      - Arrest outlaw
      - Challenge Request

      r0: mission destination info pointer
      return: bool
  get_mission_if_active_on_floor:
    value: 0x6d810
    doc: |-
      If the current dungeon floor has the mission corresponding to the mission number active on it, returns its mission struct.

      r0: dungeon_floor_pair struct pointer
      r1: mission id in player's job list
      return: mission struct pointer
  generate_mission_egg_monster:
    value: 0x6d920
    doc: |-
      Generates the monster ID in the egg from the given mission. Uses the base form of the monster.

      Note: unverified, ported from Irdkwia's notes

      r0: mission struct
  log_message_by_id_with_popup_check_participants:
    value: 0x6f2d0
    doc: |-
      Logs the appropriate message based on the participating entites; this function calls LogMessageByIdWithPopupCheckUserTarget is both the user and target pointers are non-null, otherwise it calls LogMessageByIdWithPopupCheckUser if the user pointer is non-null, otherwise doesn't log anything.

      This function also seems to set some global table entry to some value?

      r0: user entity pointer
      r1: target entity pointer
      r2: message ID
      r3: index into some table?
      stack[0]: value to set at the table index specified by r3?
  log_message_by_id_with_popup_check_user:
    value: 0x6f324
    doc: |-
      Logs a message in the message log alongside a message popup, if the user hasn't fainted.

      r0: user entity pointer
      r1: message ID
  log_message_with_popup_check_user:
    value: 0x6f364
    doc: |-
      Logs a message in the message log alongside a message popup, if the user hasn't fainted.

      r0: user entity pointer
      r1: message string
  log_message_by_id_quiet:
    value: 0x6f39c
    doc: |-
      Logs a message in the message log (but without a message popup).

      r0: user entity pointer
      r1: message ID
  log_message_quiet:
    value: 0x6f3c0
    doc: |-
      Logs a message in the message log (but without a message popup).

      r0: user entity pointer
      r1: message string
  log_message_by_id_with_popup_check_user_target:
    value: 0x6f3d0
    doc: |-
      Logs a message in the message log alongside a message popup, if some user check passes and the target hasn't fainted.

      r0: user entity pointer
      r1: target entity pointer
      r2: message ID
  log_message_with_popup_check_user_target:
    value: 0x6f424
    doc: |-
      Logs a message in the message log alongside a message popup, if some user check passes and the target hasn't fainted.

      r0: user entity pointer
      r1: target entity pointer
      r2: message string
  log_message_by_id_quiet_check_user_target:
    value: 0x6f470
    doc: |-
      Logs a message in the message log (but without a message popup), if some user check passes and the target hasn't fainted.

      r0: user entity pointer
      r1: target entity pointer
      r2: message ID
  log_message_by_id_with_popup_check_user_unknown:
    value: 0x6f4c4
    doc: |-
      Logs a message in the message log alongside a message popup, if the user hasn't fainted and some other unknown check.

      r0: user entity pointer
      r1: ?
      r2: message ID
  log_message_by_id_with_popup:
    value: 0x6f518
    doc: |-
      Logs a message in the message log alongside a message popup.

      r0: user entity pointer
      r1: message ID
  log_message_with_popup:
    value: 0x6f53c
    doc: |-
      Logs a message in the message log alongside a message popup.

      r0: user entity pointer
      r1: message string
  log_message:
    value: 0x6f588
    doc: |-
      Logs a message in the message log.

      r0: user entity pointer
      r1: message string
      r2: bool, whether or not to present a message popup
  log_message_by_id:
    value: 0x6f794
    doc: |-
      Logs a message in the message log.

      r0: user entity pointer
      r1: message ID
      r2: bool, whether or not to present a message popup
  init_portrait_dungeon:
    value: 0x6fb40
    doc: |-
      Initialize the portrait params structure for the given monster and expression

      r0: pointer the portrait params data structure to initialize
      r1: monster id
      r2: emotion id
  open_message_log:
    value: 0x6fbdc
    doc: |-
      Opens the message log window.

      r0: ?
      r1: ?
  run_dungeon_mode:
    value: 0x6ffa8
    doc: |-
      This appears to be the top-level function for running dungeon mode.

      It gets called by MainGame right after doing the dungeon fade transition, and once it exits, the dungeon results are processed.

      This function is presumably in charge of allocating the dungeon struct, setting it up, launching the dungeon engine, etc.
  start_fade_dungeon:
    value: 0x70488
    doc: |-
      Initiates a screen fade in dungeon mode.

      Sets the fields of the dungeon_fade struct to appropriate values given in the args.

      r0: Dungeon fade struct
      r1: Change of brightness per frame
      r2: Fade type
  start_fade_dungeon_wrapper:
    value: 0x706e8
    doc: |-
      Calls StartFadeDungeon to initiate a screen fade in dungeon mode.

      Sets the status field in the dungeon_fades struct to the fade type, then uses a switch-case to create a mapping of the status enums to different ones for some reason. This mapped value is then used in the StartFadeDungeon call.

      r0: Fade type
      r1: Change of brightness per frame
      r2: Screen to fade
  handle_fades_dungeon:
    value: 0x70854
    doc: |-
      Gets called every frame for both screens in dungeon mode. Handles the status of the screen fades.

      r0: enum screen
  handle_fades_dungeon_both_screens:
    value: 0x70a64
    doc: |-
      Calls HandleFadesDungeon for both screens.

      No params.
  display_floor_tip:
    value: 0x70c08
    doc: |-
      Display the dungeon tip that displays on floor change, based on which tips have already been displayed.

      No params.

      return: 1 if a tip has been displayed, 0 otherwise
  display_item_tip:
    value: 0x70d34
    doc: |-
      Display the dungeon tip if not already displayed matching the (presumably newly acquired) item

      r0: item id
      return: 1 if a tip has been displayed, 0 otherwise
  display_dungeon_tip:
    value: 0x70f70
    doc: |-
      Checks if a given dungeon tip should be displayed at the start of a floor and if so, displays it. Called up to 4 times at the start of each new floor, with a different r0 parameter each time.

      r0: Pointer to the message_tip struct of the message that should be displayed
      r1: True to log the message in the message log

      return: 1 if the message has been displayed, 0 if it wasn’t
  set_both_screens_window_color_to_default:
    value: 0x70fe0
    doc: |-
      This changes the palettes of windows in both screens to an appropiate value depending on the playthrough
      If you're in a special episode, they turn green , otherwise, they turn blue or pink depending on your character's sex

      No params
  get_personality_index:
    value: 0x7106c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster pointer
      return: ?
  display_message:
    value: 0x712d8
    doc: |-
      Displays a message in a dialogue box that optionally waits for player input before closing.

      r0: pointer to the structure representing the desired state of the portrait
      r1: ID of the string to display
      r2: True to wait for player input before closing the dialogue box, false to close it automatically once all the characters get printed.
  display_message2:
    value: 0x7132c
    doc: Very similar to DisplayMessage
  yes_no_menu:
    value: 0x71598
    doc: |-
      Opens a menu where the user can choose "Yes" or "No" and waits for input before returning.

      r0: ?
      r1: ID of the string to display in the textbox
      r2: Option that the cursor will be on by default. 0 for "Yes", 1 for "No"
      r3: ?
      return: True if the user chooses "Yes", false if the user chooses "No"
  display_message_internal:
    value: 0x71610
    doc: |-
      Called by DisplayMessage. Seems to be the function that handles the display of the dialogue box. It won't return until all the characters have been written and after the player manually closes the dialogue box (if the corresponding parameter was set).

      r0: ID of the string to display
      r1: True to wait for player input before closing the dialogue box, false to close it automatically once all the characters get printed.
      r2: pointer to the structure representing the desired state of the portrait
      r3: ?
      stack[0]: ?
      stack[1]: ?
  open_menu:
    value: 0x71e74
    doc: |-
      Opens a menu. The menu to open depends on the specified parameter.

      It looks like the function takes a parameter in r0, but doesn't use it. r1 doesn't even get set when this function is called.

      r0: (?) Unused by the function. Seems to be 1 byte long.
      r1: (?) Unused by the function. Seems to be 1 byte long.
      r2: True to open the bag menu, false to open the main dungeon menu
  dungeon_mode_setup_and_show_name_keyboard:
    value: 0x73094
    doc: |-
      Sets up and opens the naming keyboard in dungeon mode.

      r0: [output] keyboard result, also the inital string
      r1: buffer?
      r2: ?
      return: ?
  others_menu_loop:
    value: 0x7384c
    doc: |-
      Called on each frame while the in-dungeon "others" menu is open.

      It contains a switch to determine whether an option has been chosen or not and a second switch that determines what to do depending on which option was chosen.

      return: int (Actually, this is probably some sort of enum shared by all the MenuLoop functions)
  others_menu:
    value: 0x73ab0
    doc: |-
      Called when the in-dungeon "others" menu is open. Does not return until the menu is closed.

      return: Always 0
