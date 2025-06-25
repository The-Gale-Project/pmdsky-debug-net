doc: Represents a struct or union dungeon defined within pmdsky-debug.
meta:
  id: dungeon
  endian: le
  bit-endian: le
  imports:
  - forced_loss_reason
  - pointer
  - entity
  - damage_calc_diag
  - position
  - dungeon_color_table_array
  - dungeon_shopkeeper_spawns_array
  - dungeon_fallen_ally_monster_name_array
  - dungeon_id_8
  - dungeon_group_and_group_floor
  - floor_loop_status_8
  - mission_destination_info
  - dungeon_objective_8
  - monster_id_16
  - game_id
  - dungeon_monsters_array
  - dungeon_enemy_spawn_stats_array
  - dungeon_spawn_entries_array
  - dungeon_unknown_array_0x3b74_array
  - dungeon_monster_unique_id_array
  - dungeon_plus_is_active_array
  - dungeon_minus_is_active_array
  - dungeon_items_array
  - dungeon_traps_array
  - dungeon_generation_info
  - dungeon_unk_team_direction_array_array
  - weather_id_8
  - dungeon_weather_turns_array
  - dungeon_artificial_permaweather_turns_array
  - dungeon_fixed_room_tiles_array
  - dungeon_tile_ptrs_array
  - dungeon_room_data_array
  - dungeon_natural_junction_list_counts_array
  - dungeon_natural_junction_list_array
  - dungeon_unknown_file_buffer_0x102a8_array
  - dungeon_unknown_tile_matrix_array
  - dungeon_unknown_matrix_0x1212c_array
  - dungeon_unknown_file_buffer_0x12162_array
  - dungeon_unknown_array_0x12a92_array
  - trap_id_8
  - entity_table
  - dungeon_sprite_indexes_array
  - display_data
  - minimap_display_data
  - floor_properties
  - dungeon_regular_item_weights_array
  - dungeon_kecleon_item_weights_array
  - dungeon_monster_house_item_weights_array
  - dungeon_buried_item_weights_array
  - dungeon_grab_bag_item_weights_array
  - dungeon_secret_room_item_weights_array
  - dungeon_trap_weights_array
  - dungeon_spawn_entries_master_array
  - item_id_16
  - dungeon_spawn_table_entries_chosen_array
  - dungeon_fainted_monster_cause_entity_name_array
  - dungeon_fainted_monster_name_array
  - dungeon_fallen_escort_monster_name_array
  - damage_source_16
  - item
  - dungeon_fainted_monster_offensive_stats_array
  - dungeon_fainted_monster_defensive_stats_array
  - monster_summary
  - music_id_16
seq:
- id: field_0x0
  type: u1
- id: target_enemy_defeated_message
  type: u1
- id: hidden_outlaw_defeated_message
  type: u1
- id: target_monster_not_found_flag
  type: u1
- id: field_0x4
  type: u1
- id: stepped_on_stairs
  type: u1
- id: end_floor_flag
  type: u1
- id: quicksave_flag
  type: u1
- id: end_floor_no_death_check_flag
  type: u1
- id: field_0x9
  type: u1
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: mission_deliver_item_check
  type: u1
- id: field_0xd
  type: u1
- id: activate_artificial_weather_flag
  type: u1
- id: should_enemy_evolve
  type: u1
- id: swapping_places
  type: u1
- id: no_action_in_progress
  type: u1
- id: iq_disabled
  type: u1
- id: regular_attack_reveal_traps
  type: u1
- id: forced_loss_reason
  type: forced_loss_reason
- id: successful_exit_tracker
  type: u4
- id: camera_frame_counter
  type: s2
- id: number_completed_floors
  type: u1
- id: speed_boost_counter
  type: u1
- id: number_preceding_floors
  type: u2
- id: total_floors_completed
  type: u2
- id: field_0x24
  type: u1
- id: field_0x25
  type: u1
- id: field_0x26
  type: u1
- id: field_0x27
  type: u1
- id: field_0x28
  type: u1
- id: field_0x29
  type: u1
- id: field_0x2a
  type: u1
- id: field_0x2b
  type: u1
- id: field_0x2c
  type: u1
- id: field_0x2d
  type: u1
- id: field_0x2e
  type: u1
- id: field_0x2f
  type: u1
- id: field_0x30
  type: u1
- id: field_0x31
  type: u1
- id: field_0x32
  type: u1
- id: field_0x33
  type: u1
- id: field_0x34
  type: u1
- id: field_0x35
  type: u1
- id: field_0x36
  type: u1
- id: field_0x37
  type: u1
- id: field_0x38
  type: u1
- id: field_0x39
  type: u1
- id: field_0x3a
  type: u1
- id: field_0x3b
  type: u1
- id: field_0x3c
  type: u1
- id: field_0x3d
  type: u1
- id: field_0x3e
  type: u1
- id: field_0x3f
  type: u1
- id: field_0x40
  type: u1
- id: field_0x41
  type: u1
- id: field_0x42
  type: u1
- id: field_0x43
  type: u1
- id: field_0x44
  type: u1
- id: field_0x45
  type: u1
- id: field_0x46
  type: u1
- id: field_0x47
  type: u1
- id: field_0x48
  type: u1
- id: field_0x49
  type: u1
- id: field_0x4a
  type: u1
- id: field_0x4b
  type: u1
- id: field_0x4c
  type: u1
- id: field_0x4d
  type: u1
- id: field_0x4e
  type: u1
- id: field_0x4f
  type: u1
- id: field_0x50
  type: u1
- id: field_0x51
  type: u1
- id: field_0x52
  type: u1
- id: field_0x53
  type: u1
- id: field_0x54
  type: u1
- id: field_0x55
  type: u1
- id: field_0x56
  type: u1
- id: field_0x57
  type: u1
- id: field_0x58
  type: u1
- id: field_0x59
  type: u1
- id: field_0x5a
  type: u1
- id: field_0x5b
  type: u1
- id: field_0x5c
  type: u1
- id: field_0x5d
  type: u1
- id: field_0x5e
  type: u1
- id: field_0x5f
  type: u1
- id: field_0x60
  type: u1
- id: field_0x61
  type: u1
- id: field_0x62
  type: u1
- id: field_0x63
  type: u1
- id: field_0x64
  type: u1
- id: field_0x65
  type: u1
- id: field_0x66
  type: u1
- id: field_0x67
  type: u1
- id: field_0x68
  type: u1
- id: field_0x69
  type: u1
- id: field_0x6a
  type: u1
- id: field_0x6b
  type: u1
- id: field_0x6c
  type: u1
- id: field_0x6d
  type: u1
- id: field_0x6e
  type: u1
- id: field_0x6f
  type: u1
- id: field_0x70
  type: u1
- id: field_0x71
  type: u1
- id: field_0x72
  type: u1
- id: field_0x73
  type: u1
- id: field_0x74
  type: u1
- id: field_0x75
  type: u1
- id: field_0x76
  type: u1
- id: field_0x77
  type: u1
- id: field_0x78
  type: u1
- id: field_0x79
  type: u1
- id: field_0x7a
  type: u1
- id: field_0x7b
  type: u1
- id: field_0x7c
  type: u1
- id: field_0x7d
  type: u1
- id: field_0x7e
  type: u1
- id: field_0x7f
  type: u1
- id: field_0x80
  type: u1
- id: field_0x81
  type: u1
- id: field_0x82
  type: u1
- id: field_0x83
  type: u1
- id: field_0x84
  type: u1
- id: field_0x85
  type: u1
- id: field_0x86
  type: u1
- id: field_0x87
  type: u1
- id: field_0x88
  type: u1
- id: field_0x89
  type: u1
- id: field_0x8a
  type: u1
- id: field_0x8b
  type: u1
- id: field_0x8c
  type: u1
