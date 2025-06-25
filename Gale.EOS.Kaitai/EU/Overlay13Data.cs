// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay13Data : KaitaiStruct
    {
        public static Overlay13Data FromFile(string fileName)
        {
            return new Overlay13Data(new KaitaiStream(fileName));
        }

        public Overlay13Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay13Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_quizBorderColorTable = false;
            f_startersHeroIds = false;
            f_quizWindowParams1 = false;
            f_quizAnswerPoints = false;
            f_startersTypeIncompatibilityTable = false;
            f_overlay13UnknownStructNa238cf14 = false;
            f_quizMenuItems1 = false;
            f_quizDebugMenuItems = false;
            f_quizWindowParams4 = false;
            f_quizWindowParams5 = false;
            f_quizWindowParams6 = false;
            f_overlay13UnknownPointerNa238cea0 = false;
            f_overlay13ReservedSpace = false;
            f_quizWindowParams3 = false;
            f_startersPartnerIds = false;
            f_portraitAttributes = false;
            f_quizMaleFemaleBoostTable = false;
            f_quizAnswerStrings = false;
            f_overlay13UnknownStructNa238c024 = false;
            f_quizQuestionStrings = false;
            f_quizWindowParams2 = false;
            f_quizQuestionAnswerAssociations = false;
            f_partnerSelectMenuOptionTracker = false;
            f_partnerSelectMenuOptionTimer = false;
            f_startersStrings = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_quizBorderColorTable;
        private List<byte> _quizBorderColorTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> QuizBorderColorTable
        {
            get
            {
                if (f_quizBorderColorTable)
                    return _quizBorderColorTable;
                long _pos = m_io.Pos;
                m_io.Seek(7888);
                _quizBorderColorTable = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _quizBorderColorTable.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_quizBorderColorTable = true;
                return _quizBorderColorTable;
            }
        }
        private bool f_startersHeroIds;
        private StartersHeroIdsArray _startersHeroIds;

        /// <summary>
        /// type: struct monster_id_16[32]
        /// </summary>
        public StartersHeroIdsArray StartersHeroIds
        {
            get
            {
                if (f_startersHeroIds)
                    return _startersHeroIds;
                long _pos = m_io.Pos;
                m_io.Seek(8056);
                _startersHeroIds = new StartersHeroIdsArray(m_io);
                m_io.Seek(_pos);
                f_startersHeroIds = true;
                return _startersHeroIds;
            }
        }
        private bool f_quizWindowParams1;
        private WindowParams _quizWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams QuizWindowParams1
        {
            get
            {
                if (f_quizWindowParams1)
                    return _quizWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(7924);
                _quizWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_quizWindowParams1 = true;
                return _quizWindowParams1;
            }
        }
        private bool f_quizAnswerPoints;
        private QuizAnswerPointsArray _quizAnswerPoints;

        /// <summary>
        /// 0x10 * (174 answers?)
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public QuizAnswerPointsArray QuizAnswerPoints
        {
            get
            {
                if (f_quizAnswerPoints)
                    return _quizAnswerPoints;
                long _pos = m_io.Pos;
                m_io.Seek(8784);
                _quizAnswerPoints = new QuizAnswerPointsArray(m_io);
                m_io.Seek(_pos);
                f_quizAnswerPoints = true;
                return _quizAnswerPoints;
            }
        }
        private bool f_startersTypeIncompatibilityTable;
        private List<byte> _startersTypeIncompatibilityTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> StartersTypeIncompatibilityTable
        {
            get
            {
                if (f_startersTypeIncompatibilityTable)
                    return _startersTypeIncompatibilityTable;
                long _pos = m_io.Pos;
                m_io.Seek(8120);
                _startersTypeIncompatibilityTable = new List<byte>();
                for (var i = 0; i < 84; i++)
                {
                    _startersTypeIncompatibilityTable.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_startersTypeIncompatibilityTable = true;
                return _startersTypeIncompatibilityTable;
            }
        }
        private bool f_overlay13UnknownStructNa238cf14;
        private List<byte> _overlay13UnknownStructNa238cf14;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay13UnknownStructNa238cf14
        {
            get
            {
                if (f_overlay13UnknownStructNa238cf14)
                    return _overlay13UnknownStructNa238cf14;
                long _pos = m_io.Pos;
                m_io.Seek(11732);
                _overlay13UnknownStructNa238cf14 = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _overlay13UnknownStructNa238cf14.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay13UnknownStructNa238cf14 = true;
                return _overlay13UnknownStructNa238cf14;
            }
        }
        private bool f_quizMenuItems1;
        private QuizMenuItems1Array _quizMenuItems1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public QuizMenuItems1Array QuizMenuItems1
        {
            get
            {
                if (f_quizMenuItems1)
                    return _quizMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(7988);
                _quizMenuItems1 = new QuizMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_quizMenuItems1 = true;
                return _quizMenuItems1;
            }
        }
        private bool f_quizDebugMenuItems;
        private QuizDebugMenuItemsArray _quizDebugMenuItems;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public QuizDebugMenuItemsArray QuizDebugMenuItems
        {
            get
            {
                if (f_quizDebugMenuItems)
                    return _quizDebugMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(11660);
                _quizDebugMenuItems = new QuizDebugMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_quizDebugMenuItems = true;
                return _quizDebugMenuItems;
            }
        }
        private bool f_quizWindowParams4;
        private WindowParams _quizWindowParams4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams QuizWindowParams4
        {
            get
            {
                if (f_quizWindowParams4)
                    return _quizWindowParams4;
                long _pos = m_io.Pos;
                m_io.Seek(7972);
                _quizWindowParams4 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_quizWindowParams4 = true;
                return _quizWindowParams4;
            }
        }
        private bool f_quizWindowParams5;
        private WindowParams _quizWindowParams5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams QuizWindowParams5
        {
            get
            {
                if (f_quizWindowParams5)
                    return _quizWindowParams5;
                long _pos = m_io.Pos;
                m_io.Seek(11628);
                _quizWindowParams5 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_quizWindowParams5 = true;
                return _quizWindowParams5;
            }
        }
        private bool f_quizWindowParams6;
        private WindowParams _quizWindowParams6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams QuizWindowParams6
        {
            get
            {
                if (f_quizWindowParams6)
                    return _quizWindowParams6;
                long _pos = m_io.Pos;
                m_io.Seek(11644);
                _quizWindowParams6 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_quizWindowParams6 = true;
                return _quizWindowParams6;
            }
        }
        private bool f_overlay13UnknownPointerNa238cea0;
        private List<byte> _overlay13UnknownPointerNa238cea0;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay13UnknownPointerNa238cea0
        {
            get
            {
                if (f_overlay13UnknownPointerNa238cea0)
                    return _overlay13UnknownPointerNa238cea0;
                long _pos = m_io.Pos;
                m_io.Seek(11616);
                _overlay13UnknownPointerNa238cea0 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _overlay13UnknownPointerNa238cea0.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay13UnknownPointerNa238cea0 = true;
                return _overlay13UnknownPointerNa238cea0;
            }
        }
        private bool f_overlay13ReservedSpace;
        private List<byte> _overlay13ReservedSpace;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay13ReservedSpace
        {
            get
            {
                if (f_overlay13ReservedSpace)
                    return _overlay13ReservedSpace;
                long _pos = m_io.Pos;
                m_io.Seek(11600);
                _overlay13ReservedSpace = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _overlay13ReservedSpace.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay13ReservedSpace = true;
                return _overlay13ReservedSpace;
            }
        }
        private bool f_quizWindowParams3;
        private WindowParams _quizWindowParams3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams QuizWindowParams3
        {
            get
            {
                if (f_quizWindowParams3)
                    return _quizWindowParams3;
                long _pos = m_io.Pos;
                m_io.Seek(7956);
                _quizWindowParams3 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_quizWindowParams3 = true;
                return _quizWindowParams3;
            }
        }
        private bool f_startersPartnerIds;
        private StartersPartnerIdsArray _startersPartnerIds;

        /// <summary>
        /// type: struct monster_id_16[21]
        /// </summary>
        public StartersPartnerIdsArray StartersPartnerIds
        {
            get
            {
                if (f_startersPartnerIds)
                    return _startersPartnerIds;
                long _pos = m_io.Pos;
                m_io.Seek(8012);
                _startersPartnerIds = new StartersPartnerIdsArray(m_io);
                m_io.Seek(_pos);
                f_startersPartnerIds = true;
                return _startersPartnerIds;
            }
        }
        private bool f_portraitAttributes;
        private List<byte> _portraitAttributes;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> PortraitAttributes
        {
            get
            {
                if (f_portraitAttributes)
                    return _portraitAttributes;
                long _pos = m_io.Pos;
                m_io.Seek(7892);
                _portraitAttributes = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _portraitAttributes.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_portraitAttributes = true;
                return _portraitAttributes;
            }
        }
        private bool f_quizMaleFemaleBoostTable;
        private List<byte> _quizMaleFemaleBoostTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> QuizMaleFemaleBoostTable
        {
            get
            {
                if (f_quizMaleFemaleBoostTable)
                    return _quizMaleFemaleBoostTable;
                long _pos = m_io.Pos;
                m_io.Seek(7900);
                _quizMaleFemaleBoostTable = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _quizMaleFemaleBoostTable.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_quizMaleFemaleBoostTable = true;
                return _quizMaleFemaleBoostTable;
            }
        }
        private bool f_quizAnswerStrings;
        private QuizAnswerStringsArray _quizAnswerStrings;

        /// <summary>
        /// 0x2 * (175 answers + null-terminator)
        /// </summary>
        public QuizAnswerStringsArray QuizAnswerStrings
        {
            get
            {
                if (f_quizAnswerStrings)
                    return _quizAnswerStrings;
                long _pos = m_io.Pos;
                m_io.Seek(8432);
                _quizAnswerStrings = new QuizAnswerStringsArray(m_io);
                m_io.Seek(_pos);
                f_quizAnswerStrings = true;
                return _quizAnswerStrings;
            }
        }
        private bool f_overlay13UnknownStructNa238c024;
        private List<byte> _overlay13UnknownStructNa238c024;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Overlay13UnknownStructNa238c024
        {
            get
            {
                if (f_overlay13UnknownStructNa238c024)
                    return _overlay13UnknownStructNa238c024;
                long _pos = m_io.Pos;
                m_io.Seek(7908);
                _overlay13UnknownStructNa238c024 = new List<byte>();
                for (var i = 0; i < 16; i++)
                {
                    _overlay13UnknownStructNa238c024.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay13UnknownStructNa238c024 = true;
                return _overlay13UnknownStructNa238c024;
            }
        }
        private bool f_quizQuestionStrings;
        private QuizQuestionStringsArray _quizQuestionStrings;

        /// <summary>
        /// 0x2 * (66 questions)
        /// </summary>
        public QuizQuestionStringsArray QuizQuestionStrings
        {
            get
            {
                if (f_quizQuestionStrings)
                    return _quizQuestionStrings;
                long _pos = m_io.Pos;
                m_io.Seek(8300);
                _quizQuestionStrings = new QuizQuestionStringsArray(m_io);
                m_io.Seek(_pos);
                f_quizQuestionStrings = true;
                return _quizQuestionStrings;
            }
        }
        private bool f_quizWindowParams2;
        private WindowParams _quizWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams QuizWindowParams2
        {
            get
            {
                if (f_quizWindowParams2)
                    return _quizWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(7940);
                _quizWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_quizWindowParams2 = true;
                return _quizWindowParams2;
            }
        }
        private bool f_quizQuestionAnswerAssociations;
        private QuizQuestionAnswerAssociationsArray _quizQuestionAnswerAssociations;

        /// <summary>
        /// 0x2 * (66 questions)
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public QuizQuestionAnswerAssociationsArray QuizQuestionAnswerAssociations
        {
            get
            {
                if (f_quizQuestionAnswerAssociations)
                    return _quizQuestionAnswerAssociations;
                long _pos = m_io.Pos;
                m_io.Seek(11748);
                _quizQuestionAnswerAssociations = new QuizQuestionAnswerAssociationsArray(m_io);
                m_io.Seek(_pos);
                f_quizQuestionAnswerAssociations = true;
                return _quizQuestionAnswerAssociations;
            }
        }
        private bool f_partnerSelectMenuOptionTracker;
        private uint _partnerSelectMenuOptionTracker;

        /// <summary>
        /// Keeps track of the currently hovered option in the partner menu to change
        /// the portrait when the another option is hovered.
        /// </summary>
        public uint PartnerSelectMenuOptionTracker
        {
            get
            {
                if (f_partnerSelectMenuOptionTracker)
                    return _partnerSelectMenuOptionTracker;
                long _pos = m_io.Pos;
                m_io.Seek(11620);
                _partnerSelectMenuOptionTracker = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_partnerSelectMenuOptionTracker = true;
                return _partnerSelectMenuOptionTracker;
            }
        }
        private bool f_partnerSelectMenuOptionTimer;
        private uint _partnerSelectMenuOptionTimer;

        /// <summary>
        /// Keeps track of how long the currently hovered option in the partner menu
        /// has been hovered over. Used to change the portrait to happy after some time
        /// has elapsed.
        /// </summary>
        public uint PartnerSelectMenuOptionTimer
        {
            get
            {
                if (f_partnerSelectMenuOptionTimer)
                    return _partnerSelectMenuOptionTimer;
                long _pos = m_io.Pos;
                m_io.Seek(11624);
                _partnerSelectMenuOptionTimer = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_partnerSelectMenuOptionTimer = true;
                return _partnerSelectMenuOptionTimer;
            }
        }
        private bool f_startersStrings;
        private StartersStringsArray _startersStrings;

        /// <summary>
        /// Irdkwia's notes: InsightsStringIDs
        /// </summary>
        public StartersStringsArray StartersStrings
        {
            get
            {
                if (f_startersStrings)
                    return _startersStrings;
                long _pos = m_io.Pos;
                m_io.Seek(8204);
                _startersStrings = new StartersStringsArray(m_io);
                m_io.Seek(_pos);
                f_startersStrings = true;
                return _startersStrings;
            }
        }
        private Overlay13Data m_root;
        private KaitaiStruct m_parent;
        public Overlay13Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
