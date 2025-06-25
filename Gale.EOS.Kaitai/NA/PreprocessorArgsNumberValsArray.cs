// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array preprocessor_args_number_vals defined within pmdsky.
    /// </summary>
    public partial class PreprocessorArgsNumberValsArray : KaitaiStruct
    {
        public static PreprocessorArgsNumberValsArray FromFile(string fileName)
        {
            return new PreprocessorArgsNumberValsArray(new KaitaiStream(fileName));
        }

        public PreprocessorArgsNumberValsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PreprocessorArgsNumberValsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PreprocessorArgsNumberValsArrayDim0(m_io, this, m_root);
        }
        public partial class PreprocessorArgsNumberValsArrayDim0 : KaitaiStruct
        {
            public static PreprocessorArgsNumberValsArrayDim0 FromFile(string fileName)
            {
                return new PreprocessorArgsNumberValsArrayDim0(new KaitaiStream(fileName));
            }

            public PreprocessorArgsNumberValsArrayDim0(KaitaiStream p__io, PreprocessorArgsNumberValsArray p__parent = null, PreprocessorArgsNumberValsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private PreprocessorArgsNumberValsArray m_root;
            private PreprocessorArgsNumberValsArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public PreprocessorArgsNumberValsArray M_Root { get { return m_root; } }
            public PreprocessorArgsNumberValsArray M_Parent { get { return m_parent; } }
        }
        private PreprocessorArgsNumberValsArrayDim0 _entries;
        private PreprocessorArgsNumberValsArray m_root;
        private KaitaiStruct m_parent;
        public PreprocessorArgsNumberValsArrayDim0 Entries { get { return _entries; } }
        public PreprocessorArgsNumberValsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