- id: field_0x8d
  type: u1
- id: field_0x8e
  type: u1
- id: field_0x8f
  type: u1
- id: field_0x90
  type: u1
- id: field_0x91
  type: u1
- id: field_0x92
  type: u1
- id: field_0x93
  type: u1
- id: field_0x94
  type: u1
- id: field_0x95
  type: u1
- id: field_0x96
  type: u1
- id: field_0x97
  type: u1
- id: field_0x98
  type: u1
- id: field_0x99
  type: u1
- id: field_0x9a
  type: u1
- id: field_0x9b
  type: u1
- id: field_0x9c
  type: u1
- id: field_0x9d
  type: u1
- id: field_0x9e
  type: u1
- id: field_0x9f
  type: u1
- id: field_0xa0
  type: u1
- id: field_0xa1
  type: u1
- id: field_0xa2
  type: u1
- id: field_0xa3
  type: u1
- id: field_0xa4
  type: u1
- id: field_0xa5
  type: u1
- id: field_0xa6
  type: u1
- id: field_0xa7
  type: u1
- id: field_0xa8
  type: u1
- id: field_0xa9
  type: u1
- id: field_0xaa
  type: u1
- id: field_0xab
  type: u1
- id: field_0xac
  type: u1
- id: field_0xad
  type: u1
- id: field_0xae
  type: u1
- id: field_0xaf
  type: u1
- id: field_0xb0
  type: u1
- id: field_0xb1
  type: u1
- id: field_0xb2
  type: u1
- id: field_0xb3
  type: u1
- id: field_0xb4
  type: u1
- id: field_0xb5
  type: u1
- id: field_0xb6
  type: u1
- id: field_0xb7
  type: u1
- id: field_0xb8
  type: u1
- id: field_0xb9
  type: u1
- id: field_0xba
  type: u1
- id: field_0xbb
  type: u1
- id: field_0xbc
  type: u1
- id: field_0xbd
  type: u1
- id: field_0xbe
  type: u1
- id: field_0xbf
  type: u1
- id: field_0xc0
  type: u1
- id: field_0xc1
  type: u1
- id: field_0xc2
  type: u1
- id: field_0xc3
  type: u1
- id: current_active_entity
  type: pointer
- id: new_leader
  type: pointer
- id: thrown_item
  type: entity
- id: last_damage_calc
  type: damage_calc_diag
- id: touchscreen_target_position
  type: position
- id: unknown_leader_position
  type: position
- id: color_table
  type: dungeon_color_table_array
- id: shopkeeper_spawns
  type: dungeon_shopkeeper_spawns_array
- id: shopkeeper_spawn_count
  type: s4
- id: field_0x614
  type: s4
- id: unk1_animation1_value
  type: u4
- id: unk2_animation1_value
  type: u4
- id: unk3_animation1_value
  type: u4
- id: animation1_entity
  type: pointer
- id: unk1_animation2_value
  type: u4
- id: unk2_animation2_value
  type: u4
- id: unk3_animation2_value
  type: u4
- id: animation2_entity
  type: pointer
- id: unk1_animation3_value
  type: u4
- id: unk2_animation3_value
  type: u4
- id: unk3_animation3_value
  type: u4
- id: animation3_entity
  type: pointer
- id: fallen_ally_monster_name
  type: dungeon_fallen_ally_monster_name_array
- id: field_0x652
  type: u1
- id: field_0x653
  type: u1
- id: field_0x654
  type: u1
- id: field_0x655
  type: u1
- id: field_0x656
  type: u1
- id: field_0x657
  type: u1
- id: field_0x658
  type: u1
- id: field_0x659
  type: u1
- id: field_0x65a
  type: u1
- id: field_0x65b
  type: u1
- id: field_0x65c
  type: u1
- id: field_0x65d
  type: u1
- id: field_0x65e
  type: u1
- id: field_0x65f
  type: u1
- id: field_0x660
  type: u1
- id: field_0x661
  type: u1
- id: field_0x662
  type: u1
- id: field_0x663
  type: u1
- id: field_0x664
  type: u1
- id: field_0x665
  type: u1
- id: field_0x666
  type: u1
- id: field_0x667
  type: u1
- id: field_0x668
  type: u1
- id: field_0x669
  type: u1
- id: field_0x66a
  type: u1
- id: field_0x66b
  type: u1
- id: field_0x66c
  type: u1
- id: field_0x66d
  type: u1
- id: field_0x66e
  type: u1
- id: field_0x66f
  type: u1
- id: field_0x670
  type: u1
- id: field_0x671
  type: u1
- id: field_0x672
  type: u1
- id: field_0x673
  type: u1
- id: field_0x674
  type: u1
- id: field_0x675
  type: u1
- id: field_0x676
  type: u1
- id: field_0x677
  type: u1
- id: field_0x678
  type: u1
- id: field_0x679
  type: u1
- id: field_0x67a
  type: u1
- id: field_0x67b
  type: u1
- id: field_0x67c
  type: u1
- id: field_0x67d
  type: u1
- id: field_0x67e
  type: u1
- id: field_0x67f
  type: u1
- id: field_0x680
  type: u1
- id: field_0x681
  type: u1
- id: field_0x682
  type: u1
- id: field_0x683
  type: u1
- id: field_0x684
  type: u1
- id: field_0x685
  type: u1
- id: field_0x686
  type: u1
- id: field_0x687
  type: u1
- id: field_0x688
  type: u1
- id: field_0x689
  type: u1
- id: field_0x68a
  type: u1
- id: field_0x68b
  type: u1
- id: field_0x68c
  type: u1
- id: field_0x68d
  type: u1
- id: field_0x68e
  type: u1
- id: field_0x68f
  type: u1
- id: field_0x690
  type: u1
- id: field_0x691
  type: u1
- id: field_0x692
  type: u1
- id: field_0x693
  type: u1
- id: field_0x694
  type: u1
- id: field_0x695
  type: u1
- id: field_0x696
  type: u1
- id: field_0x697
  type: u1
- id: field_0x698
  type: u1
- id: field_0x699
  type: u1
- id: field_0x69a
  type: u1
- id: field_0x69b
  type: u1
- id: field_0x69c
  type: u1
- id: field_0x69d
  type: u1
- id: field_0x69e
  type: u1
- id: field_0x69f
  type: u1
- id: field_0x6a0
  type: u1
- id: field_0x6a1
  type: u1
- id: field_0x6a2
  type: u1
- id: field_0x6a3
  type: u1
- id: field_0x6a4
  type: u1
- id: field_0x6a5
  type: u1
- id: field_0x6a6
  type: u1
- id: field_0x6a7
  type: u1
- id: field_0x6a8
  type: u1
- id: field_0x6a9
  type: u1
- id: field_0x6aa
  type: u1
- id: field_0x6ab
  type: u1
- id: field_0x6ac
  type: u1
- id: field_0x6ad
  type: u1
- id: field_0x6ae
  type: u1
- id: field_0x6af
  type: u1
- id: field_0x6b0
  type: u1
- id: field_0x6b1
  type: u1
- id: field_0x6b2
  type: u1
- id: field_0x6b3
  type: u1
- id: field_0x6b4
  type: u1
- id: field_0x6b5
  type: u1
- id: field_0x6b6
  type: u1
- id: field_0x6b7
  type: u1
- id: field_0x6b8
  type: u1
- id: field_0x6b9
  type: u1
- id: field_0x6ba
  type: u1
- id: field_0x6bb
  type: u1
- id: field_0x6bc
  type: u1
- id: field_0x6bd
  type: u1
- id: field_0x6be
  type: u1
- id: field_0x6bf
  type: u1
- id: field_0x6c0
  type: u1
- id: field_0x6c1
  type: u1
- id: field_0x6c2
  type: u1
- id: field_0x6c3
  type: u1
