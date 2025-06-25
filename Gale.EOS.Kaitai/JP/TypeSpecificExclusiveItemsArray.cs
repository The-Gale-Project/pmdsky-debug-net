// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array TYPE_SPECIFIC_EXCLUSIVE_ITEMS defined within pmdsky.
    /// </summary>
    public partial class TypeSpecificExclusiveItemsArray : KaitaiStruct
    {
        public static TypeSpecificExclusiveItemsArray FromFile(string fileName)
        {
            return new TypeSpecificExclusiveItemsArray(new KaitaiStream(fileName));
        }

        public TypeSpecificExclusiveItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeSpecificExclusiveItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TypeSpecificExclusiveItemsArrayDim1(m_io, this, m_root);
        }
        public partial class TypeSpecificExclusiveItemsArrayDim0 : KaitaiStruct
        {
            public static TypeSpecificExclusiveItemsArrayDim0 FromFile(string fileName)
            {
                return new TypeSpecificExclusiveItemsArrayDim0(new KaitaiStream(fileName));
            }

            public TypeSpecificExclusiveItemsArrayDim0(KaitaiStream p__io, TypeSpecificExclusiveItemsArray.TypeSpecificExclusiveItemsArrayDim1 p__parent = null, TypeSpecificExclusiveItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private TypeSpecificExclusiveItemsArray m_root;
            private TypeSpecificExclusiveItemsArray.TypeSpecificExclusiveItemsArrayDim1 m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public TypeSpecificExclusiveItemsArray M_Root { get { return m_root; } }
            public TypeSpecificExclusiveItemsArray.TypeSpecificExclusiveItemsArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class TypeSpecificExclusiveItemsArrayDim1 : KaitaiStruct
        {
            public static TypeSpecificExclusiveItemsArrayDim1 FromFile(string fileName)
            {
                return new TypeSpecificExclusiveItemsArrayDim1(new KaitaiStream(fileName));
            }

            public TypeSpecificExclusiveItemsArrayDim1(KaitaiStream p__io, TypeSpecificExclusiveItemsArray p__parent = null, TypeSpecificExclusiveItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeSpecificExclusiveItemsArrayDim0>();
                for (var i = 0; i < 17; i++)
                {
                    _entries.Add(new TypeSpecificExclusiveItemsArrayDim0(m_io, this, m_root));
                }
            }
            private List<TypeSpecificExclusiveItemsArrayDim0> _entries;
            private TypeSpecificExclusiveItemsArray m_root;
            private TypeSpecificExclusiveItemsArray m_parent;
            public List<TypeSpecificExclusiveItemsArrayDim0> Entries { get { return _entries; } }
            public TypeSpecificExclusiveItemsArray M_Root { get { return m_root; } }
            public TypeSpecificExclusiveItemsArray M_Parent { get { return m_parent; } }
        }
        private TypeSpecificExclusiveItemsArrayDim1 _entries;
        private TypeSpecificExclusiveItemsArray m_root;
        private KaitaiStruct m_parent;
        public TypeSpecificExclusiveItemsArrayDim1 Entries { get { return _entries; } }
        public TypeSpecificExclusiveItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
