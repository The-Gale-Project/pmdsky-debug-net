// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// The dungeon engine.
    /// 
    /// This is the &quot;main&quot; overlay of dungeon mode. It controls most things that happen in a Mystery Dungeon, such as dungeon layout generation, dungeon menus, enemy AI, and generally just running each turn while within a dungeon.
    /// </summary>
    public partial class Overlay29 : KaitaiStruct
    {
        public static Overlay29 FromFile(string fileName)
        {
            return new Overlay29(new KaitaiStream(fileName));
        }

        public Overlay29(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay29 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_functions = false;
            f_data = false;
            f_moveEffects = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_functions;
        private Overlay29Functions _functions;
        public Overlay29Functions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new Overlay29Functions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private Overlay29Data _data;
        public Overlay29Data Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new Overlay29Data(m_io);
                f_data = true;
                return _data;
            }
        }
        private bool f_moveEffects;
        private MoveEffects _moveEffects;
        public MoveEffects MoveEffects
        {
            get
            {
                if (f_moveEffects)
                    return _moveEffects;
                _moveEffects = new MoveEffects(m_io);
                f_moveEffects = true;
                return _moveEffects;
            }
        }
        private Overlay29 m_root;
        private KaitaiStruct m_parent;
        public Overlay29 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
