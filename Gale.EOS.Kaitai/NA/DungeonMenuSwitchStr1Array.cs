// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DUNGEON_MENU_SWITCH_STR1 defined within pmdsky.
    /// </summary>
    public partial class DungeonMenuSwitchStr1Array : KaitaiStruct
    {
        public static DungeonMenuSwitchStr1Array FromFile(string fileName)
        {
            return new DungeonMenuSwitchStr1Array(new KaitaiStream(fileName));
        }

        public DungeonMenuSwitchStr1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonMenuSwitchStr1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonMenuSwitchStr1ArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonMenuSwitchStr1ArrayDim0 : KaitaiStruct
        {
            public static DungeonMenuSwitchStr1ArrayDim0 FromFile(string fileName)
            {
                return new DungeonMenuSwitchStr1ArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonMenuSwitchStr1ArrayDim0(KaitaiStream p__io, DungeonMenuSwitchStr1Array p__parent = null, DungeonMenuSwitchStr1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private DungeonMenuSwitchStr1Array m_root;
            private DungeonMenuSwitchStr1Array m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public DungeonMenuSwitchStr1Array M_Root { get { return m_root; } }
            public DungeonMenuSwitchStr1Array M_Parent { get { return m_parent; } }
        }
        private DungeonMenuSwitchStr1ArrayDim0 _entries;
        private DungeonMenuSwitchStr1Array m_root;
        private KaitaiStruct m_parent;
        public DungeonMenuSwitchStr1ArrayDim0 Entries { get { return _entries; } }
        public DungeonMenuSwitchStr1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
