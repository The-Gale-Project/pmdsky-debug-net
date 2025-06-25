// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array statuses_original_types defined within pmdsky.
    /// </summary>
    public partial class StatusesOriginalTypesArray : KaitaiStruct
    {
        public static StatusesOriginalTypesArray FromFile(string fileName)
        {
            return new StatusesOriginalTypesArray(new KaitaiStream(fileName));
        }

        public StatusesOriginalTypesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusesOriginalTypesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusesOriginalTypesArrayDim0(m_io, this, m_root);
        }
        public partial class StatusesOriginalTypesArrayDim0 : KaitaiStruct
        {
            public static StatusesOriginalTypesArrayDim0 FromFile(string fileName)
            {
                return new StatusesOriginalTypesArrayDim0(new KaitaiStream(fileName));
            }

            public StatusesOriginalTypesArrayDim0(KaitaiStream p__io, StatusesOriginalTypesArray p__parent = null, StatusesOriginalTypesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeId8>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new TypeId8(m_io));
                }
            }
            private List<TypeId8> _entries;
            private StatusesOriginalTypesArray m_root;
            private StatusesOriginalTypesArray m_parent;
            public List<TypeId8> Entries { get { return _entries; } }
            public StatusesOriginalTypesArray M_Root { get { return m_root; } }
            public StatusesOriginalTypesArray M_Parent { get { return m_parent; } }
        }
        private StatusesOriginalTypesArrayDim0 _entries;
        private StatusesOriginalTypesArray m_root;
        private KaitaiStruct m_parent;
        public StatusesOriginalTypesArrayDim0 Entries { get { return _entries; } }
        public StatusesOriginalTypesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
