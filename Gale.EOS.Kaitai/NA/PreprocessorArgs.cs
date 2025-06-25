// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union preprocessor_args defined within pmdsky-debug.
    /// </summary>
    public partial class PreprocessorArgs : KaitaiStruct
    {
        public static PreprocessorArgs FromFile(string fileName)
        {
            return new PreprocessorArgs(new KaitaiStream(fileName));
        }

        public PreprocessorArgs(KaitaiStream p__io, KaitaiStruct p__parent = null, PreprocessorArgs p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _flagVals = new PreprocessorArgsFlagValsArray(m_io);
            _idVals = new PreprocessorArgsIdValsArray(m_io);
            _numberVals = new PreprocessorArgsNumberValsArray(m_io);
            _strings = new PreprocessorArgsStringsArray(m_io);
            _speakerId = m_io.ReadU4le();
        }
        private PreprocessorArgsFlagValsArray _flagVals;
        private PreprocessorArgsIdValsArray _idVals;
        private PreprocessorArgsNumberValsArray _numberVals;
        private PreprocessorArgsStringsArray _strings;
        private uint _speakerId;
        private PreprocessorArgs m_root;
        private KaitaiStruct m_parent;
        public PreprocessorArgsFlagValsArray FlagVals { get { return _flagVals; } }
        public PreprocessorArgsIdValsArray IdVals { get { return _idVals; } }
        public PreprocessorArgsNumberValsArray NumberVals { get { return _numberVals; } }
        public PreprocessorArgsStringsArray Strings { get { return _strings; } }
        public uint SpeakerId { get { return _speakerId; } }
        public PreprocessorArgs M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
