doc: Represents an array dse_driver_work_global_volumes defined within pmdsky.
meta:
  id: dse_driver_work_global_volumes_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_driver_work_global_volumes_array_dim_0
types:
  dse_driver_work_global_volumes_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 16
