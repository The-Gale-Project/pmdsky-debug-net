// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GUMMI_BELLY_RESTORE_TABLE defined within pmdsky.
    /// </summary>
    public partial class GummiBellyRestoreTableArray : KaitaiStruct
    {
        public static GummiBellyRestoreTableArray FromFile(string fileName)
        {
            return new GummiBellyRestoreTableArray(new KaitaiStream(fileName));
        }

        public GummiBellyRestoreTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GummiBellyRestoreTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GummiBellyRestoreTableArrayDim1(m_io, this, m_root);
        }
        public partial class GummiBellyRestoreTableArrayDim0 : KaitaiStruct
        {
            public static GummiBellyRestoreTableArrayDim0 FromFile(string fileName)
            {
                return new GummiBellyRestoreTableArrayDim0(new KaitaiStream(fileName));
            }

            public GummiBellyRestoreTableArrayDim0(KaitaiStream p__io, GummiBellyRestoreTableArray.GummiBellyRestoreTableArrayDim1 p__parent = null, GummiBellyRestoreTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private GummiBellyRestoreTableArray m_root;
            private GummiBellyRestoreTableArray.GummiBellyRestoreTableArrayDim1 m_parent;
            public List<short> Entries { get { return _entries; } }
            public GummiBellyRestoreTableArray M_Root { get { return m_root; } }
            public GummiBellyRestoreTableArray.GummiBellyRestoreTableArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class GummiBellyRestoreTableArrayDim1 : KaitaiStruct
        {
            public static GummiBellyRestoreTableArrayDim1 FromFile(string fileName)
            {
                return new GummiBellyRestoreTableArrayDim1(new KaitaiStream(fileName));
            }

            public GummiBellyRestoreTableArrayDim1(KaitaiStream p__io, GummiBellyRestoreTableArray p__parent = null, GummiBellyRestoreTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GummiBellyRestoreTableArrayDim0>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new GummiBellyRestoreTableArrayDim0(m_io, this, m_root));
                }
            }
            private List<GummiBellyRestoreTableArrayDim0> _entries;
            private GummiBellyRestoreTableArray m_root;
            private GummiBellyRestoreTableArray m_parent;
            public List<GummiBellyRestoreTableArrayDim0> Entries { get { return _entries; } }
            public GummiBellyRestoreTableArray M_Root { get { return m_root; } }
            public GummiBellyRestoreTableArray M_Parent { get { return m_parent; } }
        }
        private GummiBellyRestoreTableArrayDim1 _entries;
        private GummiBellyRestoreTableArray m_root;
        private KaitaiStruct m_parent;
        public GummiBellyRestoreTableArrayDim1 Entries { get { return _entries; } }
        public GummiBellyRestoreTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