- id: field_0x6c4
  type: u1
- id: field_0x6c5
  type: u1
- id: field_0x6c6
  type: u1
- id: field_0x6c7
  type: u1
- id: field_0x6c8
  type: u1
- id: field_0x6c9
  type: u1
- id: field_0x6ca
  type: u1
- id: field_0x6cb
  type: u1
- id: field_0x6cc
  type: u1
- id: field_0x6cd
  type: u1
- id: field_0x6ce
  type: u1
- id: field_0x6cf
  type: u1
- id: field_0x6d0
  type: u1
- id: field_0x6d1
  type: u1
- id: field_0x6d2
  type: u1
- id: field_0x6d3
  type: u1
- id: field_0x6d4
  type: u1
- id: field_0x6d5
  type: u1
- id: field_0x6d6
  type: u1
- id: field_0x6d7
  type: u1
- id: field_0x6d8
  type: u1
- id: field_0x6d9
  type: u1
- id: field_0x6da
  type: u1
- id: field_0x6db
  type: u1
- id: field_0x6dc
  type: u1
- id: field_0x6dd
  type: u1
- id: field_0x6de
  type: u1
- id: field_0x6df
  type: u1
- id: field_0x6e0
  type: u1
- id: field_0x6e1
  type: u1
- id: field_0x6e2
  type: u1
- id: field_0x6e3
  type: u1
- id: field_0x6e4
  type: u1
- id: field_0x6e5
  type: u1
- id: field_0x6e6
  type: u1
- id: field_0x6e7
  type: u1
- id: field_0x6e8
  type: u1
- id: field_0x6e9
  type: u1
- id: field_0x6ea
  type: u1
- id: field_0x6eb
  type: u1
- id: field_0x6ec
  type: u1
- id: field_0x6ed
  type: u1
- id: field_0x6ee
  type: u1
- id: field_0x6ef
  type: u1
- id: field_0x6f0
  type: u1
- id: field_0x6f1
  type: u1
- id: field_0x6f2
  type: u1
- id: field_0x6f3
  type: u1
- id: field_0x6f4
  type: u1
- id: field_0x6f5
  type: u1
- id: field_0x6f6
  type: u1
- id: field_0x6f7
  type: u1
- id: field_0x6f8
  type: u1
- id: field_0x6f9
  type: u1
- id: field_0x6fa
  type: u1
- id: field_0x6fb
  type: u1
- id: field_0x6fc
  type: u1
- id: field_0x6fd
  type: u1
- id: field_0x6fe
  type: u1
- id: field_0x6ff
  type: u1
- id: field_0x700
  type: u1
- id: field_0x701
  type: u1
- id: field_0x702
  type: u1
- id: field_0x703
  type: u1
- id: field_0x704
  type: u1
- id: field_0x705
  type: u1
- id: field_0x706
  type: u1
- id: field_0x707
  type: u1
- id: field_0x708
  type: u1
- id: field_0x709
  type: u1
- id: field_0x70a
  type: u1
- id: field_0x70b
  type: u1
- id: field_0x70c
  type: u1
- id: field_0x70d
  type: u1
- id: field_0x70e
  type: u1
- id: field_0x70f
  type: u1
- id: field_0x710
  type: u1
- id: field_0x711
  type: u1
- id: field_0x712
  type: u1
- id: field_0x713
  type: u1
- id: field_0x714
  type: u1
- id: field_0x715
  type: u1
- id: field_0x716
  type: u1
- id: field_0x717
  type: u1
- id: field_0x718
  type: u1
- id: field_0x719
  type: u1
- id: field_0x71a
  type: u1
- id: field_0x71b
  type: u1
- id: field_0x71c
  type: u1
- id: field_0x71d
  type: u1
- id: field_0x71e
  type: u1
- id: field_0x71f
  type: u1
- id: field_0x720
  type: u1
- id: field_0x721
  type: u1
- id: field_0x722
  type: u1
- id: field_0x723
  type: u1
- id: field_0x724
  type: u1
- id: field_0x725
  type: u1
- id: field_0x726
  type: u1
- id: field_0x727
  type: u1
- id: field_0x728
  type: u1
- id: field_0x729
  type: u1
- id: field_0x72a
  type: u1
- id: field_0x72b
  type: u1
- id: field_0x72c
  type: u1
- id: field_0x72d
  type: u1
- id: field_0x72e
  type: u1
- id: field_0x72f
  type: u1
- id: field_0x730
  type: u1
- id: field_0x731
  type: u1
- id: field_0x732
  type: u1
- id: field_0x733
  type: u1
- id: field_0x734
  type: u1
- id: field_0x735
  type: u1
- id: field_0x736
  type: u1
- id: field_0x737
  type: u1
- id: field_0x738
  type: u1
- id: field_0x739
  type: u1
- id: field_0x73a
  type: u1
- id: field_0x73b
  type: u1
- id: field_0x73c
  type: u1
- id: field_0x73d
  type: u1
- id: field_0x73e
  type: u1
- id: field_0x73f
  type: u1
- id: field_0x740
  type: u1
- id: field_0x741
  type: u1
- id: field_0x742
  type: u1
- id: field_0x743
  type: u1
- id: field_0x744
  type: u1
- id: field_0x745
  type: u1
- id: field_0x746
  type: u1
- id: field_0x747
  type: u1
- id: id
  type: dungeon_id_8
- id: floor
  type: u1
- id: group_and_group_floor_id
  type: dungeon_group_and_group_floor
- id: field_0x74c
  type: u2
- id: field_0x74e
  type: u1
- id: field_0x74f
  type: u1
- id: field_0x750
  type: u1
- id: rescue_floor
  type: u1
- id: field_0x752
  type: u1
- id: field_0x753
  type: u1
- id: prng_preseed_23_bit
  type: u4
- id: floor_loop_status
  type: floor_loop_status_8
- id: recruiting_enabled
  type: u1
- id: field_0x75a
  type: u1
- id: bag_enabled
  type: u1
- id: nonstory_flag
  type: u1
- id: send_home_disabled
  type: u1
- id: hidden_land_flag
  type: u1
- id: skip_faint_animation_flag
  type: u1
- id: mission_destination
  type: mission_destination_info
- id: bazaar_mime_jr_heal
  type: u1
- id: field_0x77f
  type: u1
- id: fractional_turn
  type: u2
- id: enemy_spawn_counter
  type: u2
- id: wind_turns
  type: s2
- id: enemy_density
  type: u2
- id: next_spawn_genid
  type: u2
- id: field_0x78a
  type: u1
- id: leader_running
  type: u1
- id: prevent_misinputs
  type: u1
- id: identify_orb_flag
  type: u1
- id: pass_turn
  type: u1
- id: drought_orb_flag
  type: u1
- id: thief_alert
  type: u1
- id: thief_alert_event
  type: u1
- id: unk_music_flag
  type: u1
- id: monster_house_triggered
  type: u1
- id: monster_house_triggered_event
  type: u1
- id: field_0x795
  type: u1
- id: field_0x796
  type: u2
- id: dungeon_objective
  type: dungeon_objective_8
- id: leader_hunger_message_tracker
  type: u1
- id: turn_limit_warning_tracker
  type: u1
- id: rescue_attempts_left
  type: s1
- id: prng_seed
  type: u4
- id: rescue_prng_preseed_23_bit
  type: u4
- id: fixed_room_action_109_position
  type: position
- id: some_monster_sprite_to_load
  type: monster_id_16
- id: some_monster_level
  type: u1
- id: field_0x7ab
  type: u1
- id: prng_preseed
  type: u4
- id: field_0x7b0
  type: u1
- id: field_0x7b1
  type: u1
- id: field_0x7b2
  type: u1
- id: field_0x7b3
  type: u1
- id: field_0x7b4
  type: u1
