// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array JOB_MENU_ITEMS_11 defined within pmdsky.
    /// </summary>
    public partial class JobMenuItems11Array : KaitaiStruct
    {
        public static JobMenuItems11Array FromFile(string fileName)
        {
            return new JobMenuItems11Array(new KaitaiStream(fileName));
        }

        public JobMenuItems11Array(KaitaiStream p__io, KaitaiStruct p__parent = null, JobMenuItems11Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new JobMenuItems11ArrayDim0(m_io, this, m_root);
        }
        public partial class JobMenuItems11ArrayDim0 : KaitaiStruct
        {
            public static JobMenuItems11ArrayDim0 FromFile(string fileName)
            {
                return new JobMenuItems11ArrayDim0(new KaitaiStream(fileName));
            }

            public JobMenuItems11ArrayDim0(KaitaiStream p__io, JobMenuItems11Array p__parent = null, JobMenuItems11Array p__root = null) : base(p__io)
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
            private JobMenuItems11Array m_root;
            private JobMenuItems11Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public JobMenuItems11Array M_Root { get { return m_root; } }
            public JobMenuItems11Array M_Parent { get { return m_parent; } }
        }
        private JobMenuItems11ArrayDim0 _entries;
        private JobMenuItems11Array m_root;
        private KaitaiStruct m_parent;
        public JobMenuItems11ArrayDim0 Entries { get { return _entries; } }
        public JobMenuItems11Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
