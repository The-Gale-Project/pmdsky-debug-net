doc: Holds the data for the enum pack_file_id.
meta:
  id: pack_file_id
  endian: le
  bit-endian: le
seq:
- id: pack_file_id_value
  type: b32
  enum: pack_file_id_enum
enums:
  pack_file_id_enum:
    0: pack_archive_monster
    1: pack_archive_m_attack
    2: pack_archive_m_ground
    3: pack_archive_effect
    4: pack_archive_dungeon
    5: pack_archive_m_level
