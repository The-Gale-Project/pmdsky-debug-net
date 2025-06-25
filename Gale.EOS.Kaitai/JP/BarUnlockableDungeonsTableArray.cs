// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array BAR_UNLOCKABLE_DUNGEONS_TABLE defined within pmdsky.
    /// </summary>
    public partial class BarUnlockableDungeonsTableArray : KaitaiStruct
    {
        public static BarUnlockableDungeonsTableArray FromFile(string fileName)
        {
            return new BarUnlockableDungeonsTableArray(new KaitaiStream(fileName));
        }

        public BarUnlockableDungeonsTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BarUnlockableDungeonsTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarUnlockableDungeonsTableArrayDim0(m_io, this, m_root);
        }
        public partial class BarUnlockableDungeonsTableArrayDim0 : KaitaiStruct
        {
            public static BarUnlockableDungeonsTableArrayDim0 FromFile(string fileName)
            {
                return new BarUnlockableDungeonsTableArrayDim0(new KaitaiStream(fileName));
            }

            public BarUnlockableDungeonsTableArrayDim0(KaitaiStream p__io, BarUnlockableDungeonsTableArray p__parent = null, BarUnlockableDungeonsTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonId16>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(new DungeonId16(m_io));
                }
            }
            private List<DungeonId16> _entries;
            private BarUnlockableDungeonsTableArray m_root;
            private BarUnlockableDungeonsTableArray m_parent;
            public List<DungeonId16> Entries { get { return _entries; } }
            public BarUnlockableDungeonsTableArray M_Root { get { return m_root; } }
            public BarUnlockableDungeonsTableArray M_Parent { get { return m_parent; } }
        }
        private BarUnlockableDungeonsTableArrayDim0 _entries;
        private BarUnlockableDungeonsTableArray m_root;
        private KaitaiStruct m_parent;
        public BarUnlockableDungeonsTableArrayDim0 Entries { get { return _entries; } }
        public BarUnlockableDungeonsTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
