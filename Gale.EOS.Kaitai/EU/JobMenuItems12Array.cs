// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array JOB_MENU_ITEMS_12 defined within pmdsky.
    /// </summary>
    public partial class JobMenuItems12Array : KaitaiStruct
    {
        public static JobMenuItems12Array FromFile(string fileName)
        {
            return new JobMenuItems12Array(new KaitaiStream(fileName));
        }

        public JobMenuItems12Array(KaitaiStream p__io, KaitaiStruct p__parent = null, JobMenuItems12Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new JobMenuItems12ArrayDim0(m_io, this, m_root);
        }
        public partial class JobMenuItems12ArrayDim0 : KaitaiStruct
        {
            public static JobMenuItems12ArrayDim0 FromFile(string fileName)
            {
                return new JobMenuItems12ArrayDim0(new KaitaiStream(fileName));
            }

            public JobMenuItems12ArrayDim0(KaitaiStream p__io, JobMenuItems12Array p__parent = null, JobMenuItems12Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private JobMenuItems12Array m_root;
            private JobMenuItems12Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public JobMenuItems12Array M_Root { get { return m_root; } }
            public JobMenuItems12Array M_Parent { get { return m_parent; } }
        }
        private JobMenuItems12ArrayDim0 _entries;
        private JobMenuItems12Array m_root;
        private KaitaiStruct m_parent;
        public JobMenuItems12ArrayDim0 Entries { get { return _entries; } }
        public JobMenuItems12Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
