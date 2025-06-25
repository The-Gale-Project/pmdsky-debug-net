doc: Represents a struct or union top_screen_status defined within pmdsky-debug.
meta:
  id: top_screen_status
  endian: le
  bit-endian: le
  imports:
  - top_screen_fade_status
  - top_screen_type
  - pointer
seq:
- id: field0_0x0
  type: u1
- id: field1_0x1
  type: u1
- id: field2_0x2
  type: u1
- id: field3_0x3
  type: u1
- id: fade_status
  type: top_screen_fade_status
- id: field5_0x8
  type: u1
- id: field6_0x9
  type: u1
- id: field7_0xa
  type: u1
- id: field8_0xb
  type: u1
- id: field9_0xc
  type: s4
- id: top_screen_type
  type: top_screen_type
- id: init_func
  type: pointer
- id: update_func
  type: pointer
- id: field13_0x1c
  type: pointer
- id: free_func
  type: pointer
- id: field15_0x24
  type: u1
- id: field16_0x25
  type: u1
- id: field17_0x26
  type: u1
- id: field18_0x27
  type: u1
- id: field19_0x28
  type: u1
- id: field20_0x29
  type: u1
- id: field21_0x2a
  type: u1
- id: field22_0x2b
  type: u1
- id: field23_0x2c
  type: u1
- id: field24_0x2d
  type: u1
- id: field25_0x2e
  type: u1
- id: field26_0x2f
  type: u1
- id: field27_0x30
  type: u1
- id: field28_0x31
  type: u1
- id: field29_0x32
  type: u1
- id: field30_0x33
  type: u1
- id: field31_0x34
  type: u1
- id: field32_0x35
  type: u1
- id: field33_0x36
  type: u1
- id: field34_0x37
  type: u1
- id: field35_0x38
  type: u1
- id: field36_0x39
  type: u1
- id: field37_0x3a
  type: u1
- id: field38_0x3b
  type: u1
- id: field39_0x3c
  type: u1
- id: field40_0x3d
  type: u1
- id: field41_0x3e
  type: u1
- id: field42_0x3f
  type: u1
- id: field43_0x40
  type: u1
- id: field44_0x41
  type: u1
- id: field45_0x42
  type: u1
- id: field46_0x43
  type: u1
- id: field47_0x44
  type: u1
- id: field48_0x45
  type: u1
- id: field49_0x46
  type: u1
- id: field50_0x47
  type: u1
- id: field51_0x48
  type: u1
- id: field52_0x49
  type: u1
- id: field53_0x4a
  type: u1
- id: field54_0x4b
  type: u1
- id: field55_0x4c
  type: u1
- id: field56_0x4d
  type: u1
- id: field57_0x4e
  type: u1
- id: field58_0x4f
  type: u1
- id: field59_0x50
  type: u1
- id: field60_0x51
  type: u1
- id: field61_0x52
  type: u1
- id: field62_0x53
  type: u1
- id: field63_0x54
  type: u1
- id: field64_0x55
  type: u1
- id: field65_0x56
  type: u1
- id: field66_0x57
  type: u1
- id: field67_0x58
  type: u1
- id: field68_0x59
  type: u1
- id: field69_0x5a
  type: u1
- id: field70_0x5b
  type: u1
- id: field71_0x5c
  type: u1
- id: field72_0x5d
  type: u1
- id: field73_0x5e
  type: u1
- id: field74_0x5f
  type: u1
- id: field75_0x60
  type: u1
- id: field76_0x61
  type: u1
- id: field77_0x62
  type: u1
- id: field78_0x63
  type: u1
- id: field79_0x64
  type: u1
- id: field80_0x65
  type: u1
- id: field81_0x66
  type: u1
- id: field82_0x67
  type: u1
- id: field83_0x68
  type: u1
- id: field84_0x69
  type: u1
- id: field85_0x6a
  type: u1
- id: field86_0x6b
  type: u1
- id: field87_0x6c
  type: u1
- id: field88_0x6d
  type: u1
- id: field89_0x6e
  type: u1
- id: field90_0x6f
  type: u1
- id: field91_0x70
  type: u1
- id: field92_0x71
  type: u1
- id: field93_0x72
  type: u1
- id: field94_0x73
  type: u1
- id: field95_0x74
  type: u1
- id: field96_0x75
  type: u1
- id: field97_0x76
  type: u1
- id: field98_0x77
  type: u1
- id: field99_0x78
  type: u1
- id: field100_0x79
  type: u1
- id: field101_0x7a
  type: u1
- id: field102_0x7b
  type: u1
- id: field103_0x7c
  type: u1
