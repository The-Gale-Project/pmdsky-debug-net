doc: Represents a struct or union mission_template defined within pmdsky-debug.
meta:
  id: mission_template
  endian: le
  bit-endian: le
  imports:
  - mission_template_item_case_16
  - mission_template_item_data
  - mission_template_dungeon_case_16
  - mission_template_client_case_16
  - mission_template_client_data
  - mission_template_target_case_16
  - mission_template_target_data
  - mission_type_8
  - mission_subtype
seq:
- id: text_string_offset
  type: u2
- id: item_case
  type: mission_template_item_case_16
- id: template_item_data_1
  type: mission_template_item_data
- id: template_item_data_2
  type: mission_template_item_data
- id: dungeon_case
  type: mission_template_dungeon_case_16
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: restricted_dungeon
  type: s2
- id: client_case
  type: mission_template_client_case_16
- id: template_client_data_1
  type: mission_template_client_data
- id: template_client_data_2
  type: mission_template_client_data
- id: target_case
  type: mission_template_target_case_16
- id: template_target_data_1
  type: mission_template_target_data
- id: template_target_data_2
  type: mission_template_target_data
- id: target_backup_case
  type: mission_template_target_case_16
- id: target_backup_data_1
  type: mission_template_target_data
- id: target_backup_data_2
  type: mission_template_target_data
- id: type
  type: mission_type_8
- id: subtype
  type: mission_subtype
