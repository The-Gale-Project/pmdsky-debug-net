doc: Represents a struct or union dse_driver_work defined within pmdsky-debug.
meta:
  id: dse_driver_work
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_driver_work_global_volumes_array
  - dse_driver_work_notes_array
  - dse_driver_work_field_0x670_array
  - dse_heap_allocator
  - dse_driver_work_field_0x70c_array
  - dse_driver_work_voices_array
  - thread
seq:
- id: initialized
  type: s1
- id: stopped
  type: u1
- id: unknown_0x2
  type: u2
- id: error_code
  type: s4
- id: error_data
  type: u4
- id: error_data2
  type: u4
- id: error2_code
  type: s4
- id: error2_data
  type: u4
- id: error2_data2
  type: u4
- id: error_callback
  type: pointer
- id: error2_callback
  type: pointer
- id: field_0x24
  type: u4
- id: microseconds_per_driver_tick
  type: s2
- id: field_0x2a
  type: u2
- id: total_driver_ticks
  type: s4
- id: driver_tick_rate
  type: s4
- id: current_rng_seed
  type: u4
- id: field_0x38
  type: u1
- id: field_0x39
  type: u1
- id: last_se_bank_num_sequences
  type: u1
- id: last_se_bank_tracks_per_sequence
  type: u1
- id: field_0x3c
  type: u1
- id: field_0x3d
  type: s1
- id: field_0x3e
  type: u2
- id: global_volumes
  type: dse_driver_work_global_volumes_array
- id: notes
  type: dse_driver_work_notes_array
- id: free_notes_list
  type: pointer
- id: field_0x654
  type: u4
- id: synth_list
  type: pointer
- id: field_0x65c
  type: u4
- id: loaded_wavebanks_list
  type: pointer
- id: bgm_sequences_list
  type: pointer
- id: se_sequences_list
  type: pointer
- id: loaded_effect_banks
  type: pointer
- id: field_0x670
  type: dse_driver_work_field_0x670_array
- id: heap_node_list
  type: pointer
- id: heap_end
  type: pointer
- id: heap_size
  type: s4
- id: heap_allocator
  type: dse_heap_allocator
- id: field_0x70c
  type: dse_driver_work_field_0x70c_array
- id: num_voices
  type: s2
- id: active_voices_bits
  type: u2
- id: start_voices_bits
  type: u2
- id: deactivate_voices_bits
  type: u2
- id: deallocate_voices_bits
  type: u2
- id: field_0x73c
  type: u2
- id: voices
  type: dse_driver_work_voices_array
- id: field_0x1cfc
  type: u2
- id: field_0x1cfe
  type: u2
- id: num_active_voices
  type: s4
- id: prev_nom_active_voices
  type: s4
- id: ticks_until_num_active_voices_timeout
  type: s4
- id: microseconds_per_driver_tick_2
  type: u4
- id: field_1d10
  type: u4
- id: field_1d14
  type: u4
- id: driver_thread
  type: thread
- id: driver_stack
  type: pointer
- id: field_0x1ddc
  type: u4
- id: loaded_mainbanks
  type: pointer
- id: mainbank_max_read_size
  type: s4
- id: mainbank_read_callback
  type: pointer
- id: mainbank_read_callback_param
  type: pointer
- id: loader_thread_priority
  type: u1
- id: field_0x1df1
  type: u1
- id: quit_sample_loader
  type: s1
- id: is_sample_loader_sleeping
  type: s1
- id: sample_loader_thread
  type: thread
- id: sample_loader_thread_stack
  type: pointer
- id: loading_bank
  type: pointer
- id: loading_bank_pcm_data
  type: pointer
