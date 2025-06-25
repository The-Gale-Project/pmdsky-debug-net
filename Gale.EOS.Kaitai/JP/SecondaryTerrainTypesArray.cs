// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array SECONDARY_TERRAIN_TYPES defined within pmdsky.
    /// </summary>
    public partial class SecondaryTerrainTypesArray : KaitaiStruct
    {
        public static SecondaryTerrainTypesArray FromFile(string fileName)
        {
            return new SecondaryTerrainTypesArray(new KaitaiStream(fileName));
        }

        public SecondaryTerrainTypesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SecondaryTerrainTypesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SecondaryTerrainTypesArrayDim0(m_io, this, m_root);
        }
        public partial class SecondaryTerrainTypesArrayDim0 : KaitaiStruct
        {
            public static SecondaryTerrainTypesArrayDim0 FromFile(string fileName)
            {
                return new SecondaryTerrainTypesArrayDim0(new KaitaiStream(fileName));
            }

            public SecondaryTerrainTypesArrayDim0(KaitaiStream p__io, SecondaryTerrainTypesArray p__parent = null, SecondaryTerrainTypesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SecondaryTerrainType8>();
                for (var i = 0; i < 200; i++)
                {
                    _entries.Add(new SecondaryTerrainType8(m_io));
                }
            }
            private List<SecondaryTerrainType8> _entries;
            private SecondaryTerrainTypesArray m_root;
            private SecondaryTerrainTypesArray m_parent;
            public List<SecondaryTerrainType8> Entries { get { return _entries; } }
            public SecondaryTerrainTypesArray M_Root { get { return m_root; } }
            public SecondaryTerrainTypesArray M_Parent { get { return m_parent; } }
        }
        private SecondaryTerrainTypesArrayDim0 _entries;
        private SecondaryTerrainTypesArray m_root;
        private KaitaiStruct m_parent;
        public SecondaryTerrainTypesArrayDim0 Entries { get { return _entries; } }
        public SecondaryTerrainTypesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
