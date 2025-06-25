// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array IQ_GUMMI_GAIN_TABLE defined within pmdsky.
    /// </summary>
    public partial class IqGummiGainTableArray : KaitaiStruct
    {
        public static IqGummiGainTableArray FromFile(string fileName)
        {
            return new IqGummiGainTableArray(new KaitaiStream(fileName));
        }

        public IqGummiGainTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, IqGummiGainTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new IqGummiGainTableArrayDim1(m_io, this, m_root);
        }
        public partial class IqGummiGainTableArrayDim0 : KaitaiStruct
        {
            public static IqGummiGainTableArrayDim0 FromFile(string fileName)
            {
                return new IqGummiGainTableArrayDim0(new KaitaiStream(fileName));
            }

            public IqGummiGainTableArrayDim0(KaitaiStream p__io, IqGummiGainTableArray.IqGummiGainTableArrayDim1 p__parent = null, IqGummiGainTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private IqGummiGainTableArray m_root;
            private IqGummiGainTableArray.IqGummiGainTableArrayDim1 m_parent;
            public List<short> Entries { get { return _entries; } }
            public IqGummiGainTableArray M_Root { get { return m_root; } }
            public IqGummiGainTableArray.IqGummiGainTableArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class IqGummiGainTableArrayDim1 : KaitaiStruct
        {
            public static IqGummiGainTableArrayDim1 FromFile(string fileName)
            {
                return new IqGummiGainTableArrayDim1(new KaitaiStream(fileName));
            }

            public IqGummiGainTableArrayDim1(KaitaiStream p__io, IqGummiGainTableArray p__parent = null, IqGummiGainTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<IqGummiGainTableArrayDim0>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new IqGummiGainTableArrayDim0(m_io, this, m_root));
                }
            }
            private List<IqGummiGainTableArrayDim0> _entries;
            private IqGummiGainTableArray m_root;
            private IqGummiGainTableArray m_parent;
            public List<IqGummiGainTableArrayDim0> Entries { get { return _entries; } }
            public IqGummiGainTableArray M_Root { get { return m_root; } }
            public IqGummiGainTableArray M_Parent { get { return m_parent; } }
        }
        private IqGummiGainTableArrayDim1 _entries;
        private IqGummiGainTableArray m_root;
        private KaitaiStruct m_parent;
        public IqGummiGainTableArrayDim1 Entries { get { return _entries; } }
        public IqGummiGainTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
