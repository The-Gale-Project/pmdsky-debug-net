// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array UNOWN_SPECIES_ADDITIONAL_CHARS defined within pmdsky.
    /// </summary>
    public partial class UnownSpeciesAdditionalCharsArray : KaitaiStruct
    {
        public static UnownSpeciesAdditionalCharsArray FromFile(string fileName)
        {
            return new UnownSpeciesAdditionalCharsArray(new KaitaiStream(fileName));
        }

        public UnownSpeciesAdditionalCharsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, UnownSpeciesAdditionalCharsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new UnownSpeciesAdditionalCharsArrayDim0(m_io, this, m_root);
        }
        public partial class UnownSpeciesAdditionalCharsArrayDim0 : KaitaiStruct
        {
            public static UnownSpeciesAdditionalCharsArrayDim0 FromFile(string fileName)
            {
                return new UnownSpeciesAdditionalCharsArrayDim0(new KaitaiStream(fileName));
            }

            public UnownSpeciesAdditionalCharsArrayDim0(KaitaiStream p__io, UnownSpeciesAdditionalCharsArray p__parent = null, UnownSpeciesAdditionalCharsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId>();
                for (var i = 0; i < 28; i++)
                {
                    _entries.Add(new MonsterId(m_io));
                }
            }
            private List<MonsterId> _entries;
            private UnownSpeciesAdditionalCharsArray m_root;
            private UnownSpeciesAdditionalCharsArray m_parent;
            public List<MonsterId> Entries { get { return _entries; } }
            public UnownSpeciesAdditionalCharsArray M_Root { get { return m_root; } }
            public UnownSpeciesAdditionalCharsArray M_Parent { get { return m_parent; } }
        }
        private UnownSpeciesAdditionalCharsArrayDim0 _entries;
        private UnownSpeciesAdditionalCharsArray m_root;
        private KaitaiStruct m_parent;
        public UnownSpeciesAdditionalCharsArrayDim0 Entries { get { return _entries; } }
        public UnownSpeciesAdditionalCharsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
