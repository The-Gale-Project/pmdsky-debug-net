doc: Holds the data for the enum special_process_id.
meta:
  id: special_process_id
  endian: le
  bit-endian: le
seq:
- id: special_process_id_value
  type: b32
  enum: special_process_id_enum
enums:
  special_process_id_enum:
    0: special_proc_none
    1: special_proc_return_dungeon
    2: special_proc_init_main_team_after_quiz
    3: special_proc_init_special_episode_partners
    4: special_proc_init_extra_special_episode_partners
    5: special_proc_next_day
    6: special_proc_0x6
    7: special_proc_dungeon_had_request_done
    8: special_proc_0x8
    9: special_proc_0x9
    10: special_proc_get_sos_mail_count
    11: special_proc_get_sos_mission_retries_left
    12: special_proc_init_random_npc_jobs
    13: special_proc_get_random_npc_job_type
    14: special_proc_get_random_npc_job_subtype
    15: special_proc_get_random_npc_job_still_available
    16: special_proc_accept_random_npc_job
    17: special_proc_0x11
    18: special_proc_0x12
    19: special_proc_key_wait_press
    20: special_proc_key_wait_init
    21: special_proc_key_wait_check
    22: special_proc_0x16
    23: special_proc_randomize_demo_actors
    24: special_proc_0x18
    25: special_proc_jump_to_title_screen
    26: special_proc_0x1a
    27: special_proc_return_to_title_screen
    28: special_proc_is_recruitable_in_team
    29: special_proc_get_recruitable_current_level
    30: special_proc_recruitable_can_add
    31: special_proc_add_recruitable_to_team
    32: special_proc_count_item_type_in_bag
    33: special_proc_count_table_item_type_in_bag
    34: special_proc_count_item_type_in_storage
    35: special_proc_count_table_item_type_in_storage
    36: special_proc_add_item_to_bag
    37: special_proc_add_table_item_to_bag
    38: special_proc_add_item_to_storage
    39: special_proc_add_table_item_to_storage
    40: special_proc_remove_items_type_in_bag
    41: special_proc_remove_table_items_type_in_bag
    42: special_proc_remove_item_type_in_storage
    43: special_proc_remove_table_item_type_in_storage
    44: special_proc_prepare_menu_accept_team_member
    45: special_proc_get_hero_kind
    46: special_proc_get_partner_kind
    47: special_proc_is_team_setup_hero_and_partner_only
    48: special_proc_is_team_setup_partner_and_hero_only
    49: special_proc_is_team_setup_contains_partner_and_hero
    50: special_proc_is_team_setup_solo
    51: special_proc_set_team_setup_hero_and_partner_only
    52: special_proc_set_team_setup_hero_only
    53: special_proc_0x35
    54: special_proc_status_update
    55: special_proc_0x37
    56: special_proc_is_bag_full
    57: special_proc_0x39
    58: special_proc_increment_dungeons_cleared
    59: special_proc_increment_big_treasure_wins
    60: special_proc_send_sky_gift_to_guildmaster
    61: special_proc_set_actor_talk_main
    62: special_proc_set_actor_talk_sub
