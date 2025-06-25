# Gale Kaitai
[![NuGet version (Gale.EOS.Kaitai)](https://img.shields.io/nuget/v/Gale.EOS.Kaitai.svg?style=flat-square)](https://www.nuget.org/packages/Gale.EOS.Kaitai/)

A comprehensive symbol mapping of Pokémon Mystery Dungeon: Explorers of Sky generated from [pmdsky-debug](https://github.com/UsernameFodder/pmdsky-debug) using [Kaitai Struct](https://kaitai.io/).

## Installing
Gale Kaitai can be installed using Nuget:
```
dotnet add package Gale.EOS.Kaitai
```

## Getting Started
### Dependencies
- [go-task](https://github.com/go-task/task)
  - Simplifies running all the needed commands to generate the source files.
- [Python 3.13](https://www.python.org)
- The following pip packages:
  - pycparser
  - ruamel.yaml
  - ruamel.yaml.clib
- [kaitai-struct-compiler](https://github.com/kaitai-io/kaitai_struct_compiler)

### Building
#### Linux
For generating C# source files, the simplest method is to run `go-task build` from the root directory. However, see [Known Issues](#known-issues).

You can also build source files for languages other than C# if you wish. You can see how to do that here: https://doc.kaitai.io/user_guide.html#invocation

#### Other
Currently not supported.

### Known Issues
- Kaitai tends to fail to generate source files inexplicably. As a result, it may take a few tries to run the taskfile successfully. It is recommended to instead run each task one by one instead of using the composite `build` task.

## Contributing

This project exists thanks to all the people who contribute.

<a href="https://github.com/The-Gale-Project/pmdsky-debug-net/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=The-Gale-Project/pmdsky-debug-net" />
</a>

**Pull requests will not be accepted for any changes to generated source files.**
At the time of writing, this includes the following folders:
- `./gale_kaitai`
- `./Gale.EOS.Kaitai/EU`
- `./Gale.EOS.Kaitai/JP`
- `./Gale.EOS.Kaitai/NA`

## License
This project is licensed under the [GPL-3.0 License](LICENSE).

## Acknowledgments
- [pmdsky-debug](https://github.com/UsernameFodder/pmdsky-debug)
- [Kaitai Struct](https://github.com/kaitai-io/kaitai_struct)