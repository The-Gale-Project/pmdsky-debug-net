// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union animation defined within pmdsky-debug.
    /// </summary>
    public partial class Animation : KaitaiStruct
    {
        public static Animation FromFile(string fileName)
        {
            return new Animation(new KaitaiStream(fileName));
        }

        public Animation(KaitaiStream p__io, KaitaiStruct p__parent = null, Animation p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = new AnimationField0x0Array(m_io);
            _ctrl = new AnimationControl(m_io);
            _fields = new AnimationFieldsArray(m_io);
        }
        private AnimationField0x0Array _field0x0;
        private AnimationControl _ctrl;
        private AnimationFieldsArray _fields;
        private Animation m_root;
        private KaitaiStruct m_parent;
        public AnimationField0x0Array Field0x0 { get { return _field0x0; } }
        public AnimationControl Ctrl { get { return _ctrl; } }
        public AnimationFieldsArray Fields { get { return _fields; } }
        public Animation M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
