// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_MAGNET_RISE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayMagnetRiseArray : KaitaiStruct
    {
        public static StatusIconArrayMagnetRiseArray FromFile(string fileName)
        {
            return new StatusIconArrayMagnetRiseArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayMagnetRiseArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayMagnetRiseArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayMagnetRiseArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayMagnetRiseArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayMagnetRiseArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayMagnetRiseArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayMagnetRiseArrayDim0(KaitaiStream p__io, StatusIconArrayMagnetRiseArray p__parent = null, StatusIconArrayMagnetRiseArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayMagnetRiseArray m_root;
            private StatusIconArrayMagnetRiseArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayMagnetRiseArray M_Root { get { return m_root; } }
            public StatusIconArrayMagnetRiseArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayMagnetRiseArrayDim0 _entries;
        private StatusIconArrayMagnetRiseArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayMagnetRiseArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayMagnetRiseArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
