// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array C_ROUTINE_NAMES defined within pmdsky.
    /// </summary>
    public partial class CRoutineNamesArray : KaitaiStruct
    {
        public static CRoutineNamesArray FromFile(string fileName)
        {
            return new CRoutineNamesArray(new KaitaiStream(fileName));
        }

        public CRoutineNamesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, CRoutineNamesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new CRoutineNamesArrayDim0(m_io, this, m_root);
        }
        public partial class CRoutineNamesArrayDim0 : KaitaiStruct
        {
            public static CRoutineNamesArrayDim0 FromFile(string fileName)
            {
                return new CRoutineNamesArrayDim0(new KaitaiStream(fileName));
            }

            public CRoutineNamesArrayDim0(KaitaiStream p__io, CRoutineNamesArray p__parent = null, CRoutineNamesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 0; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private CRoutineNamesArray m_root;
            private CRoutineNamesArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public CRoutineNamesArray M_Root { get { return m_root; } }
            public CRoutineNamesArray M_Parent { get { return m_parent; } }
        }
        private CRoutineNamesArrayDim0 _entries;
        private CRoutineNamesArray m_root;
        private KaitaiStruct m_parent;
        public CRoutineNamesArrayDim0 Entries { get { return _entries; } }
        public CRoutineNamesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