- id: field_0x7b5
  type: u1
- id: field_0x7b6
  type: u1
- id: field_0x7b7
  type: u1
- id: field_0x7b8
  type: u1
- id: field_0x7b9
  type: u1
- id: field_0x7ba
  type: u1
- id: field_0x7bb
  type: u1
- id: poke_buy_kecleon_shop
  type: u4
- id: poke_sold_kecleon_shop
  type: u4
- id: unk_poke_kecleon_shop_tracker
  type: u4
- id: leader_standing_in_kecleon_shop
  type: u1
- id: standing_in_kecleon_shop
  type: u1
- id: field_0x7ca
  type: u1
- id: field_0x7cb
  type: u1
- id: dungeon_game_version_id
  type: game_id
- id: field_0x7d0
  type: u1
- id: field_0x7d1
  type: u1
- id: field_0x7d2
  type: u1
- id: field_0x7d3
  type: u1
- id: field_0x7d4
  type: u1
- id: field_0x7d5
  type: u1
- id: field_0x7d6
  type: u1
- id: field_0x7d7
  type: u1
- id: field_0x7d8
  type: u1
- id: field_0x7d9
  type: u1
- id: field_0x7da
  type: u1
- id: field_0x7db
  type: u1
- id: field_0x7dc
  type: u1
- id: field_0x7dd
  type: u1
- id: field_0x7de
  type: u1
- id: field_0x7df
  type: u1
- id: field_0x7e0
  type: u1
- id: field_0x7e1
  type: u1
- id: field_0x7e2
  type: u1
- id: field_0x7e3
  type: u1
- id: field_0x7e4
  type: u1
- id: field_0x7e5
  type: u1
- id: field_0x7e6
  type: u1
- id: field_0x7e7
  type: u1
- id: field_0x7e8
  type: u1
- id: field_0x7e9
  type: u1
- id: field_0x7ea
  type: u1
- id: field_0x7eb
  type: u1
- id: field_0x7ec
  type: u1
- id: field_0x7ed
  type: u1
- id: field_0x7ee
  type: u1
- id: field_0x7ef
  type: u1
- id: num_entries_for_field_0x7d0
  type: u2
- id: some_monster_sprite
  type: monster_id_16
- id: monsters
  type: dungeon_monsters_array
- id: enemy_spawn_stats
  type: dungeon_enemy_spawn_stats_array
- id: spawn_entries
  type: dungeon_spawn_entries_array
- id: field_0x39f4
  type: u1
- id: field_0x39f5
  type: u1
- id: field_0x39f6
  type: u1
- id: field_0x39f7
  type: u1
- id: field_0x39f8
  type: u1
- id: field_0x39f9
  type: u1
- id: field_0x39fa
  type: u1
- id: field_0x39fb
  type: u1
- id: field_0x39fc
  type: u1
- id: field_0x39fd
  type: u1
- id: field_0x39fe
  type: u1
- id: field_0x39ff
  type: u1
- id: field_0x3a00
  type: u1
- id: field_0x3a01
  type: u1
- id: field_0x3a02
  type: u1
- id: field_0x3a03
  type: u1
- id: field_0x3a04
  type: u1
- id: field_0x3a05
  type: u1
- id: field_0x3a06
  type: u1
- id: field_0x3a07
  type: u1
- id: field_0x3a08
  type: u1
- id: field_0x3a09
  type: u1
- id: field_0x3a0a
  type: u1
- id: field_0x3a0b
  type: u1
- id: field_0x3a0c
  type: u1
- id: field_0x3a0d
  type: u1
- id: field_0x3a0e
  type: u1
- id: field_0x3a0f
  type: u1
- id: field_0x3a10
  type: u1
- id: field_0x3a11
  type: u1
- id: field_0x3a12
  type: u1
- id: field_0x3a13
  type: u1
- id: field_0x3a14
  type: u1
- id: field_0x3a15
  type: u1
- id: field_0x3a16
  type: u1
- id: field_0x3a17
  type: u1
- id: field_0x3a18
  type: u1
- id: field_0x3a19
  type: u1
- id: field_0x3a1a
  type: u1
- id: field_0x3a1b
  type: u1
- id: field_0x3a1c
  type: u1
- id: field_0x3a1d
  type: u1
- id: field_0x3a1e
  type: u1
- id: field_0x3a1f
  type: u1
- id: field_0x3a20
  type: u1
- id: field_0x3a21
  type: u1
- id: field_0x3a22
  type: u1
- id: field_0x3a23
  type: u1
- id: field_0x3a24
  type: u1
- id: field_0x3a25
  type: u1
- id: field_0x3a26
  type: u1
- id: field_0x3a27
  type: u1
- id: field_0x3a28
  type: u1
- id: field_0x3a29
  type: u1
- id: field_0x3a2a
  type: u1
- id: field_0x3a2b
  type: u1
- id: field_0x3a2c
  type: u1
- id: field_0x3a2d
  type: u1
- id: field_0x3a2e
  type: u1
- id: field_0x3a2f
  type: u1
- id: field_0x3a30
  type: u1
- id: field_0x3a31
  type: u1
- id: field_0x3a32
  type: u1
- id: field_0x3a33
  type: u1
- id: field_0x3a34
  type: u1
- id: field_0x3a35
  type: u1
- id: field_0x3a36
  type: u1
- id: field_0x3a37
  type: u1
- id: field_0x3a38
  type: u1
- id: field_0x3a39
  type: u1
- id: field_0x3a3a
  type: u1
- id: field_0x3a3b
  type: u1
- id: field_0x3a3c
  type: u1
- id: field_0x3a3d
  type: u1
- id: field_0x3a3e
  type: u1
- id: field_0x3a3f
  type: u1
- id: field_0x3a40
  type: u1
- id: field_0x3a41
  type: u1
- id: field_0x3a42
  type: u1
- id: field_0x3a43
  type: u1
- id: field_0x3a44
  type: u1
- id: field_0x3a45
  type: u1
- id: field_0x3a46
  type: u1
- id: field_0x3a47
  type: u1
- id: field_0x3a48
  type: u1
- id: field_0x3a49
  type: u1
- id: field_0x3a4a
  type: u1
- id: field_0x3a4b
  type: u1
- id: field_0x3a4c
  type: u1
- id: field_0x3a4d
  type: u1
- id: field_0x3a4e
  type: u1
- id: field_0x3a4f
  type: u1
- id: field_0x3a50
  type: u1
- id: field_0x3a51
  type: u1
- id: field_0x3a52
  type: u1
- id: field_0x3a53
  type: u1
- id: field_0x3a54
  type: u1
- id: field_0x3a55
  type: u1
- id: field_0x3a56
  type: u1
- id: field_0x3a57
  type: u1
- id: field_0x3a58
  type: u1
- id: field_0x3a59
  type: u1
- id: field_0x3a5a
  type: u1
- id: field_0x3a5b
  type: u1
- id: field_0x3a5c
  type: u1
- id: field_0x3a5d
  type: u1
- id: field_0x3a5e
  type: u1
- id: field_0x3a5f
  type: u1
- id: field_0x3a60
  type: u1
- id: field_0x3a61
  type: u1
- id: field_0x3a62
  type: u1
- id: field_0x3a63
  type: u1
- id: field_0x3a64
  type: u1
- id: field_0x3a65
  type: u1
- id: field_0x3a66
  type: u1
- id: field_0x3a67
  type: u1
- id: field_0x3a68
  type: u1
- id: field_0x3a69
  type: u1
- id: field_0x3a6a
  type: u1
- id: field_0x3a6b
  type: u1
- id: field_0x3a6c
  type: u1
- id: field_0x3a6d
  type: u1
- id: field_0x3a6e
  type: u1
- id: field_0x3a6f
  type: u1
- id: field_0x3a70
  type: u1
