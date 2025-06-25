// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RECOIL_MOVE_LIST defined within pmdsky.
    /// </summary>
    public partial class RecoilMoveListArray : KaitaiStruct
    {
        public static RecoilMoveListArray FromFile(string fileName)
        {
            return new RecoilMoveListArray(new KaitaiStream(fileName));
        }

        public RecoilMoveListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RecoilMoveListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecoilMoveListArrayDim0(m_io, this, m_root);
        }
        public partial class RecoilMoveListArrayDim0 : KaitaiStruct
        {
            public static RecoilMoveListArrayDim0 FromFile(string fileName)
            {
                return new RecoilMoveListArrayDim0(new KaitaiStream(fileName));
            }

            public RecoilMoveListArrayDim0(KaitaiStream p__io, RecoilMoveListArray p__parent = null, RecoilMoveListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MoveId16>();
                for (var i = 0; i < 11; i++)
                {
                    _entries.Add(new MoveId16(m_io));
                }
            }
            private List<MoveId16> _entries;
            private RecoilMoveListArray m_root;
            private RecoilMoveListArray m_parent;
            public List<MoveId16> Entries { get { return _entries; } }
            public RecoilMoveListArray M_Root { get { return m_root; } }
            public RecoilMoveListArray M_Parent { get { return m_parent; } }
        }
        private RecoilMoveListArrayDim0 _entries;
        private RecoilMoveListArray m_root;
        private KaitaiStruct m_parent;
        public RecoilMoveListArrayDim0 Entries { get { return _entries; } }
        public RecoilMoveListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
