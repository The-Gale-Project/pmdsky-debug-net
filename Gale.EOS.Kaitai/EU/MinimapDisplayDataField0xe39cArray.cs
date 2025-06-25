// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array minimap_display_data_field_0xE39C defined within pmdsky.
    /// </summary>
    public partial class MinimapDisplayDataField0xe39cArray : KaitaiStruct
    {
        public static MinimapDisplayDataField0xe39cArray FromFile(string fileName)
        {
            return new MinimapDisplayDataField0xe39cArray(new KaitaiStream(fileName));
        }

        public MinimapDisplayDataField0xe39cArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayDataField0xe39cArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MinimapDisplayDataField0xe39cArrayDim0(m_io, this, m_root);
        }
        public partial class MinimapDisplayDataField0xe39cArrayDim0 : KaitaiStruct
        {
            public static MinimapDisplayDataField0xe39cArrayDim0 FromFile(string fileName)
            {
                return new MinimapDisplayDataField0xe39cArrayDim0(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataField0xe39cArrayDim0(KaitaiStream p__io, MinimapDisplayDataField0xe39cArray p__parent = null, MinimapDisplayDataField0xe39cArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 41; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private MinimapDisplayDataField0xe39cArray m_root;
            private MinimapDisplayDataField0xe39cArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public MinimapDisplayDataField0xe39cArray M_Root { get { return m_root; } }
            public MinimapDisplayDataField0xe39cArray M_Parent { get { return m_parent; } }
        }
        private MinimapDisplayDataField0xe39cArrayDim0 _entries;
        private MinimapDisplayDataField0xe39cArray m_root;
        private KaitaiStruct m_parent;
        public MinimapDisplayDataField0xe39cArrayDim0 Entries { get { return _entries; } }
        public MinimapDisplayDataField0xe39cArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
