// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array SENTRY_DUTY_MONSTER_IDS defined within pmdsky.
    /// </summary>
    public partial class SentryDutyMonsterIdsArray : KaitaiStruct
    {
        public static SentryDutyMonsterIdsArray FromFile(string fileName)
        {
            return new SentryDutyMonsterIdsArray(new KaitaiStream(fileName));
        }

        public SentryDutyMonsterIdsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryDutyMonsterIdsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SentryDutyMonsterIdsArrayDim0(m_io, this, m_root);
        }
        public partial class SentryDutyMonsterIdsArrayDim0 : KaitaiStruct
        {
            public static SentryDutyMonsterIdsArrayDim0 FromFile(string fileName)
            {
                return new SentryDutyMonsterIdsArrayDim0(new KaitaiStream(fileName));
            }

            public SentryDutyMonsterIdsArrayDim0(KaitaiStream p__io, SentryDutyMonsterIdsArray p__parent = null, SentryDutyMonsterIdsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 102; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private SentryDutyMonsterIdsArray m_root;
            private SentryDutyMonsterIdsArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public SentryDutyMonsterIdsArray M_Root { get { return m_root; } }
            public SentryDutyMonsterIdsArray M_Parent { get { return m_parent; } }
        }
        private SentryDutyMonsterIdsArrayDim0 _entries;
        private SentryDutyMonsterIdsArray m_root;
        private KaitaiStruct m_parent;
        public SentryDutyMonsterIdsArrayDim0 Entries { get { return _entries; } }
        public SentryDutyMonsterIdsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
