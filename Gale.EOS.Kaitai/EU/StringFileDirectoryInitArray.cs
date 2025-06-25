// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STRING_FILE_DIRECTORY_INIT defined within pmdsky.
    /// </summary>
    public partial class StringFileDirectoryInitArray : KaitaiStruct
    {
        public static StringFileDirectoryInitArray FromFile(string fileName)
        {
            return new StringFileDirectoryInitArray(new KaitaiStream(fileName));
        }

        public StringFileDirectoryInitArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringFileDirectoryInitArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringFileDirectoryInitArrayDim0(m_io, this, m_root);
        }
        public partial class StringFileDirectoryInitArrayDim0 : KaitaiStruct
        {
            public static StringFileDirectoryInitArrayDim0 FromFile(string fileName)
            {
                return new StringFileDirectoryInitArrayDim0(new KaitaiStream(fileName));
            }

            public StringFileDirectoryInitArrayDim0(KaitaiStream p__io, StringFileDirectoryInitArray p__parent = null, StringFileDirectoryInitArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 40; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringFileDirectoryInitArray m_root;
            private StringFileDirectoryInitArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringFileDirectoryInitArray M_Root { get { return m_root; } }
            public StringFileDirectoryInitArray M_Parent { get { return m_parent; } }
        }
        private StringFileDirectoryInitArrayDim0 _entries;
        private StringFileDirectoryInitArray m_root;
        private KaitaiStruct m_parent;
        public StringFileDirectoryInitArrayDim0 Entries { get { return _entries; } }
        public StringFileDirectoryInitArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