- id: field104_0x7d
  type: u1
- id: field105_0x7e
  type: u1
- id: field106_0x7f
  type: u1
- id: field107_0x80
  type: u1
- id: field108_0x81
  type: u1
- id: field109_0x82
  type: u1
- id: field110_0x83
  type: u1
- id: field111_0x84
  type: u1
- id: field112_0x85
  type: u1
- id: field113_0x86
  type: u1
- id: field114_0x87
  type: u1
- id: field115_0x88
  type: u1
- id: field116_0x89
  type: u1
- id: field117_0x8a
  type: u1
- id: field118_0x8b
  type: u1
- id: field119_0x8c
  type: u1
- id: field120_0x8d
  type: u1
- id: field121_0x8e
  type: u1
- id: field122_0x8f
  type: u1
- id: field123_0x90
  type: u1
- id: field124_0x91
  type: u1
- id: field125_0x92
  type: u1
- id: field126_0x93
  type: u1
- id: field127_0x94
  type: u1
- id: field128_0x95
  type: u1
- id: field129_0x96
  type: u1
- id: field130_0x97
  type: u1
- id: field131_0x98
  type: u1
- id: field132_0x99
  type: u1
- id: field133_0x9a
  type: u1
- id: field134_0x9b
  type: u1
- id: field135_0x9c
  type: u1
- id: field136_0x9d
  type: u1
- id: field137_0x9e
  type: u1
- id: field138_0x9f
  type: u1
- id: field139_0xa0
  type: u1
- id: field140_0xa1
  type: u1
- id: field141_0xa2
  type: u1
- id: field142_0xa3
  type: u1
- id: field143_0xa4
  type: u1
- id: field144_0xa5
  type: u1
- id: field145_0xa6
  type: u1
- id: field146_0xa7
  type: u1
- id: field147_0xa8
  type: u1
- id: field148_0xa9
  type: u1
- id: field149_0xaa
  type: u1
- id: field150_0xab
  type: u1
- id: field151_0xac
  type: u1
- id: field152_0xad
  type: u1
- id: field153_0xae
  type: u1
- id: field154_0xaf
  type: u1
- id: field155_0xb0
  type: u1
- id: field156_0xb1
  type: u1
- id: field157_0xb2
  type: u1
- id: field158_0xb3
  type: u1
- id: field159_0xb4
  type: u1
- id: field160_0xb5
  type: u1
- id: field161_0xb6
  type: u1
- id: field162_0xb7
  type: u1
- id: field163_0xb8
  type: u1
- id: field164_0xb9
  type: u1
- id: field165_0xba
  type: u1
- id: field166_0xbb
  type: u1
- id: field167_0xbc
  type: u1
- id: field168_0xbd
  type: u1
- id: field169_0xbe
  type: u1
- id: field170_0xbf
  type: u1
- id: field171_0xc0
  type: u1
- id: field172_0xc1
  type: u1
- id: field173_0xc2
  type: u1
- id: field174_0xc3
  type: u1
- id: field175_0xc4
  type: u1
- id: field176_0xc5
  type: u1
- id: field177_0xc6
  type: u1
- id: field178_0xc7
  type: u1
- id: field179_0xc8
  type: u1
- id: field180_0xc9
  type: u1
- id: field181_0xca
  type: u1
- id: field182_0xcb
  type: u1
- id: field183_0xcc
  type: u1
- id: field184_0xcd
  type: u1
- id: field185_0xce
  type: u1
- id: field186_0xcf
  type: u1
- id: field187_0xd0
  type: u1
- id: field188_0xd1
  type: u1
- id: field189_0xd2
  type: u1
- id: field190_0xd3
  type: u1
- id: field191_0xd4
  type: u1
- id: field192_0xd5
  type: u1
- id: field193_0xd6
  type: u1
- id: field194_0xd7
  type: u1
- id: field195_0xd8
  type: u1
- id: field196_0xd9
  type: u1
- id: field197_0xda
  type: u1
- id: field198_0xdb
  type: u1
- id: field199_0xdc
  type: u1
- id: field200_0xdd
  type: u1
- id: field201_0xde
  type: u1
- id: field202_0xdf
  type: u1
- id: field203_0xe0
  type: u1
- id: field204_0xe1
  type: u1
- id: field205_0xe2
  type: u1
- id: field206_0xe3
  type: u1
- id: field207_0xe4
  type: u1
- id: field208_0xe5
  type: u1
- id: field209_0xe6
  type: u1
- id: field210_0xe7
  type: u1
- id: field211_0xe8
  type: u1
- id: field212_0xe9
  type: u1
