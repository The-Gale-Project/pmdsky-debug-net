// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array LFO_WAVEFORM_CALLBACKS defined within pmdsky.
    /// </summary>
    public partial class LfoWaveformCallbacksArray : KaitaiStruct
    {
        public static LfoWaveformCallbacksArray FromFile(string fileName)
        {
            return new LfoWaveformCallbacksArray(new KaitaiStream(fileName));
        }

        public LfoWaveformCallbacksArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LfoWaveformCallbacksArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LfoWaveformCallbacksArrayDim0(m_io, this, m_root);
        }
        public partial class LfoWaveformCallbacksArrayDim0 : KaitaiStruct
        {
            public static LfoWaveformCallbacksArrayDim0 FromFile(string fileName)
            {
                return new LfoWaveformCallbacksArrayDim0(new KaitaiStream(fileName));
            }

            public LfoWaveformCallbacksArrayDim0(KaitaiStream p__io, LfoWaveformCallbacksArray p__parent = null, LfoWaveformCallbacksArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private LfoWaveformCallbacksArray m_root;
            private LfoWaveformCallbacksArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public LfoWaveformCallbacksArray M_Root { get { return m_root; } }
            public LfoWaveformCallbacksArray M_Parent { get { return m_parent; } }
        }
        private LfoWaveformCallbacksArrayDim0 _entries;
        private LfoWaveformCallbacksArray m_root;
        private KaitaiStruct m_parent;
        public LfoWaveformCallbacksArrayDim0 Entries { get { return _entries; } }
        public LfoWaveformCallbacksArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
