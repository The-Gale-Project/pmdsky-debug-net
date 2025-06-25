// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array common_routine_table_routines defined within pmdsky.
    /// </summary>
    public partial class CommonRoutineTableRoutinesArray : KaitaiStruct
    {
        public static CommonRoutineTableRoutinesArray FromFile(string fileName)
        {
            return new CommonRoutineTableRoutinesArray(new KaitaiStream(fileName));
        }

        public CommonRoutineTableRoutinesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, CommonRoutineTableRoutinesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new CommonRoutineTableRoutinesArrayDim0(m_io, this, m_root);
        }
        public partial class CommonRoutineTableRoutinesArrayDim0 : KaitaiStruct
        {
            public static CommonRoutineTableRoutinesArrayDim0 FromFile(string fileName)
            {
                return new CommonRoutineTableRoutinesArrayDim0(new KaitaiStream(fileName));
            }

            public CommonRoutineTableRoutinesArrayDim0(KaitaiStream p__io, CommonRoutineTableRoutinesArray p__parent = null, CommonRoutineTableRoutinesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<CommonRoutine>();
                for (var i = 0; i < 701; i++)
                {
                    _entries.Add(new CommonRoutine(m_io));
                }
            }
            private List<CommonRoutine> _entries;
            private CommonRoutineTableRoutinesArray m_root;
            private CommonRoutineTableRoutinesArray m_parent;
            public List<CommonRoutine> Entries { get { return _entries; } }
            public CommonRoutineTableRoutinesArray M_Root { get { return m_root; } }
            public CommonRoutineTableRoutinesArray M_Parent { get { return m_parent; } }
        }
        private CommonRoutineTableRoutinesArrayDim0 _entries;
        private CommonRoutineTableRoutinesArray m_root;
        private KaitaiStruct m_parent;
        public CommonRoutineTableRoutinesArrayDim0 Entries { get { return _entries; } }
        public CommonRoutineTableRoutinesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