- id: field213_0xea
  type: u1
- id: field214_0xeb
  type: u1
- id: field215_0xec
  type: u1
- id: field216_0xed
  type: u1
- id: field217_0xee
  type: u1
- id: field218_0xef
  type: u1
- id: field219_0xf0
  type: u1
- id: field220_0xf1
  type: u1
- id: field221_0xf2
  type: u1
- id: field222_0xf3
  type: u1
- id: field223_0xf4
  type: u1
- id: field224_0xf5
  type: u1
- id: field225_0xf6
  type: u1
- id: field226_0xf7
  type: u1
- id: field227_0xf8
  type: u1
- id: field228_0xf9
  type: u1
- id: field229_0xfa
  type: u1
- id: field230_0xfb
  type: u1
- id: field231_0xfc
  type: u1
- id: field232_0xfd
  type: u1
- id: field233_0xfe
  type: u1
- id: field234_0xff
  type: u1
- id: field235_0x100
  type: u1
- id: field236_0x101
  type: u1
- id: field237_0x102
  type: u1
- id: field238_0x103
  type: u1
- id: field239_0x104
  type: u1
- id: field240_0x105
  type: u1
- id: field241_0x106
  type: u1
- id: field242_0x107
  type: u1
- id: field243_0x108
  type: u1
- id: field244_0x109
  type: u1
- id: field245_0x10a
  type: u1
- id: field246_0x10b
  type: u1
- id: field247_0x10c
  type: u1
- id: field248_0x10d
  type: u1
- id: field249_0x10e
  type: u1
- id: field250_0x10f
  type: u1
- id: field251_0x110
  type: u1
- id: field252_0x111
  type: u1
- id: field253_0x112
  type: u1
- id: field254_0x113
  type: u1
- id: field255_0x114
  type: u1
- id: field256_0x115
  type: u1
- id: field257_0x116
  type: u1
- id: field258_0x117
  type: u1
- id: field259_0x118
  type: u1
- id: field260_0x119
  type: u1
- id: field261_0x11a
  type: u1
- id: field262_0x11b
  type: u1
- id: field263_0x11c
  type: u1
- id: field264_0x11d
  type: u1
- id: field265_0x11e
  type: u1
- id: field266_0x11f
  type: u1
- id: field267_0x120
  type: u1
- id: field268_0x121
  type: u1
- id: field269_0x122
  type: u1
- id: field270_0x123
  type: u1
- id: field271_0x124
  type: u1
- id: field272_0x125
  type: u1
- id: field273_0x126
  type: u1
- id: field274_0x127
  type: u1
- id: field275_0x128
  type: u1
- id: field276_0x129
  type: u1
- id: field277_0x12a
  type: u1
- id: field278_0x12b
  type: u1
- id: field279_0x12c
  type: u1
- id: field280_0x12d
  type: u1
- id: field281_0x12e
  type: u1
- id: field282_0x12f
  type: u1
- id: field283_0x130
  type: u1
- id: field284_0x131
  type: u1
- id: field285_0x132
  type: u1
- id: field286_0x133
  type: u1
- id: field287_0x134
  type: u1
- id: field288_0x135
  type: u1
- id: field289_0x136
  type: u1
- id: field290_0x137
  type: u1
- id: field291_0x138
  type: u1
- id: field292_0x139
  type: u1
- id: field293_0x13a
  type: u1
- id: field294_0x13b
  type: u1
- id: field295_0x13c
  type: u1
- id: field296_0x13d
  type: u1
- id: field297_0x13e
  type: u1
- id: field298_0x13f
  type: u1
- id: field299_0x140
  type: u1
- id: field300_0x141
  type: u1
- id: field301_0x142
  type: u1
- id: field302_0x143
  type: u1
- id: field303_0x144
  type: u1
- id: field304_0x145
  type: u1
- id: field305_0x146
  type: u1
- id: field306_0x147
  type: u1
- id: field307_0x148
  type: u1
- id: field308_0x149
  type: u1
- id: field309_0x14a
  type: u1
- id: field310_0x14b
  type: u1
- id: field311_0x14c
  type: u1
- id: field312_0x14d
  type: u1
- id: field313_0x14e
  type: u1
- id: field314_0x14f
  type: u1
- id: field315_0x150
  type: u1
- id: field316_0x151
  type: u1
- id: field317_0x152
  type: u1
- id: field318_0x153
  type: u1
- id: field319_0x154
  type: u1
- id: field320_0x155
  type: u1
- id: field321_0x156
  type: u1
- id: field322_0x157
  type: u1
- id: field323_0x158
  type: u1
- id: field324_0x159
  type: u1
