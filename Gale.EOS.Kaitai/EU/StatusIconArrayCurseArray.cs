// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_CURSE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayCurseArray : KaitaiStruct
    {
        public static StatusIconArrayCurseArray FromFile(string fileName)
        {
            return new StatusIconArrayCurseArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayCurseArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayCurseArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayCurseArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayCurseArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayCurseArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayCurseArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayCurseArrayDim0(KaitaiStream p__io, StatusIconArrayCurseArray p__parent = null, StatusIconArrayCurseArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 7; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayCurseArray m_root;
            private StatusIconArrayCurseArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayCurseArray M_Root { get { return m_root; } }
            public StatusIconArrayCurseArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayCurseArrayDim0 _entries;
        private StatusIconArrayCurseArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayCurseArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayCurseArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
