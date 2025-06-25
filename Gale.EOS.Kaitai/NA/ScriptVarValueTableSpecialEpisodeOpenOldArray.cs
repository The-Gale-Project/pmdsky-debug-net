// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array script_var_value_table_special_episode_open_old defined within pmdsky.
    /// </summary>
    public partial class ScriptVarValueTableSpecialEpisodeOpenOldArray : KaitaiStruct
    {
        public static ScriptVarValueTableSpecialEpisodeOpenOldArray FromFile(string fileName)
        {
            return new ScriptVarValueTableSpecialEpisodeOpenOldArray(new KaitaiStream(fileName));
        }

        public ScriptVarValueTableSpecialEpisodeOpenOldArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarValueTableSpecialEpisodeOpenOldArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0 : KaitaiStruct
        {
            public static ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0 FromFile(string fileName)
            {
                return new ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0(KaitaiStream p__io, ScriptVarValueTableSpecialEpisodeOpenOldArray p__parent = null, ScriptVarValueTableSpecialEpisodeOpenOldArray p__root = null) : base(p__io)
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
            private ScriptVarValueTableSpecialEpisodeOpenOldArray m_root;
            private ScriptVarValueTableSpecialEpisodeOpenOldArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptVarValueTableSpecialEpisodeOpenOldArray M_Root { get { return m_root; } }
            public ScriptVarValueTableSpecialEpisodeOpenOldArray M_Parent { get { return m_parent; } }
        }
        private ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0 _entries;
        private ScriptVarValueTableSpecialEpisodeOpenOldArray m_root;
        private KaitaiStruct m_parent;
        public ScriptVarValueTableSpecialEpisodeOpenOldArrayDim0 Entries { get { return _entries; } }
        public ScriptVarValueTableSpecialEpisodeOpenOldArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
