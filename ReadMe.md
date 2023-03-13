# Actor Loader

Loads the required [`C-Actors`](https://gamebanana.com/mods/307642) (typically actors suffixed with C) by analyzing a mods map unit (mubin) files.

## Setup

- Install the latest [.NET 7.0 runtime](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Download the [latest release](https://github.com/ArchLeaders/ActorLoader/releases/latest)

## Usage

```
ActorLoader.exe <path> [-a|--auto]
```

**path:** The path to the root mod folder (e.g. the folder containing 'content')

**auto:** Automatically append C to valid actors that don't exist in the vanilla game files

<br>

*(c) Arch Leaders 2023, under the AGPL-3.0 license*