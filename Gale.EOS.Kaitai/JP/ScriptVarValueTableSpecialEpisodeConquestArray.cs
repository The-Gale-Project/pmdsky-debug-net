// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_var_value_table_special_episode_conquest defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableSpecialEpisodeConquestArray : KaitaiStruct
    {
        public static ScriptVarValueTableSpecialEpisodeConquestArray FromFile(string fileName)
        {
            return new ScriptVarValueTableSpecialEpisodeConquestArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableSpecialEpisodeConquestArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableSpecialEpisodeConquestArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableSpecialEpisodeConquestArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableSpecialEpisodeConquestArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableSpecialEpisodeConquestArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableSpecialEpisodeConquestArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableSpecialEpisodeConquestArrayDim0(KaitaiStream p__io, ScriptVarValueTableSpecialEpisodeConquestArray p__parent = null, ScriptVarValueTableSpecialEpisodeConquestArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableSpecialEpisodeConquestArray m_root;
            private ScriptVarValueTableSpecialEpisodeConquestArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableSpecialEpisodeConquestArray M_Root { get { return m_root; } }
            public ScriptVarValueTableSpecialEpisodeConquestArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableSpecialEpisodeConquestArrayDim0 _entries;
        private ScriptVarValueTableSpecialEpisodeConquestArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableSpecialEpisodeConquestArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableSpecialEpisodeConquestArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
