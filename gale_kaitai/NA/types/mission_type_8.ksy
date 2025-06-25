doc: Holds bitsized data for the parent enum mission_type.
meta:
  id: mission_type_8
  endian: le
  bit-endian: le
seq:
- id: mission_type_8_value
  type: b8
  enum: mission_type_8_enum
enums:
  mission_type_8_enum:
    0: mission_rescue_client
    1: mission_rescue_target
    2: mission_escort_to_target
    3: mission_explore_with_client
    4: mission_prospect_with_client
    5: mission_guide_client
    6: mission_find_item
    7: mission_deliver_item
    8: mission_search_for_target
    9: mission_take_item_from_outlaw
    10: mission_arrest_outlaw
    11: mission_challenge_request
    12: mission_treasure_memo
    13: mission_type_unk_0xd
    14: mission_type_consumable
