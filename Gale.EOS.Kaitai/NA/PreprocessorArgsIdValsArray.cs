// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array preprocessor_args_id_vals defined within pmdsky.
    /// </summary>
    public partial class PreprocessorArgsIdValsArray : KaitaiStruct
    {
        public static PreprocessorArgsIdValsArray FromFile(string fileName)
        {
            return new PreprocessorArgsIdValsArray(new KaitaiStream(fileName));
        }

        public PreprocessorArgsIdValsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PreprocessorArgsIdValsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PreprocessorArgsIdValsArrayDim0(m_io, this, m_root);
        }
        public partial class PreprocessorArgsIdValsArrayDim0 : KaitaiStruct
        {
            public static PreprocessorArgsIdValsArrayDim0 FromFile(string fileName)
            {
                return new PreprocessorArgsIdValsArrayDim0(new KaitaiStream(fileName));
            }

            public PreprocessorArgsIdValsArrayDim0(KaitaiStream p__io, PreprocessorArgsIdValsArray p__parent = null, PreprocessorArgsIdValsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private PreprocessorArgsIdValsArray m_root;
            private PreprocessorArgsIdValsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public PreprocessorArgsIdValsArray M_Root { get { return m_root; } }
            public PreprocessorArgsIdValsArray M_Parent { get { return m_parent; } }
        }
        private PreprocessorArgsIdValsArrayDim0 _entries;
        private PreprocessorArgsIdValsArray m_root;
        private KaitaiStruct m_parent;
        public PreprocessorArgsIdValsArrayDim0 Entries { get { return _entries; } }
        public PreprocessorArgsIdValsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
