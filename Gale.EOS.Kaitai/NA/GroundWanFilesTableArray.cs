// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GROUND_WAN_FILES_TABLE defined within pmdsky.
    /// </summary>
    public partial class GroundWanFilesTableArray : KaitaiStruct
    {
        public static GroundWanFilesTableArray FromFile(string fileName)
        {
            return new GroundWanFilesTableArray(new KaitaiStream(fileName));
        }

        public GroundWanFilesTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundWanFilesTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundWanFilesTableArrayDim1(m_io, this, m_root);
        }
        public partial class GroundWanFilesTableArrayDim0 : KaitaiStruct
        {
            public static GroundWanFilesTableArrayDim0 FromFile(string fileName)
            {
                return new GroundWanFilesTableArrayDim0(new KaitaiStream(fileName));
            }

            public GroundWanFilesTableArrayDim0(KaitaiStream p__io, GroundWanFilesTableArray.GroundWanFilesTableArrayDim1 p__parent = null, GroundWanFilesTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 12; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private GroundWanFilesTableArray m_root;
            private GroundWanFilesTableArray.GroundWanFilesTableArrayDim1 m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public GroundWanFilesTableArray M_Root { get { return m_root; } }
            public GroundWanFilesTableArray.GroundWanFilesTableArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class GroundWanFilesTableArrayDim1 : KaitaiStruct
        {
            public static GroundWanFilesTableArrayDim1 FromFile(string fileName)
            {
                return new GroundWanFilesTableArrayDim1(new KaitaiStream(fileName));
            }

            public GroundWanFilesTableArrayDim1(KaitaiStream p__io, GroundWanFilesTableArray p__parent = null, GroundWanFilesTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GroundWanFilesTableArrayDim0>();
                for (var i = 0; i < 343; i++)
                {
                    _entries.Add(new GroundWanFilesTableArrayDim0(m_io, this, m_root));
                }
            }
            private List<GroundWanFilesTableArrayDim0> _entries;
            private GroundWanFilesTableArray m_root;
            private GroundWanFilesTableArray m_parent;
            public List<GroundWanFilesTableArrayDim0> Entries { get { return _entries; } }
            public GroundWanFilesTableArray M_Root { get { return m_root; } }
            public GroundWanFilesTableArray M_Parent { get { return m_parent; } }
        }
        private GroundWanFilesTableArrayDim1 _entries;
        private GroundWanFilesTableArray m_root;
        private KaitaiStruct m_parent;
        public GroundWanFilesTableArrayDim1 Entries { get { return _entries; } }
        public GroundWanFilesTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
