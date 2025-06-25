// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SCRIPT_COMMAND_PARSING_DATA defined within pmdsky.
    /// </summary>
    public partial class ScriptCommandParsingDataArray : KaitaiStruct
    {
        public static ScriptCommandParsingDataArray FromFile(string fileName)
        {
            return new ScriptCommandParsingDataArray(new KaitaiStream(fileName));
        }

        public ScriptCommandParsingDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptCommandParsingDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptCommandParsingDataArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptCommandParsingDataArrayDim0 : KaitaiStruct
        {
            public static ScriptCommandParsingDataArrayDim0 FromFile(string fileName)
            {
                return new ScriptCommandParsingDataArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptCommandParsingDataArrayDim0(KaitaiStream p__io, ScriptCommandParsingDataArray p__parent = null, ScriptCommandParsingDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptCommandParsingDataArray m_root;
            private ScriptCommandParsingDataArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptCommandParsingDataArray M_Root { get { return m_root; } }
            public ScriptCommandParsingDataArray M_Parent { get { return m_parent; } }
        }
        private ScriptCommandParsingDataArrayDim0 _entries;
        private ScriptCommandParsingDataArray m_root;
        private KaitaiStruct m_parent;
        public ScriptCommandParsingDataArrayDim0 Entries { get { return _entries; } }
        public ScriptCommandParsingDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