- id: field325_0x15a
  type: u1
- id: field326_0x15b
  type: u1
- id: field327_0x15c
  type: u1
- id: field328_0x15d
  type: u1
- id: field329_0x15e
  type: u1
- id: field330_0x15f
  type: u1
- id: field331_0x160
  type: u1
- id: field332_0x161
  type: u1
- id: field333_0x162
  type: u1
- id: field334_0x163
  type: u1
- id: field335_0x164
  type: u1
- id: field336_0x165
  type: u1
- id: field337_0x166
  type: u1
- id: field338_0x167
  type: u1
- id: field339_0x168
  type: u1
- id: field340_0x169
  type: u1
- id: field341_0x16a
  type: u1
- id: field342_0x16b
  type: u1
- id: field343_0x16c
  type: u1
- id: field344_0x16d
  type: u1
- id: field345_0x16e
  type: u1
- id: field346_0x16f
  type: u1
- id: field347_0x170
  type: u1
- id: field348_0x171
  type: u1
- id: field349_0x172
  type: u1
- id: field350_0x173
  type: u1
- id: field351_0x174
  type: u1
- id: field352_0x175
  type: u1
- id: field353_0x176
  type: u1
- id: field354_0x177
  type: u1
- id: field355_0x178
  type: u1
- id: field356_0x179
  type: u1
- id: field357_0x17a
  type: u1
- id: field358_0x17b
  type: u1
- id: field359_0x17c
  type: u1
- id: field360_0x17d
  type: u1
- id: field361_0x17e
  type: u1
- id: field362_0x17f
  type: u1
- id: field363_0x180
  type: u1
- id: field364_0x181
  type: u1
- id: field365_0x182
  type: u1
- id: field366_0x183
  type: u1
- id: field367_0x184
  type: u1
- id: field368_0x185
  type: u1
- id: field369_0x186
  type: u1
- id: field370_0x187
  type: u1
- id: field371_0x188
  type: u1
- id: field372_0x189
  type: u1
- id: field373_0x18a
  type: u1
- id: field374_0x18b
  type: u1
- id: field375_0x18c
  type: u1
- id: field376_0x18d
  type: u1
- id: field377_0x18e
  type: u1
- id: field378_0x18f
  type: u1
- id: field379_0x190
  type: u1
- id: field380_0x191
  type: u1
- id: field381_0x192
  type: u1
- id: field382_0x193
  type: u1
- id: field383_0x194
  type: u1
- id: field384_0x195
  type: u1
- id: field385_0x196
  type: u1
- id: field386_0x197
  type: u1
- id: field387_0x198
  type: u1
- id: field388_0x199
  type: u1
- id: field389_0x19a
  type: u1
- id: field390_0x19b
  type: u1
- id: field391_0x19c
  type: u1
- id: field392_0x19d
  type: u1
- id: field393_0x19e
  type: u1
- id: field394_0x19f
  type: u1
- id: field395_0x1a0
  type: u1
- id: field396_0x1a1
  type: u1
- id: field397_0x1a2
  type: u1
- id: field398_0x1a3
  type: u1
- id: field399_0x1a4
  type: u1
- id: field400_0x1a5
  type: u1
- id: field401_0x1a6
  type: u1
- id: field402_0x1a7
  type: u1
- id: field403_0x1a8
  type: u1
- id: field404_0x1a9
  type: u1
- id: field405_0x1aa
  type: u1
- id: field406_0x1ab
  type: u1
- id: field407_0x1ac
  type: u1
- id: field408_0x1ad
  type: u1
- id: field409_0x1ae
  type: u1
- id: field410_0x1af
  type: u1
- id: field411_0x1b0
  type: u1
- id: field412_0x1b1
  type: u1
- id: field413_0x1b2
  type: u1
- id: field414_0x1b3
  type: u1
- id: field415_0x1b4
  type: u1
- id: field416_0x1b5
  type: u1
- id: field417_0x1b6
  type: u1
- id: field418_0x1b7
  type: u1
- id: field419_0x1b8
  type: u1
- id: field420_0x1b9
  type: u1
- id: field421_0x1ba
  type: u1
- id: field422_0x1bb
  type: u1
- id: field423_0x1bc
  type: u1
- id: field424_0x1bd
  type: u1
- id: field425_0x1be
  type: u1
- id: field426_0x1bf
  type: u1
- id: field427_0x1c0
  type: u1
- id: field428_0x1c1
  type: u1
- id: field429_0x1c2
  type: u1
- id: field430_0x1c3
  type: u1
- id: field431_0x1c4
  type: u1
- id: field432_0x1c5
  type: u1
