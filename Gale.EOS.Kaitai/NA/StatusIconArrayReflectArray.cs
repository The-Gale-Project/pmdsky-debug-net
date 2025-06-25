// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_REFLECT defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayReflectArray : KaitaiStruct
    {
        public static StatusIconArrayReflectArray FromFile(string fileName)
        {
            return new StatusIconArrayReflectArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayReflectArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayReflectArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayReflectArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayReflectArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayReflectArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayReflectArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayReflectArrayDim0(KaitaiStream p__io, StatusIconArrayReflectArray p__parent = null, StatusIconArrayReflectArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayReflectArray m_root;
            private StatusIconArrayReflectArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayReflectArray M_Root { get { return m_root; } }
            public StatusIconArrayReflectArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayReflectArrayDim0 _entries;
        private StatusIconArrayReflectArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayReflectArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayReflectArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
