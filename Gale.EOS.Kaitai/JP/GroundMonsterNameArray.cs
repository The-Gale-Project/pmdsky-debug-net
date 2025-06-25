// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array ground_monster_name defined within pmdsky.
    /// </summary>
    public partial class GroundMonsterNameArray : KaitaiStruct
    {
        public static GroundMonsterNameArray FromFile(string fileName)
        {
            return new GroundMonsterNameArray(new KaitaiStream(fileName));
        }

        public GroundMonsterNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMonsterNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMonsterNameArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMonsterNameArrayDim0 : KaitaiStruct
        {
            public static GroundMonsterNameArrayDim0 FromFile(string fileName)
            {
                return new GroundMonsterNameArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMonsterNameArrayDim0(KaitaiStream p__io, GroundMonsterNameArray p__parent = null, GroundMonsterNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private GroundMonsterNameArray m_root;
            private GroundMonsterNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public GroundMonsterNameArray M_Root { get { return m_root; } }
            public GroundMonsterNameArray M_Parent { get { return m_parent; } }
        }
        private GroundMonsterNameArrayDim0 _entries;
        private GroundMonsterNameArray m_root;
        private KaitaiStruct m_parent;
        public GroundMonsterNameArrayDim0 Entries { get { return _entries; } }
        public GroundMonsterNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
