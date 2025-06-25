// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_SURE_SHOT defined within pmdsky.
    /// </summary>
    public partial class StatusIconArraySureShotArray : KaitaiStruct
    {
        public static StatusIconArraySureShotArray FromFile(string fileName)
        {
            return new StatusIconArraySureShotArray(new KaitaiStream(fileName));
        }

        public StatusIconArraySureShotArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArraySureShotArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArraySureShotArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArraySureShotArrayDim0 : KaitaiStruct
        {
            public static StatusIconArraySureShotArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArraySureShotArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArraySureShotArrayDim0(KaitaiStream p__io, StatusIconArraySureShotArray p__parent = null, StatusIconArraySureShotArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArraySureShotArray m_root;
            private StatusIconArraySureShotArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArraySureShotArray M_Root { get { return m_root; } }
            public StatusIconArraySureShotArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArraySureShotArrayDim0 _entries;
        private StatusIconArraySureShotArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArraySureShotArrayDim0 Entries { get { return _entries; } }
        public StatusIconArraySureShotArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
