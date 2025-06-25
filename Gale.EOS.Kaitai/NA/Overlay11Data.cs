// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{
    public partial class Overlay11Data : KaitaiStruct
    {
        public static Overlay11Data FromFile(string fileName)
        {
            return new Overlay11Data(new KaitaiStream(fileName));
        }

        public Overlay11Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay11Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_worldMapMode = false;
            f_teamInfoBoxDefaultWindowParams = false;
            f_cRoutines = false;
            f_recruitmentTableLocations = false;
            f_overlay11OverlayLoadTable = false;
            f_objectFunctionTable = false;
            f_cRoutineNames = false;
            f_overlay11UnknownTableNa2316a38 = false;
            f_performerFunctionTable = false;
            f_scriptCommandParsingData = false;
            f_scriptOpCodes = false;
            f_overlay11DebugStrings = false;
            f_levelTilemapList = false;
            f_actorFunctionTable = false;
            f_objects = false;
            f_groundStatePtrs = false;
            f_recruitmentTableLevels = false;
            f_recruitmentTableSpecies = false;
            f_groundWeatherTable = false;
            f_scriptOpCodeNames = false;
            f_groundWanFilesTable = false;
            f_setanimationTable = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_worldMapMode;
        private uint _worldMapMode;

        /// <summary>
        /// The current world map
        /// </summary>
        public uint WorldMapMode
        {
            get
            {
                if (f_worldMapMode)
                    return _worldMapMode;
                long _pos = m_io.Pos;
                m_io.Seek(297892);
                _worldMapMode = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_worldMapMode = true;
                return _worldMapMode;
            }
        }
        private bool f_teamInfoBoxDefaultWindowParams;
        private WindowParams _teamInfoBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for a team_info_box.
        /// </summary>
        public WindowParams TeamInfoBoxDefaultWindowParams
        {
            get
            {
                if (f_teamInfoBoxDefaultWindowParams)
                    return _teamInfoBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(287260);
                _teamInfoBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_teamInfoBoxDefaultWindowParams = true;
                return _teamInfoBoxDefaultWindowParams;
            }
        }
        private bool f_cRoutines;
        private CommonRoutineTable _cRoutines;

        /// <summary>
        /// Common routines used within the unionall.ssb script (the master script). There are 701 8-byte entries.
        /// 
        /// These routines underpin the ExplorerScript coroutines you can call in the SkyTemple SSB debugger.
        /// 
        /// type: struct common_routine_table
        /// </summary>
        public CommonRoutineTable CRoutines
        {
            get
            {
                if (f_cRoutines)
                    return _cRoutines;
                long _pos = m_io.Pos;
                m_io.Seek(263656);
                _cRoutines = new CommonRoutineTable(m_io);
                m_io.Seek(_pos);
                f_cRoutines = true;
                return _cRoutines;
            }
        }
        private bool f_recruitmentTableLocations;
        private RecruitmentTableLocationsArray _recruitmentTableLocations;

        /// <summary>
        /// Table of dungeon IDs corresponding to entries in RECRUITMENT_TABLE_SPECIES.
        /// 
        /// type: struct dungeon_id_16[22]
        /// </summary>
        public RecruitmentTableLocationsArray RecruitmentTableLocations
        {
            get
            {
                if (f_recruitmentTableLocations)
                    return _recruitmentTableLocations;
                long _pos = m_io.Pos;
                m_io.Seek(280148);
                _recruitmentTableLocations = new RecruitmentTableLocationsArray(m_io);
                m_io.Seek(_pos);
                f_recruitmentTableLocations = true;
                return _recruitmentTableLocations;
            }
        }
        private bool f_overlay11OverlayLoadTable;
        private Overlay11OverlayLoadTableArray _overlay11OverlayLoadTable;

        /// <summary>
        /// The overlays that can be loaded while this one is loaded.
        /// 
        /// Each entry is 16 bytes, consisting of:
        /// - overlay group ID (see arm9.yml or enum overlay_group_id in the C headers for a mapping between group ID and overlay number)
        /// - function pointer to entry point
        /// - function pointer to destructor
        /// - possibly function pointer to frame-update function?
        /// 
        /// type: struct overlay_load_entry[21]
        /// </summary>
        public Overlay11OverlayLoadTableArray Overlay11OverlayLoadTable
        {
            get
            {
                if (f_overlay11OverlayLoadTable)
                    return _overlay11OverlayLoadTable;
                long _pos = m_io.Pos;
                m_io.Seek(290348);
                _overlay11OverlayLoadTable = new Overlay11OverlayLoadTableArray(m_io);
                m_io.Seek(_pos);
                f_overlay11OverlayLoadTable = true;
                return _overlay11OverlayLoadTable;
            }
        }
        private bool f_objectFunctionTable;
        private GroundEntityFunctionTable _objectFunctionTable;

        /// <summary>
        /// A function pointer table accessed when performing script opcodes on objects.
        /// </summary>
        public GroundEntityFunctionTable ObjectFunctionTable
        {
            get
            {
                if (f_objectFunctionTable)
                    return _objectFunctionTable;
                long _pos = m_io.Pos;
                m_io.Seek(285628);
                _objectFunctionTable = new GroundEntityFunctionTable(m_io);
                m_io.Seek(_pos);
                f_objectFunctionTable = true;
                return _objectFunctionTable;
            }
        }
        private bool f_cRoutineNames;
        private CRoutineNamesArray _cRoutineNames;

        /// <summary>
        /// Common routine name strings pointed to by entries in C_ROUTINES (common_routine::name)
        /// </summary>
        public CRoutineNamesArray CRoutineNames
        {
            get
            {
                if (f_cRoutineNames)
                    return _cRoutineNames;
                long _pos = m_io.Pos;
                m_io.Seek(252076);
                _cRoutineNames = new CRoutineNamesArray(m_io);
                m_io.Seek(_pos);
                f_cRoutineNames = true;
                return _cRoutineNames;
            }
        }
        private bool f_overlay11UnknownTableNa2316a38;
        private List<byte> _overlay11UnknownTableNa2316a38;

        /// <summary>
        /// Multiple entries are pointers to the string &quot;script.c&quot;
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: undefined4[40]
        /// </summary>
        public List<byte> Overlay11UnknownTableNa2316a38
        {
            get
            {
                if (f_overlay11UnknownTableNa2316a38)
                    return _overlay11UnknownTableNa2316a38;
                long _pos = m_io.Pos;
                m_io.Seek(239608);
                _overlay11UnknownTableNa2316a38 = new List<byte>();
                for (var i = 0; i < 160; i++)
                {
                    _overlay11UnknownTableNa2316a38.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_overlay11UnknownTableNa2316a38 = true;
                return _overlay11UnknownTableNa2316a38;
            }
        }
        private bool f_performerFunctionTable;
        private GroundEntityFunctionTable _performerFunctionTable;

        /// <summary>
        /// A function pointer table accessed when performing script opcodes on performers.
        /// </summary>
        public GroundEntityFunctionTable PerformerFunctionTable
        {
            get
            {
                if (f_performerFunctionTable)
                    return _performerFunctionTable;
                long _pos = m_io.Pos;
                m_io.Seek(286416);
                _performerFunctionTable = new GroundEntityFunctionTable(m_io);
                m_io.Seek(_pos);
                f_performerFunctionTable = true;
                return _performerFunctionTable;
            }
        }
        private bool f_scriptCommandParsingData;
        private ScriptCommandParsingDataArray _scriptCommandParsingData;

        /// <summary>
        /// Used by ScriptCommandParsing somehow
        /// </summary>
        public ScriptCommandParsingDataArray ScriptCommandParsingData
        {
            get
            {
                if (f_scriptCommandParsingData)
                    return _scriptCommandParsingData;
                long _pos = m_io.Pos;
                m_io.Seek(239768);
                _scriptCommandParsingData = new ScriptCommandParsingDataArray(m_io);
                m_io.Seek(_pos);
                f_scriptCommandParsingData = true;
                return _scriptCommandParsingData;
            }
        }
        private bool f_scriptOpCodes;
        private ScriptOpcodeTable _scriptOpCodes;

        /// <summary>
        /// Table of opcodes for the script engine. There are 383 8-byte entries.
        /// 
        /// These opcodes underpin the various ExplorerScript functions you can call in the SkyTemple SSB debugger.
        /// 
        /// type: struct script_opcode_table
        /// </summary>
        public ScriptOpcodeTable ScriptOpCodes
        {
            get
            {
                if (f_scriptOpCodes)
                    return _scriptOpCodes;
                long _pos = m_io.Pos;
                m_io.Seek(246736);
                _scriptOpCodes = new ScriptOpcodeTable(m_io);
                m_io.Seek(_pos);
                f_scriptOpCodes = true;
                return _scriptOpCodes;
            }
        }
        private bool f_overlay11DebugStrings;
        private Overlay11DebugStringsArray _overlay11DebugStrings;

        /// <summary>
        /// Strings used with various debug printing functions throughout the overlay
        /// </summary>
        public Overlay11DebugStringsArray Overlay11DebugStrings
        {
            get
            {
                if (f_overlay11DebugStrings)
                    return _overlay11DebugStrings;
                long _pos = m_io.Pos;
                m_io.Seek(249800);
                _overlay11DebugStrings = new Overlay11DebugStringsArray(m_io);
                m_io.Seek(_pos);
                f_overlay11DebugStrings = true;
                return _overlay11DebugStrings;
            }
        }
        private bool f_levelTilemapList;
        private LevelTilemapListArray _levelTilemapList;

        /// <summary>
        /// Irdkwia's notes: FIXED_FLOOR_GROUND_ASSOCIATION
        /// 
        /// type: struct level_tilemap_list_entry[81]
        /// </summary>
        public LevelTilemapListArray LevelTilemapList
        {
            get
            {
                if (f_levelTilemapList)
                    return _levelTilemapList;
                long _pos = m_io.Pos;
                m_io.Seek(281324);
                _levelTilemapList = new LevelTilemapListArray(m_io);
                m_io.Seek(_pos);
                f_levelTilemapList = true;
                return _levelTilemapList;
            }
        }
        private bool f_actorFunctionTable;
        private GroundEntityFunctionTable _actorFunctionTable;

        /// <summary>
        /// A function pointer table accessed when performing script opcodes on actors.
        /// </summary>
        public GroundEntityFunctionTable ActorFunctionTable
        {
            get
            {
                if (f_actorFunctionTable)
                    return _actorFunctionTable;
                long _pos = m_io.Pos;
                m_io.Seek(284220);
                _actorFunctionTable = new GroundEntityFunctionTable(m_io);
                m_io.Seek(_pos);
                f_actorFunctionTable = true;
                return _actorFunctionTable;
            }
        }
        private bool f_objects;
        private ObjectsArray _objects;

        /// <summary>
        /// Table of objects for the script engine, which can be placed in scenes. There are a version-dependent number of 12-byte entries.
        /// 
        /// type: struct script_object[length / 12]
        /// </summary>
        public ObjectsArray Objects
        {
            get
            {
                if (f_objects)
                    return _objects;
                long _pos = m_io.Pos;
                m_io.Seek(273428);
                _objects = new ObjectsArray(m_io);
                m_io.Seek(_pos);
                f_objects = true;
                return _objects;
            }
        }
        private bool f_groundStatePtrs;
        private MainGroundData _groundStatePtrs;

        /// <summary>
        /// Host pointers to multiple structure used for performing an overworld scene
        /// 
        /// type: struct main_ground_data
        /// </summary>
        public MainGroundData GroundStatePtrs
        {
            get
            {
                if (f_groundStatePtrs)
                    return _groundStatePtrs;
                long _pos = m_io.Pos;
                m_io.Seek(297652);
                _groundStatePtrs = new MainGroundData(m_io);
                m_io.Seek(_pos);
                f_groundStatePtrs = true;
                return _groundStatePtrs;
            }
        }
        private bool f_recruitmentTableLevels;
        private RecruitmentTableLevelsArray _recruitmentTableLevels;

        /// <summary>
        /// Table of levels for recruited Pokémon, corresponding to entries in RECRUITMENT_TABLE_SPECIES.
        /// 
        /// type: int16_t[22]
        /// </summary>
        public RecruitmentTableLevelsArray RecruitmentTableLevels
        {
            get
            {
                if (f_recruitmentTableLevels)
                    return _recruitmentTableLevels;
                long _pos = m_io.Pos;
                m_io.Seek(280172);
                _recruitmentTableLevels = new RecruitmentTableLevelsArray(m_io);
                m_io.Seek(_pos);
                f_recruitmentTableLevels = true;
                return _recruitmentTableLevels;
            }
        }
        private bool f_recruitmentTableSpecies;
        private RecruitmentTableSpeciesArray _recruitmentTableSpecies;

        /// <summary>
        /// Table of Pokémon recruited at special locations, such as at the ends of certain dungeons (e.g., Dialga or the Seven Treasures legendaries) or during a cutscene (e.g., Cresselia and Manaphy).
        /// 
        /// Interestingly, this includes both Heatran genders. It also includes Darkrai for some reason?
        /// 
        /// type: struct monster_id_16[22]
        /// </summary>
        public RecruitmentTableSpeciesArray RecruitmentTableSpecies
        {
            get
            {
                if (f_recruitmentTableSpecies)
                    return _recruitmentTableSpecies;
                long _pos = m_io.Pos;
                m_io.Seek(280216);
                _recruitmentTableSpecies = new RecruitmentTableSpeciesArray(m_io);
                m_io.Seek(_pos);
                f_recruitmentTableSpecies = true;
                return _recruitmentTableSpecies;
            }
        }
        private bool f_groundWeatherTable;
        private GroundWeatherTableArray _groundWeatherTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct ground_weather_entry[12]
        /// </summary>
        public GroundWeatherTableArray GroundWeatherTable
        {
            get
            {
                if (f_groundWeatherTable)
                    return _groundWeatherTable;
                long _pos = m_io.Pos;
                m_io.Seek(269264);
                _groundWeatherTable = new GroundWeatherTableArray(m_io);
                m_io.Seek(_pos);
                f_groundWeatherTable = true;
                return _groundWeatherTable;
            }
        }
        private bool f_scriptOpCodeNames;
        private ScriptOpCodeNamesArray _scriptOpCodeNames;

        /// <summary>
        /// Opcode name strings pointed to by entries in SCRIPT_OP_CODES (script_opcode::name)
        /// </summary>
        public ScriptOpCodeNamesArray ScriptOpCodeNames
        {
            get
            {
                if (f_scriptOpCodeNames)
                    return _scriptOpCodeNames;
                long _pos = m_io.Pos;
                m_io.Seek(239800);
                _scriptOpCodeNames = new ScriptOpCodeNamesArray(m_io);
                m_io.Seek(_pos);
                f_scriptOpCodeNames = true;
                return _scriptOpCodeNames;
            }
        }
        private bool f_groundWanFilesTable;
        private GroundWanFilesTableArray _groundWanFilesTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: char[343][12]
        /// </summary>
        public GroundWanFilesTableArray GroundWanFilesTable
        {
            get
            {
                if (f_groundWanFilesTable)
                    return _groundWanFilesTable;
                long _pos = m_io.Pos;
                m_io.Seek(269312);
                _groundWanFilesTable = new GroundWanFilesTableArray(m_io);
                m_io.Seek(_pos);
                f_groundWanFilesTable = true;
                return _groundWanFilesTable;
            }
        }
        private bool f_setanimationTable;
        private SetanimationTableArray _setanimationTable;

        /// <summary>
        /// Table that associates the parameter of the SetAnimation scripting opcode to animation data.
        /// 
        /// The first entry is unused and has a value of 0xFFFF.
        /// </summary>
        public SetanimationTableArray SetanimationTable
        {
            get
            {
                if (f_setanimationTable)
                    return _setanimationTable;
                long _pos = m_io.Pos;
                m_io.Seek(284300);
                _setanimationTable = new SetanimationTableArray(m_io);
                m_io.Seek(_pos);
                f_setanimationTable = true;
                return _setanimationTable;
            }
        }
        private Overlay11Data m_root;
        private KaitaiStruct m_parent;
        public Overlay11Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
