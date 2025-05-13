all: build_na build_eu build_jp

build_eu:
	mkdir -p ./Gale.EOS.Kaitai/EU
	kaitai-struct-compiler -t csharp --outdir ./Gale.EOS.Kaitai/EU --dotnet-namespace Gale.EOS.Kaitai.EU gale_kaitai/sky_europe.ksy

build_jp:
	mkdir -p ./Gale.EOS.Kaitai/JP
	kaitai-struct-compiler -t csharp --outdir ./Gale.EOS.Kaitai/JP --dotnet-namespace Gale.EOS.Kaitai.JP gale_kaitai/sky_japan.ksy

build_na:
	mkdir -p ./Gale.EOS.Kaitai/NA
	kaitai-struct-compiler -t csharp --outdir ./Gale.EOS.Kaitai/NA --dotnet-namespace Gale.EOS.Kaitai.NA gale_kaitai/sky_north_america.ksy

clean:
	rm -rf Gale.EOS.Kaitai/EU
	rm -rf Gale.EOS.Kaitai/JP
	rm -rf Gale.EOS.Kaitai/NA