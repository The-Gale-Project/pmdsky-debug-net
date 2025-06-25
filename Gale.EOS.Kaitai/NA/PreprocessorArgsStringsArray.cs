// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array preprocessor_args_strings defined within pmdsky.
    /// </summary>
    public partial class PreprocessorArgsStringsArray : KaitaiStruct
    {
        public static PreprocessorArgsStringsArray FromFile(string fileName)
        {
            return new PreprocessorArgsStringsArray(new KaitaiStream(fileName));
        }

        public PreprocessorArgsStringsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PreprocessorArgsStringsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PreprocessorArgsStringsArrayDim0(m_io, this, m_root);
        }
        public partial class PreprocessorArgsStringsArrayDim0 : KaitaiStruct
        {
            public static PreprocessorArgsStringsArrayDim0 FromFile(string fileName)
            {
                return new PreprocessorArgsStringsArrayDim0(new KaitaiStream(fileName));
            }

            public PreprocessorArgsStringsArrayDim0(KaitaiStream p__io, PreprocessorArgsStringsArray p__parent = null, PreprocessorArgsStringsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private PreprocessorArgsStringsArray m_root;
            private PreprocessorArgsStringsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public PreprocessorArgsStringsArray M_Root { get { return m_root; } }
            public PreprocessorArgsStringsArray M_Parent { get { return m_parent; } }
        }
        private PreprocessorArgsStringsArrayDim0 _entries;
        private PreprocessorArgsStringsArray m_root;
        private KaitaiStruct m_parent;
        public PreprocessorArgsStringsArrayDim0 Entries { get { return _entries; } }
        public PreprocessorArgsStringsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
