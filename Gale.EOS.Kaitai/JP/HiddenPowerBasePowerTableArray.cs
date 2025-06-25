// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array HIDDEN_POWER_BASE_POWER_TABLE defined within pmdsky.
    /// </summary>
    public partial class HiddenPowerBasePowerTableArray : KaitaiStruct
    {
        public static HiddenPowerBasePowerTableArray FromFile(string fileName)
        {
            return new HiddenPowerBasePowerTableArray(new KaitaiStream(fileName));
        }

        public HiddenPowerBasePowerTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, HiddenPowerBasePowerTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new HiddenPowerBasePowerTableArrayDim0(m_io, this, m_root);
        }
        public partial class HiddenPowerBasePowerTableArrayDim0 : KaitaiStruct
        {
            public static HiddenPowerBasePowerTableArrayDim0 FromFile(string fileName)
            {
                return new HiddenPowerBasePowerTableArrayDim0(new KaitaiStream(fileName));
            }

            public HiddenPowerBasePowerTableArrayDim0(KaitaiStream p__io, HiddenPowerBasePowerTableArray p__parent = null, HiddenPowerBasePowerTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private HiddenPowerBasePowerTableArray m_root;
            private HiddenPowerBasePowerTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public HiddenPowerBasePowerTableArray M_Root { get { return m_root; } }
            public HiddenPowerBasePowerTableArray M_Parent { get { return m_parent; } }
        }
        private HiddenPowerBasePowerTableArrayDim0 _entries;
        private HiddenPowerBasePowerTableArray m_root;
        private KaitaiStruct m_parent;
        public HiddenPowerBasePowerTableArrayDim0 Entries { get { return _entries; } }
        public HiddenPowerBasePowerTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
