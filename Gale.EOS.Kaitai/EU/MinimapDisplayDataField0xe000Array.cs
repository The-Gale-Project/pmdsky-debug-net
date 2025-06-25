// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array minimap_display_data_field_0xE000 defined within pmdsky.
    /// </summary>
    public partial class MinimapDisplayDataField0xe000Array : KaitaiStruct
    {
        public static MinimapDisplayDataField0xe000Array FromFile(string fileName)
        {
            return new MinimapDisplayDataField0xe000Array(new KaitaiStream(fileName));
        }

        public MinimapDisplayDataField0xe000Array(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayDataField0xe000Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MinimapDisplayDataField0xe000ArrayDim1(m_io, this, m_root);
        }
        public partial class MinimapDisplayDataField0xe000ArrayDim0 : KaitaiStruct
        {
            public static MinimapDisplayDataField0xe000ArrayDim0 FromFile(string fileName)
            {
                return new MinimapDisplayDataField0xe000ArrayDim0(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataField0xe000ArrayDim0(KaitaiStream p__io, MinimapDisplayDataField0xe000Array.MinimapDisplayDataField0xe000ArrayDim1 p__parent = null, MinimapDisplayDataField0xe000Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 28; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private MinimapDisplayDataField0xe000Array m_root;
            private MinimapDisplayDataField0xe000Array.MinimapDisplayDataField0xe000ArrayDim1 m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MinimapDisplayDataField0xe000Array M_Root { get { return m_root; } }
            public MinimapDisplayDataField0xe000Array.MinimapDisplayDataField0xe000ArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class MinimapDisplayDataField0xe000ArrayDim1 : KaitaiStruct
        {
            public static MinimapDisplayDataField0xe000ArrayDim1 FromFile(string fileName)
            {
                return new MinimapDisplayDataField0xe000ArrayDim1(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataField0xe000ArrayDim1(KaitaiStream p__io, MinimapDisplayDataField0xe000Array p__parent = null, MinimapDisplayDataField0xe000Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MinimapDisplayDataField0xe000ArrayDim0>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new MinimapDisplayDataField0xe000ArrayDim0(m_io, this, m_root));
                }
            }
            private List<MinimapDisplayDataField0xe000ArrayDim0> _entries;
            private MinimapDisplayDataField0xe000Array m_root;
            private MinimapDisplayDataField0xe000Array m_parent;
            public List<MinimapDisplayDataField0xe000ArrayDim0> Entries { get { return _entries; } }
            public MinimapDisplayDataField0xe000Array M_Root { get { return m_root; } }
            public MinimapDisplayDataField0xe000Array M_Parent { get { return m_parent; } }
        }
        private MinimapDisplayDataField0xe000ArrayDim1 _entries;
        private MinimapDisplayDataField0xe000Array m_root;
        private KaitaiStruct m_parent;
        public MinimapDisplayDataField0xe000ArrayDim1 Entries { get { return _entries; } }
        public MinimapDisplayDataField0xe000Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
