// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Move effect handlers for individual moves, called by ExecuteMoveEffect (and also the Metronome and Nature Power tables).
    /// 
    /// This subregion contains only the move effect handlers themselves, and not necessarily all the utility functions used by the move effect handlers (such as the damage calculation functions). These supporting utilities are in the main overlay29 block.
    /// </summary>
    public partial class MoveEffects : KaitaiStruct
    {
        public static MoveEffects FromFile(string fileName)
        {
            return new MoveEffects(new KaitaiStream(fileName));
        }

        public MoveEffects(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveEffects p__root = null) : base(p__io)
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
        private MoveEffectsFunctions _functions;
        public MoveEffectsFunctions Functions
        {
            get
            {
                if (f_functions)
                    return _functions;
                _functions = new MoveEffectsFunctions(m_io);
                f_functions = true;
                return _functions;
            }
        }
        private bool f_data;
        private MoveEffectsData _data;
        public MoveEffectsData Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new MoveEffectsData(m_io);
                f_data = true;
                return _data;
            }
        }
        private MoveEffects m_root;
        private KaitaiStruct m_parent;
        public MoveEffects M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
