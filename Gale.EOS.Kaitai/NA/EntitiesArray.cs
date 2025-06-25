// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ENTITIES defined within pmdsky.
    /// </summary>
    public partial class EntitiesArray : KaitaiStruct
    {
        public static EntitiesArray FromFile(string fileName)
        {
            return new EntitiesArray(new KaitaiStream(fileName));
        }

        public EntitiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EntitiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EntitiesArrayDim0(m_io, this, m_root);
        }
        public partial class EntitiesArrayDim0 : KaitaiStruct
        {
            public static EntitiesArrayDim0 FromFile(string fileName)
            {
                return new EntitiesArrayDim0(new KaitaiStream(fileName));
            }

            public EntitiesArrayDim0(KaitaiStream p__io, EntitiesArray p__parent = null, EntitiesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ScriptEntity>();
                for (var i = 0; i < 386; i++)
                {
                    _entries.Add(new ScriptEntity(m_io));
                }
            }
            private List<ScriptEntity> _entries;
            private EntitiesArray m_root;
            private EntitiesArray m_parent;
            public List<ScriptEntity> Entries { get { return _entries; } }
            public EntitiesArray M_Root { get { return m_root; } }
            public EntitiesArray M_Parent { get { return m_parent; } }
        }
        private EntitiesArrayDim0 _entries;
        private EntitiesArray m_root;
        private KaitaiStruct m_parent;
        public EntitiesArrayDim0 Entries { get { return _entries; } }
        public EntitiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
