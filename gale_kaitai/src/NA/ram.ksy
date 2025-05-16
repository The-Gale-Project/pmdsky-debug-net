doc: |-
  Main memory.
  Data in this file aren't located in the ROM itself, and are instead constructs loaded at runtime.

  More specifically, this file is a dumping ground for addresses that are useful to know about, but don't fall in the address ranges of any of the other files. Dynamically loaded constructs that do fall within the address range of a relevant binary should be listed in the corresponding YAML file of that binary, since it still has direct utility when reverse-engineering that particular binary.
meta:
  id: ram
  tags: NA
  endian: le
  imports:
  - data/ram_data
instances:
  data:
    type: ram_data
