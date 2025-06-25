// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within ITCM with relative address locations as their values.
    /// </summary>
    public partial class ItcmFunctions : KaitaiStruct
    {
        public static ItcmFunctions FromFile(string fileName)
        {
            return new ItcmFunctions(new KaitaiStream(fileName));
        }

        public ItcmFunctions(KaitaiStream p__io, KaitaiStruct p__parent = null, ItcmFunctions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_newRender3dTexture = false;
            f_chooseAiMove = false;
            f_calculateAiTargetPos = false;
            f_lightningRodStormDrainCheck = false;
            f_render3dQuadrilateral = false;
            f_render3dRectangle = false;
            f_newRender3dRectangle = false;
            f_getKeyN2MBaseForm = false;
            f_getKeyM2NBaseForm = false;
            f_newRender3dTiling = false;
            f_render3dProcessQueue = false;
            f_hardwareInterrupt = false;
            f_render3dTextureNoSetup = false;
            f_render3dTextureInternal = false;
            f_initDmaTransferStandard = false;
            f_newRender3dElement = false;
            f_render3dTexture = false;
            f_enqueueRender3dTiling = false;
            f_render3dSetPaletteBase = false;
            f_render3dTiling = false;
            f_newRender3dQuadrilateral = false;
            f_copyAndInterleave = false;
            f_shouldMonsterRunAwayAndShowEffectOutlawCheck = false;
            f_returnFromInterrupt = false;
            f_getKeyN2M = false;
            f_render3dSetTextureParams = false;
            f_geomSetPolygonAttributes = false;
            f_copyAndInterleave0 = false;
            f_aiMovement = false;
            f_getKeyN2MSwitch = false;
            f_enqueueRender3dTexture = false;
            f_getKeyM2N = false;
            f_getKeyM2NSwitch = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_newRender3dTexture;
        private int _newRender3dTexture;

        /// <summary>
        /// Return a render_3d_element from NewRender3dElement with a type of RENDER_TEXTURE, and all other fields in the first 40 bytes zeroed.
        /// 
        /// return: render_3d_element or NULL if there is no more available space in the queue
        /// </summary>
        public int NewRender3dTexture
        {
            get
            {
                if (f_newRender3dTexture)
                    return _newRender3dTexture;
                _newRender3dTexture = (int) (3436);
                f_newRender3dTexture = true;
                return _newRender3dTexture;
            }
        }
        private bool f_chooseAiMove;
        private int _chooseAiMove;

        /// <summary>
        /// Determines if an AI-controlled monster will use a move and which one it will use
        /// 
        /// r0: Entity pointer
        /// </summary>
        public int ChooseAiMove
        {
            get
            {
                if (f_chooseAiMove)
                    return _chooseAiMove;
                _chooseAiMove = (int) (13912);
                f_chooseAiMove = true;
                return _chooseAiMove;
            }
        }
        private bool f_calculateAiTargetPos;
        private int _calculateAiTargetPos;

        /// <summary>
        /// Calculates the target position of an AI-controlled monster and stores it in the monster's ai_target_pos field
        /// 
        /// r0: Entity pointer
        /// </summary>
        public int CalculateAiTargetPos
        {
            get
            {
                if (f_calculateAiTargetPos)
                    return _calculateAiTargetPos;
                _calculateAiTargetPos = (int) (13000);
                f_calculateAiTargetPos = true;
                return _calculateAiTargetPos;
            }
        }
        private bool f_lightningRodStormDrainCheck;
        private int _lightningRodStormDrainCheck;

        /// <summary>
        /// Appears to check whether LightningRod or Storm Drain should draw in a move.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move pointer
        /// r3: true if checking for Storm Drain, false if checking for LightningRod
        /// return: whether the move should be drawn in
        /// </summary>
        public int LightningRodStormDrainCheck
        {
            get
            {
                if (f_lightningRodStormDrainCheck)
                    return _lightningRodStormDrainCheck;
                _lightningRodStormDrainCheck = (int) (15964);
                f_lightningRodStormDrainCheck = true;
                return _lightningRodStormDrainCheck;
            }
        }
        private bool f_render3dQuadrilateral;
        private int _render3dQuadrilateral;

        /// <summary>
        /// RENDER_3D_FUNCTIONS[1]. Renders a render_3d_element with type RENDER_QUADRILATERAL.
        /// 
        /// r0: render_3d_quadrilateral
        /// </summary>
        public int Render3dQuadrilateral
        {
            get
            {
                if (f_render3dQuadrilateral)
                    return _render3dQuadrilateral;
                _render3dQuadrilateral = (int) (1180);
                f_render3dQuadrilateral = true;
                return _render3dQuadrilateral;
            }
        }
        private bool f_render3dRectangle;
        private int _render3dRectangle;

        /// <summary>
        /// RENDER_3D_FUNCTIONS[0]. Renders a render_3d_element with type RENDER_RECTANGLE.
        /// 
        /// r0: render_3d_rectangle
        /// </summary>
        public int Render3dRectangle
        {
            get
            {
                if (f_render3dRectangle)
                    return _render3dRectangle;
                _render3dRectangle = (int) (548);
                f_render3dRectangle = true;
                return _render3dRectangle;
            }
        }
        private bool f_newRender3dRectangle;
        private int _newRender3dRectangle;

        /// <summary>
        /// Return a render_3d_element from NewRender3dElement with a type of RENDER_RECTANGLE, and all other fields in the first 38 bytes zeroed.
        /// 
        /// return: render_3d_element or NULL if there is no more available space in the queue
        /// </summary>
        public int NewRender3dRectangle
        {
            get
            {
                if (f_newRender3dRectangle)
                    return _newRender3dRectangle;
                _newRender3dRectangle = (int) (3340);
                f_newRender3dRectangle = true;
                return _newRender3dRectangle;
            }
        }
        private bool f_getKeyN2MBaseForm;
        private int _getKeyN2MBaseForm;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: key
        /// return: monster ID
        /// </summary>
        public int GetKeyN2MBaseForm
        {
            get
            {
                if (f_getKeyN2MBaseForm)
                    return _getKeyN2MBaseForm;
                _getKeyN2MBaseForm = (int) (5332);
                f_getKeyN2MBaseForm = true;
                return _getKeyN2MBaseForm;
            }
        }
        private bool f_getKeyM2NBaseForm;
        private int _getKeyM2NBaseForm;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: key
        /// </summary>
        public int GetKeyM2NBaseForm
        {
            get
            {
                if (f_getKeyM2NBaseForm)
                    return _getKeyM2NBaseForm;
                _getKeyM2NBaseForm = (int) (5548);
                f_getKeyM2NBaseForm = true;
                return _getKeyM2NBaseForm;
            }
        }
        private bool f_newRender3dTiling;
        private int _newRender3dTiling;

        /// <summary>
        /// Return a render_3d_element from NewRender3dElement with a type of RENDER_TILING, and all other fields zeroed.
        /// 
        /// return: render_3d_element or NULL if there is no more available space in the queue
        /// </summary>
        public int NewRender3dTiling
        {
            get
            {
                if (f_newRender3dTiling)
                    return _newRender3dTiling;
                _newRender3dTiling = (int) (3484);
                f_newRender3dTiling = true;
                return _newRender3dTiling;
            }
        }
        private bool f_render3dProcessQueue;
        private int _render3dProcessQueue;

        /// <summary>
        /// Perform rendering of the render queue of RENDER_3D structure. Does nothing if there are no elements, otherwise, sort them based on a value, and render them all consecutively.
        /// 
        /// No params.
        /// </summary>
        public int Render3dProcessQueue
        {
            get
            {
                if (f_render3dProcessQueue)
                    return _render3dProcessQueue;
                _render3dProcessQueue = (int) (3532);
                f_render3dProcessQueue = true;
                return _render3dProcessQueue;
            }
        }
        private bool f_hardwareInterrupt;
        private int _hardwareInterrupt;

        /// <summary>
        /// Called whenever a hardware interrupt takes place.
        /// 
        /// Returns immediately if the IME flag is 0 or if none of the devices that requested an interrupt has the corresponding Interrupt Enable flag set.
        /// It searches for the first device that requested an interrupt, clears its Interrupt Request flag, then jumps to the start of the corresponding interrupt function. The return address is manually set to ReturnFromInterrupt.
        /// The address of the function to jump to is read from the interrupt vector at the start of the DTCM region (0x27E0000).
        /// This function does not return.
        /// 
        /// No params.
        /// </summary>
        public int HardwareInterrupt
        {
            get
            {
                if (f_hardwareInterrupt)
                    return _hardwareInterrupt;
                _hardwareInterrupt = (int) (5608);
                f_hardwareInterrupt = true;
                return _hardwareInterrupt;
            }
        }
        private bool f_render3dTextureNoSetup;
        private int _render3dTextureNoSetup;

        /// <summary>
        /// Same as Render3dTexture except without calls to Render3dSetTextureParams and Render3dSetPaletteBase to set up geometry engine parameters.
        /// 
        /// Presumably used to render multiple texture tiles with the same parameters without the extra setup overhead? But this function doesn't actually seem to be referenced anywhere.
        /// 
        /// r0: render_3d_texture
        /// </summary>
        public int Render3dTextureNoSetup
        {
            get
            {
                if (f_render3dTextureNoSetup)
                    return _render3dTextureNoSetup;
                _render3dTextureNoSetup = (int) (3168);
                f_render3dTextureNoSetup = true;
                return _render3dTextureNoSetup;
            }
        }
        private bool f_render3dTextureInternal;
        private int _render3dTextureInternal;

        /// <summary>
        /// Implements most of the rendering logic for Render3dTexture.
        /// 
        /// r0: render_3d_texture
        /// </summary>
        public int Render3dTextureInternal
        {
            get
            {
                if (f_render3dTextureInternal)
                    return _render3dTextureInternal;
                _render3dTextureInternal = (int) (2576);
                f_render3dTextureInternal = true;
                return _render3dTextureInternal;
            }
        }
        private bool f_initDmaTransferStandard;
        private int _initDmaTransferStandard;

        /// <summary>
        /// Initiates a DMA transfer.
        /// 
        /// See https://problemkaputt.de/gbatek-gba-dma-transfers.htm and https://en.wikipedia.org/wiki/Direct_memory_access
        /// 
        /// r0: channel id
        /// r1: source address
        /// r2: destination address
        /// r3: word count
        /// </summary>
        public int InitDmaTransferStandard
        {
            get
            {
                if (f_initDmaTransferStandard)
                    return _initDmaTransferStandard;
                _initDmaTransferStandard = (int) (6760);
                f_initDmaTransferStandard = true;
                return _initDmaTransferStandard;
            }
        }
        private bool f_newRender3dElement;
        private int _newRender3dElement;

        /// <summary>
        /// Return a new render_3d_element from RENDER_3D's render queue, to draw a new element using the 3d render engine later in the frame.
        /// 
        /// return: render_3d_element or NULL if there is no more available space in the queue
        /// </summary>
        public int NewRender3dElement
        {
            get
            {
                if (f_newRender3dElement)
                    return _newRender3dElement;
                _newRender3dElement = (int) (3192);
                f_newRender3dElement = true;
                return _newRender3dElement;
            }
        }
        private bool f_render3dTexture;
        private int _render3dTexture;

        /// <summary>
        /// RENDER_3D_FUNCTIONS[3]. Renders a render_3d_element with type RENDER_TEXTURE.
        /// 
        /// This is primarily just a wrapper around Render3dTextureInternal, with a preceding alpha check and calls to Render3dSetTextureParams and Render3dSetPaletteBase.
        /// 
        /// r0: render_3d_texture
        /// </summary>
        public int Render3dTexture
        {
            get
            {
                if (f_render3dTexture)
                    return _render3dTexture;
                _render3dTexture = (int) (3112);
                f_render3dTexture = true;
                return _render3dTexture;
            }
        }
        private bool f_enqueueRender3dTiling;
        private int _enqueueRender3dTiling;

        /// <summary>
        /// Copies a render_3d_element onto the render queue of RENDER_3D, with type set to RENDER_TILING.
        /// 
        /// r0: render_3d_element
        /// </summary>
        public int EnqueueRender3dTiling
        {
            get
            {
                if (f_enqueueRender3dTiling)
                    return _enqueueRender3dTiling;
                _enqueueRender3dTiling = (int) (3292);
                f_enqueueRender3dTiling = true;
                return _enqueueRender3dTiling;
            }
        }
        private bool f_render3dSetPaletteBase;
        private int _render3dSetPaletteBase;

        /// <summary>
        /// Send the PLTT_BASE geometry engine command, that sets the texture palette base address. Also caches the base address on RENDER_3D.
        /// See http://problemkaputt.de/gbatek.htm#ds3dtextureattributes for more information on the parameters.
        /// 
        /// r0: render_3d_texture_params pointer
        /// r1: palette base address
        /// </summary>
        public int Render3dSetPaletteBase
        {
            get
            {
                if (f_render3dSetPaletteBase)
                    return _render3dSetPaletteBase;
                _render3dSetPaletteBase = (int) (460);
                f_render3dSetPaletteBase = true;
                return _render3dSetPaletteBase;
            }
        }
        private bool f_render3dTiling;
        private int _render3dTiling;

        /// <summary>
        /// RENDER_3D_FUNCTIONS[2]. Renders a render_3d_element with type RENDER_TILING.
        /// 
        /// r0: render_3d_tiling
        /// </summary>
        public int Render3dTiling
        {
            get
            {
                if (f_render3dTiling)
                    return _render3dTiling;
                _render3dTiling = (int) (1832);
                f_render3dTiling = true;
                return _render3dTiling;
            }
        }
        private bool f_newRender3dQuadrilateral;
        private int _newRender3dQuadrilateral;

        /// <summary>
        /// Return a render_3d_element from NewRender3dElement with a type of RENDER_QUADRILATERAL, and all other fields in the first 38 bytes zeroed.
        /// 
        /// return: render_3d_element or NULL if there is no more available space in the queue
        /// </summary>
        public int NewRender3dQuadrilateral
        {
            get
            {
                if (f_newRender3dQuadrilateral)
                    return _newRender3dQuadrilateral;
                _newRender3dQuadrilateral = (int) (3388);
                f_newRender3dQuadrilateral = true;
                return _newRender3dQuadrilateral;
            }
        }
        private bool f_copyAndInterleave;
        private sbyte _copyAndInterleave;

        /// <summary>
        /// Copies data from src to dst, interleaving the lower 4 bits of val with every 4 bits copied (if the copied bits are nonzero).
        /// 
        /// In total, the number of bytes copied from src will be len, while the number of bytes pasted will be 2 * len.
        /// 
        /// For example, for arbitrary inputs (assuming little-endian byte order)
        ///   src[i] = {76543210 fedcba98}
        ///       {3210} != 0
        ///       {7654} != 0
        ///       {ba98} != 0
        ///       {fedc} != 0
        ///   val &amp; 0xF = {vwxy}
        /// The output written to dst will be:
        ///   dst[2*i] = {vwxy7654 vwxy3210}
        ///   dst[2*i+1] = {vwxyfedc vwxyba98}
        /// 
        /// If any 4-bit nibble is 0, the corresponding byte written to dst is interleaved with 0 rather than the low bits of val. For example, if 'z' represents a 0 bit, given the inputs:
        ///   src[i] = {zzzz3210 fedczzzz}
        ///   val &amp; 0xF = {vwxy}
        /// The output written to dst will be:
        ///   dst[2*i] = {zzzzzzzz vwxy3210}
        ///   dst[2*i+1] = {vwxyfedc zzzzzzzz}
        /// 
        /// r0: [output] dst (2 * len bytes long)
        /// r1: src (len bytes long)
        /// r2: len (in bytes, must be even)
        /// r3: val
        /// </summary>
        public sbyte CopyAndInterleave
        {
            get
            {
                if (f_copyAndInterleave)
                    return _copyAndInterleave;
                _copyAndInterleave = (sbyte) (0);
                f_copyAndInterleave = true;
                return _copyAndInterleave;
            }
        }
        private bool f_shouldMonsterRunAwayAndShowEffectOutlawCheck;
        private int _shouldMonsterRunAwayAndShowEffectOutlawCheck;

        /// <summary>
        /// Calls ShouldMonsterRunAwayAndShowEffect. If the result is true, returns true. Otherwise, returns true only if the monster's behavior field is equal to monster_behavior::BEHAVIOR_FLEEING_OUTLAW.
        /// 
        /// r0: Entity pointer
        /// r1: Boolean value. If true, display a visual &quot;poof&quot; effect if the Run Away ability caused the monster to run away.
        /// return: True if ShouldMonsterRunAway returns true or the monster is a fleeing outlaw
        /// </summary>
        public int ShouldMonsterRunAwayAndShowEffectOutlawCheck
        {
            get
            {
                if (f_shouldMonsterRunAwayAndShowEffectOutlawCheck)
                    return _shouldMonsterRunAwayAndShowEffectOutlawCheck;
                _shouldMonsterRunAwayAndShowEffectOutlawCheck = (int) (9104);
                f_shouldMonsterRunAwayAndShowEffectOutlawCheck = true;
                return _shouldMonsterRunAwayAndShowEffectOutlawCheck;
            }
        }
        private bool f_returnFromInterrupt;
        private int _returnFromInterrupt;

        /// <summary>
        /// The execution returns to this function after a hardware interrupt function is run.
        /// 
        /// No params.
        /// </summary>
        public int ReturnFromInterrupt
        {
            get
            {
                if (f_returnFromInterrupt)
                    return _returnFromInterrupt;
                _returnFromInterrupt = (int) (5712);
                f_returnFromInterrupt = true;
                return _returnFromInterrupt;
            }
        }
        private bool f_getKeyN2M;
        private int _getKeyN2M;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: key
        /// return: monster ID
        /// </summary>
        public int GetKeyN2M
        {
            get
            {
                if (f_getKeyN2M)
                    return _getKeyN2M;
                _getKeyN2M = (int) (5224);
                f_getKeyN2M = true;
                return _getKeyN2M;
            }
        }
        private bool f_render3dSetTextureParams;
        private int _render3dSetTextureParams;

        /// <summary>
        /// A wrapper around GeomSetTexImageParam that caches the VRAM offset on RENDER_3D.
        /// 
        /// Always disables flipping and sets color values of 0 to be transparent.
        /// 
        /// r0: render_3d_texture_params pointer
        /// r1: texture VRAM offset
        /// </summary>
        public int Render3dSetTextureParams
        {
            get
            {
                if (f_render3dSetTextureParams)
                    return _render3dSetTextureParams;
                _render3dSetTextureParams = (int) (304);
                f_render3dSetTextureParams = true;
                return _render3dSetTextureParams;
            }
        }
        private bool f_geomSetPolygonAttributes;
        private int _geomSetPolygonAttributes;

        /// <summary>
        /// Send the POLYGON_ATTR geometry engine command, that defines some polygon attributes for rendering.
        /// See https://problemkaputt.de/gbatek.htm#ds3dpolygonattributes for more information
        /// 
        /// r0: polygon ID
        /// r1: alpha
        /// </summary>
        public int GeomSetPolygonAttributes
        {
            get
            {
                if (f_geomSetPolygonAttributes)
                    return _geomSetPolygonAttributes;
                _geomSetPolygonAttributes = (int) (1152);
                f_geomSetPolygonAttributes = true;
                return _geomSetPolygonAttributes;
            }
        }
        private bool f_copyAndInterleave0;
        private byte _copyAndInterleave0;

        /// <summary>
        /// Equivalent to CopyAndInterleave with an interleaved value of 0.
        /// 
        /// In total, the number of bytes copied from src will be len, while the number of bytes pasted will be 2 * len.
        /// 
        /// For example, for arbitrary input (assuming little-endian byte order):
        ///   src[i] = {76543210 fedcba98}
        /// Then the output written to dst will be (where 'z' is a 0 bit):
        ///   dst[2*i] = {zzzz7654 zzzz3210}
        ///   dst[2*i+1] = {zzzzfedc zzzzba98}
        /// 
        /// r0: [output] dst (2 * len bytes long)
        /// r1: src (len bytes long)
        /// r2: len (in bytes, must be even)
        /// </summary>
        public byte CopyAndInterleave0
        {
            get
            {
                if (f_copyAndInterleave0)
                    return _copyAndInterleave0;
                _copyAndInterleave0 = (byte) (176);
                f_copyAndInterleave0 = true;
                return _copyAndInterleave0;
            }
        }
        private bool f_aiMovement;
        private int _aiMovement;

        /// <summary>
        /// Used by the AI to determine the direction in which a monster should move
        /// 
        /// r0: Entity pointer
        /// r1: Boolean value. If the monster becomes terrified, this flag determines whether the &quot;poof&quot; visual effect will show.
        /// </summary>
        public int AiMovement
        {
            get
            {
                if (f_aiMovement)
                    return _aiMovement;
                _aiMovement = (int) (9156);
                f_aiMovement = true;
                return _aiMovement;
            }
        }
        private bool f_getKeyN2MSwitch;
        private int _getKeyN2MSwitch;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: key
        /// r1: switch
        /// </summary>
        public int GetKeyN2MSwitch
        {
            get
            {
                if (f_getKeyN2MSwitch)
                    return _getKeyN2MSwitch;
                _getKeyN2MSwitch = (int) (5172);
                f_getKeyN2MSwitch = true;
                return _getKeyN2MSwitch;
            }
        }
        private bool f_enqueueRender3dTexture;
        private int _enqueueRender3dTexture;

        /// <summary>
        /// Copies the first 40 bytes of a render_3d_element onto the render queue of RENDER_3D, with type set to RENDER_TEXTURE.
        /// 
        /// r0: render_3d_element
        /// </summary>
        public int EnqueueRender3dTexture
        {
            get
            {
                if (f_enqueueRender3dTexture)
                    return _enqueueRender3dTexture;
                _enqueueRender3dTexture = (int) (3244);
                f_enqueueRender3dTexture = true;
                return _enqueueRender3dTexture;
            }
        }
        private bool f_getKeyM2N;
        private int _getKeyM2N;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: key
        /// </summary>
        public int GetKeyM2N
        {
            get
            {
                if (f_getKeyM2N)
                    return _getKeyM2N;
                _getKeyM2N = (int) (5440);
                f_getKeyM2N = true;
                return _getKeyM2N;
            }
        }
        private bool f_getKeyM2NSwitch;
        private int _getKeyM2NSwitch;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// r1: switch
        /// </summary>
        public int GetKeyM2NSwitch
        {
            get
            {
                if (f_getKeyM2NSwitch)
                    return _getKeyM2NSwitch;
                _getKeyM2NSwitch = (int) (5388);
                f_getKeyM2NSwitch = true;
                return _getKeyM2NSwitch;
            }
        }
        private ItcmFunctions m_root;
        private KaitaiStruct m_parent;
        public ItcmFunctions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
