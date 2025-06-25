// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MISSION_MENU_STRING_IDS_1 defined within pmdsky.
    /// </summary>
    public partial class MissionMenuStringIds1Array : KaitaiStruct
    {
        public static MissionMenuStringIds1Array FromFile(string fileName)
        {
            return new MissionMenuStringIds1Array(new KaitaiStream(fileName));
        }

        public MissionMenuStringIds1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionMenuStringIds1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionMenuStringIds1ArrayDim0(m_io, this, m_root);
        }
        public partial class MissionMenuStringIds1ArrayDim0 : KaitaiStruct
        {
            public static MissionMenuStringIds1ArrayDim0 FromFile(string fileName)
            {
                return new MissionMenuStringIds1ArrayDim0(new KaitaiStream(fileName));
            }

            public MissionMenuStringIds1ArrayDim0(KaitaiStream p__io, MissionMenuStringIds1Array p__parent = null, MissionMenuStringIds1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private MissionMenuStringIds1Array m_root;
            private MissionMenuStringIds1Array m_parent;
            public List<short> Entries { get { return _entries; } }
            public MissionMenuStringIds1Array M_Root { get { return m_root; } }
            public MissionMenuStringIds1Array M_Parent { get { return m_parent; } }
        }
        private MissionMenuStringIds1ArrayDim0 _entries;
        private MissionMenuStringIds1Array m_root;
        private KaitaiStruct m_parent;
        public MissionMenuStringIds1ArrayDim0 Entries { get { return _entries; } }
        public MissionMenuStringIds1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
