doc: Represents a struct or union script_var_value_table defined within 
  pmdsky-debug.
meta:
  id: script_var_value_table
  endian: le
  bit-endian: le
  imports:
  - script_var_value_table_position_x_array
  - script_var_value_table_position_y_array
  - script_var_value_table_position_height_array
  - script_var_value_table_ground_enter_backup_array
  - script_var_value_table_ground_getout_backup_array
  - script_var_value_table_ground_map_backup_array
  - script_var_value_table_ground_place_backup_array
  - script_var_value_table_dungeon_enter_backup_array
  - script_var_value_table_dungeon_enter_mode_backup_array
  - script_var_value_table_dungeon_enter_index_backup_array
  - script_var_value_table_item_backup_array
  - script_var_value_table_item_backup_kurekure_array
  - script_var_value_table_item_backup_take_array
  - script_var_value_table_item_backup_get_array
  - script_var_value_table_dungeon_enter_frequency_backup_array
  - special_episode_type
  - script_var_value_table_position_direction_array
  - script_var_value_table_scenario_select_array
  - script_var_value_table_scenario_main_array
  - script_var_value_table_scenario_side_array
  - script_var_value_table_scenario_sub1_array
  - script_var_value_table_scenario_sub2_array
  - script_var_value_table_scenario_sub3_array
  - script_var_value_table_scenario_sub4_array
  - script_var_value_table_scenario_sub5_array
  - script_var_value_table_scenario_sub6_array
  - script_var_value_table_scenario_sub7_array
  - script_var_value_table_scenario_sub8_array
  - script_var_value_table_scenario_select_backup_array
  - script_var_value_table_ground_enter_link_backup_array
  - script_var_value_table_dungeon_result_backup_array
  - script_var_value_table_ground_start_mode_backup_array
  - script_var_value_table_player_kind_backup_array
  - script_var_value_table_attendant1_kind_backup_array
  - script_var_value_table_attendant2_kind_backup_array
  - script_var_value_table_hero_first_name_array
  - script_var_value_table_partner_first_name_array
  - script_var_value_table_scenario_main_bit_flag_array
  - script_var_value_table_scenario_talk_bit_flag_array
  - script_var_value_table_scenario_main_bit_flag_backup_array
  - script_var_value_table_special_episode_open_array
  - script_var_value_table_special_episode_open_old_array
  - script_var_value_table_special_episode_conquest_array
  - script_var_value_table_performance_progress_list_array
  - script_var_value_table_dungeon_open_list_array
  - script_var_value_table_dungeon_enter_list_array
  - script_var_value_table_dungeon_arrive_list_array
  - script_var_value_table_dungeon_conquest_list_array
  - script_var_value_table_dungeon_present_list_array
  - script_var_value_table_dungeon_request_list_array
  - script_var_value_table_world_map_mark_list_normal_array
  - script_var_value_table_world_map_mark_list_special_array
  - script_var_value_table_station_item_static_array
  - script_var_value_table_station_item_temp_array
  - script_var_value_table_deliver_item_static_array
  - script_var_value_table_deliver_item_temp_array
  - script_var_value_table_unused_array
seq:
- id: version
  type: s4
- id: condition
  type: s4
- id: position_x
  type: script_var_value_table_position_x_array
- id: position_y
  type: script_var_value_table_position_y_array
- id: position_height
  type: script_var_value_table_position_height_array
- id: recycle_count
  type: u4
- id: ground_enter
  type: s2
- id: ground_getout
  type: s2
- id: ground_map
  type: s2
- id: ground_place
  type: s2
- id: ground_enter_backup
  type: script_var_value_table_ground_enter_backup_array
- id: ground_getout_backup
  type: script_var_value_table_ground_getout_backup_array
- id: ground_map_backup
  type: script_var_value_table_ground_map_backup_array
- id: ground_place_backup
  type: script_var_value_table_ground_place_backup_array
- id: dungeon_select
  type: s2
- id: dungeon_enter
  type: s2
- id: dungeon_enter_mode
  type: s2
- id: dungeon_enter_index
  type: s2
- id: dungeon_enter_backup
  type: script_var_value_table_dungeon_enter_backup_array
- id: dungeon_enter_mode_backup
  type: script_var_value_table_dungeon_enter_mode_backup_array
- id: dungeon_enter_index_backup
  type: script_var_value_table_dungeon_enter_index_backup_array
- id: hero_first_kind
  type: s2
- id: partner_first_kind
  type: s2
- id: random_request_npc03_kind
  type: s2
- id: event_local
  type: s2
- id: dungeon_event_local
  type: s2
- id: item_backup
  type: script_var_value_table_item_backup_array
- id: item_backup_kurekure
  type: script_var_value_table_item_backup_kurekure_array
- id: item_backup_take
  type: script_var_value_table_item_backup_take_array
- id: item_backup_get
  type: script_var_value_table_item_backup_get_array
- id: request_thanks_result_kind
  type: s2
- id: request_thanks_result_variation
  type: s2
