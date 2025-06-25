// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_opcode_table_ops defined within pmdsky.
    /// </summary>
    public partial class ScriptOpcodeTableOpsArray : KaitaiStruct
    {
        public static ScriptOpcodeTableOpsArray FromFile(string fileName)
        {
            return new ScriptOpcodeTableOpsArray(new KaitaiStream(fileName));
        }

        public ScriptOpcodeTableOpsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptOpcodeTableOpsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptOpcodeTableOpsArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptOpcodeTableOpsArrayDim0 : KaitaiStruct
        {
            public static ScriptOpcodeTableOpsArrayDim0 FromFile(string fileName)
            {
                return new ScriptOpcodeTableOpsArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptOpcodeTableOpsArrayDim0(KaitaiStream p__io, ScriptOpcodeTableOpsArray p__parent = null, ScriptOpcodeTableOpsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ScriptOpcode>();
                for (var i = 0; i < 383; i++)
                {
                    _entries.Add(new ScriptOpcode(m_io));
                }
            }
            private List<ScriptOpcode> _entries;
            private ScriptOpcodeTableOpsArray m_root;
            private ScriptOpcodeTableOpsArray m_parent;
            public List<ScriptOpcode> Entries { get { return _entries; } }
            public ScriptOpcodeTableOpsArray M_Root { get { return m_root; } }
            public ScriptOpcodeTableOpsArray M_Parent { get { return m_parent; } }
        }
        private ScriptOpcodeTableOpsArrayDim0 _entries;
        private ScriptOpcodeTableOpsArray m_root;
        private KaitaiStruct m_parent;
        public ScriptOpcodeTableOpsArrayDim0 Entries { get { return _entries; } }
        public ScriptOpcodeTableOpsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
