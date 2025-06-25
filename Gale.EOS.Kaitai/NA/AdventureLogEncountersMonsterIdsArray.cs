// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ADVENTURE_LOG_ENCOUNTERS_MONSTER_IDS defined within pmdsky.
    /// </summary>
    public partial class AdventureLogEncountersMonsterIdsArray : KaitaiStruct
    {
        public static AdventureLogEncountersMonsterIdsArray FromFile(string fileName)
        {
            return new AdventureLogEncountersMonsterIdsArray(new KaitaiStream(fileName));
        }

        public AdventureLogEncountersMonsterIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AdventureLogEncountersMonsterIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AdventureLogEncountersMonsterIdsArrayDim0(m_io, this, m_root);
        }
        public partial class AdventureLogEncountersMonsterIdsArrayDim0 : KaitaiStruct
        {
            public static AdventureLogEncountersMonsterIdsArrayDim0 FromFile(string fileName)
            {
                return new AdventureLogEncountersMonsterIdsArrayDim0(new KaitaiStream(fileName));
            }

            public AdventureLogEncountersMonsterIdsArrayDim0(KaitaiStream p__io, AdventureLogEncountersMonsterIdsArray p__parent = null, AdventureLogEncountersMonsterIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 38; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private AdventureLogEncountersMonsterIdsArray m_root;
            private AdventureLogEncountersMonsterIdsArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public AdventureLogEncountersMonsterIdsArray M_Root { get { return m_root; } }
            public AdventureLogEncountersMonsterIdsArray M_Parent { get { return m_parent; } }
        }
        private AdventureLogEncountersMonsterIdsArrayDim0 _entries;
        private AdventureLogEncountersMonsterIdsArray m_root;
        private KaitaiStruct m_parent;
        public AdventureLogEncountersMonsterIdsArrayDim0 Entries { get { return _entries; } }
        public AdventureLogEncountersMonsterIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
