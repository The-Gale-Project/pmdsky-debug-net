// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_MUZZLED defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayMuzzledArray : KaitaiStruct
    {
        public static StatusIconArrayMuzzledArray FromFile(string fileName)
        {
            return new StatusIconArrayMuzzledArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayMuzzledArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayMuzzledArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayMuzzledArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayMuzzledArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayMuzzledArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayMuzzledArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayMuzzledArrayDim0(KaitaiStream p__io, StatusIconArrayMuzzledArray p__parent = null, StatusIconArrayMuzzledArray p__root = null) : base(p__io)
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
            private StatusIconArrayMuzzledArray m_root;
            private StatusIconArrayMuzzledArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayMuzzledArray M_Root { get { return m_root; } }
            public StatusIconArrayMuzzledArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayMuzzledArrayDim0 _entries;
        private StatusIconArrayMuzzledArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayMuzzledArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayMuzzledArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
