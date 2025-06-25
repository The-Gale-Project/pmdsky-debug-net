// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array JOB_MENU_ITEMS_10 defined within pmdsky.
    /// </summary>
    public partial class JobMenuItems10Array : KaitaiStruct
    {
        public static JobMenuItems10Array FromFile(string fileName)
        {
            return new JobMenuItems10Array(new KaitaiStream(fileName));
        }

        public JobMenuItems10Array(KaitaiStream p__io, KaitaiStruct p__parent = null, JobMenuItems10Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new JobMenuItems10ArrayDim0(m_io, this, m_root);
        }
        public partial class JobMenuItems10ArrayDim0 : KaitaiStruct
        {
            public static JobMenuItems10ArrayDim0 FromFile(string fileName)
            {
                return new JobMenuItems10ArrayDim0(new KaitaiStream(fileName));
            }

            public JobMenuItems10ArrayDim0(KaitaiStream p__io, JobMenuItems10Array p__parent = null, JobMenuItems10Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private JobMenuItems10Array m_root;
            private JobMenuItems10Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public JobMenuItems10Array M_Root { get { return m_root; } }
            public JobMenuItems10Array M_Parent { get { return m_parent; } }
        }
        private JobMenuItems10ArrayDim0 _entries;
        private JobMenuItems10Array m_root;
        private KaitaiStruct m_parent;
        public JobMenuItems10ArrayDim0 Entries { get { return _entries; } }
        public JobMenuItems10Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
