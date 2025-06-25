// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_special_episode_open defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableSpecialEpisodeOpenArray : KaitaiStruct
    {
        public static ScriptVarValueTableSpecialEpisodeOpenArray FromFile(string fileName)
        {
            return new ScriptVarValueTableSpecialEpisodeOpenArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableSpecialEpisodeOpenArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableSpecialEpisodeOpenArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableSpecialEpisodeOpenArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableSpecialEpisodeOpenArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableSpecialEpisodeOpenArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableSpecialEpisodeOpenArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableSpecialEpisodeOpenArrayDim0(KaitaiStream p__io, ScriptVarValueTableSpecialEpisodeOpenArray p__parent = null, ScriptVarValueTableSpecialEpisodeOpenArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 1; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptVarValueTableSpecialEpisodeOpenArray m_root;
            private ScriptVarValueTableSpecialEpisodeOpenArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableSpecialEpisodeOpenArray M_Root { get { return m_root; } }
            public ScriptVarValueTableSpecialEpisodeOpenArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableSpecialEpisodeOpenArrayDim0 _entries;
        private ScriptVarValueTableSpecialEpisodeOpenArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableSpecialEpisodeOpenArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableSpecialEpisodeOpenArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
