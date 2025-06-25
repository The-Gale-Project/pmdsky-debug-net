// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STRING_MONSTER_MONSTER_BIN defined within pmdsky.
    /// </summary>
    public partial class StringMonsterMonsterBinArray : KaitaiStruct
    {
        public static StringMonsterMonsterBinArray FromFile(string fileName)
        {
            return new StringMonsterMonsterBinArray(new KaitaiStream(fileName));
        }

        public StringMonsterMonsterBinArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringMonsterMonsterBinArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringMonsterMonsterBinArrayDim0(m_io, this, m_root);
        }
        public partial class StringMonsterMonsterBinArrayDim0 : KaitaiStruct
        {
            public static StringMonsterMonsterBinArrayDim0 FromFile(string fileName)
            {
                return new StringMonsterMonsterBinArrayDim0(new KaitaiStream(fileName));
            }

            public StringMonsterMonsterBinArrayDim0(KaitaiStream p__io, StringMonsterMonsterBinArray p__parent = null, StringMonsterMonsterBinArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringMonsterMonsterBinArray m_root;
            private StringMonsterMonsterBinArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringMonsterMonsterBinArray M_Root { get { return m_root; } }
            public StringMonsterMonsterBinArray M_Parent { get { return m_parent; } }
        }
        private StringMonsterMonsterBinArrayDim0 _entries;
        private StringMonsterMonsterBinArray m_root;
        private KaitaiStruct m_parent;
        public StringMonsterMonsterBinArrayDim0 Entries { get { return _entries; } }
        public StringMonsterMonsterBinArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
