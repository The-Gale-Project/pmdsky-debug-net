doc: Represents an array DS_DOWNLOAD_TEAMS defined within pmdsky.
meta:
  id: ds_download_teams_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: ds_download_teams_array_dim_0
types:
  ds_download_teams_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 56
