// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MISSION_VALIDATION_FUNCTION_LIST defined within pmdsky.
    /// </summary>
    public partial class MissionValidationFunctionListArray : KaitaiStruct
    {
        public static MissionValidationFunctionListArray FromFile(string fileName)
        {
            return new MissionValidationFunctionListArray(new KaitaiStream(fileName));
        }

        public MissionValidationFunctionListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MissionValidationFunctionListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MissionValidationFunctionListArrayDim0(m_io, this, m_root);
        }
        public partial class MissionValidationFunctionListArrayDim0 : KaitaiStruct
        {
            public static MissionValidationFunctionListArrayDim0 FromFile(string fileName)
            {
                return new MissionValidationFunctionListArrayDim0(new KaitaiStream(fileName));
            }

            public MissionValidationFunctionListArrayDim0(KaitaiStream p__io, MissionValidationFunctionListArray p__parent = null, MissionValidationFunctionListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private MissionValidationFunctionListArray m_root;
            private MissionValidationFunctionListArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public MissionValidationFunctionListArray M_Root { get { return m_root; } }
            public MissionValidationFunctionListArray M_Parent { get { return m_parent; } }
        }
        private MissionValidationFunctionListArrayDim0 _entries;
        private MissionValidationFunctionListArray m_root;
        private KaitaiStruct m_parent;
        public MissionValidationFunctionListArrayDim0 Entries { get { return _entries; } }
        public MissionValidationFunctionListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
