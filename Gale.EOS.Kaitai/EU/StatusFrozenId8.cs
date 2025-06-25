// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_frozen_id.
    /// </summary>
    public partial class StatusFrozenId8 : KaitaiStruct
    {
        public static StatusFrozenId8 FromFile(string fileName)
        {
            return new StatusFrozenId8(new KaitaiStream(fileName));
        }


        public enum StatusFrozenId8Enum
        {
            StatusFrozenNone = 0,
            StatusFrozenFrozen = 1,
            StatusFrozenShadowHold = 2,
            StatusFrozenWrap = 3,
            StatusFrozenWrapped = 4,
            StatusFrozenIngrain = 5,
            StatusFrozenPetrified = 6,
            StatusFrozenConstriction = 7,
        }
        public StatusFrozenId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusFrozenId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusFrozenId8Value = ((StatusFrozenId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusFrozenId8Enum _statusFrozenId8Value;
        private StatusFrozenId8 m_root;
        private KaitaiStruct m_parent;
        public StatusFrozenId8Enum StatusFrozenId8Value { get { return _statusFrozenId8Value; } }
        public StatusFrozenId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
