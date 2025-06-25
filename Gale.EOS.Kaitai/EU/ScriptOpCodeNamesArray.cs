// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SCRIPT_OP_CODE_NAMES defined within pmdsky.
    /// </summary>
    public partial class ScriptOpCodeNamesArray : KaitaiStruct
    {
        public static ScriptOpCodeNamesArray FromFile(string fileName)
        {
            return new ScriptOpCodeNamesArray(new KaitaiStream(fileName));
        }

        public ScriptOpCodeNamesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptOpCodeNamesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptOpCodeNamesArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptOpCodeNamesArrayDim0 : KaitaiStruct
        {
            public static ScriptOpCodeNamesArrayDim0 FromFile(string fileName)
            {
                return new ScriptOpCodeNamesArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptOpCodeNamesArrayDim0(KaitaiStream p__io, ScriptOpCodeNamesArray p__parent = null, ScriptOpCodeNamesArray p__root = null) : base(p__io)
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
            private ScriptOpCodeNamesArray m_root;
            private ScriptOpCodeNamesArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public ScriptOpCodeNamesArray M_Root { get { return m_root; } }
            public ScriptOpCodeNamesArray M_Parent { get { return m_parent; } }
        }
        private ScriptOpCodeNamesArrayDim0 _entries;
        private ScriptOpCodeNamesArray m_root;
        private KaitaiStruct m_parent;
        public ScriptOpCodeNamesArrayDim0 Entries { get { return _entries; } }
        public ScriptOpCodeNamesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
