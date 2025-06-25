// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array TACTIC_NAME_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class TacticNameStringIdsArray : KaitaiStruct
    {
        public static TacticNameStringIdsArray FromFile(string fileName)
        {
            return new TacticNameStringIdsArray(new KaitaiStream(fileName));
        }

        public TacticNameStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TacticNameStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TacticNameStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class TacticNameStringIdsArrayDim0 : KaitaiStruct
        {
            public static TacticNameStringIdsArrayDim0 FromFile(string fileName)
            {
                return new TacticNameStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public TacticNameStringIdsArrayDim0(KaitaiStream p__io, TacticNameStringIdsArray p__parent = null, TacticNameStringIdsArray p__root = null) : base(p__io)
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
            private TacticNameStringIdsArray m_root;
            private TacticNameStringIdsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public TacticNameStringIdsArray M_Root { get { return m_root; } }
            public TacticNameStringIdsArray M_Parent { get { return m_parent; } }
        }
        private TacticNameStringIdsArrayDim0 _entries;
        private TacticNameStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public TacticNameStringIdsArrayDim0 Entries { get { return _entries; } }
        public TacticNameStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