- id: dungeon_enter_frequency
  type: u2
- id: dungeon_enter_frequency_backup
  type: script_var_value_table_dungeon_enter_frequency_backup_array
- id: scenario_balance_flag
  type: s1
- id: scenario_balance_debug
  type: s1
- id: hero_talk_kind
  type: s1
- id: partner_talk_kind
  type: s1
- id: config_color_kind
  type: s1
- id: rom_variation
  type: s1
- id: special_episode_type
  type: special_episode_type
- id: position_direction
  type: script_var_value_table_position_direction_array
- id: scenario_select
  type: script_var_value_table_scenario_select_array
- id: scenario_main
  type: script_var_value_table_scenario_main_array
- id: scenario_side
  type: script_var_value_table_scenario_side_array
- id: scenario_sub1
  type: script_var_value_table_scenario_sub1_array
- id: scenario_sub2
  type: script_var_value_table_scenario_sub2_array
- id: scenario_sub3
  type: script_var_value_table_scenario_sub3_array
- id: scenario_sub4
  type: script_var_value_table_scenario_sub4_array
- id: scenario_sub5
  type: script_var_value_table_scenario_sub5_array
- id: scenario_sub6
  type: script_var_value_table_scenario_sub6_array
- id: scenario_sub7
  type: script_var_value_table_scenario_sub7_array
- id: scenario_sub8
  type: script_var_value_table_scenario_sub8_array
- id: crystal_color_01
  type: u1
- id: crystal_color_02
  type: u1
- id: crystal_color_03
  type: u1
- id: compulsory_save_point
  type: u1
- id: compulsory_save_point_side
  type: u1
- id: scenario_select_backup
  type: script_var_value_table_scenario_select_backup_array
- id: ground_enter_link
  type: u1
- id: ground_enter_link_backup
  type: script_var_value_table_ground_enter_link_backup_array
- id: dungeon_result
  type: u1
- id: ground_start_mode
  type: u1
- id: dungeon_result_backup
  type: script_var_value_table_dungeon_result_backup_array
- id: ground_start_mode_backup
  type: script_var_value_table_ground_start_mode_backup_array
- id: request_clear_count
  type: u1
- id: player_kind
  type: u1
- id: attendant1_kind
  type: u1
- id: attendant2_kind
  type: u1
- id: player_kind_backup
  type: script_var_value_table_player_kind_backup_array
- id: attendant1_kind_backup
  type: script_var_value_table_attendant1_kind_backup_array
- id: attendant2_kind_backup
  type: script_var_value_table_attendant2_kind_backup_array
- id: world_map_level
  type: u1
- id: lottery_result
  type: u1
- id: sub30_spot_level
  type: u1
- id: team_rank_event_level
  type: u1
- id: play_old_game
  type: u1
- id: hero_first_name
  type: script_var_value_table_hero_first_name_array
- id: partner_first_name
  type: script_var_value_table_partner_first_name_array
- id: side02_talk
  type: b3
- id: side06_room
  type: b3
- id: side08_boss2nd
  type: b1
- id: side01_boss2nd
  type: b1
- id: scenario_main_bit_flag
  type: script_var_value_table_scenario_main_bit_flag_array
- id: scenario_talk_bit_flag
  type: script_var_value_table_scenario_talk_bit_flag_array
- id: scenario_main_bit_flag_backup
  type: script_var_value_table_scenario_main_bit_flag_backup_array
- id: special_episode_open
  type: script_var_value_table_special_episode_open_array
- id: special_episode_open_old
  type: script_var_value_table_special_episode_open_old_array
- id: special_episode_conquest
  type: script_var_value_table_special_episode_conquest_array
- id: performance_progress_list
  type: script_var_value_table_performance_progress_list_array
- id: dungeon_open_list
  type: script_var_value_table_dungeon_open_list_array
- id: dungeon_enter_list
  type: script_var_value_table_dungeon_enter_list_array
- id: dungeon_arrive_list
  type: script_var_value_table_dungeon_arrive_list_array
- id: dungeon_conquest_list
  type: script_var_value_table_dungeon_conquest_list_array
- id: dungeon_present_list
  type: script_var_value_table_dungeon_present_list_array
- id: dungeon_request_list
  type: script_var_value_table_dungeon_request_list_array
- id: world_map_mark_list_normal
  type: script_var_value_table_world_map_mark_list_normal_array
- id: world_map_mark_list_special
  type: script_var_value_table_world_map_mark_list_special_array
- id: station_item_static
  type: script_var_value_table_station_item_static_array
- id: station_item_temp
  type: script_var_value_table_station_item_temp_array
- id: deliver_item_static
  type: script_var_value_table_deliver_item_static_array
- id: deliver_item_temp
  type: script_var_value_table_deliver_item_temp_array
- id: bit_fuwarante_local
  type: b5
- id: sub30_treasure_discover
  type: b1
- id: sub30_spot_discover
  type: b1
- id: sub30_projectp
  type: b1
- id: unused
  type: script_var_value_table_unused_array
