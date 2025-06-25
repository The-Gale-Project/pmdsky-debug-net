// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array preprocessor_args_flag_vals defined within pmdsky.
    /// </summary>
    public partial class PreprocessorArgsFlagValsArray : KaitaiStruct
    {
        public static PreprocessorArgsFlagValsArray FromFile(string fileName)
        {
            return new PreprocessorArgsFlagValsArray(new KaitaiStream(fileName));
        }

        public PreprocessorArgsFlagValsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PreprocessorArgsFlagValsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PreprocessorArgsFlagValsArrayDim0(m_io, this, m_root);
        }
        public partial class PreprocessorArgsFlagValsArrayDim0 : KaitaiStruct
        {
            public static PreprocessorArgsFlagValsArrayDim0 FromFile(string fileName)
            {
                return new PreprocessorArgsFlagValsArrayDim0(new KaitaiStream(fileName));
            }

            public PreprocessorArgsFlagValsArrayDim0(KaitaiStream p__io, PreprocessorArgsFlagValsArray p__parent = null, PreprocessorArgsFlagValsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private PreprocessorArgsFlagValsArray m_root;
            private PreprocessorArgsFlagValsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public PreprocessorArgsFlagValsArray M_Root { get { return m_root; } }
            public PreprocessorArgsFlagValsArray M_Parent { get { return m_parent; } }
        }
        private PreprocessorArgsFlagValsArrayDim0 _entries;
        private PreprocessorArgsFlagValsArray m_root;
        private KaitaiStruct m_parent;
        public PreprocessorArgsFlagValsArrayDim0 Entries { get { return _entries; } }
        public PreprocessorArgsFlagValsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
