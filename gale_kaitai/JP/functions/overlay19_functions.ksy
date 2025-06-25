doc: List of functions within OVERLAY19 with relative address locations as their
  values.
meta:
  id: overlay19_functions
  endian: le
instances:
  get_bar_item:
    value: 0x0
    doc: |-
      Gets the struct bar_item from BAR_AVAILABLE_ITEMS with the specified item ID.

      r0: item ID
      return: struct bar_item*
  get_recruitable_monster_all:
    value: 0x84
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: int?
  get_recruitable_monster_list:
    value: 0x134
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: int?
  get_recruitable_monster_list_restricted:
    value: 0x1dc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      return: int?
