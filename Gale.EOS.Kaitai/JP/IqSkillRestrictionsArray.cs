// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array IQ_SKILL_RESTRICTIONS defined within pmdsky.
    /// </summary>
    public partial class IqSkillRestrictionsArray : KaitaiStruct
    {
        public static IqSkillRestrictionsArray FromFile(string fileName)
        {
            return new IqSkillRestrictionsArray(new KaitaiStream(fileName));
        }

        public IqSkillRestrictionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, IqSkillRestrictionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new IqSkillRestrictionsArrayDim0(m_io, this, m_root);
        }
        public partial class IqSkillRestrictionsArrayDim0 : KaitaiStruct
        {
            public static IqSkillRestrictionsArrayDim0 FromFile(string fileName)
            {
                return new IqSkillRestrictionsArrayDim0(new KaitaiStream(fileName));
            }

            public IqSkillRestrictionsArrayDim0(KaitaiStream p__io, IqSkillRestrictionsArray p__parent = null, IqSkillRestrictionsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 69; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private IqSkillRestrictionsArray m_root;
            private IqSkillRestrictionsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public IqSkillRestrictionsArray M_Root { get { return m_root; } }
            public IqSkillRestrictionsArray M_Parent { get { return m_parent; } }
        }
        private IqSkillRestrictionsArrayDim0 _entries;
        private IqSkillRestrictionsArray m_root;
        private KaitaiStruct m_parent;
        public IqSkillRestrictionsArrayDim0 Entries { get { return _entries; } }
        public IqSkillRestrictionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
