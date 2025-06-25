// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Holds the data for the enum overlay_group_id.
    /// </summary>
    public partial class OverlayGroupId : KaitaiStruct
    {
        public static OverlayGroupId FromFile(string fileName)
        {
            return new OverlayGroupId(new KaitaiStream(fileName));
        }


        public enum OverlayGroupIdEnum
        {
            OgroupNone = 0,
            OgroupOverlay0 = 1,
            OgroupOverlay10 = 2,
            OgroupOverlay35 = 3,
            OgroupOverlay1 = 4,
            OgroupOverlay2 = 5,
            OgroupOverlay3 = 6,
            OgroupOverlay6 = 7,
            OgroupOverlay4 = 8,
            OgroupOverlay5 = 9,
            OgroupOverlay7 = 10,
            OgroupOverlay8 = 11,
            OgroupOverlay9 = 12,
            OgroupOverlay11 = 13,
            OgroupOverlay29 = 14,
            OgroupOverlay34 = 15,
            OgroupOverlay12 = 16,
            OgroupOverlay13 = 17,
            OgroupOverlay14 = 18,
            OgroupOverlay15 = 19,
            OgroupOverlay16 = 20,
            OgroupOverlay17 = 21,
            OgroupOverlay18 = 22,
            OgroupOverlay19 = 23,
            OgroupOverlay20 = 24,
            OgroupOverlay21 = 25,
            OgroupOverlay22 = 26,
            OgroupOverlay23 = 27,
            OgroupOverlay24 = 28,
            OgroupOverlay25 = 29,
            OgroupOverlay26 = 30,
            OgroupOverlay27 = 31,
            OgroupOverlay28 = 32,
            OgroupOverlay30 = 33,
            OgroupOverlay31 = 34,
            OgroupOverlay32 = 35,
            OgroupOverlay33 = 36,
        }
        public OverlayGroupId(KaitaiStream p__io, KaitaiStruct p__parent = null, OverlayGroupId p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _overlayGroupIdValue = ((OverlayGroupIdEnum) m_io.ReadBitsIntLe(32));
        }
        private OverlayGroupIdEnum _overlayGroupIdValue;
        private OverlayGroupId m_root;
        private KaitaiStruct m_parent;
        public OverlayGroupIdEnum OverlayGroupIdValue { get { return _overlayGroupIdValue; } }
        public OverlayGroupId M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
