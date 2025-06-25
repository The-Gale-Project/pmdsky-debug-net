doc: Represents an array CART_REMOVED_IMG_DATA defined within pmdsky.
meta:
  id: cart_removed_img_data_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: cart_removed_img_data_array_dim_0
types:
  cart_removed_img_data_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 0
