using Gsf;

class RecordType
{

    public enum TypeCode {
	Unknown = 0,
	Document = 1000,
	DocumentAtom = 1001,
	EndDocument = 1002,
	Slide = 1006,
	SlideAtom = 1007,
	Notes = 1008,
	NotesAtom = 1009,
	Environment = 1010,
	SlidePersistAtom = 1011,
	SSlideLayoutAtom = 1015,
	MainMaster = 1016,
	SSSlideInfoAtom = 1017,
	SlideViewInfo = 1018,
	GuideAtom = 1019,
	ViewInfo = 1020,
	ViewInfoAtom = 1021,
	SlideViewInfoAtom = 1022,
	VBAInfo = 1023,
	VBAInfoAtom = 1024,
	SSDocInfoAtom = 1025,
	Summary = 1026,
	DocRoutingSlip = 1030,
	OutlineViewInfo = 1031,
	SorterViewInfo = 1032,
	ExObjList = 1033,
	ExObjListAtom = 1034,
	PPDrawingGroup = 1035, //FIXME: Office Art File Format Docu
	PPDrawing = 1036, //FIXME: Office Art File Format Docu
	NamedShows = 1040, // don't know if container
	NamedShow = 1041,
	NamedShowSlides = 1042, // don't know if container
	List = 2000,
	FontCollection = 2005,
	BookmarkCollection = 2019,
	SoundCollAtom = 2021,
	Sound = 2022,
	SoundData = 2023,
	BookmarkSeedAtom = 2025,
	ColorSchemeAtom = 2032,
	ExObjRefAtom = 3009,
	OEShapeAtom = 3009,
	OEPlaceholderAtom = 3011,
	GPointAtom = 3024,
	GRatioAtom = 3031,
	OutlineTextRefAtom = 3998,
	TextHeaderAtom = 3999,
	TextCharsAtom = 4000,
	StyleTextPropAtom = 4001,
	BaseTextPropAtom = 4002,
	TxMasterStyleAtom = 4003,
	TxCFStyleAtom = 4004,
	TxPFStyleAtom = 4005,
	TextRulerAtom = 4006,
	TextBookmarkAtom = 4007,
	TextBytesAtom = 4008,
	TxSIStyleAtom = 4009,
	TextSpecInfoAtom = 4010,
	DefaultRulerAtom = 4011,
	FontEntityAtom = 4023,
	FontEmbeddedData = 4024,
	CString = 4026,
	MetaFile = 4033,
	ExOleObjAtom = 4035,
	SrKinsoku = 4040,
	HandOut = 4041,
	ExEmbed = 4044,
	ExEmbedAtom = 4045,
	ExLink = 4046,
	BookmarkEntityAtom = 4048,
	ExLinkAtom = 4049,
	SrKinsokuAtom = 4050,
	ExHyperlinkAtom = 4051,
	ExHyperlink = 4055,
	SlideNumberMCAtom = 4056,
	HeadersFooters = 4057,
	HeadersFootersAtom = 4058,
	TxInteractiveInfoAtom = 4063,
	CharFormatAtom = 4066,
	ParaFormatAtom = 4067,
	RecolorInfoAtom = 4071,
	ExQuickTimeMovie = 4074,
	ExQuickTimeMovieData = 4075,
	ExControl = 4078,
	SlideListWithText = 4080,
	InteractiveInfo = 4082,
	InteractiveInfoAtom = 4083,
	UserEditAtom = 4085,
	CurrentUserAtom = 4086,
	DateTimeMCAtom = 4087,
	GenericDateMCAtom = 4088,
	FooterMCAtom = 4090,
	ExControlAtom = 4091,
	ExMediaAtom = 4100,
	ExVideo = 4101,
	ExAviMovie = 4102,
	ExMCIMovie = 4103,
	ExMIDIAudio = 4109,
	ExCDAudio = 4110,
	ExWAVAudioEmbedded = 4111,
	ExWAVAudioLink = 4112,
	ExOleObjStg = 4113,
	ExCDAudioAtom = 4114,
	ExWAVAudioEmbeddedAtom = 4115,
	AnimationInfoAtom = 4116,
	RTFDateTimeMCAtom = 4117,
	ProgTags = 5000, // don't know if container
	ProgStringTag = 5001,
	ProgBinaryTag = 5002,
	BinaryTagData = 5003,
	PrintOptions = 6000,
	PersistPtrFullBlock = 6001, // don't know if container
	PersistPtrIncrementalBlock = 6002, // don't know if container
	GScalingAtom = 10001,
	GRColorAtom = 10002,
	EscherDggContainer		= 0xf000, /* Drawing Group Container */
	EscherDgg			= 0xf006,
	EscherCLSID			= 0xf016,
	EscherOPT			= 0xf00b,
	EscherBStoreContainer		= 0xf001,
	EscherBSE			= 0xf007,
	EscherBlip_START		= 0xf018, /* Blip types are between */
	EscherBlip_END			= 0xf117, /* these two values */
	EscherDgContainer		= 0xf002, /* Drawing Container */
	EscherDg			= 0xf008,
	EscherRegroupItems		= 0xf118,
	EscherColorScheme		= 0xf120, /* bug in docs */
	EscherSpgrContainer		= 0xf003,
	EscherSpContainer		= 0xf004,
	EscherSpgr			= 0xf009,
	EscherSp			= 0xf00a,
	EscherTextbox			= 0xf00c,
	EscherClientTextbox		= 0xf00d,
	EscherAnchor			= 0xf00e,
	EscherChildAnchor		= 0xf00f,
	EscherClientAnchor		= 0xf010,
	EscherClientData		= 0xf011,
	EscherSolverContainer		= 0xf005,
	EscherConnectorRule		= 0xf012, /* bug in docs */
	EscherAlignRule			= 0xf013,
	EscherArcRule			= 0xf014,
	EscherClientRule		= 0xf015,
	EscherCalloutRule		= 0xf017,
	EscherSelection			= 0xf119,
	EscherColorMRU			= 0xf11a,
	EscherDeletedPspl		= 0xf11d, /* bug in docs */
	EscherSplitMenuColors		= 0xf11e,
	EscherOleObject			= 0xf11f,
	EscherUserDefined		= 0xf122,
    };