- id: field_0x3a71
  type: u1
- id: field_0x3a72
  type: u1
- id: field_0x3a73
  type: u1
- id: field_0x3a74
  type: u1
- id: field_0x3a75
  type: u1
- id: field_0x3a76
  type: u1
- id: field_0x3a77
  type: u1
- id: field_0x3a78
  type: u1
- id: field_0x3a79
  type: u1
- id: field_0x3a7a
  type: u1
- id: field_0x3a7b
  type: u1
- id: field_0x3a7c
  type: u1
- id: field_0x3a7d
  type: u1
- id: field_0x3a7e
  type: u1
- id: field_0x3a7f
  type: u1
- id: field_0x3a80
  type: u1
- id: field_0x3a81
  type: u1
- id: field_0x3a82
  type: u1
- id: field_0x3a83
  type: u1
- id: field_0x3a84
  type: u1
- id: field_0x3a85
  type: u1
- id: field_0x3a86
  type: u1
- id: field_0x3a87
  type: u1
- id: field_0x3a88
  type: u1
- id: field_0x3a89
  type: u1
- id: field_0x3a8a
  type: u1
- id: field_0x3a8b
  type: u1
- id: field_0x3a8c
  type: u1
- id: field_0x3a8d
  type: u1
- id: field_0x3a8e
  type: u1
- id: field_0x3a8f
  type: u1
- id: field_0x3a90
  type: u1
- id: field_0x3a91
  type: u1
- id: field_0x3a92
  type: u1
- id: field_0x3a93
  type: u1
- id: field_0x3a94
  type: u1
- id: field_0x3a95
  type: u1
- id: field_0x3a96
  type: u1
- id: field_0x3a97
  type: u1
- id: field_0x3a98
  type: u1
- id: field_0x3a99
  type: u1
- id: field_0x3a9a
  type: u1
- id: field_0x3a9b
  type: u1
- id: field_0x3a9c
  type: u1
- id: field_0x3a9d
  type: u1
- id: field_0x3a9e
  type: u1
- id: field_0x3a9f
  type: u1
- id: field_0x3aa0
  type: u1
- id: field_0x3aa1
  type: u1
- id: field_0x3aa2
  type: u1
- id: field_0x3aa3
  type: u1
- id: field_0x3aa4
  type: u1
- id: field_0x3aa5
  type: u1
- id: field_0x3aa6
  type: u1
- id: field_0x3aa7
  type: u1
- id: field_0x3aa8
  type: u1
- id: field_0x3aa9
  type: u1
- id: field_0x3aaa
  type: u1
- id: field_0x3aab
  type: u1
- id: field_0x3aac
  type: u1
- id: field_0x3aad
  type: u1
- id: field_0x3aae
  type: u1
- id: field_0x3aaf
  type: u1
- id: field_0x3ab0
  type: u1
- id: field_0x3ab1
  type: u1
- id: field_0x3ab2
  type: u1
- id: field_0x3ab3
  type: u1
- id: field_0x3ab4
  type: u1
- id: field_0x3ab5
  type: u1
- id: field_0x3ab6
  type: u1
- id: field_0x3ab7
  type: u1
- id: field_0x3ab8
  type: u1
- id: field_0x3ab9
  type: u1
- id: field_0x3aba
  type: u1
- id: field_0x3abb
  type: u1
- id: field_0x3abc
  type: u1
- id: field_0x3abd
  type: u1
- id: field_0x3abe
  type: u1
- id: field_0x3abf
  type: u1
- id: field_0x3ac0
  type: u1
- id: field_0x3ac1
  type: u1
- id: field_0x3ac2
  type: u1
- id: field_0x3ac3
  type: u1
- id: field_0x3ac4
  type: u1
- id: field_0x3ac5
  type: u1
- id: field_0x3ac6
  type: u1
- id: field_0x3ac7
  type: u1
- id: field_0x3ac8
  type: u1
- id: field_0x3ac9
  type: u1
- id: field_0x3aca
  type: u1
- id: field_0x3acb
  type: u1
- id: field_0x3acc
  type: u1
- id: field_0x3acd
  type: u1
- id: field_0x3ace
  type: u1
- id: field_0x3acf
  type: u1
- id: field_0x3ad0
  type: u1
- id: field_0x3ad1
  type: u1
- id: field_0x3ad2
  type: u1
- id: field_0x3ad3
  type: u1
- id: field_0x3ad4
  type: u1
- id: field_0x3ad5
  type: u1
- id: field_0x3ad6
  type: u1
- id: field_0x3ad7
  type: u1
- id: field_0x3ad8
  type: u1
- id: field_0x3ad9
  type: u1
- id: field_0x3ada
  type: u1
- id: field_0x3adb
  type: u1
- id: field_0x3adc
  type: u1
- id: field_0x3add
  type: u1
- id: field_0x3ade
  type: u1
- id: field_0x3adf
  type: u1
- id: field_0x3ae0
  type: u1
- id: field_0x3ae1
  type: u1
- id: field_0x3ae2
  type: u1
- id: field_0x3ae3
  type: u1
- id: field_0x3ae4
  type: u1
- id: field_0x3ae5
  type: u1
- id: field_0x3ae6
  type: u1
- id: field_0x3ae7
  type: u1
- id: field_0x3ae8
  type: u1
- id: field_0x3ae9
  type: u1
- id: field_0x3aea
  type: u1
- id: field_0x3aeb
  type: u1
- id: field_0x3aec
  type: u1
- id: field_0x3aed
  type: u1
- id: field_0x3aee
  type: u1
- id: field_0x3aef
  type: u1
- id: field_0x3af0
  type: u1
- id: field_0x3af1
  type: u1
- id: field_0x3af2
  type: u1
- id: field_0x3af3
  type: u1
- id: field_0x3af4
  type: u1
- id: field_0x3af5
  type: u1
- id: field_0x3af6
  type: u1
- id: field_0x3af7
  type: u1
- id: field_0x3af8
  type: u1
- id: field_0x3af9
  type: u1
- id: field_0x3afa
  type: u1
- id: field_0x3afb
  type: u1
- id: field_0x3afc
  type: u1
- id: field_0x3afd
  type: u1
- id: field_0x3afe
  type: u1
- id: field_0x3aff
  type: u1
- id: field_0x3b00
  type: u1
- id: field_0x3b01
  type: u1
- id: field_0x3b02
  type: u1
- id: field_0x3b03
  type: u1
- id: field_0x3b04
  type: u1
- id: field_0x3b05
  type: u1
- id: field_0x3b06
  type: u1
- id: field_0x3b07
  type: u1
- id: field_0x3b08
  type: u1
- id: field_0x3b09
  type: u1
- id: field_0x3b0a
  type: u1
- id: field_0x3b0b
  type: u1
- id: field_0x3b0c
  type: u1
- id: field_0x3b0d
  type: u1
- id: field_0x3b0e
  type: u1
- id: field_0x3b0f
  type: u1
- id: field_0x3b10
  type: u1
- id: field_0x3b11
  type: u1
- id: field_0x3b12
  type: u1
- id: field_0x3b13
  type: u1
- id: field_0x3b14
  type: u1
- id: field_0x3b15
  type: u1
- id: field_0x3b16
  type: u1
- id: field_0x3b17
  type: u1
- id: field_0x3b18
  type: u1
- id: field_0x3b19
  type: u1
- id: field_0x3b1a
  type: u1
- id: field_0x3b1b
  type: u1
- id: field_0x3b1c
  type: u1
- id: field_0x3b1d
  type: u1
- id: field_0x3b1e
  type: u1
- id: field_0x3b1f
  type: u1
- id: field_0x3b20
  type: u1
- id: field_0x3b21
  type: u1
- id: field_0x3b22
  type: u1
- id: field_0x3b23
  type: u1
