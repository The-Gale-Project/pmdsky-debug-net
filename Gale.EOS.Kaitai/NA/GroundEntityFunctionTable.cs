// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union ground_entity_function_table defined within pmdsky-debug.
    /// </summary>
    public partial class GroundEntityFunctionTable : KaitaiStruct
    {
        public static GroundEntityFunctionTable FromFile(string fileName)
        {
            return new GroundEntityFunctionTable(new KaitaiStream(fileName));
        }

        public GroundEntityFunctionTable(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundEntityFunctionTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _routineKind = new ScriptRoutineKind16(m_io);
            _padding = m_io.ReadU2le();
            _getId = new Pointer(m_io);
            _getCollisionBox = new Pointer(m_io);
            _getCollisionBoxCenter = new Pointer(m_io);
            _getHeight = new Pointer(m_io);
            _getDirection = new Pointer(m_io);
            _getAttributeBitfield = new Pointer(m_io);
            _setPositionInitial = new Pointer(m_io);
            _setMovementRange = new Pointer(m_io);
            _setPosition = new Pointer(m_io);
            _setHeight = new Pointer(m_io);
            _setDirection = new Pointer(m_io);
            _setAnimation = new Pointer(m_io);
            _setEffect = new Pointer(m_io);
            _setAttributeBitfieldWrapper = new Pointer(m_io);
            _resetAttributeBitfieldWrapper = new Pointer(m_io);
            _setBlink = new Pointer(m_io);
            _setPositionOffset = new Pointer(m_io);
            _getAnimationStatus = new Pointer(m_io);
            _getEffectStatus = new Pointer(m_io);
        }
        private ScriptRoutineKind16 _routineKind;
        private ushort _padding;
        private Pointer _getId;
        private Pointer _getCollisionBox;
        private Pointer _getCollisionBoxCenter;
        private Pointer _getHeight;
        private Pointer _getDirection;
        private Pointer _getAttributeBitfield;
        private Pointer _setPositionInitial;
        private Pointer _setMovementRange;
        private Pointer _setPosition;
        private Pointer _setHeight;
        private Pointer _setDirection;
        private Pointer _setAnimation;
        private Pointer _setEffect;
        private Pointer _setAttributeBitfieldWrapper;
        private Pointer _resetAttributeBitfieldWrapper;
        private Pointer _setBlink;
        private Pointer _setPositionOffset;
        private Pointer _getAnimationStatus;
        private Pointer _getEffectStatus;
        private GroundEntityFunctionTable m_root;
        private KaitaiStruct m_parent;
        public ScriptRoutineKind16 RoutineKind { get { return _routineKind; } }
        public ushort Padding { get { return _padding; } }
        public Pointer GetId { get { return _getId; } }
        public Pointer GetCollisionBox { get { return _getCollisionBox; } }
        public Pointer GetCollisionBoxCenter { get { return _getCollisionBoxCenter; } }
        public Pointer GetHeight { get { return _getHeight; } }
        public Pointer GetDirection { get { return _getDirection; } }
        public Pointer GetAttributeBitfield { get { return _getAttributeBitfield; } }
        public Pointer SetPositionInitial { get { return _setPositionInitial; } }
        public Pointer SetMovementRange { get { return _setMovementRange; } }
        public Pointer SetPosition { get { return _setPosition; } }
        public Pointer SetHeight { get { return _setHeight; } }
        public Pointer SetDirection { get { return _setDirection; } }
        public Pointer SetAnimation { get { return _setAnimation; } }
        public Pointer SetEffect { get { return _setEffect; } }
        public Pointer SetAttributeBitfieldWrapper { get { return _setAttributeBitfieldWrapper; } }
        public Pointer ResetAttributeBitfieldWrapper { get { return _resetAttributeBitfieldWrapper; } }
        public Pointer SetBlink { get { return _setBlink; } }
        public Pointer SetPositionOffset { get { return _setPositionOffset; } }
        public Pointer GetAnimationStatus { get { return _getAnimationStatus; } }
        public Pointer GetEffectStatus { get { return _getEffectStatus; } }
        public GroundEntityFunctionTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
