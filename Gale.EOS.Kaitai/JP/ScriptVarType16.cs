// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds bitsized data for the parent enum script_var_type.
    /// </summary>
    public partial class ScriptVarType16 : KaitaiStruct
    {
        public static ScriptVarType16 FromFile(string fileName)
        {
            return new ScriptVarType16(new KaitaiStream(fileName));
        }


        public enum ScriptVarType16Enum
        {
            VartypeNone = 0,
            VartypeBit = 1,
            VartypeString = 2,
            VartypeUint8 = 3,
            VartypeInt8 = 4,
            VartypeUint16 = 5,
            VartypeInt16 = 6,
            VartypeUint32 = 7,
            VartypeInt32 = 8,
            VartypeSpecial = 9,
        }
        public ScriptVarType16(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptVarType16 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _scriptVarType16Value = ((ScriptVarType16Enum) m_io.ReadBitsIntLe(16));
        }
        private ScriptVarType16Enum _scriptVarType16Value;
        private ScriptVarType16 m_root;
        private KaitaiStruct m_parent;
        public ScriptVarType16Enum ScriptVarType16Value { get { return _scriptVarType16Value; } }
        public ScriptVarType16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
