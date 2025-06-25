// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay30Data : KaitaiStruct
    {
        public static Overlay30Data FromFile(string fileName)
        {
            return new Overlay30Data(new KaitaiStream(fileName));
        }

        public Overlay30Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay30Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_overlay30JpString1 = false;
            f_overlay30JpString2 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_overlay30JpString1;
        private List<byte> _overlay30JpString1;

        /// <summary>
        /// みさき様
        /// </summary>
        public List<byte> Overlay30JpString1
        {
            get
            {
                if (f_overlay30JpString1)
                    return _overlay30JpString1;
                long _pos = m_io.Pos;
                m_io.Seek(14400);
                _overlay30JpString1 = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay30JpString1.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay30JpString1 = true;
                return _overlay30JpString1;
            }
        }
        private bool f_overlay30JpString2;
        private List<byte> _overlay30JpString2;

        /// <summary>
        /// やよい様
        /// </summary>
        public List<byte> Overlay30JpString2
        {
            get
            {
                if (f_overlay30JpString2)
                    return _overlay30JpString2;
                long _pos = m_io.Pos;
                m_io.Seek(14412);
                _overlay30JpString2 = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _overlay30JpString2.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay30JpString2 = true;
                return _overlay30JpString2;
            }
        }
        private Overlay30Data m_root;
        private KaitaiStruct m_parent;
        public Overlay30Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
