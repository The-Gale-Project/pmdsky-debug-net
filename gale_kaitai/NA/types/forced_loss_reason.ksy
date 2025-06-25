doc: Holds the data for the enum forced_loss_reason.
meta:
  id: forced_loss_reason
  endian: le
  bit-endian: le
seq:
- id: forced_loss_reason_value
  type: b32
  enum: forced_loss_reason_enum
enums:
  forced_loss_reason_enum:
    0: forced_loss_none
    1: forced_loss_partner_fainted
    2: forced_loss_client_fainted
    3: forced_loss_escort_fainted
    4: forced_loss_client_cant_join