    public TypeCode  typecode;
    public string name;
    public bool    is_container;
    public bool    do_read;
    public int min_record_size;
    public int max_record_size;
    RecordType (TypeCode  typecode, string name, bool    is_container, bool    do_read, int min_record_size, int max_record_size)
    {
	this.typecode = typecode;
	this.name = name;
	this.is_container = is_container;
	this.do_read = do_read;
	this.min_record_size = min_record_size;
	this.max_record_size = max_record_size;
    }

    static RecordType[] types =
    {
	new RecordType (	TypeCode.Unknown,			"Unknown",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.Document,			"Document",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.DocumentAtom,			"DocumentAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EndDocument,			"EndDocument",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.Slide,				"Slide",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SlideAtom,			"SlideAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.Notes,				"Notes",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.NotesAtom,			"NotesAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.Environment,			"Environment",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SlidePersistAtom,		"SlidePersistAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.SSlideLayoutAtom,		"SSlideLayoutAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.MainMaster,			"MainMaster",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SSSlideInfoAtom,		"SSSlideInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.SlideViewInfo,			"SlideViewInfo",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.GuideAtom,			"GuideAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ViewInfo,			"ViewInfo",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ViewInfoAtom,			"ViewInfoAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.SlideViewInfoAtom,		"SlideViewInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.VBAInfo,			"VBAInfo",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.VBAInfoAtom,			"VBAInfoAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.SSDocInfoAtom,			"SSDocInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.Summary,			"Summary",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.DocRoutingSlip,		"DocRoutingSlip",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.OutlineViewInfo,		"OutlineViewInfo",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SorterViewInfo,		"SorterViewInfo",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExObjList,			"ExObjList",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExObjListAtom,			"ExObjListAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.PPDrawingGroup,		"PPDrawingGroup",		true,	true,	-1,	-1	), //FIXME: Office Art File Format Docu
	new RecordType (	TypeCode.PPDrawing,			"PPDrawing",			true,	true,	-1,	-1	), //FIXME: Office Art File Format Docu
	new RecordType (	TypeCode.NamedShows,			"NamedShows",			false,	true,	-1,	-1	), // don't know if container
	new RecordType (	TypeCode.NamedShow,			"NamedShow",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.NamedShowSlides,		"NamedShowSlides",		false,	true,	-1,	-1	), // don't know if container
	new RecordType (	TypeCode.List,				"List",				true,	true,	-1,	-1	),
	new RecordType (	TypeCode.FontCollection,		"FontCollection",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.BookmarkCollection,		"BookmarkCollection",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SoundCollAtom,			"SoundCollAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.Sound,				"Sound",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SoundData,			"SoundData",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.BookmarkSeedAtom,		"BookmarkSeedAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ColorSchemeAtom,		"ColorSchemeAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExObjRefAtom,			"ExObjRefAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.OEShapeAtom,			"OEShapeAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.OEPlaceholderAtom,		"OEPlaceholderAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.GPointAtom,			"GPointAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.GRatioAtom,			"GRatioAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.OutlineTextRefAtom,		"OutlineTextRefAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TextHeaderAtom,		"TextHeaderAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TextCharsAtom,			"TextCharsAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.StyleTextPropAtom,		"StyleTextPropAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.BaseTextPropAtom,		"BaseTextPropAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TxMasterStyleAtom,		"TxMasterStyleAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TxCFStyleAtom,			"TxCFStyleAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TxPFStyleAtom,			"TxPFStyleAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TextRulerAtom,			"TextRulerAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TextBookmarkAtom,		"TextBookmarkAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TextBytesAtom,			"TextBytesAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TxSIStyleAtom,			"TxSIStyleAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TextSpecInfoAtom,		"TextSpecInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.DefaultRulerAtom,		"DefaultRulerAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.FontEntityAtom,		"FontEntityAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.FontEmbeddedData,		"FontEmbeddedData",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.CString,			"CString",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.MetaFile,			"MetaFile",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExOleObjAtom,			"ExOleObjAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.SrKinsoku,			"SrKinsoku",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.HandOut,			"HandOut",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExEmbed,			"ExEmbed",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExEmbedAtom,			"ExEmbedAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExLink,			"ExLink",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.BookmarkEntityAtom,		"BookmarkEntityAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExLinkAtom,			"ExLinkAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.SrKinsokuAtom,			"SrKinsokuAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExHyperlinkAtom,		"ExHyperlinkAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExHyperlink,			"ExHyperlink",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SlideNumberMCAtom,		"SlideNumberMCAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.HeadersFooters,		"HeadersFooters",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.HeadersFootersAtom,		"HeadersFootersAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.TxInteractiveInfoAtom,		"TxInteractiveInfoAtom",	false,	true,	-1,	-1	),
	new RecordType (	TypeCode.CharFormatAtom,		"CharFormatAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ParaFormatAtom,		"ParaFormatAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.RecolorInfoAtom,		"RecolorInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExQuickTimeMovie,		"ExQuickTimeMovie",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExQuickTimeMovieData,		"ExQuickTimeMovieData",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExControl,			"ExControl",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.SlideListWithText,		"SlideListWithText",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.InteractiveInfo,		"InteractiveInfo",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.InteractiveInfoAtom,		"InteractiveInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.UserEditAtom,			"UserEditAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.CurrentUserAtom,		"CurrentUserAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.DateTimeMCAtom,		"DateTimeMCAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.GenericDateMCAtom,		"GenericDateMCAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.FooterMCAtom,			"FooterMCAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExControlAtom,			"ExControlAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExMediaAtom,			"ExMediaAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExVideo,			"ExVideo",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExAviMovie,			"ExAviMovie",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExMCIMovie,			"ExMCIMovie",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExMIDIAudio,			"ExMIDIAudio",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExCDAudio,			"ExCDAudio",			true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExWAVAudioEmbedded,		"ExWAVAudioEmbedded",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExWAVAudioLink,		"ExWAVAudioLink",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExOleObjStg,			"ExOleObjStg",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExCDAudioAtom,			"ExCDAudioAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ExWAVAudioEmbeddedAtom,	"ExWAVAudioEmbeddedAtom",	false,	true,	-1,	-1	),
	new RecordType (	TypeCode.AnimationInfoAtom,		"AnimationInfoAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.RTFDateTimeMCAtom,		"RTFDateTimeMCAtom",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.ProgTags,			"ProgTags",			false,	true,	-1,	-1	), // don't know if container
	new RecordType (	TypeCode.ProgStringTag,			"ProgStringTag",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.ProgBinaryTag,			"ProgBinaryTag",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.BinaryTagData,			"BinaryTagData",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.PrintOptions,			"PrintOptions",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.PersistPtrFullBlock,		"PersistPtrFullBlock",		false,	true,	-1,	-1	), // don't know if container
	new RecordType (	TypeCode.PersistPtrIncrementalBlock,	"PersistPtrIncrementalBlock",	false,	true,	-1,	-1	),
	new RecordType (	TypeCode.GScalingAtom,			"GScalingAtom",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.GRColorAtom,			"GRColorAtom",			false,	true,	-1,	-1	),

	new RecordType (	TypeCode.EscherDggContainer,		"EscherDggContainer",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherDgg,			"EscherDgg",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherCLSID,			"EscherCLSID",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherOPT,			"EscherOPT",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherBStoreContainer,		"EscherBStoreContainer",	true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherBSE,			"EscherBSE",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherBlip_START,		"EscherBlip_START",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherBlip_END,		"EscherBlip_END",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherDgContainer,		"EscherDgContainer",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherDg,			"EscherDg",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherRegroupItems,		"EscherRegroupItems",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherColorScheme,		"EscherColorScheme",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSpgrContainer,		"EscherSpgrContainer",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSpContainer,		"EscherSpContainer",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSpgr,			"EscherSpgr",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSp,			"EscherSp",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherTextbox,			"EscherTextbox",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherClientTextbox,		"EscherClientTextbox",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherAnchor,			"EscherAnchor",			false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherChildAnchor,		"EscherChildAnchor",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherClientAnchor,		"EscherClientAnchor",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherClientData,		"EscherClientData",		true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSolverContainer,		"EscherSolverContainer",	true,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherConnectorRule,		"EscherConnectorRule",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherAlignRule,		"EscherAlignRule",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherArcRule,			"EscherArcRule",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherClientRule,		"EscherClientRule",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherCalloutRule,		"EscherCalloutRule",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSelection,		"EscherSelection",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherColorMRU,		"EscherColorMRU",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherDeletedPspl,		"EscherDeletedPspl",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherSplitMenuColors,		"EscherSplitMenuColors",	false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherOleObject,		"EscherOleObject",		false,	true,	-1,	-1	),
	new RecordType (	TypeCode.EscherUserDefined,		"EscherUserDefined",		false,	true,	-1,	-1	)
    };

    public static RecordType Find (TypeCode typecode)
    {
	for (int i = 0; i < types.Length; i++) {
	    if (types[i].typecode == typecode)
		return types[i];
	}
	return types[0];
    }
}

class Test {

    private static int ParseElement (Gsf.Input stream)
    {
	byte [] data = stream.Read(8);
	if (data == null)
	    return 0;
	RecordType.TypeCode opcode = (RecordType.TypeCode) (data[2] + (data[3] << 8));
	int length = data[4] + (data[5] << 8) + (data[6] << 16) + (data[7] << 24);
	RecordType type = RecordType.Find (opcode);
	if (type.is_container) {
	    int length_remaining = length;
	    while (length_remaining > 0) {
		int elem_length = ParseElement(stream);
		if (elem_length == 0)
		    return 0;
		length_remaining -= elem_length;
	    }
	} else {
	    if (length != 0) {
		data = stream.Read(length);
		if (data == null)
		    return 0;
		string val = null;
		if (opcode == RecordType.TypeCode.TextBytesAtom) {
		    val = System.Text.Encoding.GetEncoding (28591).GetString (data);
		} else if (opcode == RecordType.TypeCode.TextCharsAtom) {
		    val = System.Text.Encoding.Unicode.GetString (data);
		}
		if (val != null)
		    System.Console.WriteLine(val);
	    }
	}
	return length + 8;
    }

    public static int Main (string[] args)
    {
	Gsf.Global.Init ();
	string arg = args[0];
	Gsf.Input input = Gsf.Input.MmapNew (arg);
	input = input.Uncompress();
	Gsf.Infile infile = new Gsf.InfileMSOle (input);

	Gsf.Input stream = infile.ChildByName ("PowerPoint Document");

	long size = stream.Size;
	string name = stream.Name;

	ParseElement(stream);
	return 0;
    }
}
