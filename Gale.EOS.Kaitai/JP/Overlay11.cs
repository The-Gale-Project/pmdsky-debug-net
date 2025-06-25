// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// The script engine.
    /// 
    /// This is the &quot;main&quot; overlay of ground mode. The script engine is what runs the ground mode scripts contained in the SCRIPT folder, which are written in a custom scripting language. These scripts encode things like cutscenes, screen transitions, ground mode events, and tons of other things related to ground mode.
    /// </summary>
    public partial class Overlay11 : KaitaiStruct
    {
        public static Overlay11 FromFile(string fileName)
        {
            return new Overlay11(new KaitaiStream(fileName));
        }

        public Overlay11(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay11 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_functions = false;
            f_data = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_functions;
        private Overlay11Functions _functions;
        public Overlay11Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay11Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay11Data _data;
        public Overlay11Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay11Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private Overlay11 m_root;
        private KaitaiStruct m_parent;
        public Overlay11 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
