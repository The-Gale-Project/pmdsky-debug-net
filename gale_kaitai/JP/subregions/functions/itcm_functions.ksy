doc: List of functions within ITCM with relative address locations as their 
  values.
meta:
  id: itcm_functions
  endian: le
instances:
  copy_and_interleave:
    value: 0x0
    doc: |-
      Copies data from src to dst, interleaving the lower 4 bits of val with every 4 bits copied (if the copied bits are nonzero).

      In total, the number of bytes copied from src will be len, while the number of bytes pasted will be 2 * len.

      For example, for arbitrary inputs (assuming little-endian byte order)
        src[i] = {76543210 fedcba98}
            {3210} != 0
            {7654} != 0
            {ba98} != 0
            {fedc} != 0
        val & 0xF = {vwxy}
      The output written to dst will be:
        dst[2*i] = {vwxy7654 vwxy3210}
        dst[2*i+1] = {vwxyfedc vwxyba98}

      If any 4-bit nibble is 0, the corresponding byte written to dst is interleaved with 0 rather than the low bits of val. For example, if 'z' represents a 0 bit, given the inputs:
        src[i] = {zzzz3210 fedczzzz}
        val & 0xF = {vwxy}
      The output written to dst will be:
        dst[2*i] = {zzzzzzzz vwxy3210}
        dst[2*i+1] = {vwxyfedc zzzzzzzz}

      r0: [output] dst (2 * len bytes long)
      r1: src (len bytes long)
      r2: len (in bytes, must be even)
      r3: val
  copy_and_interleave0:
    value: 0xb0
    doc: |-
      Equivalent to CopyAndInterleave with an interleaved value of 0.

      In total, the number of bytes copied from src will be len, while the number of bytes pasted will be 2 * len.

      For example, for arbitrary input (assuming little-endian byte order):
        src[i] = {76543210 fedcba98}
      Then the output written to dst will be (where 'z' is a 0 bit):
        dst[2*i] = {zzzz7654 zzzz3210}
        dst[2*i+1] = {zzzzfedc zzzzba98}

      r0: [output] dst (2 * len bytes long)
      r1: src (len bytes long)
      r2: len (in bytes, must be even)
  render3d_set_texture_params:
    value: 0x130
    doc: |-
      A wrapper around GeomSetTexImageParam that caches the VRAM offset on RENDER_3D.

      Always disables flipping and sets color values of 0 to be transparent.

      r0: render_3d_texture_params pointer
      r1: texture VRAM offset
  render3d_set_palette_base:
    value: 0x1cc
    doc: |-
      Send the PLTT_BASE geometry engine command, that sets the texture palette base address. Also caches the base address on RENDER_3D.
      See http://problemkaputt.de/gbatek.htm#ds3dtextureattributes for more information on the parameters.

      r0: render_3d_texture_params pointer
      r1: palette base address
  render3d_rectangle:
    value: 0x224
    doc: |-
      RENDER_3D_FUNCTIONS[0]. Renders a render_3d_element with type RENDER_RECTANGLE.

      r0: render_3d_rectangle
  geom_set_polygon_attributes:
    value: 0x480
    doc: |-
      Send the POLYGON_ATTR geometry engine command, that defines some polygon attributes for rendering.
      See https://problemkaputt.de/gbatek.htm#ds3dpolygonattributes for more information

      r0: polygon ID
      r1: alpha
  render3d_quadrilateral:
    value: 0x49c
    doc: |-
      RENDER_3D_FUNCTIONS[1]. Renders a render_3d_element with type RENDER_QUADRILATERAL.

      r0: render_3d_quadrilateral
  render3d_tiling:
    value: 0x728
    doc: |-
      RENDER_3D_FUNCTIONS[2]. Renders a render_3d_element with type RENDER_TILING.

      r0: render_3d_tiling
  render3d_texture_internal:
    value: 0xa10
    doc: |-
      Implements most of the rendering logic for Render3dTexture.

      r0: render_3d_texture
  render3d_texture:
    value: 0xc28
    doc: |-
      RENDER_3D_FUNCTIONS[3]. Renders a render_3d_element with type RENDER_TEXTURE.

      This is primarily just a wrapper around Render3dTextureInternal, with a preceding alpha check and calls to Render3dSetTextureParams and Render3dSetPaletteBase.

      r0: render_3d_texture
  render3d_texture_no_setup:
    value: 0xc60
    doc: |-
      Same as Render3dTexture except without calls to Render3dSetTextureParams and Render3dSetPaletteBase to set up geometry engine parameters.

      Presumably used to render multiple texture tiles with the same parameters without the extra setup overhead? But this function doesn't actually seem to be referenced anywhere.

      r0: render_3d_texture
  new_render3d_element:
    value: 0xc78
    doc: |-
      Return a new render_3d_element from RENDER_3D's render queue, to draw a new element using the 3d render engine later in the frame.

      return: render_3d_element or NULL if there is no more available space in the queue
  enqueue_render3d_texture:
    value: 0xcac
    doc: |-
      Copies the first 40 bytes of a render_3d_element onto the render queue of RENDER_3D, with type set to RENDER_TEXTURE.

      r0: render_3d_element
  enqueue_render3d_tiling:
    value: 0xcdc
    doc: |-
      Copies a render_3d_element onto the render queue of RENDER_3D, with type set to RENDER_TILING.

      r0: render_3d_element
  new_render3d_rectangle:
    value: 0xd0c
    doc: |-
      Return a render_3d_element from NewRender3dElement with a type of RENDER_RECTANGLE, and all other fields in the first 38 bytes zeroed.

      return: render_3d_element or NULL if there is no more available space in the queue
  new_render3d_quadrilateral:
    value: 0xd3c
    doc: |-
      Return a render_3d_element from NewRender3dElement with a type of RENDER_QUADRILATERAL, and all other fields in the first 38 bytes zeroed.

      return: render_3d_element or NULL if there is no more available space in the queue
  new_render3d_texture:
    value: 0xd6c
    doc: |-
      Return a render_3d_element from NewRender3dElement with a type of RENDER_TEXTURE, and all other fields in the first 40 bytes zeroed.

      return: render_3d_element or NULL if there is no more available space in the queue
  new_render3d_tiling:
    value: 0xd9c
    doc: |-
      Return a render_3d_element from NewRender3dElement with a type of RENDER_TILING, and all other fields zeroed.

      return: render_3d_element or NULL if there is no more available space in the queue
  render3d_process_queue:
    value: 0xdcc
    doc: |-
      Perform rendering of the render queue of RENDER_3D structure. Does nothing if there are no elements, otherwise, sort them based on a value, and render them all consecutively.

      No params.
  get_key_n2_m_switch:
    value: 0x149c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: key
      r1: switch
  get_key_n2_m:
    value: 0x14d0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: key
      return: monster ID
  get_key_n2_m_base_form:
    value: 0x153c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: key
      return: monster ID
  get_key_m2_n_switch:
    value: 0x1574
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      r1: switch
  get_key_m2_n:
    value: 0x15a8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: key
  get_key_m2_n_base_form:
    value: 0x1614
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      r0: monster ID
      return: key
  hardware_interrupt:
    value: 0x1650
    doc: |-
      Called whenever a hardware interrupt takes place.

      Returns immediately if the IME flag is 0 or if none of the devices that requested an interrupt has the corresponding Interrupt Enable flag set.
      It searches for the first device that requested an interrupt, clears its Interrupt Request flag, then jumps to the start of the corresponding interrupt function. The return address is manually set to ReturnFromInterrupt.
      The address of the function to jump to is read from the interrupt vector at the start of the DTCM region (0x27E0000).
      This function does not return.

      No params.
  return_from_interrupt:
    value: 0x16b8
    doc: |-
      The execution returns to this function after a hardware interrupt function is run.

      No params.
  init_dma_transfer__standard:
    value: 0x1ad0
    doc: |-
      Initiates a DMA transfer.

      See https://problemkaputt.de/gbatek-gba-dma-transfers.htm and https://en.wikipedia.org/wiki/Direct_memory_access

      r0: channel id
      r1: source address
      r2: destination address
      r3: word count
  should_monster_run_away_and_show_effect_outlaw_check:
    value: 0x23f8
    doc: |-
      Calls ShouldMonsterRunAwayAndShowEffect. If the result is true, returns true. Otherwise, returns true only if the monster's behavior field is equal to monster_behavior::BEHAVIOR_FLEEING_OUTLAW.

      r0: Entity pointer
      r1: Boolean value. If true, display a visual "poof" effect if the Run Away ability caused the monster to run away.
      return: True if ShouldMonsterRunAway returns true or the monster is a fleeing outlaw
  ai_movement:
    value: 0x242c
    doc: |-
      Used by the AI to determine the direction in which a monster should move

      r0: Entity pointer
      r1: Boolean value. If the monster becomes terrified, this flag determines whether the "poof" visual effect will show.
  calculate_ai_target_pos:
    value: 0x3330
    doc: |-
      Calculates the target position of an AI-controlled monster and stores it in the monster's ai_target_pos field

      r0: Entity pointer
  choose_ai_move:
    value: 0x36c0
    doc: |-
      Determines if an AI-controlled monster will use a move and which one it will use

      r0: Entity pointer
  lightning_rod_storm_drain_check:
    value: 0x3ec4
    doc: |-
      Appears to check whether LightningRod or Storm Drain should draw in a move.

      r0: attacker pointer
      r1: defender pointer
      r2: move pointer
      r3: true if checking for Storm Drain, false if checking for LightningRod
      return: whether the move should be drawn in
