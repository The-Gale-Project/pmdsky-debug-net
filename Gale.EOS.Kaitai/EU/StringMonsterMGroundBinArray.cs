// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STRING_MONSTER_M_GROUND_BIN defined within pmdsky.
    /// </summary>
    public partial class StringMonsterMGroundBinArray : KaitaiStruct
    {
        public static StringMonsterMGroundBinArray FromFile(string fileName)
        {
            return new StringMonsterMGroundBinArray(new KaitaiStream(fileName));
        }

        public StringMonsterMGroundBinArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringMonsterMGroundBinArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringMonsterMGroundBinArrayDim0(m_io, this, m_root);
        }
        public partial class StringMonsterMGroundBinArrayDim0 : KaitaiStruct
        {
            public static StringMonsterMGroundBinArrayDim0 FromFile(string fileName)
            {
                return new StringMonsterMGroundBinArrayDim0(new KaitaiStream(fileName));
            }

            public StringMonsterMGroundBinArrayDim0(KaitaiStream p__io, StringMonsterMGroundBinArray p__parent = null, StringMonsterMGroundBinArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 24; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringMonsterMGroundBinArray m_root;
            private StringMonsterMGroundBinArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringMonsterMGroundBinArray M_Root { get { return m_root; } }
            public StringMonsterMGroundBinArray M_Parent { get { return m_parent; } }
        }
        private StringMonsterMGroundBinArrayDim0 _entries;
        private StringMonsterMGroundBinArray m_root;
        private KaitaiStruct m_parent;
        public StringMonsterMGroundBinArrayDim0 Entries { get { return _entries; } }
        public StringMonsterMGroundBinArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
