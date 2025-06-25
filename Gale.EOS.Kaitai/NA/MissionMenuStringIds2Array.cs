// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array MISSION_MENU_STRING_IDS_2 defined within pmdsky.
    /// </summary>
    public partial class MissionMenuStringIds2Array : KaitaiStruct
    {
        public static MissionMenuStringIds2Array FromFile(string fileName)
        {
            return new MissionMenuStringIds2Array(new KaitaiStream(fileName));
        }

        public MissionMenuStringIds2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionMenuStringIds2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionMenuStringIds2ArrayDim0(m_io, this, m_root);
        }
        public partial class MissionMenuStringIds2ArrayDim0 : KaitaiStruct
        {
            public static MissionMenuStringIds2ArrayDim0 FromFile(string fileName)
            {
                return new MissionMenuStringIds2ArrayDim0(new KaitaiStream(fileName));
            }

            public MissionMenuStringIds2ArrayDim0(KaitaiStream p__io, MissionMenuStringIds2Array p__parent = null, MissionMenuStringIds2Array p__root = null) : base(p__io)
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
            private MissionMenuStringIds2Array m_root;
            private MissionMenuStringIds2Array m_parent;
            public List<short> Entries { get { return _entries; } }
            public MissionMenuStringIds2Array M_Root { get { return m_root; } }
            public MissionMenuStringIds2Array M_Parent { get { return m_parent; } }
        }
        private MissionMenuStringIds2ArrayDim0 _entries;
        private MissionMenuStringIds2Array m_root;
        private KaitaiStruct m_parent;
        public MissionMenuStringIds2ArrayDim0 Entries { get { return _entries; } }
        public MissionMenuStringIds2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
