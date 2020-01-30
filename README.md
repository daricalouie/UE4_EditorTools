# UE4_BoilerplatePlugin
Boilerplate code for a C++/BP plugin that handles dependencies automatically.

## Setup
1. Clone the repo into a folder with your **plugin name** (should be whatever your plugin name you'll use for the project; here as an example it's `MyPlugin`):

```
git clone https://github.com/peetonn/UE4_BoilerplatePlugin.git MyPlugin
```

2. From within the plugin folder, run `setup.sh` like this (your plugin name as argument):

```
./setup.sh `basename $(pwd)`
```

3. Once setup is completed, copy your plugin folder over to your UE4 project's "Plugins" folder.
4. In Unreal Editor, go to "Plugins" -> "Other" and enable your plugin. This will require editor restart and plugin compilation.

This will create main module code for your plugin. You can now start adding code to your plugin.

## Third Party Dependencies

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
