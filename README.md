# UE4_BoilerplatePlugin
Boilerplate code for a C++/BP plugin that handles dependencies automatically.

## Setup
The setup process will guide you how to create new plugin from the boilerplate code. 

1. Clone the repo:
```
git clone https://github.com/peetonn/UE4_BoilerplatePlugin.git
```

2. Rename cloned directory into your **plugin name** (substitute `<plugin name>` with your **plugin name**, for example *OSCSupport*).

> **Do not use word "boilerplate" in your plugin name** 

```
mv UE4_BoilerplatePlugin <plugin name>
```

3. Execute these commands (substitute `<plugin name>` with your **plugin name**):

```
cd <plugin name>
./setup.sh `basename $(pwd)`
```

4. Once the setup is completed, copy your plugin folder over to your UE4 project's "Plugins" folder (create this folder, if it does not exist already).
5. Restart your project, it will prompt you to recompile found plugins, click "Yes".

This will create main module code for your plugin. You can now start adding code to your plugin.

## Adding Third Party Dependencies

If your plugin requires any C++ third party libraries, the boilerplate code is set up to handle them automatically, **as long as third party code and binaries organized in specific way**, described below.
Your third party dependency may either be *header-only* or *dynamic library* (which contains also binaries, pre-built for a certain platform, or several platforms).
In either case, you need to organize your third party dependency in a folder like this:

```
<third-party lib name>
  *-- include      // headers should be placed here
  *-- lib          // (can omit this subfolder for header-only dependencies)
    *-- Android    // include only those platforms, that your third-party supports
    *-- IOS
    *-- macOS
    *-- Win64
```

You should place your third party folder under `<plugin name>/ThirdParty/deps<plugin name>` folder. The [build script](https://github.com/peetonn/UE4_BoilerplatePlugin/blob/master/Source/ThirdParty/depsBoilerplate/depsBoilerplate.Build.cs) will pick it up from there for proper compling.
