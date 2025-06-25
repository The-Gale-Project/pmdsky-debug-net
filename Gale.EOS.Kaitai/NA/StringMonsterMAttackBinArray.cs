// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STRING_MONSTER_M_ATTACK_BIN defined within pmdsky.
    /// </summary>
    public partial class StringMonsterMAttackBinArray : KaitaiStruct
    {
        public static StringMonsterMAttackBinArray FromFile(string fileName)
        {
            return new StringMonsterMAttackBinArray(new KaitaiStream(fileName));
        }

        public StringMonsterMAttackBinArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringMonsterMAttackBinArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringMonsterMAttackBinArrayDim0(m_io, this, m_root);
        }
        public partial class StringMonsterMAttackBinArrayDim0 : KaitaiStruct
        {
            public static StringMonsterMAttackBinArrayDim0 FromFile(string fileName)
            {
                return new StringMonsterMAttackBinArrayDim0(new KaitaiStream(fileName));
            }

            public StringMonsterMAttackBinArrayDim0(KaitaiStream p__io, StringMonsterMAttackBinArray p__parent = null, StringMonsterMAttackBinArray p__root = null) : base(p__io)
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
            private StringMonsterMAttackBinArray m_root;
            private StringMonsterMAttackBinArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringMonsterMAttackBinArray M_Root { get { return m_root; } }
            public StringMonsterMAttackBinArray M_Parent { get { return m_parent; } }
        }
        private StringMonsterMAttackBinArrayDim0 _entries;
        private StringMonsterMAttackBinArray m_root;
        private KaitaiStruct m_parent;
        public StringMonsterMAttackBinArrayDim0 Entries { get { return _entries; } }
        public StringMonsterMAttackBinArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
