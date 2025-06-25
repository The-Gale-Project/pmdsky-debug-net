// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array TACTICS_UNLOCK_LEVEL_TABLE defined within pmdsky.
    /// </summary>
    public partial class TacticsUnlockLevelTableArray : KaitaiStruct
    {
        public static TacticsUnlockLevelTableArray FromFile(string fileName)
        {
            return new TacticsUnlockLevelTableArray(new KaitaiStream(fileName));
        }

        public TacticsUnlockLevelTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TacticsUnlockLevelTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TacticsUnlockLevelTableArrayDim0(m_io, this, m_root);
        }
        public partial class TacticsUnlockLevelTableArrayDim0 : KaitaiStruct
        {
            public static TacticsUnlockLevelTableArrayDim0 FromFile(string fileName)
            {
                return new TacticsUnlockLevelTableArrayDim0(new KaitaiStream(fileName));
            }

            public TacticsUnlockLevelTableArrayDim0(KaitaiStream p__io, TacticsUnlockLevelTableArray p__parent = null, TacticsUnlockLevelTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private TacticsUnlockLevelTableArray m_root;
            private TacticsUnlockLevelTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public TacticsUnlockLevelTableArray M_Root { get { return m_root; } }
            public TacticsUnlockLevelTableArray M_Parent { get { return m_parent; } }
        }
        private TacticsUnlockLevelTableArrayDim0 _entries;
        private TacticsUnlockLevelTableArray m_root;
        private KaitaiStruct m_parent;
        public TacticsUnlockLevelTableArrayDim0 Entries { get { return _entries; } }
        public TacticsUnlockLevelTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
