doc: Holds the data for the enum status_sure_shot_id.
meta:
  id: status_sure_shot_id
  endian: le
  bit-endian: le
seq:
- id: status_sure_shot_id_value
  type: b32
  enum: status_sure_shot_id_enum
enums:
  status_sure_shot_id_enum:
    0: status_sure_shot_none
    1: status_sure_shot_sure_shot
    2: status_sure_shot_whiffer
    3: status_sure_shot_set_damage
    4: status_sure_shot_focus_energy
