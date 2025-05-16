doc: List of functions within LIBS with relative address locations as their values.
meta:
  id: libs_functions
  endian: le
instances:
  dse_driver__load_default_settings:
    value: 0xe8
  dse_driver__is_settings_valid:
    value: 0x180
    doc: |-
      r0: DSE driver settings
      return: Flags specifying what settings are invalid.
  dse_driver__configure_heap:
    value: 0x264
  dse_driver__init:
    value: 0x308
  dse__set_error:
    value: 0x77c
  dse__set_error2:
    value: 0x7b0
  dse_util__byte_swap32:
    value: 0x7ec
  sound_util__get_random_number:
    value: 0x81c
    doc: 'return: random number in the range [0, 32767]'
  dse_mem__init:
    value: 0x844
  dse_mem__quit:
    value: 0x8b4
  dse_mem__allocate_user:
    value: 0x8d0
  dse_mem__allocate:
    value: 0x8e4
  dse_mem__allocate_thread_stack:
    value: 0x9f4
  dse_mem__free:
    value: 0xb3c
  dse_mem__clear:
    value: 0xbe4
  dse_file__check_header:
    value: 0xc44
  dse_swd__sys_init:
    value: 0xcc4
  dse_swd__sys_quit:
    value: 0xd50
  dse_swd__sample_loader_main:
    value: 0xd90
  dse_swd__main_bank_dummy_callback:
    value: 0xdf0
  dse_swd__load_main_bank:
    value: 0xdf8
  dse_swd__load_bank:
    value: 0x1030
  dse_swd__is_bank_loading:
    value: 0x1234
  dse_swd__load_waves:
    value: 0x1250
  dse_swd__load_waves_internal:
    value: 0x1300
  dse_swd__unload:
    value: 0x140c
  read_wavi_entry:
    value: 0x1480
    doc: |-
      Reads an entry from the pointer table of a wavi container and returns a pointer to the data of said entry, which contains information about a particular sample.

      r0: Wavi data struct
      r1: Entry index
      return: Pointer to the entry's data
  dse_swd__get_instrument:
    value: 0x14b8
  dse_swd__get_next_split_in_range:
    value: 0x14f0
  dse_swd__get_main_bank_by_id:
    value: 0x1578
  dse_swd__get_bank_by_id:
    value: 0x15c8
  dse_swd__init_main_bank_file_reader:
    value: 0x1618
  dse_swd__open_main_bank_file_reader:
    value: 0x1628
  dse_swd__close_main_bank_file_reader:
    value: 0x1654
  dse_swd__read_main_bank:
    value: 0x1664
  dse_bgm__default_signal_callback:
    value: 0x1728
  dse_bgm__load:
    value: 0x1730
  dse_bgm__unload:
    value: 0x1834
  dse_bgm__set_signal_callback:
    value: 0x186c
  dse_bgm__is_playing:
    value: 0x18cc
  resume_bgm:
    value: 0x18e4
    doc: |-
      Uncertain.

      Note: unverified, ported from Irdkwia's notes
  dse_bgm__stop:
    value: 0x19c4
  dse_bgm__stop_all:
    value: 0x1a04
  dse_bgm__set_fades:
    value: 0x1a64
  dse_sequence__start:
    value: 0x1aa4
  dse_sequence__pause_list:
    value: 0x1b34
  dse_sequence__set_fades:
    value: 0x1c98
  dse_sequence__get_parameter:
    value: 0x1f8c
  dse_sequence__get_smallest_num_loops:
    value: 0x2140
  dse_sequence__reset:
    value: 0x2194
  dse_sequence__stop:
    value: 0x22ec
  find_smdl_song_chunk:
    value: 0x2410
    doc: |-
      Finds the first song chunk within an SMDL file that has the specified value on its 0x10 field.

      See https://projectpokemon.org/home/docs/mystery-dungeon-nds/dse-smdl-format-r13/.

      r0: Pointer to the start of the SMDL file
      r1: Value to search for
      return: Pointer to the first chunk that has the specified value + 0x10, or null if no chunk was found.
  dse_sequence__load_song:
    value: 0x247c
  dse_sequence__get_by_id:
    value: 0x257c
  dse_sequence__allocate_new:
    value: 0x25c8
  dse_sequence__unload:
    value: 0x2700
  dse_sequence__init_tracks:
    value: 0x2784
  dse_bgm__sys_setup_note_list:
    value: 0x27d4
  dse_se__sys_reset:
    value: 0x2848
  dse_se__load:
    value: 0x2940
  dse_se__unload:
    value: 0x2af4
  dse_se__get_used_bank_i_ds:
    value: 0x2b84
  dse_se__has_playing_instances:
    value: 0x2c58
  dse_se__play:
    value: 0x2d24
  dse_se__get_effect_song:
    value: 0x2ed8
  dse_se__check_too_many_instances:
    value: 0x2f20
  dse_se__check_too_many_instances_in_group:
    value: 0x3028
  dse_se__get_best_seq_allocation:
    value: 0x31ec
  dse_se__get_by_id:
    value: 0x3268
  dse_se__stop:
    value: 0x32b4
  dse_se__stop_all:
    value: 0x3408
  dse_se__stop_seq:
    value: 0x3474
  flush_channels:
    value: 0x459c
    doc: "Note: unverified, ported from Irdkwia's notes"
  dse_driver__start_main_thread:
    value: 0x4d34
  dse_driver__start_tick_timer:
    value: 0x4e04
  dse_driver__notify_tick:
    value: 0x4efc
  dse_driver__main:
    value: 0x4f3c
  dse_sequence__tick_notes:
    value: 0x5088
  parse_dse_event:
    value: 0x514c
    doc: |-
      Parses and executes a DSE event for the specified track, if necessary.

      The function checks the time left before the next event (track_data::event_delay), and parses it if said time is 0.

      See also https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/

      r0: Pointer to some struct that seems to hold the state of the audio engine
      r1: Pointer to track data
  update_sequencer_tracks:
    value: 0x5310
    doc: From 
      https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/
  dse_sequence__tick_fades:
    value: 0x56ac
  dse_track_event__invalid:
    value: 0x5844
  dse_track_event__wait_same:
    value: 0x5850
  dse_track_event__wait_delta:
    value: 0x585c
  dse_track_event__wait8:
    value: 0x5874
  dse_track_event__wait16:
    value: 0x5884
  dse_track_event__wait24:
    value: 0x58a0
  dse_track_event__wait_until_fadeout:
    value: 0x58c4
  dse_track_event__end_track:
    value: 0x58f0
  dse_track_event__main_loop_begin:
    value: 0x593c
  dse_track_event__sub_loop_begin:
    value: 0x5944
  dse_track_event__sub_loop_end:
    value: 0x5984
  dse_track_event__sub_loop_break_on_last_iteration:
    value: 0x59c0
  dse_track_event__set_octave:
    value: 0x59e8
  dse_track_event__octave_delta:
    value: 0x59f4
  dse_track_event__set_bpm:
    value: 0x5a08
  dse_track_event__set_bpm2:
    value: 0x5a48
  dse_track_event__set_bank:
    value: 0x5a88
  dse_track_event__set_bank_msb:
    value: 0x5ab4
  dse_track_event__set_bank_lsb:
    value: 0x5ae4
  dse_track_event__dummy1_byte:
    value: 0x5b14
  dse_track_event__set_instrument:
    value: 0x5b1c
  dse_track_event__song_volume_fade:
    value: 0x5b64
  dse_track_event__restore_envelope_defaults:
    value: 0x5bf0
  dse_track_event__set_envelope_attack_begin:
    value: 0x5c08
  dse_track_event__set_envelope_attack_time:
    value: 0x5c28
  dse_track_event__set_envelope_hold_time:
    value: 0x5c48
  dse_track_event__set_envelope_decay_time_and_sustain_level:
    value: 0x5c68
  dse_track_event__set_envelope_sustain_time:
    value: 0x5c98
  dse_track_event__set_envelope_release_time:
    value: 0x5cb8
  dse_track_event__set_note_duration_multiplier:
    value: 0x5cd8
  dse_track_event__force_lfo_envelope_level:
    value: 0x5ce4
  dse_track_event__set_hold_notes:
    value: 0x5d00
  dse_track_event__set_flag_bit1_unknown:
    value: 0x5d38
  dse_track_event__set_optional_volume:
    value: 0x5d48
  dse_track_event__dummy2_bytes:
    value: 0x5d54
  dse_track_event__set_tuning:
    value: 0x5d5c
  dse_track_event__tuning_delta_coarse:
    value: 0x5ddc
  dse_track_event__tuning_delta_fine:
    value: 0x5e64
  dse_track_event__tuning_delta_full:
    value: 0x5eec
  dse_track_event__tuning_fade:
    value: 0x5f7c
  dse_track_event__set_note_random_region:
    value: 0x606c
  dse_track_event__set_tuning_jitter_amplitude:
    value: 0x6094
  dse_track_event__set_key_bend:
    value: 0x60ac
  dse_track_event__set_unknown2:
    value: 0x60d8
  dse_track_event__set_key_bend_range:
    value: 0x60f0
  dse_track_event__setup_key_bend_lfo:
    value: 0x60fc
  dse_track_event__setup_key_bend_lfo_envelope:
    value: 0x6154
  dse_track_event__use_key_bend_lfo:
    value: 0x617c
  dse_track_event__set_volume:
    value: 0x61a4
  dse_track_event__volume_delta:
    value: 0x6238
  dse_track_event__volume_fade:
    value: 0x62e8
  dse_track_event__set_expression:
    value: 0x6344
  dse_track_event__setup_volume_lfo:
    value: 0x63d0
  dse_track_event__setup_volume_lfo_envelope:
    value: 0x642c
  dse_track_event__use_volume_lfo:
    value: 0x6454
  dse_track_event__set_pan:
    value: 0x647c
  dse_track_event__pan_delta:
    value: 0x64fc
  dse_track_event__pan_fade:
    value: 0x6590
  dse_track_event__setup_pan_lfo:
    value: 0x65ec
  dse_track_event__setup_pan_lfo_envelope:
    value: 0x6648
  dse_track_event__use_pan_lfo:
    value: 0x6670
  dse_track_event__setup_lfo:
    value: 0x6698
  dse_track_event__setup_lfo_envelope:
    value: 0x66f0
  dse_track_event__set_lfo_parameter:
    value: 0x6724
  dse_track_event__use_lfo:
    value: 0x6860
  dse_track_event__signal:
    value: 0x6894
  dse_track_event__dummy2_bytes2:
    value: 0x68c4
  dse_synth__reset:
    value: 0x7130
  dse_synth__allocate_new:
    value: 0x71a8
  dse_synth__unload:
    value: 0x7278
  dse_synth__clear_held_notes:
    value: 0x72e4
  dse_synth__reset_and_set_bank_and_sequence:
    value: 0x7380
  dse_synth__stop_channels:
    value: 0x73a8
  dse_synth__reset_all_voice_timers_and_volumes:
    value: 0x73d4
  dse_synth__restore_held_notes:
    value: 0x742c
  dse_synth__set_global_volume_index:
    value: 0x7494
  dse_synth__set_bend:
    value: 0x757c
  dse_synth__set_volume:
    value: 0x7610
  dse_synth__set_pan:
    value: 0x76e0
  dse_synth__set_bank_and_sequence:
    value: 0x7774
  dse_channel__init:
    value: 0x7804
  dse_channel__deallocate_voices:
    value: 0x79b8
  dse_channel__reset_timer_and_volume_for_voices:
    value: 0x7a3c
  dse_channel__set_bank:
    value: 0x7ab8
  dse_channel__set_instrument:
    value: 0x7af0
  dse_channel__set_lfo_const_envelope_level:
    value: 0x7b84
  dse_channel__set_key_bend:
    value: 0x7bb8
  dse_channel__allocate_note:
    value: 0x7c00
  dse_channel__release_note_internal:
    value: 0x7c90
  dse_channel__change_note:
    value: 0x7d38
  dse_channel__release_note:
    value: 0x7dc8
  dse_voice__play_note:
    value: 0x7e04
  dse_voice__release_note:
    value: 0x8078
  dse_voice__update_parameters:
    value: 0x80bc
  dse_voice__reset_all:
    value: 0x8260
  dse_voice__reset_hw:
    value: 0x8304
  update_channels:
    value: 0x83b4
    doc: |-
      From https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/ and Irdkwia's notes.

      No params.
  dse_voice__cleanup:
    value: 0x84a4
  dse_voice__allocate:
    value: 0x8540
  dse_voice__start:
    value: 0x86a8
  dse_voice__release_held:
    value: 0x8704
  dse_voice__release:
    value: 0x8784
  dse_voice__deallocate:
    value: 0x87c8
  dse_voice__flag_for_activation:
    value: 0x88cc
  dse_voice__flag_for_deactivation:
    value: 0x891c
  dse_voice__count_num_active_in_channel:
    value: 0x8954
  dse_voice__update_hardware:
    value: 0x8980
  sound_envelope__reset:
    value: 0x8b98
    doc: 'r0: Sound envelope pointer'
  sound_envelope_parameters__reset:
    value: 0x8bac
    doc: 'r0: Sound envelope parameters pointer'
  sound_envelope_parameters__check_validity:
    value: 0x8bc8
    doc: 'r0: Sound envelope parameters pointer'
  sound_envelope__set_parameters:
    value: 0x8c1c
    doc: |-
      r0: Sound envelope pointer
      r1: Sound envelope parameters pointer
  sound_envelope__set_slide:
    value: 0x8c80
    doc: |-
      r0: Sound envelope pointer
      r1: Target volume
      r2: Music duration lookup table index
  update_track_volume_envelopes:
    value: 0x8d34
    doc: |-
      From https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/

      r0: Sound envelope pointer
  sound_envelope__release:
    value: 0x8e00
    doc: 'r0: Sound envelope pointer'
  sound_envelope__stop:
    value: 0x8e2c
    doc: 'r0: Sound envelope pointer'
  sound_envelope__force_volume:
    value: 0x8e44
    doc: |-
      r0: Sound envelope pointer
      r1: Volume
  sound_envelope__stop2:
    value: 0x8e64
    doc: 'r0: Sound envelope pointer'
  sound_envelope__tick:
    value: 0x8e7c
    doc: |-
      r0: Sound envelope pointer
      return: Current volume
  sound_lfo_bank__reset:
    value: 0x8fc4
    doc: 'r0: LFO bank pointer'
  sound_lfo_bank__set:
    value: 0x8fdc
    doc: |-
      r0: LFO bank pointer
      r1: LFO settings pointer
      r2: Envelope level
  sound_lfo_bank__set_const_envelopes:
    value: 0x91d4
    doc: |-
      r0: LFO bank pointer
      r1: Level
  sound_lfo_bank__tick:
    value: 0x9220
    doc: |-
      r0: LFO bank pointer
      return: New voice update flags
  sound_lfo_wave__invalid_func:
    value: 0x92d4
    doc: |-
      r0: LFO pointer
      return: 0
  sound_lfo_wave__half_square_func:
    value: 0x92e8
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__full_square_func:
    value: 0x9324
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__half_triangle_func:
    value: 0x936c
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__full_triangle_func:
    value: 0x93c0
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__saw_func:
    value: 0x9424
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__reverse_saw_func:
    value: 0x9460
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__half_noise_func:
    value: 0x949c
    doc: |-
      r0: LFO pointer
      return: LFO current output
  sound_lfo_wave__full_noise_func:
    value: 0x94e0
    doc: |-
      r0: LFO pointer
      return: LFO current output
  crypto__rc4_init:
    value: 0x9648
  mtx__look_at:
    value: 0x9750
  mtx__ortho_w:
    value: 0x9858
  fx__div:
    value: 0x9a60
  fx__get_div_result_fx64c:
    value: 0x9a70
  fx__get_div_result:
    value: 0x9a94
  fx__inv_async:
    value: 0x9acc
  fx__div_async:
    value: 0x9afc
  fx__div_s32:
    value: 0x9b24
  fx__mod_s32:
    value: 0x9b60
  vec__dot_product:
    value: 0x9b9c
  vec__cross_product:
    value: 0x9bd8
  vec__normalize:
    value: 0x9c5c
  vec__distance:
    value: 0x9d74
  fx__atan2_idx:
    value: 0x9df0
  gx__init:
    value: 0x9f9c
  gx__h_blank_intr:
    value: 0xa0e8
  gx__v_blank_intr:
    value: 0xa110
  gx__disp_off:
    value: 0xa144
  gx__disp_on:
    value: 0xa180
  gx__set_graphics_mode:
    value: 0xa1c8
  gxs__set_graphics_mode:
    value: 0xa230
  g_xx__set_master_brightness:
    value: 0xa24c
  gx__init_gx_state:
    value: 0xa274
  enable_vram_banks_in_set_dont_save:
    value: 0xa2d4
    doc: |-
      Enable the VRAM bank marked in the input set, but don’t mark them as enabled in ENABLED_VRAM_BANKS

      r0: vram_banks_set
  gx__set_bank_for_bg:
    value: 0xa38c
  gx__set_bank_for_obj:
    value: 0xa61c
  gx__set_bank_for_bg_ext_pltt:
    value: 0xa76c
  gx__set_bank_for_obj_ext_pltt:
    value: 0xa86c
  gx__set_bank_for_tex:
    value: 0xa918
  gx__set_bank_for_tex_pltt:
    value: 0xaaf0
  gx__set_bank_for_clear_image:
    value: 0xabd8
  gx__set_bank_for_arm7:
    value: 0xad0c
  gx__set_bank_for_lcdc:
    value: 0xadb8
  gx__set_bank_for_sub_bg:
    value: 0xadd8
  gx__set_bank_for_sub_obj:
    value: 0xae80
  gx__set_bank_for_sub_bg_ext_pltt:
    value: 0xaef0
  gx__set_bank_for_sub_obj_ext_pltt:
    value: 0xaf70
  enable_vram_banks_in_set:
    value: 0xaff0
    doc: |-
      Enable the VRAM banks in the input set. Will reset the pointed set to 0, and update ENABLED_VRAM_BANKS

      r0: vram_banks_set *
  gx__reset_bank_for_bg_ext_pltt:
    value: 0xb024
  gx__reset_bank_for_obj_ext_pltt:
    value: 0xb048
  gx__reset_bank_for_tex:
    value: 0xb06c
  gx__reset_bank_for_tex_pltt:
    value: 0xb080
  gx__reset_bank_for_sub_bg_ext_pltt:
    value: 0xb094
  gx__reset_bank_for_sub_obj_ext_pltt:
    value: 0xb0bc
  disable_bank_for_x:
    value: 0xb0e4
  gx__disable_bank_for_bg:
    value: 0xb1c4
  gx__disable_bank_for_obj:
    value: 0xb1d8
  gx__disable_bank_for_bg_ext_pltt:
    value: 0xb1ec
  gx__disable_bank_for_obj_ext_pltt:
    value: 0xb210
  gx__disable_bank_for_tex:
    value: 0xb234
  gx__disable_bank_for_tex_pltt:
    value: 0xb248
  gx__disable_bank_for_clear_image:
    value: 0xb25c
  gx__disable_bank_for_arm7:
    value: 0xb270
  gx__disable_bank_for_lcdc:
    value: 0xb284
  gx__disable_bank_for_sub_bg:
    value: 0xb298
  gx__disable_bank_for_sub_obj:
    value: 0xb2ac
  gx__disable_bank_for_sub_bg_ext_pltt:
    value: 0xb2c0
  gx__disable_bank_for_sub_obj_ext_pltt:
    value: 0xb2e8
  g2__get_bg0_scr_ptr:
    value: 0xb310
  g2_s__get_bg0_scr_ptr:
    value: 0xb344
  g2__get_bg1_scr_ptr:
    value: 0xb364
  g2_s__get_bg1_scr_ptr:
    value: 0xb398
  g2__get_bg2_scr_ptr:
    value: 0xb3b8
  g2__get_bg3_scr_ptr:
    value: 0xb43c
  g2__get_bg0_char_ptr:
    value: 0xb4c0
  g2_s__get_bg0_char_ptr:
    value: 0xb4f4
  g2__get_bg1_char_ptr:
    value: 0xb514
  g2_s__get_bg1_char_ptr:
    value: 0xb548
  g2__get_bg2_char_ptr:
    value: 0xb568
  g2__get_bg3_char_ptr:
    value: 0xb5b8
  g2x__set_blend_alpha:
    value: 0xb610
  g2x__set_blend_brightness:
    value: 0xb62c
  g2x__change_blend_brightness:
    value: 0xb654
  g3__load_mtx44:
    value: 0xb698
  g3__load_mtx43:
    value: 0xb6b4
    doc: |-
      Send the MTX_LOAD_4x3 geometry engine command, through a GXFIFO command. See https://problemkaputt.de/gbatek.htm#ds3dgeometrycommands and https://problemkaputt.de/gbatek.htm#ds3dmatrixloadmultiply for more information.

      This pops the top of the current matrix stack (https://problemkaputt.de/gbatek.htm#ds3dmatrixstack) and sets it as the engine's "current" matrix. It's commonly preceded by a MTX_PUSH command to populate the matrix stack with a matrix.

      r0: matrix_4x3 pointer
  g3__mult_mtx43:
    value: 0xb6d0
    doc: |-
      Send the MTX_MULT_4x3 geometry engine command, through a GXFIFO command. See https://problemkaputt.de/gbatek.htm#ds3dgeometrycommands and https://problemkaputt.de/gbatek.htm#ds3dmatrixloadmultiply for more information.

      This pops the top of the current matrix stack (https://problemkaputt.de/gbatek.htm#ds3dmatrixstack) and left-multiplies the engine's "current" matrix by the new matrix. It's commonly preceded by a MTX_PUSH command to populate the matrix stack with a matrix.

      r0: matrix_4x3 pointer
  g3_x__init:
    value: 0xb6ec
  g3_x__reset:
    value: 0xb7f8
  g3_x__clear_fifo:
    value: 0xb864
  g3_x__init_mtx_stack:
    value: 0xb88c
  g3_x__reset_mtx_stack:
    value: 0xb924
  g3_x__set_clear_color:
    value: 0xb9b4
  g3_x__init_table:
    value: 0xb9dc
  g3_x__get_mtx_stack_level_pv:
    value: 0xba7c
  g3_x__get_mtx_stack_level_pj:
    value: 0xbaac
  g_xi__nop_clear_fifo128:
    value: 0xbadc
  g3i__ortho_w:
    value: 0xbb70
  g3i__look_at:
    value: 0xbbd4
  gx__load_bg_pltt:
    value: 0xbc20
  gxs__load_bg_pltt:
    value: 0xbc74
  gx__load_obj_pltt:
    value: 0xbccc
  gxs__load_obj_pltt:
    value: 0xbd24
  gx__load_oam:
    value: 0xbd7c
  gxs__load_oam:
    value: 0xbdd0
  gx__load_obj:
    value: 0xbe28
  gxs__load_obj:
    value: 0xbe80
  gx__load_bg0_scr:
    value: 0xbed8
  gx__load_bg1_scr:
    value: 0xbf38
  gxs__load_bg1_scr:
    value: 0xbf98
  gx__load_bg2_scr:
    value: 0xbff8
  gx__load_bg3_scr:
    value: 0xc058
  gx__load_bg0_char:
    value: 0xc0b8
  gxs__load_bg0_char:
    value: 0xc118
  gx__load_bg1_char:
    value: 0xc178
  gxs__load_bg1_char:
    value: 0xc1d8
  gx__load_bg2_char:
    value: 0xc238
  gx__load_bg3_char:
    value: 0xc298
  gx__begin_load_bg_ext_pltt:
    value: 0xc2f8
  gx__end_load_bg_ext_pltt:
    value: 0xc398
  gx__begin_load_obj_ext_pltt:
    value: 0xc3e0
  gx__end_load_obj_ext_pltt:
    value: 0xc428
  gxs__begin_load_bg_ext_pltt:
    value: 0xc46c
  gxs__end_load_bg_ext_pltt:
    value: 0xc484
  gxs__begin_load_obj_ext_pltt:
    value: 0xc4c4
  gxs__end_load_obj_ext_pltt:
    value: 0xc4dc
  gx__begin_load_tex:
    value: 0xc51c
  gx__load_tex:
    value: 0xc578
  gx__end_load_tex:
    value: 0xc6b8
  gx__begin_load_tex_pltt:
    value: 0xc704
  gx__load_tex_pltt:
    value: 0xc738
  gx__end_load_tex_pltt:
    value: 0xc7a4
  geom_gx_fifo_send_mtx4x3:
    value: 0xc7e8
    doc: |-
      Send a 4x3 matrix argument for a GXFIFO geometry engine command.

      This function is used by GeomMtxLoad4x3 and GeomMtxMult4x3 to pass the matrix argument for a GXFIFO command after already having written the command code. See https://problemkaputt.de/gbatek.htm#ds3dgeometrycommands for more information.

      Note that the GXFIFO address is 0x4000400, but is (maybe) mirrored up to 0x400043F. This function is optimized to take advantage of this by writing 3 matrix entries at a time using ldmia and stmia instructions.

      r0: matrix_4x3 pointer
      r1: GXFIFO pointer
  gx__send_fifo64_b:
    value: 0xc80c
  os__get_lock_id:
    value: 0xcf54
  increment_thread_count:
    value: 0xd078
    doc: |-
      Increments thread_info::thread_count by 1 and returns the new value.

      return: New thread count
  insert_thread_into_list:
    value: 0xd1c0
    doc: |-
      Inserts a new thread into the linked thread list (see thread_info::thread_list_head).

      The thread is inserted in sorted order.

      r0: Thread to insert
  start_thread:
    value: 0xd488
    doc: |-
      Called to start a new thread.

      Initializes the specified thread struct and some values on its stack area.

      r0: Struct of the thread to init
      r1: Pointer to the function to run on this thread
      r2: Pointer to a thread struct. Sometimes equal to r0. Sometimes null.
      r3: Pointer to the stack area for this thread. Not all the space is usable. See thread::usable_stack_pointer for more info.
      stack[0]: Stack size
      stack[1]: (?) Used to sort threads on a list
  thread_exit:
    value: 0xd584
    doc: |-
      Function called by threads on exit.

      Base functions that contain an infinite loop that is not supposed to return and that have their stacks in main RAM have this function as their return address.

      No params.
  set_thread_field0x_b4:
    value: 0xdba4
    doc: |-
      Sets the given thread's field_0xB4 to the specified value.

      r0: Thread
      r1: Value to set
  init_thread:
    value: 0xdbac
    doc: |-
      Initializes some fields of the given thread struct.

      Most notably, thread::flags, thread::function_address_plus_4, thread::stack_pointer_minus_4 and thread::usable_stack_pointer. Also initializes a few more fields with a value of 0.
      thread::flags is initialized to 0x1F, unless the address of the function is odd (???), in which case it's initialized to 0x3F.

      r0: Pointer to the thread to initialize
      r1: Pointer to the function the thread will run
      r2: Pointer to the start of the thread's stack area - 4
  get_timer0_control:
    value: 0xee0c
    doc: |-
      Returns the value of the control register for hardware timer 0

      return: Value of the control register
  clear_irq_flag:
    value: 0xf6f8
    doc: |-
      Enables processor interrupts by clearing the i flag in the program status register (cpsr).

      return: Old value of cpsr & 0x80 (0x80 if interrupts were disabled, 0x0 if they were already enabled)
  enable_irq_flag:
    value: 0xf70c
    doc: |-
      Disables processor interrupts by setting the i flag in the program status register (cpsr).

      return: Old value of cpsr & 0x80 (0x80 if interrupts were already disabled, 0x0 if they were enabled)
  set_irq_flag:
    value: 0xf720
    doc: |-
      Sets the value of the processor's interrupt flag according to the specified parameter.

      r0: Value to set the flag to (0x80 to set it, which disables interrupts; 0x0 to unset it, which enables interrupts)
      return: Old value of cpsr & 0x80 (0x80 if interrupts were disabled, 0x0 if they were enabled)
  enable_irq_fiq_flags:
    value: 0xf738
    doc: |-
      Disables processor all interrupts (both standard and fast) by setting the i and f flags in the program status register (cpsr).

      return: Old value of cpsr & 0xC0 (contains the previous values of the i and f flags)
  set_irq_fiq_flags:
    value: 0xf74c
    doc: |-
      Sets the value of the processor's interrupt flags (i and f) according to the specified parameter.

      r0: Value to set the flags to (0xC0 to set both flags, 0x80 to set the i flag and clear the f flag, 0x40 to set the f flag and clear the i flag and 0x0 to clear both flags)
      return: Old value of cpsr & 0xC0 (contains the previous values of the i and f flags)
  get_irq_flag:
    value: 0xf764
    doc: |-
      Gets the current value of the processor's interrupt request (i) flag

      return: cpsr & 0x80 (0x80 if interrupts are disabled, 0x0 if they are enabled)
  get_processor_mode:
    value: 0xf770
    doc: |-
      Gets the processor's current operating mode.

      See https://problemkaputt.de/gbatek.htm#armcpuflagsconditionfieldcond

      return: cpsr & 0x1f (the cpsr mode bits M4-M0)
  get_ds_firmware_user_settings:
    value: 0xf930
    doc: |-
      Gets the user settings of the DS firmware.

      See https://problemkaputt.de/gbatek.htm#dsfirmwareusersettings

      r0: user_settings pointer
  count_leading_zeros:
    value: 0xf9b4
    doc: |-
      Counts the number of leading zeros in a 32-bit integer.

      r0: x
      return: clz(x)
  wait_forever2:
    value: 0xfb48
    doc: |-
      Calls EnableIrqFlag and WaitForInterrupt in an infinite loop.

      This is called on fatal errors to hang the program indefinitely.

      No params.
  wait_for_interrupt:
    value: 0xfb58
    doc: |-
      Presumably blocks until the program receives an interrupt.

      This just calls (in Ghidra terminology) coproc_moveto_Wait_for_interrupt(0). See https://en.wikipedia.org/wiki/ARM_architecture_family#Coprocessors.

      No params.
  array_fill16:
    value: 0x101e0
    doc: |-
      Fills an array of 16-bit values with a given value.

      r0: value
      r1: ptr
      r2: len (# bytes)
  array_copy16:
    value: 0x10208
    doc: |-
      Copies an array of 16-bit values to another array of 16-bit values.

      This is essentially an alternate implementation of Memcpy16, but with a different parameter order.

      r0: src
      r1: dest
      r2: len (# bytes)
  array_fill32:
    value: 0x1023c
    doc: |-
      Fills an array of 32-bit values with a given value.

      This is essentially an alternate implementation of Memset32, but with a different parameter order.

      r0: value
      r1: ptr
      r2: len (# bytes)
  array_copy32:
    value: 0x10258
    doc: |-
      Copies an array of 32-bit values to another array of 32-bit values.

      This is essentially an alternate implementation of Memcpy32, but with a different parameter order.

      r0: src
      r1: dest
      r2: len (# bytes)
  array_fill32_fast:
    value: 0x10280
    doc: |-
      Does the same thing as ArrayFill32, except the implementation uses an unrolled loop that sets 8 values per iteration, taking advantage of the stmia instruction.

      r0: value
      r1: ptr
      r2: len (# bytes)
  array_copy32_fast:
    value: 0x102dc
    doc: |-
      Does the same thing as ArrayCopy32, except the implementation uses an unrolled loop that copies 8 values per iteration, taking advantage of the ldmia/stmia instructions.

      r0: src
      r1: dest
      r2: len (# bytes)
  memset_fast:
    value: 0x10334
    doc: |-
      A semi-optimized implementation of the memset(3) C library function.

      This function was probably manually implemented by the developers, or was included as part of a library other than libc (the Nitro SDK probably?). See memset for what's probably the real libc function.

      This function is optimized to set values in 4-byte chunks, properly dealing with pointer alignment. However, unlike the libc memset, there are no loop unrolling optimizations.

      r0: ptr
      r1: value
      r2: len (# bytes)
  memcpy_fast:
    value: 0x103f0
    doc: |-
      Copies bytes from one buffer to another, similar to memcpy(3). Note that the source/destination buffer parameters swapped relative to the standard memcpy.

      This function was probably manually implemented by the developers, or was included as part of a library other than libc (the Nitro SDK probably?). See memcpy for what's probably the real libc function.

      This function is optimized to copy values in 4-byte chunks, properly dealing with pointer alignment.

      r0: src
      r1: dest
      r2: n (# bytes)
  atomic_exchange:
    value: 0x10570
    doc: |-
      Atomically replaces a pointer's pointee with a desired value, and returns the previous value.

      This function is just a single swp instruction.

      r0: desired value
      r1: ptr
      return: previous value
  file_init:
    value: 0x1330c
    doc: |-
      Initializes a file_stream structure for file I/O.

      This function must always be called before opening a file.

      r0: file_stream pointer
  get_overlay_info:
    value: 0x13bc4
    doc: |-
      Returns the y9.bin entry for the specified overlay

      r0: [output] Overlay info struct
      r1: ?
      r2: Overlay ID
      return: True if the entry could be loaded successfully?
  load_overlay_internal:
    value: 0x13cc0
    doc: |-
      Called by LoadOverlay to load an overlay into RAM given its info struct

      r0: Overlay info struct
      Return: True if the overlay was loaded successfully?
  init_overlay:
    value: 0x13de4
    doc: |-
      Performs overlay initialization right after loading an overlay with LoadOverlayInternal.

      This function is responsible for jumping to all the pointers located in the overlay's static init array, among other things.

      r0: Overlay info struct
  abs:
    value: 0x1a484
    doc: |-
      Takes the absolute value of an integer.

      r0: x
      return: abs(x)
  mbtowc:
    value: 0x1b0e4
    doc: |-
      The mbtowc(3) C library function.

      r0: pwc
      r1: s
      r2: n
      return: number of consumed bytes, or -1 on failure
  try_assign_byte:
    value: 0x1b11c
    doc: |-
      Assign a byte to the target of a pointer if the pointer is non-null.

      r0: pointer
      r1: value
      return: true on success, false on failure
  try_assign_byte_wrapper:
    value: 0x1b130
    doc: |-
      Wrapper around TryAssignByte.

      Accesses the TryAssignByte function with a weird chain of pointer dereferences.

      r0: pointer
      r1: value
      return: true on success, false on failure
  wcstombs:
    value: 0x1b14c
    doc: |-
      The wcstombs(3) C library function.

      r0: dest
      r1: src
      r2: n
      return: characters converted
  memcpy:
    value: 0x1b1c4
    doc: |-
      The memcpy(3) C library function.

      r0: dest
      r1: src
      r2: n
      return: dest
  memmove:
    value: 0x1b1e4
    doc: |-
      The memmove(3) C library function.

      The implementation is nearly the same as memcpy, but it copies bytes from back to front if src < dst.

      r0: dest
      r1: src
      r2: n
      return: dest
  memset:
    value: 0x1b230
    doc: |-
      The memset(3) C library function.

      This is just a wrapper around memset_internal that returns the pointer at the end.

      r0: s
      r1: c (int, but must be a single-byte value)
      r2: n
      return: s
  memchr:
    value: 0x1b244
    doc: |-
      The memchr(3) C library function.

      r0: s
      r1: c
      r2: n
      return: pointer to first occurrence of c in s, or a null pointer if no match
  memcmp:
    value: 0x1b270
    doc: |-
      The memcmp(3) C library function.

      r0: s1
      r1: s2
      r2: n
      return: comparison value
  memset_internal:
    value: 0x1b2b0
    doc: |-
      The actual memory-setting implementation for the memset(3) C library function.

      This function is optimized to set bytes in 4-byte chunks for n >= 32, correctly handling any unaligned bytes at the front/back. In this case, it also further optimizes by unrolling a for loop to set 8 4-byte values at once (effectively a 32-byte chunk).

      r0: s
      r1: c (int, but must be a single-byte value)
      r2: n
  vsprintf_internal_slice:
    value: 0x1cb9c
    doc: |-
      This is what implements the bulk of __vsprintf_internal.

      The __vsprintf_internal in the modern-day version of glibc relies on __vfprintf_internal; this function has a slightly different interface, but it serves a similar role.

      r0: function pointer to append to the string being built (__vsprintf_internal uses TryAppendToSlice)
      r1: string buffer slice
      r2: format
      r3: ap
      return: number of characters printed, excluding the null-terminator
  try_append_to_slice:
    value: 0x1d3c0
    doc: |-
      Best-effort append the given data to a slice. If the slice's capacity is reached, any remaining data will be truncated.

      r0: slice pointer
      r1: buffer of data to append
      r2: number of bytes in the data buffer
      return: true
  vsprintf_internal:
    value: 0x1d404
    doc: |-
      This is what implements vsprintf. It's akin to __vsprintf_internal in the modern-day version of glibc (in fact, it's probably an older version of this).

      r0: str
      r1: maxlen (vsprintf passes UINT32_MAX for this)
      r2: format
      r3: ap
      return: number of characters printed, excluding the null-terminator
  vsprintf:
    value: 0x1d46c
    doc: |-
      The vsprintf(3) C library function.

      r0: str
      r1: format
      r2: ap
      return: number of characters printed, excluding the null-terminator
  snprintf:
    value: 0x1d484
    doc: |-
      The snprintf(3) C library function.

      This calls __vsprintf_internal directly, so it's presumably the real snprintf.

      r0: str
      r1: n
      r2: format
      ...: variadic
      return: number of characters printed, excluding the null-terminator
  sprintf:
    value: 0x1d4ac
    doc: |-
      The sprintf(3) C library function.

      This calls __vsprintf_internal directly, so it's presumably the real sprintf.

      r0: str
      r1: format
      ...: variadic
      return: number of characters printed, excluding the null-terminator
  strlen:
    value: 0x1d5a0
    doc: |-
      The strlen(3) C library function.

      r0: s
      return: length of s
  strcpy:
    value: 0x1d5bc
    doc: |-
      The strcpy(3) C library function.

      This function is optimized to copy characters in aligned 4-byte chunks if possible, correctly handling any unaligned bytes at the front/back.

      r0: dest
      r1: src
      return: dest
  strncpy:
    value: 0x1d684
    doc: |-
      The strncpy(3) C library function.

      r0: dest
      r1: src
      r2: n
      return: dest
  strcat:
    value: 0x1d6d4
    doc: |-
      The strcat(3) C library function.

      r0: dest
      r1: src
      return: dest
  strncat:
    value: 0x1d704
    doc: |-
      The strncat(3) C library function.

      r0: dest
      r1: src
      r2: n
      return: dest
  strcmp:
    value: 0x1d754
    doc: |-
      The strcmp(3) C library function.

      Similarly to strcpy, this function is optimized to compare characters in aligned 4-byte chunks if possible.

      r0: s1
      r1: s2
      return: comparison value
  strncmp:
    value: 0x1d868
    doc: |-
      The strncmp(3) C library function.

      r0: s1
      r1: s2
      r2: n
      return: comparison value
  strchr:
    value: 0x1d89c
    doc: |-
      The strchr(3) C library function.

      r0: string
      r1: c
      return: pointer to the located byte c, or null pointer if no match
  strcspn:
    value: 0x1d8d8
    doc: |-
      The strcspn(3) C library function.

      r0: string
      r1: stopset
      return: offset of the first character in string within stopset
  strstr:
    value: 0x1d998
    doc: |-
      The strstr(3) C library function.

      r0: haystack
      r1: needle
      return: pointer into haystack where needle starts, or null pointer if no match
  wcslen:
    value: 0x1f310
    doc: |-
      The wcslen(3) C library function.

      r0: ws
      return: length of ws
  dadd:
    value: 0x21df0
    doc: |-
      Implements the addition operator for IEEE 754 double-precision floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __adddf3 in libgcc.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a + b
  d2f:
    value: 0x22108
    doc: |-
      Implements the double to float cast operator for IEEE 754 floating-point numbers.

      Analogous to __truncdfsf2 in libgcc.

      r0: double (low bits)
      r1: double (high bits)
      return: (float)double
  ll_ufrom_d:
    value: 0x2220c
    doc: |-
      Implements the double to unsigned long long cast operation for IEEE 754 floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __fixunsdfti in libgcc.

      r0: double (low bits)
      r1: double (high bits)
      return: (unsigned long long)double
  dflt:
    value: 0x22298
    doc: |-
      Implements the int to double cast operation for IEEE 754 floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __floatsidf in libgcc.

      r0: int
      return: (double)int
  dfltu:
    value: 0x222d8
    doc: |-
      Implements the unsigned int to double cast operation for IEEE 754 floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __floatunsidf in libgcc.

      r0: uint
      return: (double)uint
  dmul:
    value: 0x22314
    doc: |-
      Implements the multiplication operator for IEEE 754 double-precision floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __muldf3 in libgcc.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a * b
  dsqrt:
    value: 0x22678
    doc: |-
      Analogous to the sqrt(3) C library function.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      r0: x (low bits)
      r1: x (high bits)
      return: sqrt(x)
  dsub:
    value: 0x2282c
    doc: |-
      Implements the subtraction operator for IEEE 754 double-precision floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __subdf3 in libgcc.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a - b
  fadd:
    value: 0x22be0
    doc: |-
      Implements the addition operator for IEEE 754 floating-point numbers.

      Analogous to __addsf3 in libgcc.

      r0: a
      r1: b
      return: a + b
  dgeq:
    value: 0x22e04
    doc: |-
      Implements the >= operator for IEEE 754 double-precision floating-point numbers.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a >= b
  dleq:
    value: 0x22e9c
    doc: |-
      Implements the <= operator for IEEE 754 double-precision floating-point numbers.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a <= b
  dls:
    value: 0x22f40
    doc: |-
      Implements the < operator for IEEE 754 double-precision floating-point numbers.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a < b
  deq:
    value: 0x22fdc
    doc: |-
      Implements the == operator for IEEE 754 double-precision floating-point numbers.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a == b
  dneq:
    value: 0x23068
    doc: |-
      Implements the != operator for IEEE 754 double-precision floating-point numbers.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a != b
  fls:
    value: 0x230f4
    doc: |-
      Implements the < operator for IEEE 754 floating-point numbers.

      r0: a
      r1: b
      return: a < b
  fdiv:
    value: 0x2315c
    doc: |-
      Implements the division operator for IEEE 754 floating-point numbers.

      Analogous to __divsf3 in libgcc.

      r0: dividend
      r1: divisor
      return: dividend / divisor
  f2d:
    value: 0x23514
    doc: |-
      Implements the float to double cast operation for IEEE 754 floating-point numbers.

      Analogous to __extendsfdf2 in libgcc.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      r0: float
      return: (double)float
  ffix:
    value: 0x23598
    doc: |-
      Implements the float to int cast operation for IEEE 754 floating-point numbers. The output saturates if the input is out of the representable range for the int type.

      Analogous to __fixsfsi in libgcc.

      r0: float
      return: (int)float
  fflt:
    value: 0x235cc
    doc: |-
      Implements the int to float cast operation for IEEE 754 floating-point numbers.

      Analogous to __floatsisf in libgcc.

      r0: int
      return: (float)int
  ffltu:
    value: 0x23614
    doc: |-
      Implements the unsigned int to float cast operation for IEEE 754 floating-point numbers.

      Analogous to __floatunsisf in libgcc.

      r0: uint
      return: (float)uint
  fmul:
    value: 0x2365c
    doc: |-
      Implements the multiplication operator for IEEE 754 floating-point numbers.

      Analogous to __mulsf3 in libgcc.

      r0: a
      r1: b
      return: a * b
  sqrtf:
    value: 0x2383c
    doc: |-
      The sqrtf(3) C library function.

      r0: x
      return: sqrt(x)
  fsub:
    value: 0x2392c
    doc: |-
      Implements the subtraction operator for IEEE 754 floating-point numbers.

      Analogous to __subsf3 in libgcc.

      r0: a
      r1: b
      return: a - b
  ll_mod:
    value: 0x23ba4
    doc: |-
      Implements the modulus operator for signed long longs.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __modti3 in libgcc.

      r0: dividend (low bits)
      r1: dividend (high bits)
      r2: divisor (low bits)
      r3: divisor (high bits)
      return: dividend % divisor
  ll_sdiv:
    value: 0x23bb4
    doc: |-
      Implements the division operator for signed long longs.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __divti3 in libgcc.

      r0: dividend (low bits)
      r1: dividend (high bits)
      r2: divisor (low bits)
      r3: divisor (high bits)
      return: dividend / divisor
  ll_udiv:
    value: 0x23d64
    doc: |-
      Implements the division operator for unsigned long longs.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __udivti3 in libgcc.

      r0: dividend (low bits)
      r1: dividend (high bits)
      r2: divisor (low bits)
      r3: divisor (high bits)
      return: dividend / divisor
  ull_mod:
    value: 0x23d70
    doc: |-
      Implements the modulus operator for unsigned long longs.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __umodti3 in libgcc.

      r0: dividend (low bits)
      r1: dividend (high bits)
      r2: divisor (low bits)
      r3: divisor (high bits)
      return: dividend % divisor
  ll_mul:
    value: 0x23dac
    doc: |-
      Implements the multiplication operator for signed long longs.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __multi3 in libgcc.

      r0: a (low bits)
      r1: a (high bits)
      r2: b (low bits)
      r3: b (high bits)
      return: a * b
  s32_div_f:
    value: 0x23dcc
    doc: |-
      Implements the division operator for signed ints.

      Analogous to __divsi3 in libgcc.

      The return value is a 64-bit integer, with the quotient (dividend / divisor) in the lower 32 bits and the remainder (dividend % divisor) in the upper 32 bits. In accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return), this means that the quotient is returned in r0 and the remainder is returned in r1.

      r0: dividend
      r1: divisor
      return: (quotient) | (remainder << 32)
  u32_div_f:
    value: 0x23fd8
    doc: |-
      Implements the division operator for unsigned ints.

      Analogous to __udivsi3 in libgcc.

      The return value is a 64-bit integer, with the quotient (dividend / divisor) in the lower 32 bits and the remainder (dividend % divisor) in the upper 32 bits. In accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return), this means that the quotient is returned in r0 and the remainder is returned in r1.
      Note: This function falls through to _u32_div_not_0_f.

      r0: dividend
      r1: divisor
      return: (quotient) | (remainder << 32)
  u32_div_not_0_f:
    value: 0x23fe0
    doc: |-
      Subsidiary function to _u32_div_f. Skips the initial check for divisor == 0.

      The return value is a 64-bit integer, with the quotient (dividend / divisor) in the lower 32 bits and the remainder (dividend % divisor) in the upper 32 bits. In accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return), this means that the quotient is returned in r0 and the remainder is returned in r1.
      This function appears to only be called internally.

      r0: dividend
      r1: divisor
      return: (quotient) | (remainder << 32)
  drdiv:
    value: 0x241bc
    doc: |-
      The same as _ddiv, but with the parameters reversed.

      This simply swaps the first and second parameters, then falls through to _ddiv.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      r0: divisor (low bits)
      r1: divisor (high bits)
      r2: dividend (low bits)
      r3: dividend (high bits)
      return: dividend / divisor
  ddiv:
    value: 0x241d4
    doc: |-
      Implements the division operator for IEEE 754 double-precision floating-point numbers.

      The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).

      Analogous to __divdf3 in libgcc.

      r0: dividend (low bits)
      r1: dividend (high bits)
      r2: divisor (low bits)
      r3: divisor (high bits)
      return: dividend / divisor
  fp_init:
    value: 0x24718
    doc: |-
      Meant to do set up for floating point calculations? Does nothing.

      No params.
