// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array minimap_display_data_overwritten_extra_bytes defined within pmdsky.
    /// </summary>
    public partial class MinimapDisplayDataOverwrittenExtraBytesArray : KaitaiStruct
    {
        public static MinimapDisplayDataOverwrittenExtraBytesArray FromFile(string fileName)
        {
            return new MinimapDisplayDataOverwrittenExtraBytesArray(new KaitaiStream(fileName));
        }

        public MinimapDisplayDataOverwrittenExtraBytesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayDataOverwrittenExtraBytesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MinimapDisplayDataOverwrittenExtraBytesArrayDim0(m_io, this, m_root);
        }
        public partial class MinimapDisplayDataOverwrittenExtraBytesArrayDim0 : KaitaiStruct
        {
            public static MinimapDisplayDataOverwrittenExtraBytesArrayDim0 FromFile(string fileName)
            {
                return new MinimapDisplayDataOverwrittenExtraBytesArrayDim0(new KaitaiStream(fileName));
            }

            public MinimapDisplayDataOverwrittenExtraBytesArrayDim0(KaitaiStream p__io, MinimapDisplayDataOverwrittenExtraBytesArray p__parent = null, MinimapDisplayDataOverwrittenExtraBytesArray p__root = null) : base(p__io)
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
            private MinimapDisplayDataOverwrittenExtraBytesArray m_root;
            private MinimapDisplayDataOverwrittenExtraBytesArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MinimapDisplayDataOverwrittenExtraBytesArray M_Root { get { return m_root; } }
            public MinimapDisplayDataOverwrittenExtraBytesArray M_Parent { get { return m_parent; } }
        }
        private MinimapDisplayDataOverwrittenExtraBytesArrayDim0 _entries;
        private MinimapDisplayDataOverwrittenExtraBytesArray m_root;
        private KaitaiStruct m_parent;
        public MinimapDisplayDataOverwrittenExtraBytesArrayDim0 Entries { get { return _entries; } }
        public MinimapDisplayDataOverwrittenExtraBytesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
