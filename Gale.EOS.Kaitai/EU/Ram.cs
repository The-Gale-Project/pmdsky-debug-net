// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Main memory.
    /// Data in this file aren't located in the ROM itself, and are instead constructs loaded at runtime.
    /// 
    /// More specifically, this file is a dumping ground for addresses that are useful to know about, but don't fall in the address ranges of any of the other files. Dynamically loaded constructs that do fall within the address range of a relevant binary should be listed in the corresponding YAML file of that binary, since it still has direct utility when reverse-engineering that particular binary.
    /// </summary>
    public partial class Ram : KaitaiStruct
    {
        public static Ram FromFile(string fileName)
        {
            return new Ram(new KaitaiStream(fileName));
        }

        public Ram(KaitaiStream p__io, KaitaiStruct p__parent = null, Ram p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_data = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_data;
        private RamData _data;
        public RamData Data
        {
            get
            {
                if (f_data)
                    return _data;
                _data = new RamData(m_io);
                f_data = true;
                return _data;
            }
        }
        private Ram m_root;
        private KaitaiStruct m_parent;
        public Ram M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
