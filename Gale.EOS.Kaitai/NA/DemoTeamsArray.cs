// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DEMO_TEAMS defined within pmdsky.
    /// </summary>
    public partial class DemoTeamsArray : KaitaiStruct
    {
        public static DemoTeamsArray FromFile(string fileName)
        {
            return new DemoTeamsArray(new KaitaiStream(fileName));
        }

        public DemoTeamsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DemoTeamsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DemoTeamsArrayDim1(m_io, this, m_root);
        }
        public partial class DemoTeamsArrayDim0 : KaitaiStruct
        {
            public static DemoTeamsArrayDim0 FromFile(string fileName)
            {
                return new DemoTeamsArrayDim0(new KaitaiStream(fileName));
            }

            public DemoTeamsArrayDim0(KaitaiStream p__io, DemoTeamsArray.DemoTeamsArrayDim1 p__parent = null, DemoTeamsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private DemoTeamsArray m_root;
            private DemoTeamsArray.DemoTeamsArrayDim1 m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public DemoTeamsArray M_Root { get { return m_root; } }
            public DemoTeamsArray.DemoTeamsArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DemoTeamsArrayDim1 : KaitaiStruct
        {
            public static DemoTeamsArrayDim1 FromFile(string fileName)
            {
                return new DemoTeamsArrayDim1(new KaitaiStream(fileName));
            }

            public DemoTeamsArrayDim1(KaitaiStream p__io, DemoTeamsArray p__parent = null, DemoTeamsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DemoTeamsArrayDim0>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new DemoTeamsArrayDim0(m_io, this, m_root));
                }
            }
            private List<DemoTeamsArrayDim0> _entries;
            private DemoTeamsArray m_root;
            private DemoTeamsArray m_parent;
            public List<DemoTeamsArrayDim0> Entries { get { return _entries; } }
            public DemoTeamsArray M_Root { get { return m_root; } }
            public DemoTeamsArray M_Parent { get { return m_parent; } }
        }
        private DemoTeamsArrayDim1 _entries;
        private DemoTeamsArray m_root;
        private KaitaiStruct m_parent;
        public DemoTeamsArrayDim1 Entries { get { return _entries; } }
        public DemoTeamsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