- id: field_0x3b24
  type: u1
- id: field_0x3b25
  type: u1
- id: field_0x3b26
  type: u1
- id: field_0x3b27
  type: u1
- id: field_0x3b28
  type: u1
- id: field_0x3b29
  type: u1
- id: field_0x3b2a
  type: u1
- id: field_0x3b2b
  type: u1
- id: field_0x3b2c
  type: u1
- id: field_0x3b2d
  type: u1
- id: field_0x3b2e
  type: u1
- id: field_0x3b2f
  type: u1
- id: field_0x3b30
  type: u1
- id: field_0x3b31
  type: u1
- id: field_0x3b32
  type: u1
- id: field_0x3b33
  type: u1
- id: field_0x3b34
  type: u1
- id: field_0x3b35
  type: u1
- id: field_0x3b36
  type: u1
- id: field_0x3b37
  type: u1
- id: field_0x3b38
  type: u1
- id: field_0x3b39
  type: u1
- id: field_0x3b3a
  type: u1
- id: field_0x3b3b
  type: u1
- id: field_0x3b3c
  type: u1
- id: field_0x3b3d
  type: u1
- id: field_0x3b3e
  type: u1
- id: field_0x3b3f
  type: u1
- id: field_0x3b40
  type: u1
- id: field_0x3b41
  type: u1
- id: field_0x3b42
  type: u1
- id: field_0x3b43
  type: u1
- id: field_0x3b44
  type: u1
- id: field_0x3b45
  type: u1
- id: field_0x3b46
  type: u1
- id: field_0x3b47
  type: u1
- id: field_0x3b48
  type: u1
- id: field_0x3b49
  type: u1
- id: field_0x3b4a
  type: u1
- id: field_0x3b4b
  type: u1
- id: field_0x3b4c
  type: u1
- id: field_0x3b4d
  type: u1
- id: field_0x3b4e
  type: u1
- id: field_0x3b4f
  type: u1
- id: field_0x3b50
  type: u1
- id: field_0x3b51
  type: u1
- id: field_0x3b52
  type: u1
- id: field_0x3b53
  type: u1
- id: field_0x3b54
  type: u1
- id: field_0x3b55
  type: u1
- id: field_0x3b56
  type: u1
- id: field_0x3b57
  type: u1
- id: field_0x3b58
  type: u1
- id: field_0x3b59
  type: u1
- id: field_0x3b5a
  type: u1
- id: field_0x3b5b
  type: u1
- id: field_0x3b5c
  type: u1
- id: field_0x3b5d
  type: u1
- id: field_0x3b5e
  type: u1
- id: field_0x3b5f
  type: u1
- id: field_0x3b60
  type: u1
- id: field_0x3b61
  type: u1
- id: field_0x3b62
  type: u1
- id: field_0x3b63
  type: u1
- id: field_0x3b64
  type: u1
- id: field_0x3b65
  type: u1
- id: field_0x3b66
  type: u1
- id: field_0x3b67
  type: u1
- id: field_0x3b68
  type: u1
- id: field_0x3b69
  type: u1
- id: field_0x3b6a
  type: u1
- id: field_0x3b6b
  type: u1
- id: field_0x3b6c
  type: u1
- id: field_0x3b6d
  type: u1
- id: field_0x3b6e
  type: u1
- id: field_0x3b6f
  type: u1
- id: field_0x3b70
  type: u1
- id: field_0x3b71
  type: u1
- id: field_0x3b72
  type: u1
- id: field_0x3b73
  type: u1
- id: unknown_array_0x3b74
  type: dungeon_unknown_array_0x3b74_array
- id: monster_unique_id
  type: dungeon_monster_unique_id_array
- id: unique_id_index
  type: u4
- id: monster_spawn_entries_length
  type: s4
- id: field_0x3e24
  type: u1
- id: field_0x3e25
  type: u1
- id: field_0x3e26
  type: u1
- id: field_0x3e27
  type: u1
- id: unk_spawn_entry_id_check
  type: u1
- id: field_0x3e29
  type: u1
- id: field_0x3e2a
  type: u1
- id: field_0x3e2b
  type: u1
- id: monster_unique_id_counter
  type: u4
- id: monster_unique_wrap_counter
  type: u4
- id: plus_is_active
  type: dungeon_plus_is_active_array
- id: minus_is_active
  type: dungeon_minus_is_active_array
- id: decoy_is_active
  type: u1
- id: mew_cannot_spawn
  type: u1
- id: deoxys_floor_id
  type: monster_id_16
- id: shaymin_sky_form_loaded
  type: u1
- id: field_0x3e3d
  type: u1
- id: field_0x3e3e
  type: u1
- id: field_0x3e3f
  type: u1
- id: items
  type: dungeon_items_array
- id: n_items
  type: u2
- id: n_fixed_room_items
  type: s2
- id: traps
  type: dungeon_traps_array
- id: gen_info
  type: dungeon_generation_info
- id: field_0xccfc
  type: u1
- id: field_0xccfd
  type: u1
- id: field_0xccfe
  type: u1
- id: field_0xccff
  type: u1
- id: field_0xcd00
  type: u1
- id: field_0xcd01
  type: u1
- id: field_0xcd02
  type: u1
- id: field_0xcd03
  type: u1
- id: field_0xcd04
  type: u1
- id: field_0xcd05
  type: u1
- id: field_0xcd06
  type: u1
- id: field_0xcd07
  type: u1
- id: field_0xcd08
  type: u1
- id: field_0xcd09
  type: u1
- id: field_0xcd0a
  type: u1
- id: field_0xcd0b
  type: u1
- id: unk_team_direction_array
  type: dungeon_unk_team_direction_array_array
- id: kecleon_shop_min_x
  type: s4
- id: kecleon_shop_min_y
  type: s4
- id: kecleon_shop_max_x
  type: s4
- id: kecleon_shop_max_y
  type: s4
- id: fixed_room_min_x
  type: s4
- id: fixed_room_min_y
  type: s4
- id: fixed_room_max_x
  type: s4
- id: fixed_room_max_y
  type: s4
- id: fixed_room_width
  type: u2
- id: fixed_room_height
  type: u2
- id: weather
  type: weather_id_8
- id: natural_weather
  type: weather_id_8
- id: weather_turns
  type: dungeon_weather_turns_array
- id: artificial_permaweather_turns
  type: dungeon_artificial_permaweather_turns_array
- id: weather_damage_counter
  type: u1
- id: mud_sport_turns
  type: u1
- id: water_sport_turns
  type: u1
- id: nullify_weather
  type: u1
- id: field_0xcd5e
  type: u1
- id: field_0xcd5f
  type: u1
- id: fixed_room_tiles
  type: dungeon_fixed_room_tiles_array
- id: field_0xd260
  type: u1
- id: field_0xd261
  type: u1
- id: field_0xd262
  type: u1
- id: field_0xd263
  type: u1
- id: field_0xd264
  type: u1
- id: field_0xd265
  type: u1
- id: field_0xd266
  type: u1
- id: field_0xd267
  type: u1
- id: field_0xd268
  type: u1
- id: field_0xd269
  type: u1
- id: field_0xd26a
  type: u1
- id: field_0xd26b
  type: u1
- id: field_0xd26c
  type: u1
- id: field_0xd26d
  type: u1
- id: field_0xd26e
  type: u1
- id: field_0xd26f
  type: u1
- id: field_0xd270
  type: u1
- id: field_0xd271
  type: u1
- id: field_0xd272
  type: u1
- id: field_0xd273
  type: u1
- id: field_0xd274
  type: u1
- id: field_0xd275
  type: u1
- id: field_0xd276
  type: u1
- id: field_0xd277
  type: u1
- id: field_0xd278
  type: u1
- id: field_0xd279
  type: u1
- id: field_0xd27a
  type: u1
