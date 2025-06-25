// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array IQ_GROUP_SKILLS defined within pmdsky.
    /// </summary>
    public partial class IqGroupSkillsArray : KaitaiStruct
    {
        public static IqGroupSkillsArray FromFile(string fileName)
        {
            return new IqGroupSkillsArray(new KaitaiStream(fileName));
        }

        public IqGroupSkillsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, IqGroupSkillsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new IqGroupSkillsArrayDim0(m_io, this, m_root);
        }
        public partial class IqGroupSkillsArrayDim0 : KaitaiStruct
        {
            public static IqGroupSkillsArrayDim0 FromFile(string fileName)
            {
                return new IqGroupSkillsArrayDim0(new KaitaiStream(fileName));
            }

            public IqGroupSkillsArrayDim0(KaitaiStream p__io, IqGroupSkillsArray p__parent = null, IqGroupSkillsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 400; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private IqGroupSkillsArray m_root;
            private IqGroupSkillsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public IqGroupSkillsArray M_Root { get { return m_root; } }
            public IqGroupSkillsArray M_Parent { get { return m_parent; } }
        }
        private IqGroupSkillsArrayDim0 _entries;
        private IqGroupSkillsArray m_root;
        private KaitaiStruct m_parent;
        public IqGroupSkillsArrayDim0 Entries { get { return _entries; } }
        public IqGroupSkillsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
