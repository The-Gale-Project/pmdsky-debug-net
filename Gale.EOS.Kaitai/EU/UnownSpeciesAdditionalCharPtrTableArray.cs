// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array UNOWN_SPECIES_ADDITIONAL_CHAR_PTR_TABLE defined within pmdsky.
    /// </summary>
    public partial class UnownSpeciesAdditionalCharPtrTableArray : KaitaiStruct
    {
        public static UnownSpeciesAdditionalCharPtrTableArray FromFile(string fileName)
        {
            return new UnownSpeciesAdditionalCharPtrTableArray(new KaitaiStream(fileName));
        }

        public UnownSpeciesAdditionalCharPtrTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, UnownSpeciesAdditionalCharPtrTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new UnownSpeciesAdditionalCharPtrTableArrayDim0(m_io, this, m_root);
        }
        public partial class UnownSpeciesAdditionalCharPtrTableArrayDim0 : KaitaiStruct
        {
            public static UnownSpeciesAdditionalCharPtrTableArrayDim0 FromFile(string fileName)
            {
                return new UnownSpeciesAdditionalCharPtrTableArrayDim0(new KaitaiStream(fileName));
            }

            public UnownSpeciesAdditionalCharPtrTableArrayDim0(KaitaiStream p__io, UnownSpeciesAdditionalCharPtrTableArray p__parent = null, UnownSpeciesAdditionalCharPtrTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 28; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private UnownSpeciesAdditionalCharPtrTableArray m_root;
            private UnownSpeciesAdditionalCharPtrTableArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public UnownSpeciesAdditionalCharPtrTableArray M_Root { get { return m_root; } }
            public UnownSpeciesAdditionalCharPtrTableArray M_Parent { get { return m_parent; } }
        }
        private UnownSpeciesAdditionalCharPtrTableArrayDim0 _entries;
        private UnownSpeciesAdditionalCharPtrTableArray m_root;
        private KaitaiStruct m_parent;
        public UnownSpeciesAdditionalCharPtrTableArrayDim0 Entries { get { return _entries; } }
        public UnownSpeciesAdditionalCharPtrTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