- id: field_0xd27b
  type: u1
- id: field_0xd27c
  type: u1
- id: field_0xd27d
  type: u1
- id: field_0xd27e
  type: u1
- id: field_0xd27f
  type: u1
- id: field_0xd280
  type: u1
- id: field_0xd281
  type: u1
- id: field_0xd282
  type: u1
- id: field_0xd283
  type: u1
- id: field_0xd284
  type: u1
- id: field_0xd285
  type: u1
- id: field_0xd286
  type: u1
- id: field_0xd287
  type: u1
- id: field_0xd288
  type: u1
- id: field_0xd289
  type: u1
- id: field_0xd28a
  type: u1
- id: field_0xd28b
  type: u1
- id: field_0xd28c
  type: u1
- id: field_0xd28d
  type: u1
- id: field_0xd28e
  type: u1
- id: field_0xd28f
  type: u1
- id: field_0xd290
  type: u1
- id: field_0xd291
  type: u1
- id: field_0xd292
  type: u1
- id: field_0xd293
  type: u1
- id: field_0xd294
  type: u1
- id: field_0xd295
  type: u1
- id: field_0xd296
  type: u1
- id: field_0xd297
  type: u1
- id: field_0xd298
  type: u1
- id: field_0xd299
  type: u1
- id: field_0xd29a
  type: u1
- id: field_0xd29b
  type: u1
- id: field_0xd29c
  type: u1
- id: field_0xd29d
  type: u1
- id: field_0xd29e
  type: u1
- id: field_0xd29f
  type: u1
- id: field_0xd2a0
  type: u1
- id: field_0xd2a1
  type: u1
- id: field_0xd2a2
  type: u1
- id: field_0xd2a3
  type: u1
- id: field_0xd2a4
  type: u1
- id: field_0xd2a5
  type: u1
- id: field_0xd2a6
  type: u1
- id: field_0xd2a7
  type: u1
- id: field_0xd2a8
  type: u1
- id: field_0xd2a9
  type: u1
- id: field_0xd2aa
  type: u1
- id: field_0xd2ab
  type: u1
- id: field_0xd2ac
  type: u1
- id: field_0xd2ad
  type: u1
- id: field_0xd2ae
  type: u1
- id: field_0xd2af
  type: u1
- id: field_0xd2b0
  type: u1
- id: field_0xd2b1
  type: u1
- id: field_0xd2b2
  type: u1
- id: field_0xd2b3
  type: u1
- id: field_0xd2b4
  type: u1
- id: field_0xd2b5
  type: u1
- id: field_0xd2b6
  type: u1
- id: field_0xd2b7
  type: u1
- id: field_0xd2b8
  type: u1
- id: field_0xd2b9
  type: u1
- id: field_0xd2ba
  type: u1
- id: field_0xd2bb
  type: u1
- id: field_0xd2bc
  type: u1
- id: field_0xd2bd
  type: u1
- id: field_0xd2be
  type: u1
- id: field_0xd2bf
  type: u1
- id: field_0xd2c0
  type: u1
- id: field_0xd2c1
  type: u1
- id: field_0xd2c2
  type: u1
- id: field_0xd2c3
  type: u1
- id: field_0xd2c4
  type: u1
- id: field_0xd2c5
  type: u1
- id: field_0xd2c6
  type: u1
- id: field_0xd2c7
  type: u1
- id: field_0xd2c8
  type: u1
- id: field_0xd2c9
  type: u1
- id: field_0xd2ca
  type: u1
- id: field_0xd2cb
  type: u1
- id: field_0xd2cc
  type: u1
- id: field_0xd2cd
  type: u1
- id: field_0xd2ce
  type: u1
- id: field_0xd2cf
  type: u1
- id: field_0xd2d0
  type: u1
- id: field_0xd2d1
  type: u1
- id: field_0xd2d2
  type: u1
- id: field_0xd2d3
  type: u1
- id: field_0xd2d4
  type: u1
- id: field_0xd2d5
  type: u1
- id: field_0xd2d6
  type: u1
- id: field_0xd2d7
  type: u1
- id: field_0xd2d8
  type: u1
- id: field_0xd2d9
  type: u1
- id: field_0xd2da
  type: u1
- id: field_0xd2db
  type: u1
- id: field_0xd2dc
  type: u1
- id: field_0xd2dd
  type: u1
- id: field_0xd2de
  type: u1
- id: field_0xd2df
  type: u1
- id: fixed_room_room_index
  type: u1
- id: field_0xd2e1
  type: u1
- id: field_0xd2e2
  type: u1
- id: field_0xd2e3
  type: u1
- id: tile_ptrs
  type: dungeon_tile_ptrs_array
- id: n_rooms
  type: u1
- id: field_0xeee5
  type: u1
- id: field_0xeee6
  type: u1
- id: field_0xeee7
  type: u1
- id: room_data
  type: dungeon_room_data_array
- id: natural_junction_list_counts
  type: dungeon_natural_junction_list_counts_array
- id: natural_junction_list
  type: dungeon_natural_junction_list_array
- id: unknown_file_buffer_0x102a8
  type: dungeon_unknown_file_buffer_0x102a8_array
- id: unknown_tile_matrix
  type: dungeon_unknown_tile_matrix_array
- id: unknown_matrix_0x1212c
  type: dungeon_unknown_matrix_0x1212c_array
- id: unknown_file_buffer_0x12162
  type: dungeon_unknown_file_buffer_0x12162_array
- id: unknown_array_0x12a92
  type: dungeon_unknown_array_0x12a92_array
- id: unk_fixed_room_pointer
  type: pointer
- id: trapper_orb_flag
  type: u1
- id: field_0x12aa9
  type: u1
- id: trapper_orb_trap_pos
  type: position
- id: trapper_orb_trap_id
  type: trap_id_8
- id: trapper_orb_trap_team
  type: u1
- id: field_0x12ab0
  type: u1
- id: field_0x12ab1
  type: u1
- id: field_0x12ab2
  type: u1
- id: field_0x12ab3
  type: u1
- id: field_0x12ab4
  type: u1
- id: field_0x12ab5
  type: u1
- id: field_0x12ab6
  type: u1
- id: field_0x12ab7
  type: u1
- id: field_0x12ab8
  type: u1
- id: field_0x12ab9
  type: u1
- id: field_0x12aba
  type: u1
- id: field_0x12abb
  type: u1
- id: field_0x12abc
  type: u1
- id: field_0x12abd
  type: u1
- id: field_0x12abe
  type: u1
- id: field_0x12abf
  type: u1
- id: field_0x12ac0
  type: u1
- id: field_0x12ac1
  type: u1
- id: field_0x12ac2
  type: u1
- id: field_0x12ac3
  type: u1
- id: field_0x12ac4
  type: u1
- id: field_0x12ac5
  type: u1
- id: field_0x12ac6
  type: u1
- id: field_0x12ac7
  type: u1
- id: field_0x12ac8
  type: u1
- id: field_0x12ac9
  type: u1
- id: field_0x12aca
  type: u1
- id: field_0x12acb
  type: u1
- id: field_0x12acc
  type: u1
- id: field_0x12acd
  type: u1
- id: field_0x12ace
  type: u1
- id: field_0x12acf
  type: u1
- id: field_0x12ad0
  type: u1
- id: field_0x12ad1
  type: u1
- id: field_0x12ad2
  type: u1
- id: field_0x12ad3
  type: u1
- id: field_0x12ad4
  type: u1
- id: field_0x12ad5
  type: u1
- id: field_0x12ad6
  type: u1
- id: field_0x12ad7
  type: u1
- id: field_0x12ad8
  type: u1
- id: field_0x12ad9
  type: u1
- id: field_0x12ada
  type: u1
- id: field_0x12adb
  type: u1
- id: field_0x12adc
  type: u1
