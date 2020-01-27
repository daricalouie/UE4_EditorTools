# UE4_BoilerplatePlugin
Boilerplate code for a C++/BP plugin that handles dependencies automatically.

## Setup
1. Clone the repo into a folder with your *plugin name*
2. Run `setup.sh` with your plugin name as argument:

```
$ cd <plugin name>
$ setup.sh `basename $(pwd)`
```

3. Once setup is completed, copy folder over to your UE4 project's "Plugins" folder.
