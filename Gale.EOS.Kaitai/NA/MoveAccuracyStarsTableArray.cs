// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array MOVE_ACCURACY_STARS_TABLE defined within pmdsky.
    /// </summary>
    public partial class MoveAccuracyStarsTableArray : KaitaiStruct
    {
        public static MoveAccuracyStarsTableArray FromFile(string fileName)
        {
            return new MoveAccuracyStarsTableArray(new KaitaiStream(fileName));
        }

        public MoveAccuracyStarsTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveAccuracyStarsTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MoveAccuracyStarsTableArrayDim0(m_io, this, m_root);
        }
        public partial class MoveAccuracyStarsTableArrayDim0 : KaitaiStruct
        {
            public static MoveAccuracyStarsTableArrayDim0 FromFile(string fileName)
            {
                return new MoveAccuracyStarsTableArrayDim0(new KaitaiStream(fileName));
            }

            public MoveAccuracyStarsTableArrayDim0(KaitaiStream p__io, MoveAccuracyStarsTableArray p__parent = null, MoveAccuracyStarsTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private MoveAccuracyStarsTableArray m_root;
            private MoveAccuracyStarsTableArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MoveAccuracyStarsTableArray M_Root { get { return m_root; } }
            public MoveAccuracyStarsTableArray M_Parent { get { return m_parent; } }
        }
        private MoveAccuracyStarsTableArrayDim0 _entries;
        private MoveAccuracyStarsTableArray m_root;
        private KaitaiStruct m_parent;
        public MoveAccuracyStarsTableArrayDim0 Entries { get { return _entries; } }
        public MoveAccuracyStarsTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
