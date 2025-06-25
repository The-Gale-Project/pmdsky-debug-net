// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array PACK_FILE_PATHS_TABLE defined within pmdsky.
    /// </summary>
    public partial class PackFilePathsTableArray : KaitaiStruct
    {
        public static PackFilePathsTableArray FromFile(string fileName)
        {
            return new PackFilePathsTableArray(new KaitaiStream(fileName));
        }

        public PackFilePathsTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PackFilePathsTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PackFilePathsTableArrayDim0(m_io, this, m_root);
        }
        public partial class PackFilePathsTableArrayDim0 : KaitaiStruct
        {
            public static PackFilePathsTableArrayDim0 FromFile(string fileName)
            {
                return new PackFilePathsTableArrayDim0(new KaitaiStream(fileName));
            }

            public PackFilePathsTableArrayDim0(KaitaiStream p__io, PackFilePathsTableArray p__parent = null, PackFilePathsTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private PackFilePathsTableArray m_root;
            private PackFilePathsTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public PackFilePathsTableArray M_Root { get { return m_root; } }
            public PackFilePathsTableArray M_Parent { get { return m_parent; } }
        }
        private PackFilePathsTableArrayDim0 _entries;
        private PackFilePathsTableArray m_root;
        private KaitaiStruct m_parent;
        public PackFilePathsTableArrayDim0 Entries { get { return _entries; } }
        public PackFilePathsTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
