// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_BIDE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayBideArray : KaitaiStruct
    {
        public static StatusIconArrayBideArray FromFile(string fileName)
        {
            return new StatusIconArrayBideArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayBideArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayBideArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayBideArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayBideArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayBideArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayBideArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayBideArrayDim0(KaitaiStream p__io, StatusIconArrayBideArray p__parent = null, StatusIconArrayBideArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 14; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayBideArray m_root;
            private StatusIconArrayBideArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayBideArray M_Root { get { return m_root; } }
            public StatusIconArrayBideArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayBideArrayDim0 _entries;
        private StatusIconArrayBideArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayBideArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayBideArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
