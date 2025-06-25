// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array bar_item_field_0xe defined within pmdsky.
    /// </summary>
    public partial class BarItemField0xeArray : KaitaiStruct
    {
        public static BarItemField0xeArray FromFile(string fileName)
        {
            return new BarItemField0xeArray(new KaitaiStream(fileName));
        }

        public BarItemField0xeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BarItemField0xeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarItemField0xeArrayDim0(m_io, this, m_root);
        }
        public partial class BarItemField0xeArrayDim0 : KaitaiStruct
        {
            public static BarItemField0xeArrayDim0 FromFile(string fileName)
            {
                return new BarItemField0xeArrayDim0(new KaitaiStream(fileName));
            }

            public BarItemField0xeArrayDim0(KaitaiStream p__io, BarItemField0xeArray p__parent = null, BarItemField0xeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private BarItemField0xeArray m_root;
            private BarItemField0xeArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public BarItemField0xeArray M_Root { get { return m_root; } }
            public BarItemField0xeArray M_Parent { get { return m_parent; } }
        }
        private BarItemField0xeArrayDim0 _entries;
        private BarItemField0xeArray m_root;
        private KaitaiStruct m_parent;
        public BarItemField0xeArrayDim0 Entries { get { return _entries; } }
        public BarItemField0xeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
