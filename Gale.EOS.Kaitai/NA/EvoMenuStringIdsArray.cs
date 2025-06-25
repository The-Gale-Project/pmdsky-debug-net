// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array EVO_MENU_STRING_IDS defined within pmdsky.
    /// </summary>
    public partial class EvoMenuStringIdsArray : KaitaiStruct
    {
        public static EvoMenuStringIdsArray FromFile(string fileName)
        {
            return new EvoMenuStringIdsArray(new KaitaiStream(fileName));
        }

        public EvoMenuStringIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EvoMenuStringIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EvoMenuStringIdsArrayDim0(m_io, this, m_root);
        }
        public partial class EvoMenuStringIdsArrayDim0 : KaitaiStruct
        {
            public static EvoMenuStringIdsArrayDim0 FromFile(string fileName)
            {
                return new EvoMenuStringIdsArrayDim0(new KaitaiStream(fileName));
            }

            public EvoMenuStringIdsArrayDim0(KaitaiStream p__io, EvoMenuStringIdsArray p__parent = null, EvoMenuStringIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 26; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private EvoMenuStringIdsArray m_root;
            private EvoMenuStringIdsArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public EvoMenuStringIdsArray M_Root { get { return m_root; } }
            public EvoMenuStringIdsArray M_Parent { get { return m_parent; } }
        }
        private EvoMenuStringIdsArrayDim0 _entries;
        private EvoMenuStringIdsArray m_root;
        private KaitaiStruct m_parent;
        public EvoMenuStringIdsArrayDim0 Entries { get { return _entries; } }
        public EvoMenuStringIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
