// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array IQ_SKILLS defined within pmdsky.
    /// </summary>
    public partial class IqSkillsArray : KaitaiStruct
    {
        public static IqSkillsArray FromFile(string fileName)
        {
            return new IqSkillsArray(new KaitaiStream(fileName));
        }

        public IqSkillsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, IqSkillsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new IqSkillsArrayDim0(m_io, this, m_root);
        }
        public partial class IqSkillsArrayDim0 : KaitaiStruct
        {
            public static IqSkillsArrayDim0 FromFile(string fileName)
            {
                return new IqSkillsArrayDim0(new KaitaiStream(fileName));
            }

            public IqSkillsArrayDim0(KaitaiStream p__io, IqSkillsArray p__parent = null, IqSkillsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 69; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private IqSkillsArray m_root;
            private IqSkillsArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public IqSkillsArray M_Root { get { return m_root; } }
            public IqSkillsArray M_Parent { get { return m_parent; } }
        }
        private IqSkillsArrayDim0 _entries;
        private IqSkillsArray m_root;
        private KaitaiStruct m_parent;
        public IqSkillsArrayDim0 Entries { get { return _entries; } }
        public IqSkillsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
