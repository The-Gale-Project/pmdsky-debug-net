// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay26Data : KaitaiStruct
    {
        public static Overlay26Data FromFile(string fileName)
        {
            return new Overlay26Data(new KaitaiStream(fileName));
        }

        public Overlay26Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay26Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_overlay26ReservedSpace = false;
            f_overlay26UnknownPointer5Na238af70 = false;
            f_overlay26UnknownTableNa238ae20 = false;
            f_overlay26UnknownPointerNa238af64 = false;
            f_overlay26UnknownPointerNa238af60 = false;
            f_overlay26UnknownPointerNa238af6c = false;
            f_overlay26UnknownPointerNa238af68 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_overlay26ReservedSpace;
        private List<byte> _overlay26ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26ReservedSpace
        {
            get
            {
                if (f_overlay26ReservedSpace)
                    return _overlay26ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(3592);
                _overlay26ReservedSpace = new List<byte>();
                for (var i = 0; i < 24; i++)
                {
                    _overlay26ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26ReservedSpace = true;
                return _overlay26ReservedSpace;
            }
        }
        private bool f_overlay26UnknownPointer5Na238af70;
        private List<byte> _overlay26UnknownPointer5Na238af70;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26UnknownPointer5Na238af70
        {
            get
            {
                if (f_overlay26UnknownPointer5Na238af70)
                    return _overlay26UnknownPointer5Na238af70;
                long _pos = m_io.Pos;
                m_io.Seek(3632);
                _overlay26UnknownPointer5Na238af70 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay26UnknownPointer5Na238af70.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26UnknownPointer5Na238af70 = true;
                return _overlay26UnknownPointer5Na238af70;
            }
        }
        private bool f_overlay26UnknownTableNa238ae20;
        private List<byte> _overlay26UnknownTableNa238ae20;

        /// <summary>
        /// 0x6 + 11*0xC + 0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26UnknownTableNa238ae20
        {
            get
            {
                if (f_overlay26UnknownTableNa238ae20)
                    return _overlay26UnknownTableNa238ae20;
                long _pos = m_io.Pos;
                m_io.Seek(3296);
                _overlay26UnknownTableNa238ae20 = new List<byte>();
                for (var i = 0; i < 140; i++)
                {
                    _overlay26UnknownTableNa238ae20.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26UnknownTableNa238ae20 = true;
                return _overlay26UnknownTableNa238ae20;
            }
        }
        private bool f_overlay26UnknownPointerNa238af64;
        private List<byte> _overlay26UnknownPointerNa238af64;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26UnknownPointerNa238af64
        {
            get
            {
                if (f_overlay26UnknownPointerNa238af64)
                    return _overlay26UnknownPointerNa238af64;
                long _pos = m_io.Pos;
                m_io.Seek(3620);
                _overlay26UnknownPointerNa238af64 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay26UnknownPointerNa238af64.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26UnknownPointerNa238af64 = true;
                return _overlay26UnknownPointerNa238af64;
            }
        }
        private bool f_overlay26UnknownPointerNa238af60;
        private List<byte> _overlay26UnknownPointerNa238af60;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26UnknownPointerNa238af60
        {
            get
            {
                if (f_overlay26UnknownPointerNa238af60)
                    return _overlay26UnknownPointerNa238af60;
                long _pos = m_io.Pos;
                m_io.Seek(3616);
                _overlay26UnknownPointerNa238af60 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay26UnknownPointerNa238af60.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26UnknownPointerNa238af60 = true;
                return _overlay26UnknownPointerNa238af60;
            }
        }
        private bool f_overlay26UnknownPointerNa238af6c;
        private List<byte> _overlay26UnknownPointerNa238af6c;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26UnknownPointerNa238af6c
        {
            get
            {
                if (f_overlay26UnknownPointerNa238af6c)
                    return _overlay26UnknownPointerNa238af6c;
                long _pos = m_io.Pos;
                m_io.Seek(3628);
                _overlay26UnknownPointerNa238af6c = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay26UnknownPointerNa238af6c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26UnknownPointerNa238af6c = true;
                return _overlay26UnknownPointerNa238af6c;
            }
        }
        private bool f_overlay26UnknownPointerNa238af68;
        private List<byte> _overlay26UnknownPointerNa238af68;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay26UnknownPointerNa238af68
        {
            get
            {
                if (f_overlay26UnknownPointerNa238af68)
                    return _overlay26UnknownPointerNa238af68;
                long _pos = m_io.Pos;
                m_io.Seek(3624);
                _overlay26UnknownPointerNa238af68 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay26UnknownPointerNa238af68.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay26UnknownPointerNa238af68 = true;
                return _overlay26UnknownPointerNa238af68;
            }
        }
        private Overlay26Data m_root;
        private KaitaiStruct m_parent;
        public Overlay26Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
