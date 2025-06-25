// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array LOCK_NOTIFY_ARRAY defined within pmdsky.
    /// </summary>
    public partial class LockNotifyArrayArray : KaitaiStruct
    {
        public static LockNotifyArrayArray FromFile(string fileName)
        {
            return new LockNotifyArrayArray(new KaitaiStream(fileName));
        }

        public LockNotifyArrayArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LockNotifyArrayArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LockNotifyArrayArrayDim0(m_io, this, m_root);
        }
        public partial class LockNotifyArrayArrayDim0 : KaitaiStruct
        {
            public static LockNotifyArrayArrayDim0 FromFile(string fileName)
            {
                return new LockNotifyArrayArrayDim0(new KaitaiStream(fileName));
            }

            public LockNotifyArrayArrayDim0(KaitaiStream p__io, LockNotifyArrayArray p__parent = null, LockNotifyArrayArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private LockNotifyArrayArray m_root;
            private LockNotifyArrayArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public LockNotifyArrayArray M_Root { get { return m_root; } }
            public LockNotifyArrayArray M_Parent { get { return m_parent; } }
        }
        private LockNotifyArrayArrayDim0 _entries;
        private LockNotifyArrayArray m_root;
        private KaitaiStruct m_parent;
        public LockNotifyArrayArrayDim0 Entries { get { return _entries; } }
        public LockNotifyArrayArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
