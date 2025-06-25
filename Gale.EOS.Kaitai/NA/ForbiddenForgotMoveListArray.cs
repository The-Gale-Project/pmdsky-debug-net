// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array FORBIDDEN_FORGOT_MOVE_LIST defined within pmdsky.
    /// </summary>
    public partial class ForbiddenForgotMoveListArray : KaitaiStruct
    {
        public static ForbiddenForgotMoveListArray FromFile(string fileName)
        {
            return new ForbiddenForgotMoveListArray(new KaitaiStream(fileName));
        }

        public ForbiddenForgotMoveListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ForbiddenForgotMoveListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ForbiddenForgotMoveListArrayDim0(m_io, this, m_root);
        }
        public partial class ForbiddenForgotMoveListArrayDim0 : KaitaiStruct
        {
            public static ForbiddenForgotMoveListArrayDim0 FromFile(string fileName)
            {
                return new ForbiddenForgotMoveListArrayDim0(new KaitaiStream(fileName));
            }

            public ForbiddenForgotMoveListArrayDim0(KaitaiStream p__io, ForbiddenForgotMoveListArray p__parent = null, ForbiddenForgotMoveListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ForbiddenForgotMoveEntry>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new ForbiddenForgotMoveEntry(m_io));
                }
            }
            private List<ForbiddenForgotMoveEntry> _entries;
            private ForbiddenForgotMoveListArray m_root;
            private ForbiddenForgotMoveListArray m_parent;
            public List<ForbiddenForgotMoveEntry> Entries { get { return _entries; } }
            public ForbiddenForgotMoveListArray M_Root { get { return m_root; } }
            public ForbiddenForgotMoveListArray M_Parent { get { return m_parent; } }
        }
        private ForbiddenForgotMoveListArrayDim0 _entries;
        private ForbiddenForgotMoveListArray m_root;
        private KaitaiStruct m_parent;
        public ForbiddenForgotMoveListArrayDim0 Entries { get { return _entries; } }
        public ForbiddenForgotMoveListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
