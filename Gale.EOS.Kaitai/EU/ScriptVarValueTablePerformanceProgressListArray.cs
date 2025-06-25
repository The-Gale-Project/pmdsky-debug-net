// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array script_var_value_table_performance_progress_list defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTablePerformanceProgressListArray : KaitaiStruct
    {
        public static ScriptVarValueTablePerformanceProgressListArray FromFile(string fileName)
        {
            return new ScriptVarValueTablePerformanceProgressListArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTablePerformanceProgressListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTablePerformanceProgressListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTablePerformanceProgressListArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTablePerformanceProgressListArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTablePerformanceProgressListArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTablePerformanceProgressListArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTablePerformanceProgressListArrayDim0(KaitaiStream p__io, ScriptVarValueTablePerformanceProgressListArray p__parent = null, ScriptVarValueTablePerformanceProgressListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTablePerformanceProgressListArray m_root;
            private ScriptVarValueTablePerformanceProgressListArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTablePerformanceProgressListArray M_Root { get { return m_root; } }
            public ScriptVarValueTablePerformanceProgressListArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTablePerformanceProgressListArrayDim0 _entries;
        private ScriptVarValueTablePerformanceProgressListArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTablePerformanceProgressListArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTablePerformanceProgressListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
