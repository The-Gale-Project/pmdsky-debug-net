// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_reflect_id.
    /// </summary>
    public partial class StatusReflectId8 : KaitaiStruct
    {
        public static StatusReflectId8 FromFile(string fileName)
        {
            return new StatusReflectId8(new KaitaiStream(fileName));
        }


        public enum StatusReflectId8Enum
        {
            StatusReflectNone = 0,
            StatusReflectReflect = 1,
            StatusReflectSafeguard = 2,
            StatusReflectLightScreen = 3,
            StatusReflectCounter = 4,
            StatusReflectMagicCoat = 5,
            StatusReflectWish = 6,
            StatusReflectProtect = 7,
            StatusReflectMirrorCoat = 8,
            StatusReflectEnduring = 9,
            StatusReflectMiniCounter = 10,
            StatusReflectMirrorMove = 11,
            StatusReflectConversion2 = 12,
            StatusReflectVitalThrow = 13,
            StatusReflectMist = 14,
            StatusReflectMetalBurst = 15,
            StatusReflectAquaRing = 16,
            StatusReflectLuckyChant = 17,
        }
        public StatusReflectId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusReflectId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusReflectId8Value = ((StatusReflectId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusReflectId8Enum _statusReflectId8Value;
        private StatusReflectId8 m_root;
        private KaitaiStruct m_parent;
        public StatusReflectId8Enum StatusReflectId8Value { get { return _statusReflectId8Value; } }
        public StatusReflectId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
