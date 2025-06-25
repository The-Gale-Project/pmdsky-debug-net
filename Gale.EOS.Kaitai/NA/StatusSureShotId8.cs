// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_sure_shot_id.
    /// </summary>
    public partial class StatusSureShotId8 : KaitaiStruct
    {
        public static StatusSureShotId8 FromFile(string fileName)
        {
            return new StatusSureShotId8(new KaitaiStream(fileName));
        }


        public enum StatusSureShotId8Enum
        {
            StatusSureShotNone = 0,
            StatusSureShotSureShot = 1,
            StatusSureShotWhiffer = 2,
            StatusSureShotSetDamage = 3,
            StatusSureShotFocusEnergy = 4,
        }
        public StatusSureShotId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusSureShotId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusSureShotId8Value = ((StatusSureShotId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusSureShotId8Enum _statusSureShotId8Value;
        private StatusSureShotId8 m_root;
        private KaitaiStruct m_parent;
        public StatusSureShotId8Enum StatusSureShotId8Value { get { return _statusSureShotId8Value; } }
        public StatusSureShotId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