- id: field_0x12add
  type: u1
- id: field_0x12ade
  type: u1
- id: field_0x12adf
  type: u1
- id: field_0x12ae0
  type: u1
- id: field_0x12ae1
  type: u1
- id: field_0x12ae2
  type: u1
- id: field_0x12ae3
  type: u1
- id: field_0x12ae4
  type: u1
- id: field_0x12ae5
  type: u1
- id: field_0x12ae6
  type: u1
- id: field_0x12ae7
  type: u1
- id: field_0x12ae8
  type: u1
- id: field_0x12ae9
  type: u1
- id: field_0x12aea
  type: u1
- id: field_0x12aeb
  type: u1
- id: field_0x12aec
  type: u1
- id: field_0x12aed
  type: u1
- id: field_0x12aee
  type: u1
- id: field_0x12aef
  type: u1
- id: field_0x12af0
  type: u1
- id: field_0x12af1
  type: u1
- id: field_0x12af2
  type: u1
- id: field_0x12af3
  type: u1
- id: field_0x12af4
  type: u1
- id: field_0x12af5
  type: u1
- id: field_0x12af6
  type: u1
- id: field_0x12af7
  type: u1
- id: acute_sniffer_item_count
  type: u2
- id: n_normal_item_spawns
  type: u2
- id: gravity
  type: u1
- id: field_0x12afd
  type: u1
- id: victory_counter
  type: s2
- id: field_0x12b00
  type: u1
- id: field_0x12b01
  type: u1
- id: field_0x12b02
  type: u1
- id: field_0x12b03
  type: u1
- id: field_0x12b04
  type: u1
- id: field_0x12b05
  type: u1
- id: field_0x12b06
  type: u1
- id: field_0x12b07
  type: u1
- id: field_0x12b08
  type: u1
- id: field_0x12b09
  type: u1
- id: field_0x12b0a
  type: u1
- id: field_0x12b0b
  type: u1
- id: field_0x12b0c
  type: u1
- id: field_0x12b0d
  type: u1
- id: field_0x12b0e
  type: u1
- id: field_0x12b0f
  type: u1
- id: field_0x12b10
  type: u1
- id: field_0x12b11
  type: u1
- id: field_0x12b12
  type: u1
- id: field_0x12b13
  type: u1
- id: field_0x12b14
  type: u1
- id: field_0x12b15
  type: u1
- id: field_0x12b16
  type: u1
- id: field_0x12b17
  type: u1
- id: field_0x12b18
  type: u1
- id: field_0x12b19
  type: u1
- id: field_0x12b1a
  type: u1
- id: field_0x12b1b
  type: u1
- id: field_0x12b1c
  type: u1
- id: field_0x12b1d
  type: u1
- id: field_0x12b1e
  type: u1
- id: field_0x12b1f
  type: u1
- id: fixed_room_monster_sprite_counter
  type: u4
- id: boost_kecleon_shop_spawn_chance
  type: u1
- id: boost_hidden_stairs_spawn_chance
  type: u1
- id: field_0x12b26
  type: u1
- id: field_0x12b27
  type: u1
- id: entity_table
  type: entity_table
- id: unk_ally_monster1
  type: pointer
- id: unk_ally_monster_unique_id1
  type: u4
- id: unk_ally_monster2
  type: pointer
- id: unk_ally_monster_unique_id2
  type: u4
- id: unk_enemy_monster1
  type: pointer
- id: unk_enemy_monster_unique_id1
  type: u4
- id: unk_enemy_monster2
  type: pointer
- id: unk_enemy_monster_unique_id2
  type: u4
- id: snatch_monster
  type: pointer
- id: illuminate_spawn_entity
  type: pointer
- id: snatch_status_unique_id
  type: u4
- id: illuminate_spawn_genid
  type: u2
- id: field_0x19912
  type: u1
- id: field_0x19913
  type: u1
- id: sprite_indexes
  type: dungeon_sprite_indexes_array
- id: field_0x1a21a
  type: u1
- id: field_0x1a21b
  type: u1
- id: display_data
  type: display_data
- id: minimap_display_data
  type: minimap_display_data
- id: group_and_group_floor_id_copy
  type: dungeon_group_and_group_floor
- id: floor_properties
  type: floor_properties
- id: field_0x286d2
  type: u2
- id: field_0x286d4
  type: u2
- id: field_0x286d6
  type: u2
- id: field_0x286d8
  type: u2
- id: field_0x286da
  type: u2
- id: field_0x286dc
  type: u2
- id: field_0x286de
  type: u2
- id: field_0x286e0
  type: u2
- id: field_0x286e2
  type: u2
- id: field_0x286e4
  type: u2
- id: field_0x286e6
  type: u2
- id: field_0x286e8
  type: u2
- id: field_0x286ea
  type: u2
- id: field_0x286ec
  type: u2
- id: field_0x286ee
  type: u2
- id: field_0x286f0
  type: u2
- id: regular_item_weights
  type: dungeon_regular_item_weights_array
- id: kecleon_item_weights
  type: dungeon_kecleon_item_weights_array
- id: monster_house_item_weights
  type: dungeon_monster_house_item_weights_array
- id: buried_item_weights
  type: dungeon_buried_item_weights_array
- id: grab_bag_item_weights
  type: dungeon_grab_bag_item_weights_array
- id: secret_room_item_weights
  type: dungeon_secret_room_item_weights_array
- id: trap_weights
  type: dungeon_trap_weights_array
- id: spawn_entries_master
  type: dungeon_spawn_entries_master_array
- id: number_sprites_loaded
  type: u2
- id: highest_enemy_level
  type: u2
- id: guaranteed_item_id
  type: item_id_16
- id: spawn_table_entries_chosen
  type: dungeon_spawn_table_entries_chosen_array
- id: field_0x2ca0a
  type: u1
- id: field_0x2ca0b
  type: u1
- id: fainted_monster_cause_entity_name
  type: dungeon_fainted_monster_cause_entity_name_array
- id: fainted_monster_name
  type: dungeon_fainted_monster_name_array
- id: fallen_escort_monster_name
  type: dungeon_fallen_escort_monster_name_array
- id: fainted_monster_dungeon_end_reason
  type: damage_source_16
- id: fainted_id
  type: dungeon_id_8
- id: fainted_floor
  type: u1
- id: fainted_monster_held_item
  type: item
- id: fainted_monster_exp
  type: s4
- id: fainted_monster_max_hp
  type: s2
- id: fainted_monster_offensive_stats
  type: dungeon_fainted_monster_offensive_stats_array
- id: fainted_monster_defensive_stats
  type: dungeon_fainted_monster_defensive_stats_array
- id: fainted_monster_level
  type: u1
- id: field_0x2ca7b
  type: u1
- id: getout_monster_summary
  type: monster_summary
- id: n_floors_plus_one
  type: u1
- id: field_0x2caf5
  type: u1
- id: field_0x2caf6
  type: u1
- id: field_0x2caf7
  type: u1
- id: field_0x2caf8
  type: u4
- id: field_0x2cafc
  type: u4
- id: field_0x2cb00
  type: u2
- id: field_0x2cb02
  type: u2
- id: field_0x2cb04
  type: u2
- id: dungeon_music_playing_id
  type: music_id_16
- id: field_0x2cb08
  type: u1
- id: field_0x2cb09
  type: u1
- id: field_0x2cb0a
  type: u1
- id: field_0x2cb0b
  type: u1
- id: field_0x2cb0c
  type: u1
- id: field_0x2cb0d
  type: u1
- id: field_0x2cb0e
  type: u1
- id: field_0x2cb0f
  type: u1
- id: unk_camera_tracker
  type: u1
- id: field_0x2cb11
  type: u1
- id: field_0x2cb12
  type: u1
- id: field_0x2cb13
  type: u1