- id: field433_0x1c6
  type: u1
- id: field434_0x1c7
  type: u1
- id: field435_0x1c8
  type: u1
- id: field436_0x1c9
  type: u1
- id: field437_0x1ca
  type: u1
- id: field438_0x1cb
  type: u1
- id: field439_0x1cc
  type: u1
- id: field440_0x1cd
  type: u1
- id: field441_0x1ce
  type: u1
- id: field442_0x1cf
  type: u1
- id: field443_0x1d0
  type: u1
- id: field444_0x1d1
  type: u1
- id: field445_0x1d2
  type: u1
- id: field446_0x1d3
  type: u1
- id: field447_0x1d4
  type: u1
- id: field448_0x1d5
  type: u1
- id: field449_0x1d6
  type: u1
- id: field450_0x1d7
  type: u1
- id: field451_0x1d8
  type: u1
- id: field452_0x1d9
  type: u1
- id: field453_0x1da
  type: u1
- id: field454_0x1db
  type: u1
- id: field455_0x1dc
  type: u1
- id: field456_0x1dd
  type: u1
- id: field457_0x1de
  type: u1
- id: field458_0x1df
  type: u1
- id: field459_0x1e0
  type: u1
- id: field460_0x1e1
  type: u1
- id: field461_0x1e2
  type: u1
- id: field462_0x1e3
  type: u1
- id: field463_0x1e4
  type: u1
- id: field464_0x1e5
  type: u1
- id: field465_0x1e6
  type: u1
- id: field466_0x1e7
  type: u1
- id: field467_0x1e8
  type: u1
- id: field468_0x1e9
  type: u1
- id: field469_0x1ea
  type: u1
- id: field470_0x1eb
  type: u1
- id: field471_0x1ec
  type: u1
- id: field472_0x1ed
  type: u1
- id: field473_0x1ee
  type: u1
- id: field474_0x1ef
  type: u1
- id: field475_0x1f0
  type: u1
- id: field476_0x1f1
  type: u1
- id: field477_0x1f2
  type: u1
- id: field478_0x1f3
  type: u1
- id: field479_0x1f4
  type: u1
- id: field480_0x1f5
  type: u1
- id: field481_0x1f6
  type: u1
- id: field482_0x1f7
  type: u1
- id: field483_0x1f8
  type: u1
- id: field484_0x1f9
  type: u1
- id: field485_0x1fa
  type: u1
- id: field486_0x1fb
  type: u1
- id: field487_0x1fc
  type: u1
- id: field488_0x1fd
  type: u1
- id: field489_0x1fe
  type: u1
- id: field490_0x1ff
  type: u1
- id: field491_0x200
  type: u1
- id: field492_0x201
  type: u1
- id: field493_0x202
  type: u1
- id: field494_0x203
  type: u1
- id: field495_0x204
  type: u1
- id: field496_0x205
  type: u1
- id: field497_0x206
  type: u1
- id: field498_0x207
  type: u1
- id: field499_0x208
  type: u1
- id: field500_0x209
  type: u1
- id: field501_0x20a
  type: u1
- id: field502_0x20b
  type: u1
- id: field503_0x20c
  type: u1
- id: field504_0x20d
  type: u1
- id: field505_0x20e
  type: u1
- id: field506_0x20f
  type: u1
- id: field507_0x210
  type: u1
- id: field508_0x211
  type: u1
- id: field509_0x212
  type: u1
- id: field510_0x213
  type: u1
- id: field511_0x214
  type: u1
- id: field512_0x215
  type: u1
- id: field513_0x216
  type: u1
- id: field514_0x217
  type: u1
- id: field515_0x218
  type: u1
- id: field516_0x219
  type: u1
- id: field517_0x21a
  type: u1
- id: field518_0x21b
  type: u1
- id: field519_0x21c
  type: u1
- id: field520_0x21d
  type: u1
- id: field521_0x21e
  type: u1
- id: field522_0x21f
  type: u1
- id: field523_0x220
  type: u1
- id: field524_0x221
  type: u1
- id: field525_0x222
  type: u1
- id: field526_0x223
  type: u1
- id: field527_0x224
  type: u1
- id: field528_0x225
  type: u1
- id: field529_0x226
  type: u1
- id: field530_0x227
  type: u1
- id: field531_0x228
  type: u1
- id: field532_0x229
  type: u1
- id: field533_0x22a
  type: u1
- id: field534_0x22b
  type: u1
- id: field535_0x22c
  type: u1
- id: field536_0x22d
  type: u1
- id: field537_0x22e
  type: u1
- id: field538_0x22f
  type: u1
